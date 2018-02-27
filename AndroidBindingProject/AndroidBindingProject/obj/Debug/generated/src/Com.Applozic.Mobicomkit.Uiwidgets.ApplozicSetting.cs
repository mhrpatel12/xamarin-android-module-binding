using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/ApplozicSetting", DoNotGenerateAcw=true)]
	public partial class ApplozicSetting : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/field[@name='CUSTOM_MESSAGE_BACKGROUND_COLOR']"
		[Register ("CUSTOM_MESSAGE_BACKGROUND_COLOR")]
		public const string CustomMessageBackgroundColor = (string) "CUSTOM_MESSAGE_BACKGROUND_COLOR";

		static IntPtr applozicCustomSetting_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/field[@name='applozicCustomSetting']"
		[Register ("applozicCustomSetting")]
		public static global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ApplozicCustomSetting {
			get {
				if (applozicCustomSetting_jfieldId == IntPtr.Zero)
					applozicCustomSetting_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "applozicCustomSetting", "Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, applozicCustomSetting_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (applozicCustomSetting_jfieldId == IntPtr.Zero)
					applozicCustomSetting_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "applozicCustomSetting", "Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, applozicCustomSetting_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sharedPreferences_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/field[@name='sharedPreferences']"
		[Register ("sharedPreferences")]
		public global::Android.Content.ISharedPreferences SharedPreferences {
			get {
				if (sharedPreferences_jfieldId == IntPtr.Zero)
					sharedPreferences_jfieldId = JNIEnv.GetFieldID (class_ref, "sharedPreferences", "Landroid/content/SharedPreferences;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sharedPreferences_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sharedPreferences_jfieldId == IntPtr.Zero)
					sharedPreferences_jfieldId = JNIEnv.GetFieldID (class_ref, "sharedPreferences", "Landroid/content/SharedPreferences;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sharedPreferences_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode", DoNotGenerateAcw=true)]
		public sealed partial class RequestCode : global::Java.Lang.Enum {


			static IntPtr AUDIO_CALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']/field[@name='AUDIO_CALL']"
			[Register ("AUDIO_CALL")]
			public static global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode AudioCall {
				get {
					if (AUDIO_CALL_jfieldId == IntPtr.Zero)
						AUDIO_CALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_CALL", "Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_CALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_TAP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']/field[@name='MESSAGE_TAP']"
			[Register ("MESSAGE_TAP")]
			public static global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode MessageTap {
				get {
					if (MESSAGE_TAP_jfieldId == IntPtr.Zero)
						MESSAGE_TAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_TAP", "Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_TAP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PROFILE_VIEW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']/field[@name='PROFILE_VIEW']"
			[Register ("PROFILE_VIEW")]
			public static global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode ProfileView {
				get {
					if (PROFILE_VIEW_jfieldId == IntPtr.Zero)
						PROFILE_VIEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROFILE_VIEW", "Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROFILE_VIEW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_BLOCK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']/field[@name='USER_BLOCK']"
			[Register ("USER_BLOCK")]
			public static global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode UserBlock {
				get {
					if (USER_BLOCK_jfieldId == IntPtr.Zero)
						USER_BLOCK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_BLOCK", "Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_BLOCK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_LOOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']/field[@name='USER_LOOUT']"
			[Register ("USER_LOOUT")]
			public static global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode UserLoout {
				get {
					if (USER_LOOUT_jfieldId == IntPtr.Zero)
						USER_LOOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_LOOUT", "Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_LOOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_CALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']/field[@name='VIDEO_CALL']"
			[Register ("VIDEO_CALL")]
			public static global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode VideoCall {
				get {
					if (VIDEO_CALL_jfieldId == IntPtr.Zero)
						VIDEO_CALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_CALL", "Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_CALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RequestCode); }
			}

			internal RequestCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Integer Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Integer;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Integer;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting.RequestCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;");
				try {
					return (global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/ApplozicSetting", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicSetting); }
		}

		protected ApplozicSetting (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAttachmentIconsBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetAttachmentIconsBackgroundColorHandler ()
		{
			if (cb_getAttachmentIconsBackgroundColor == null)
				cb_getAttachmentIconsBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAttachmentIconsBackgroundColor);
			return cb_getAttachmentIconsBackgroundColor;
		}

		static int n_GetAttachmentIconsBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AttachmentIconsBackgroundColor;
		}
#pragma warning restore 0169

		static IntPtr id_getAttachmentIconsBackgroundColor;
		public virtual unsafe int AttachmentIconsBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getAttachmentIconsBackgroundColor' and count(parameter)=0]"
			[Register ("getAttachmentIconsBackgroundColor", "()I", "GetGetAttachmentIconsBackgroundColorHandler")]
			get {
				if (id_getAttachmentIconsBackgroundColor == IntPtr.Zero)
					id_getAttachmentIconsBackgroundColor = JNIEnv.GetMethodID (class_ref, "getAttachmentIconsBackgroundColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAttachmentIconsBackgroundColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttachmentIconsBackgroundColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getChannelCustomMesssageBgColor;
#pragma warning disable 0169
		static Delegate GetGetChannelCustomMesssageBgColorHandler ()
		{
			if (cb_getChannelCustomMesssageBgColor == null)
				cb_getChannelCustomMesssageBgColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannelCustomMesssageBgColor);
			return cb_getChannelCustomMesssageBgColor;
		}

		static int n_GetChannelCustomMesssageBgColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChannelCustomMesssageBgColor;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelCustomMesssageBgColor;
		public virtual unsafe int ChannelCustomMesssageBgColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getChannelCustomMesssageBgColor' and count(parameter)=0]"
			[Register ("getChannelCustomMesssageBgColor", "()I", "GetGetChannelCustomMesssageBgColorHandler")]
			get {
				if (id_getChannelCustomMesssageBgColor == IntPtr.Zero)
					id_getChannelCustomMesssageBgColor = JNIEnv.GetMethodID (class_ref, "getChannelCustomMesssageBgColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChannelCustomMesssageBgColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelCustomMesssageBgColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getChannelCustomMesssageBorderColor;
#pragma warning disable 0169
		static Delegate GetGetChannelCustomMesssageBorderColorHandler ()
		{
			if (cb_getChannelCustomMesssageBorderColor == null)
				cb_getChannelCustomMesssageBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannelCustomMesssageBorderColor);
			return cb_getChannelCustomMesssageBorderColor;
		}

		static int n_GetChannelCustomMesssageBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChannelCustomMesssageBorderColor;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelCustomMesssageBorderColor;
		public virtual unsafe int ChannelCustomMesssageBorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getChannelCustomMesssageBorderColor' and count(parameter)=0]"
			[Register ("getChannelCustomMesssageBorderColor", "()I", "GetGetChannelCustomMesssageBorderColorHandler")]
			get {
				if (id_getChannelCustomMesssageBorderColor == IntPtr.Zero)
					id_getChannelCustomMesssageBorderColor = JNIEnv.GetMethodID (class_ref, "getChannelCustomMesssageBorderColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChannelCustomMesssageBorderColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelCustomMesssageBorderColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getChannelCustomMesssageTextColor;
#pragma warning disable 0169
		static Delegate GetGetChannelCustomMesssageTextColorHandler ()
		{
			if (cb_getChannelCustomMesssageTextColor == null)
				cb_getChannelCustomMesssageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChannelCustomMesssageTextColor);
			return cb_getChannelCustomMesssageTextColor;
		}

		static int n_GetChannelCustomMesssageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChannelCustomMesssageTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelCustomMesssageTextColor;
		public virtual unsafe int ChannelCustomMesssageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getChannelCustomMesssageTextColor' and count(parameter)=0]"
			[Register ("getChannelCustomMesssageTextColor", "()I", "GetGetChannelCustomMesssageTextColorHandler")]
			get {
				if (id_getChannelCustomMesssageTextColor == IntPtr.Zero)
					id_getChannelCustomMesssageTextColor = JNIEnv.GetMethodID (class_ref, "getChannelCustomMesssageTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChannelCustomMesssageTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelCustomMesssageTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getChatBackgroundColorOrDrawableResource;
#pragma warning disable 0169
		static Delegate GetGetChatBackgroundColorOrDrawableResourceHandler ()
		{
			if (cb_getChatBackgroundColorOrDrawableResource == null)
				cb_getChatBackgroundColorOrDrawableResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChatBackgroundColorOrDrawableResource);
			return cb_getChatBackgroundColorOrDrawableResource;
		}

		static int n_GetChatBackgroundColorOrDrawableResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChatBackgroundColorOrDrawableResource;
		}
#pragma warning restore 0169

		static IntPtr id_getChatBackgroundColorOrDrawableResource;
		public virtual unsafe int ChatBackgroundColorOrDrawableResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getChatBackgroundColorOrDrawableResource' and count(parameter)=0]"
			[Register ("getChatBackgroundColorOrDrawableResource", "()I", "GetGetChatBackgroundColorOrDrawableResourceHandler")]
			get {
				if (id_getChatBackgroundColorOrDrawableResource == IntPtr.Zero)
					id_getChatBackgroundColorOrDrawableResource = JNIEnv.GetMethodID (class_ref, "getChatBackgroundColorOrDrawableResource", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChatBackgroundColorOrDrawableResource);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChatBackgroundColorOrDrawableResource", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCompressedImageSizeInMB;
#pragma warning disable 0169
		static Delegate GetGetCompressedImageSizeInMBHandler ()
		{
			if (cb_getCompressedImageSizeInMB == null)
				cb_getCompressedImageSizeInMB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCompressedImageSizeInMB);
			return cb_getCompressedImageSizeInMB;
		}

		static int n_GetCompressedImageSizeInMB (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompressedImageSizeInMB;
		}
#pragma warning restore 0169

		static IntPtr id_getCompressedImageSizeInMB;
		public virtual unsafe int CompressedImageSizeInMB {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getCompressedImageSizeInMB' and count(parameter)=0]"
			[Register ("getCompressedImageSizeInMB", "()I", "GetGetCompressedImageSizeInMBHandler")]
			get {
				if (id_getCompressedImageSizeInMB == IntPtr.Zero)
					id_getCompressedImageSizeInMB = JNIEnv.GetMethodID (class_ref, "getCompressedImageSizeInMB", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCompressedImageSizeInMB);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCompressedImageSizeInMB", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getConversationDateTextColor;
#pragma warning disable 0169
		static Delegate GetGetConversationDateTextColorHandler ()
		{
			if (cb_getConversationDateTextColor == null)
				cb_getConversationDateTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConversationDateTextColor);
			return cb_getConversationDateTextColor;
		}

		static int n_GetConversationDateTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConversationDateTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationDateTextColor;
		public virtual unsafe int ConversationDateTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getConversationDateTextColor' and count(parameter)=0]"
			[Register ("getConversationDateTextColor", "()I", "GetGetConversationDateTextColorHandler")]
			get {
				if (id_getConversationDateTextColor == IntPtr.Zero)
					id_getConversationDateTextColor = JNIEnv.GetMethodID (class_ref, "getConversationDateTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConversationDateTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationDateTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getConversationDayTextColor;
#pragma warning disable 0169
		static Delegate GetGetConversationDayTextColorHandler ()
		{
			if (cb_getConversationDayTextColor == null)
				cb_getConversationDayTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConversationDayTextColor);
			return cb_getConversationDayTextColor;
		}

		static int n_GetConversationDayTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConversationDayTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationDayTextColor;
		public virtual unsafe int ConversationDayTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getConversationDayTextColor' and count(parameter)=0]"
			[Register ("getConversationDayTextColor", "()I", "GetGetConversationDayTextColorHandler")]
			get {
				if (id_getConversationDayTextColor == IntPtr.Zero)
					id_getConversationDayTextColor = JNIEnv.GetMethodID (class_ref, "getConversationDayTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConversationDayTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationDayTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getEditTextBackgroundColorOrDrawableResource;
#pragma warning disable 0169
		static Delegate GetGetEditTextBackgroundColorOrDrawableResourceHandler ()
		{
			if (cb_getEditTextBackgroundColorOrDrawableResource == null)
				cb_getEditTextBackgroundColorOrDrawableResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEditTextBackgroundColorOrDrawableResource);
			return cb_getEditTextBackgroundColorOrDrawableResource;
		}

		static int n_GetEditTextBackgroundColorOrDrawableResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EditTextBackgroundColorOrDrawableResource;
		}
#pragma warning restore 0169

		static IntPtr id_getEditTextBackgroundColorOrDrawableResource;
		public virtual unsafe int EditTextBackgroundColorOrDrawableResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getEditTextBackgroundColorOrDrawableResource' and count(parameter)=0]"
			[Register ("getEditTextBackgroundColorOrDrawableResource", "()I", "GetGetEditTextBackgroundColorOrDrawableResourceHandler")]
			get {
				if (id_getEditTextBackgroundColorOrDrawableResource == IntPtr.Zero)
					id_getEditTextBackgroundColorOrDrawableResource = JNIEnv.GetMethodID (class_ref, "getEditTextBackgroundColorOrDrawableResource", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEditTextBackgroundColorOrDrawableResource);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEditTextBackgroundColorOrDrawableResource", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getEditTextLayoutBackgroundColorOrDrawableResource;
#pragma warning disable 0169
		static Delegate GetGetEditTextLayoutBackgroundColorOrDrawableResourceHandler ()
		{
			if (cb_getEditTextLayoutBackgroundColorOrDrawableResource == null)
				cb_getEditTextLayoutBackgroundColorOrDrawableResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEditTextLayoutBackgroundColorOrDrawableResource);
			return cb_getEditTextLayoutBackgroundColorOrDrawableResource;
		}

		static int n_GetEditTextLayoutBackgroundColorOrDrawableResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EditTextLayoutBackgroundColorOrDrawableResource;
		}
#pragma warning restore 0169

		static IntPtr id_getEditTextLayoutBackgroundColorOrDrawableResource;
		public virtual unsafe int EditTextLayoutBackgroundColorOrDrawableResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getEditTextLayoutBackgroundColorOrDrawableResource' and count(parameter)=0]"
			[Register ("getEditTextLayoutBackgroundColorOrDrawableResource", "()I", "GetGetEditTextLayoutBackgroundColorOrDrawableResourceHandler")]
			get {
				if (id_getEditTextLayoutBackgroundColorOrDrawableResource == IntPtr.Zero)
					id_getEditTextLayoutBackgroundColorOrDrawableResource = JNIEnv.GetMethodID (class_ref, "getEditTextLayoutBackgroundColorOrDrawableResource", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEditTextLayoutBackgroundColorOrDrawableResource);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEditTextLayoutBackgroundColorOrDrawableResource", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isActionDialWithoutCallingEnabled;
#pragma warning disable 0169
		static Delegate GetIsActionDialWithoutCallingEnabledHandler ()
		{
			if (cb_isActionDialWithoutCallingEnabled == null)
				cb_isActionDialWithoutCallingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActionDialWithoutCallingEnabled);
			return cb_isActionDialWithoutCallingEnabled;
		}

		static bool n_IsActionDialWithoutCallingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsActionDialWithoutCallingEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isActionDialWithoutCallingEnabled;
		public virtual unsafe bool IsActionDialWithoutCallingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isActionDialWithoutCallingEnabled' and count(parameter)=0]"
			[Register ("isActionDialWithoutCallingEnabled", "()Z", "GetIsActionDialWithoutCallingEnabledHandler")]
			get {
				if (id_isActionDialWithoutCallingEnabled == IntPtr.Zero)
					id_isActionDialWithoutCallingEnabled = JNIEnv.GetMethodID (class_ref, "isActionDialWithoutCallingEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isActionDialWithoutCallingEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isActionDialWithoutCallingEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isConversationContactImageVisible;
#pragma warning disable 0169
		static Delegate GetIsConversationContactImageVisibleHandler ()
		{
			if (cb_isConversationContactImageVisible == null)
				cb_isConversationContactImageVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConversationContactImageVisible);
			return cb_isConversationContactImageVisible;
		}

		static bool n_IsConversationContactImageVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConversationContactImageVisible;
		}
#pragma warning restore 0169

		static IntPtr id_isConversationContactImageVisible;
		public virtual unsafe bool IsConversationContactImageVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isConversationContactImageVisible' and count(parameter)=0]"
			[Register ("isConversationContactImageVisible", "()Z", "GetIsConversationContactImageVisibleHandler")]
			get {
				if (id_isConversationContactImageVisible == IntPtr.Zero)
					id_isConversationContactImageVisible = JNIEnv.GetMethodID (class_ref, "isConversationContactImageVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConversationContactImageVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConversationContactImageVisible", "()Z"));
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCreateAnyContact;
		}
#pragma warning restore 0169

		static IntPtr id_isCreateAnyContact;
		public virtual unsafe bool IsCreateAnyContact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isCreateAnyContact' and count(parameter)=0]"
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

		static Delegate cb_isHideGroupAddMemberButton;
#pragma warning disable 0169
		static Delegate GetIsHideGroupAddMemberButtonHandler ()
		{
			if (cb_isHideGroupAddMemberButton == null)
				cb_isHideGroupAddMemberButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideGroupAddMemberButton);
			return cb_isHideGroupAddMemberButton;
		}

		static bool n_IsHideGroupAddMemberButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideGroupAddMemberButton;
		}
#pragma warning restore 0169

		static IntPtr id_isHideGroupAddMemberButton;
		public virtual unsafe bool IsHideGroupAddMemberButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isHideGroupAddMemberButton' and count(parameter)=0]"
			[Register ("isHideGroupAddMemberButton", "()Z", "GetIsHideGroupAddMemberButtonHandler")]
			get {
				if (id_isHideGroupAddMemberButton == IntPtr.Zero)
					id_isHideGroupAddMemberButton = JNIEnv.GetMethodID (class_ref, "isHideGroupAddMemberButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideGroupAddMemberButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHideGroupAddMemberButton", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHideGroupExitMemberButton;
#pragma warning disable 0169
		static Delegate GetIsHideGroupExitMemberButtonHandler ()
		{
			if (cb_isHideGroupExitMemberButton == null)
				cb_isHideGroupExitMemberButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideGroupExitMemberButton);
			return cb_isHideGroupExitMemberButton;
		}

		static bool n_IsHideGroupExitMemberButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideGroupExitMemberButton;
		}
#pragma warning restore 0169

		static IntPtr id_isHideGroupExitMemberButton;
		public virtual unsafe bool IsHideGroupExitMemberButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isHideGroupExitMemberButton' and count(parameter)=0]"
			[Register ("isHideGroupExitMemberButton", "()Z", "GetIsHideGroupExitMemberButtonHandler")]
			get {
				if (id_isHideGroupExitMemberButton == IntPtr.Zero)
					id_isHideGroupExitMemberButton = JNIEnv.GetMethodID (class_ref, "isHideGroupExitMemberButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideGroupExitMemberButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHideGroupExitMemberButton", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHideGroupNameEditButton;
#pragma warning disable 0169
		static Delegate GetIsHideGroupNameEditButtonHandler ()
		{
			if (cb_isHideGroupNameEditButton == null)
				cb_isHideGroupNameEditButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideGroupNameEditButton);
			return cb_isHideGroupNameEditButton;
		}

		static bool n_IsHideGroupNameEditButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideGroupNameEditButton;
		}
#pragma warning restore 0169

		static IntPtr id_isHideGroupNameEditButton;
		public virtual unsafe bool IsHideGroupNameEditButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isHideGroupNameEditButton' and count(parameter)=0]"
			[Register ("isHideGroupNameEditButton", "()Z", "GetIsHideGroupNameEditButtonHandler")]
			get {
				if (id_isHideGroupNameEditButton == IntPtr.Zero)
					id_isHideGroupNameEditButton = JNIEnv.GetMethodID (class_ref, "isHideGroupNameEditButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideGroupNameEditButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHideGroupNameEditButton", "()Z"));
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideGroupRemoveMemberOption;
		}
#pragma warning restore 0169

		static IntPtr id_isHideGroupRemoveMemberOption;
		public virtual unsafe bool IsHideGroupRemoveMemberOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isHideGroupRemoveMemberOption' and count(parameter)=0]"
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

		static Delegate cb_isImageCompressionEnabled;
#pragma warning disable 0169
		static Delegate GetIsImageCompressionEnabledHandler ()
		{
			if (cb_isImageCompressionEnabled == null)
				cb_isImageCompressionEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsImageCompressionEnabled);
			return cb_isImageCompressionEnabled;
		}

		static bool n_IsImageCompressionEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsImageCompressionEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isImageCompressionEnabled;
		public virtual unsafe bool IsImageCompressionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isImageCompressionEnabled' and count(parameter)=0]"
			[Register ("isImageCompressionEnabled", "()Z", "GetIsImageCompressionEnabledHandler")]
			get {
				if (id_isImageCompressionEnabled == IntPtr.Zero)
					id_isImageCompressionEnabled = JNIEnv.GetMethodID (class_ref, "isImageCompressionEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isImageCompressionEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isImageCompressionEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInviteFriendsButtonVisible;
#pragma warning disable 0169
		static Delegate GetIsInviteFriendsButtonVisibleHandler ()
		{
			if (cb_isInviteFriendsButtonVisible == null)
				cb_isInviteFriendsButtonVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInviteFriendsButtonVisible);
			return cb_isInviteFriendsButtonVisible;
		}

		static bool n_IsInviteFriendsButtonVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInviteFriendsButtonVisible;
		}
#pragma warning restore 0169

		static IntPtr id_isInviteFriendsButtonVisible;
		public virtual unsafe bool IsInviteFriendsButtonVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isInviteFriendsButtonVisible' and count(parameter)=0]"
			[Register ("isInviteFriendsButtonVisible", "()Z", "GetIsInviteFriendsButtonVisibleHandler")]
			get {
				if (id_isInviteFriendsButtonVisible == IntPtr.Zero)
					id_isInviteFriendsButtonVisible = JNIEnv.GetMethodID (class_ref, "isInviteFriendsButtonVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInviteFriendsButtonVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInviteFriendsButtonVisible", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLocationSharingViaMap;
#pragma warning disable 0169
		static Delegate GetIsLocationSharingViaMapHandler ()
		{
			if (cb_isLocationSharingViaMap == null)
				cb_isLocationSharingViaMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocationSharingViaMap);
			return cb_isLocationSharingViaMap;
		}

		static bool n_IsLocationSharingViaMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocationSharingViaMap;
		}
#pragma warning restore 0169

		static IntPtr id_isLocationSharingViaMap;
		public virtual unsafe bool IsLocationSharingViaMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isLocationSharingViaMap' and count(parameter)=0]"
			[Register ("isLocationSharingViaMap", "()Z", "GetIsLocationSharingViaMapHandler")]
			get {
				if (id_isLocationSharingViaMap == IntPtr.Zero)
					id_isLocationSharingViaMap = JNIEnv.GetMethodID (class_ref, "isLocationSharingViaMap", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocationSharingViaMap);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLocationSharingViaMap", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isMessageSearchEnabled;
#pragma warning disable 0169
		static Delegate GetIsMessageSearchEnabledHandler ()
		{
			if (cb_isMessageSearchEnabled == null)
				cb_isMessageSearchEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMessageSearchEnabled);
			return cb_isMessageSearchEnabled;
		}

		static bool n_IsMessageSearchEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMessageSearchEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isMessageSearchEnabled;
		public virtual unsafe bool IsMessageSearchEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isMessageSearchEnabled' and count(parameter)=0]"
			[Register ("isMessageSearchEnabled", "()Z", "GetIsMessageSearchEnabledHandler")]
			get {
				if (id_isMessageSearchEnabled == IntPtr.Zero)
					id_isMessageSearchEnabled = JNIEnv.GetMethodID (class_ref, "isMessageSearchEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMessageSearchEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMessageSearchEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isOnlineStatusInMasterListVisible;
#pragma warning disable 0169
		static Delegate GetIsOnlineStatusInMasterListVisibleHandler ()
		{
			if (cb_isOnlineStatusInMasterListVisible == null)
				cb_isOnlineStatusInMasterListVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnlineStatusInMasterListVisible);
			return cb_isOnlineStatusInMasterListVisible;
		}

		static bool n_IsOnlineStatusInMasterListVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOnlineStatusInMasterListVisible;
		}
#pragma warning restore 0169

		static IntPtr id_isOnlineStatusInMasterListVisible;
		public virtual unsafe bool IsOnlineStatusInMasterListVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isOnlineStatusInMasterListVisible' and count(parameter)=0]"
			[Register ("isOnlineStatusInMasterListVisible", "()Z", "GetIsOnlineStatusInMasterListVisibleHandler")]
			get {
				if (id_isOnlineStatusInMasterListVisible == IntPtr.Zero)
					id_isOnlineStatusInMasterListVisible = JNIEnv.GetMethodID (class_ref, "isOnlineStatusInMasterListVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnlineStatusInMasterListVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOnlineStatusInMasterListVisible", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isPriceOptionVisible;
#pragma warning disable 0169
		static Delegate GetIsPriceOptionVisibleHandler ()
		{
			if (cb_isPriceOptionVisible == null)
				cb_isPriceOptionVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPriceOptionVisible);
			return cb_isPriceOptionVisible;
		}

		static bool n_IsPriceOptionVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPriceOptionVisible;
		}
#pragma warning restore 0169

		static IntPtr id_isPriceOptionVisible;
		public virtual unsafe bool IsPriceOptionVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isPriceOptionVisible' and count(parameter)=0]"
			[Register ("isPriceOptionVisible", "()Z", "GetIsPriceOptionVisibleHandler")]
			get {
				if (id_isPriceOptionVisible == IntPtr.Zero)
					id_isPriceOptionVisible = JNIEnv.GetMethodID (class_ref, "isPriceOptionVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPriceOptionVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPriceOptionVisible", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isProfileLogoutEnable;
#pragma warning disable 0169
		static Delegate GetIsProfileLogoutEnableHandler ()
		{
			if (cb_isProfileLogoutEnable == null)
				cb_isProfileLogoutEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsProfileLogoutEnable);
			return cb_isProfileLogoutEnable;
		}

		static bool n_IsProfileLogoutEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsProfileLogoutEnable;
		}
#pragma warning restore 0169

		static IntPtr id_isProfileLogoutEnable;
		public virtual unsafe bool IsProfileLogoutEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isProfileLogoutEnable' and count(parameter)=0]"
			[Register ("isProfileLogoutEnable", "()Z", "GetIsProfileLogoutEnableHandler")]
			get {
				if (id_isProfileLogoutEnable == IntPtr.Zero)
					id_isProfileLogoutEnable = JNIEnv.GetMethodID (class_ref, "isProfileLogoutEnable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProfileLogoutEnable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isProfileLogoutEnable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isProfileOptionEnabled;
#pragma warning disable 0169
		static Delegate GetIsProfileOptionEnabledHandler ()
		{
			if (cb_isProfileOptionEnabled == null)
				cb_isProfileOptionEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsProfileOptionEnabled);
			return cb_isProfileOptionEnabled;
		}

		static bool n_IsProfileOptionEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsProfileOptionEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isProfileOptionEnabled;
		public virtual unsafe bool IsProfileOptionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isProfileOptionEnabled' and count(parameter)=0]"
			[Register ("isProfileOptionEnabled", "()Z", "GetIsProfileOptionEnabledHandler")]
			get {
				if (id_isProfileOptionEnabled == IntPtr.Zero)
					id_isProfileOptionEnabled = JNIEnv.GetMethodID (class_ref, "isProfileOptionEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProfileOptionEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isProfileOptionEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRegisteredUsersContactCall;
#pragma warning disable 0169
		static Delegate GetIsRegisteredUsersContactCallHandler ()
		{
			if (cb_isRegisteredUsersContactCall == null)
				cb_isRegisteredUsersContactCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRegisteredUsersContactCall);
			return cb_isRegisteredUsersContactCall;
		}

		static bool n_IsRegisteredUsersContactCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRegisteredUsersContactCall;
		}
#pragma warning restore 0169

		static IntPtr id_isRegisteredUsersContactCall;
		public virtual unsafe bool IsRegisteredUsersContactCall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isRegisteredUsersContactCall' and count(parameter)=0]"
			[Register ("isRegisteredUsersContactCall", "()Z", "GetIsRegisteredUsersContactCallHandler")]
			get {
				if (id_isRegisteredUsersContactCall == IntPtr.Zero)
					id_isRegisteredUsersContactCall = JNIEnv.GetMethodID (class_ref, "isRegisteredUsersContactCall", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRegisteredUsersContactCall);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRegisteredUsersContactCall", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStartNewButtonVisible;
#pragma warning disable 0169
		static Delegate GetIsStartNewButtonVisibleHandler ()
		{
			if (cb_isStartNewButtonVisible == null)
				cb_isStartNewButtonVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStartNewButtonVisible);
			return cb_isStartNewButtonVisible;
		}

		static bool n_IsStartNewButtonVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStartNewButtonVisible;
		}
#pragma warning restore 0169

		static IntPtr id_isStartNewButtonVisible;
		public virtual unsafe bool IsStartNewButtonVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isStartNewButtonVisible' and count(parameter)=0]"
			[Register ("isStartNewButtonVisible", "()Z", "GetIsStartNewButtonVisibleHandler")]
			get {
				if (id_isStartNewButtonVisible == IntPtr.Zero)
					id_isStartNewButtonVisible = JNIEnv.GetMethodID (class_ref, "isStartNewButtonVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStartNewButtonVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStartNewButtonVisible", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStartNewFloatingActionButtonVisible;
#pragma warning disable 0169
		static Delegate GetIsStartNewFloatingActionButtonVisibleHandler ()
		{
			if (cb_isStartNewFloatingActionButtonVisible == null)
				cb_isStartNewFloatingActionButtonVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStartNewFloatingActionButtonVisible);
			return cb_isStartNewFloatingActionButtonVisible;
		}

		static bool n_IsStartNewFloatingActionButtonVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStartNewFloatingActionButtonVisible;
		}
#pragma warning restore 0169

		static IntPtr id_isStartNewFloatingActionButtonVisible;
		public virtual unsafe bool IsStartNewFloatingActionButtonVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isStartNewFloatingActionButtonVisible' and count(parameter)=0]"
			[Register ("isStartNewFloatingActionButtonVisible", "()Z", "GetIsStartNewFloatingActionButtonVisibleHandler")]
			get {
				if (id_isStartNewFloatingActionButtonVisible == IntPtr.Zero)
					id_isStartNewFloatingActionButtonVisible = JNIEnv.GetMethodID (class_ref, "isStartNewFloatingActionButtonVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStartNewFloatingActionButtonVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStartNewFloatingActionButtonVisible", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStartNewGroupButtonVisible;
#pragma warning disable 0169
		static Delegate GetIsStartNewGroupButtonVisibleHandler ()
		{
			if (cb_isStartNewGroupButtonVisible == null)
				cb_isStartNewGroupButtonVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStartNewGroupButtonVisible);
			return cb_isStartNewGroupButtonVisible;
		}

		static bool n_IsStartNewGroupButtonVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStartNewGroupButtonVisible;
		}
#pragma warning restore 0169

		static IntPtr id_isStartNewGroupButtonVisible;
		public virtual unsafe bool IsStartNewGroupButtonVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isStartNewGroupButtonVisible' and count(parameter)=0]"
			[Register ("isStartNewGroupButtonVisible", "()Z", "GetIsStartNewGroupButtonVisibleHandler")]
			get {
				if (id_isStartNewGroupButtonVisible == IntPtr.Zero)
					id_isStartNewGroupButtonVisible = JNIEnv.GetMethodID (class_ref, "isStartNewGroupButtonVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStartNewGroupButtonVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStartNewGroupButtonVisible", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUserProfileFragmentVisible;
#pragma warning disable 0169
		static Delegate GetIsUserProfileFragmentVisibleHandler ()
		{
			if (cb_isUserProfileFragmentVisible == null)
				cb_isUserProfileFragmentVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUserProfileFragmentVisible);
			return cb_isUserProfileFragmentVisible;
		}

		static bool n_IsUserProfileFragmentVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUserProfileFragmentVisible;
		}
#pragma warning restore 0169

		static IntPtr id_isUserProfileFragmentVisible;
		public virtual unsafe bool IsUserProfileFragmentVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='isUserProfileFragmentVisible' and count(parameter)=0]"
			[Register ("isUserProfileFragmentVisible", "()Z", "GetIsUserProfileFragmentVisibleHandler")]
			get {
				if (id_isUserProfileFragmentVisible == IntPtr.Zero)
					id_isUserProfileFragmentVisible = JNIEnv.GetMethodID (class_ref, "isUserProfileFragmentVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUserProfileFragmentVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUserProfileFragmentVisible", "()Z"));
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxAttachmentAllowed;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxAttachmentAllowed;
		public virtual unsafe int MaxAttachmentAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getMaxAttachmentAllowed' and count(parameter)=0]"
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxAttachmentSizeAllowed;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxAttachmentSizeAllowed;
		public virtual unsafe int MaxAttachmentSizeAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getMaxAttachmentSizeAllowed' and count(parameter)=0]"
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

		static Delegate cb_getMessageEditTextHintColor;
#pragma warning disable 0169
		static Delegate GetGetMessageEditTextHintColorHandler ()
		{
			if (cb_getMessageEditTextHintColor == null)
				cb_getMessageEditTextHintColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageEditTextHintColor);
			return cb_getMessageEditTextHintColor;
		}

		static int n_GetMessageEditTextHintColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageEditTextHintColor;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageEditTextHintColor;
		public virtual unsafe int MessageEditTextHintColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getMessageEditTextHintColor' and count(parameter)=0]"
			[Register ("getMessageEditTextHintColor", "()I", "GetGetMessageEditTextHintColorHandler")]
			get {
				if (id_getMessageEditTextHintColor == IntPtr.Zero)
					id_getMessageEditTextHintColor = JNIEnv.GetMethodID (class_ref, "getMessageEditTextHintColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMessageEditTextHintColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageEditTextHintColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessageEditTextTextColor;
#pragma warning disable 0169
		static Delegate GetGetMessageEditTextTextColorHandler ()
		{
			if (cb_getMessageEditTextTextColor == null)
				cb_getMessageEditTextTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageEditTextTextColor);
			return cb_getMessageEditTextTextColor;
		}

		static int n_GetMessageEditTextTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageEditTextTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageEditTextTextColor;
		public virtual unsafe int MessageEditTextTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getMessageEditTextTextColor' and count(parameter)=0]"
			[Register ("getMessageEditTextTextColor", "()I", "GetGetMessageEditTextTextColorHandler")]
			get {
				if (id_getMessageEditTextTextColor == IntPtr.Zero)
					id_getMessageEditTextTextColor = JNIEnv.GetMethodID (class_ref, "getMessageEditTextTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMessageEditTextTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageEditTextTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessageTimeTextColor;
#pragma warning disable 0169
		static Delegate GetGetMessageTimeTextColorHandler ()
		{
			if (cb_getMessageTimeTextColor == null)
				cb_getMessageTimeTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageTimeTextColor);
			return cb_getMessageTimeTextColor;
		}

		static int n_GetMessageTimeTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageTimeTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageTimeTextColor;
		public virtual unsafe int MessageTimeTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getMessageTimeTextColor' and count(parameter)=0]"
			[Register ("getMessageTimeTextColor", "()I", "GetGetMessageTimeTextColorHandler")]
			get {
				if (id_getMessageTimeTextColor == IntPtr.Zero)
					id_getMessageTimeTextColor = JNIEnv.GetMethodID (class_ref, "getMessageTimeTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMessageTimeTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageTimeTextColor", "()I"));
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NoConversationLabel);
		}
#pragma warning restore 0169

		static IntPtr id_getNoConversationLabel;
		public virtual unsafe string NoConversationLabel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getNoConversationLabel' and count(parameter)=0]"
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
				cb_getNoConversationLabelTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNoConversationLabelTextColor);
			return cb_getNoConversationLabelTextColor;
		}

		static int n_GetNoConversationLabelTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NoConversationLabelTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getNoConversationLabelTextColor;
		public virtual unsafe int NoConversationLabelTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getNoConversationLabelTextColor' and count(parameter)=0]"
			[Register ("getNoConversationLabelTextColor", "()I", "GetGetNoConversationLabelTextColorHandler")]
			get {
				if (id_getNoConversationLabelTextColor == IntPtr.Zero)
					id_getNoConversationLabelTextColor = JNIEnv.GetMethodID (class_ref, "getNoConversationLabelTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNoConversationLabelTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNoConversationLabelTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedContactMessageTextColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedContactMessageTextColorHandler ()
		{
			if (cb_getReceivedContactMessageTextColor == null)
				cb_getReceivedContactMessageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReceivedContactMessageTextColor);
			return cb_getReceivedContactMessageTextColor;
		}

		static int n_GetReceivedContactMessageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReceivedContactMessageTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedContactMessageTextColor;
		public virtual unsafe int ReceivedContactMessageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getReceivedContactMessageTextColor' and count(parameter)=0]"
			[Register ("getReceivedContactMessageTextColor", "()I", "GetGetReceivedContactMessageTextColorHandler")]
			get {
				if (id_getReceivedContactMessageTextColor == IntPtr.Zero)
					id_getReceivedContactMessageTextColor = JNIEnv.GetMethodID (class_ref, "getReceivedContactMessageTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedContactMessageTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedContactMessageTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedMessageBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedMessageBackgroundColorHandler ()
		{
			if (cb_getReceivedMessageBackgroundColor == null)
				cb_getReceivedMessageBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReceivedMessageBackgroundColor);
			return cb_getReceivedMessageBackgroundColor;
		}

		static int n_GetReceivedMessageBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReceivedMessageBackgroundColor;
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedMessageBackgroundColor;
		public virtual unsafe int ReceivedMessageBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getReceivedMessageBackgroundColor' and count(parameter)=0]"
			[Register ("getReceivedMessageBackgroundColor", "()I", "GetGetReceivedMessageBackgroundColorHandler")]
			get {
				if (id_getReceivedMessageBackgroundColor == IntPtr.Zero)
					id_getReceivedMessageBackgroundColor = JNIEnv.GetMethodID (class_ref, "getReceivedMessageBackgroundColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedMessageBackgroundColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedMessageBackgroundColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedMessageBorderColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedMessageBorderColorHandler ()
		{
			if (cb_getReceivedMessageBorderColor == null)
				cb_getReceivedMessageBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReceivedMessageBorderColor);
			return cb_getReceivedMessageBorderColor;
		}

		static int n_GetReceivedMessageBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReceivedMessageBorderColor;
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedMessageBorderColor;
		public virtual unsafe int ReceivedMessageBorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getReceivedMessageBorderColor' and count(parameter)=0]"
			[Register ("getReceivedMessageBorderColor", "()I", "GetGetReceivedMessageBorderColorHandler")]
			get {
				if (id_getReceivedMessageBorderColor == IntPtr.Zero)
					id_getReceivedMessageBorderColor = JNIEnv.GetMethodID (class_ref, "getReceivedMessageBorderColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedMessageBorderColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedMessageBorderColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedMessageLinkTextColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedMessageLinkTextColorHandler ()
		{
			if (cb_getReceivedMessageLinkTextColor == null)
				cb_getReceivedMessageLinkTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReceivedMessageLinkTextColor);
			return cb_getReceivedMessageLinkTextColor;
		}

		static int n_GetReceivedMessageLinkTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReceivedMessageLinkTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedMessageLinkTextColor;
		public virtual unsafe int ReceivedMessageLinkTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getReceivedMessageLinkTextColor' and count(parameter)=0]"
			[Register ("getReceivedMessageLinkTextColor", "()I", "GetGetReceivedMessageLinkTextColorHandler")]
			get {
				if (id_getReceivedMessageLinkTextColor == IntPtr.Zero)
					id_getReceivedMessageLinkTextColor = JNIEnv.GetMethodID (class_ref, "getReceivedMessageLinkTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedMessageLinkTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedMessageLinkTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedMessageTextColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedMessageTextColorHandler ()
		{
			if (cb_getReceivedMessageTextColor == null)
				cb_getReceivedMessageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReceivedMessageTextColor);
			return cb_getReceivedMessageTextColor;
		}

		static int n_GetReceivedMessageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReceivedMessageTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedMessageTextColor;
		public virtual unsafe int ReceivedMessageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getReceivedMessageTextColor' and count(parameter)=0]"
			[Register ("getReceivedMessageTextColor", "()I", "GetGetReceivedMessageTextColorHandler")]
			get {
				if (id_getReceivedMessageTextColor == IntPtr.Zero)
					id_getReceivedMessageTextColor = JNIEnv.GetMethodID (class_ref, "getReceivedMessageTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedMessageTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedMessageTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSearchNotFoundLabelForChats;
#pragma warning disable 0169
		static Delegate GetGetSearchNotFoundLabelForChatsHandler ()
		{
			if (cb_getSearchNotFoundLabelForChats == null)
				cb_getSearchNotFoundLabelForChats = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSearchNotFoundLabelForChats);
			return cb_getSearchNotFoundLabelForChats;
		}

		static IntPtr n_GetSearchNotFoundLabelForChats (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SearchNotFoundLabelForChats);
		}
#pragma warning restore 0169

		static IntPtr id_getSearchNotFoundLabelForChats;
		public virtual unsafe string SearchNotFoundLabelForChats {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getSearchNotFoundLabelForChats' and count(parameter)=0]"
			[Register ("getSearchNotFoundLabelForChats", "()Ljava/lang/String;", "GetGetSearchNotFoundLabelForChatsHandler")]
			get {
				if (id_getSearchNotFoundLabelForChats == IntPtr.Zero)
					id_getSearchNotFoundLabelForChats = JNIEnv.GetMethodID (class_ref, "getSearchNotFoundLabelForChats", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSearchNotFoundLabelForChats), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSearchNotFoundLabelForChats", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSendButtonBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetSendButtonBackgroundColorHandler ()
		{
			if (cb_getSendButtonBackgroundColor == null)
				cb_getSendButtonBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSendButtonBackgroundColor);
			return cb_getSendButtonBackgroundColor;
		}

		static int n_GetSendButtonBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SendButtonBackgroundColor;
		}
#pragma warning restore 0169

		static IntPtr id_getSendButtonBackgroundColor;
		public virtual unsafe int SendButtonBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getSendButtonBackgroundColor' and count(parameter)=0]"
			[Register ("getSendButtonBackgroundColor", "()I", "GetGetSendButtonBackgroundColorHandler")]
			get {
				if (id_getSendButtonBackgroundColor == IntPtr.Zero)
					id_getSendButtonBackgroundColor = JNIEnv.GetMethodID (class_ref, "getSendButtonBackgroundColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSendButtonBackgroundColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSendButtonBackgroundColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSentContactMessageTextColor;
#pragma warning disable 0169
		static Delegate GetGetSentContactMessageTextColorHandler ()
		{
			if (cb_getSentContactMessageTextColor == null)
				cb_getSentContactMessageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSentContactMessageTextColor);
			return cb_getSentContactMessageTextColor;
		}

		static int n_GetSentContactMessageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentContactMessageTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getSentContactMessageTextColor;
		public virtual unsafe int SentContactMessageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getSentContactMessageTextColor' and count(parameter)=0]"
			[Register ("getSentContactMessageTextColor", "()I", "GetGetSentContactMessageTextColorHandler")]
			get {
				if (id_getSentContactMessageTextColor == IntPtr.Zero)
					id_getSentContactMessageTextColor = JNIEnv.GetMethodID (class_ref, "getSentContactMessageTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSentContactMessageTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentContactMessageTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSentMessageBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetSentMessageBackgroundColorHandler ()
		{
			if (cb_getSentMessageBackgroundColor == null)
				cb_getSentMessageBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSentMessageBackgroundColor);
			return cb_getSentMessageBackgroundColor;
		}

		static int n_GetSentMessageBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentMessageBackgroundColor;
		}
#pragma warning restore 0169

		static IntPtr id_getSentMessageBackgroundColor;
		public virtual unsafe int SentMessageBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getSentMessageBackgroundColor' and count(parameter)=0]"
			[Register ("getSentMessageBackgroundColor", "()I", "GetGetSentMessageBackgroundColorHandler")]
			get {
				if (id_getSentMessageBackgroundColor == IntPtr.Zero)
					id_getSentMessageBackgroundColor = JNIEnv.GetMethodID (class_ref, "getSentMessageBackgroundColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSentMessageBackgroundColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentMessageBackgroundColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSentMessageBorderColor;
#pragma warning disable 0169
		static Delegate GetGetSentMessageBorderColorHandler ()
		{
			if (cb_getSentMessageBorderColor == null)
				cb_getSentMessageBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSentMessageBorderColor);
			return cb_getSentMessageBorderColor;
		}

		static int n_GetSentMessageBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentMessageBorderColor;
		}
#pragma warning restore 0169

		static IntPtr id_getSentMessageBorderColor;
		public virtual unsafe int SentMessageBorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getSentMessageBorderColor' and count(parameter)=0]"
			[Register ("getSentMessageBorderColor", "()I", "GetGetSentMessageBorderColorHandler")]
			get {
				if (id_getSentMessageBorderColor == IntPtr.Zero)
					id_getSentMessageBorderColor = JNIEnv.GetMethodID (class_ref, "getSentMessageBorderColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSentMessageBorderColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentMessageBorderColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSentMessageLinkTextColor;
#pragma warning disable 0169
		static Delegate GetGetSentMessageLinkTextColorHandler ()
		{
			if (cb_getSentMessageLinkTextColor == null)
				cb_getSentMessageLinkTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSentMessageLinkTextColor);
			return cb_getSentMessageLinkTextColor;
		}

		static int n_GetSentMessageLinkTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentMessageLinkTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getSentMessageLinkTextColor;
		public virtual unsafe int SentMessageLinkTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getSentMessageLinkTextColor' and count(parameter)=0]"
			[Register ("getSentMessageLinkTextColor", "()I", "GetGetSentMessageLinkTextColorHandler")]
			get {
				if (id_getSentMessageLinkTextColor == IntPtr.Zero)
					id_getSentMessageLinkTextColor = JNIEnv.GetMethodID (class_ref, "getSentMessageLinkTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSentMessageLinkTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentMessageLinkTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSentMessageTextColor;
#pragma warning disable 0169
		static Delegate GetGetSentMessageTextColorHandler ()
		{
			if (cb_getSentMessageTextColor == null)
				cb_getSentMessageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSentMessageTextColor);
			return cb_getSentMessageTextColor;
		}

		static int n_GetSentMessageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentMessageTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getSentMessageTextColor;
		public virtual unsafe int SentMessageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getSentMessageTextColor' and count(parameter)=0]"
			[Register ("getSentMessageTextColor", "()I", "GetGetSentMessageTextColorHandler")]
			get {
				if (id_getSentMessageTextColor == IntPtr.Zero)
					id_getSentMessageTextColor = JNIEnv.GetMethodID (class_ref, "getSentMessageTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSentMessageTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentMessageTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTextForAudioPermissionNotFound;
#pragma warning disable 0169
		static Delegate GetGetTextForAudioPermissionNotFoundHandler ()
		{
			if (cb_getTextForAudioPermissionNotFound == null)
				cb_getTextForAudioPermissionNotFound = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextForAudioPermissionNotFound);
			return cb_getTextForAudioPermissionNotFound;
		}

		static IntPtr n_GetTextForAudioPermissionNotFound (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TextForAudioPermissionNotFound);
		}
#pragma warning restore 0169

		static IntPtr id_getTextForAudioPermissionNotFound;
		public virtual unsafe string TextForAudioPermissionNotFound {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getTextForAudioPermissionNotFound' and count(parameter)=0]"
			[Register ("getTextForAudioPermissionNotFound", "()Ljava/lang/String;", "GetGetTextForAudioPermissionNotFoundHandler")]
			get {
				if (id_getTextForAudioPermissionNotFound == IntPtr.Zero)
					id_getTextForAudioPermissionNotFound = JNIEnv.GetMethodID (class_ref, "getTextForAudioPermissionNotFound", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextForAudioPermissionNotFound), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextForAudioPermissionNotFound", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalOnlineUser;
#pragma warning disable 0169
		static Delegate GetGetTotalOnlineUserHandler ()
		{
			if (cb_getTotalOnlineUser == null)
				cb_getTotalOnlineUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalOnlineUser);
			return cb_getTotalOnlineUser;
		}

		static int n_GetTotalOnlineUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalOnlineUser;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalOnlineUser;
		public virtual unsafe int TotalOnlineUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getTotalOnlineUser' and count(parameter)=0]"
			[Register ("getTotalOnlineUser", "()I", "GetGetTotalOnlineUserHandler")]
			get {
				if (id_getTotalOnlineUser == IntPtr.Zero)
					id_getTotalOnlineUser = JNIEnv.GetMethodID (class_ref, "getTotalOnlineUser", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalOnlineUser);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalOnlineUser", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTotalRegisteredUsers;
#pragma warning disable 0169
		static Delegate GetGetTotalRegisteredUsersHandler ()
		{
			if (cb_getTotalRegisteredUsers == null)
				cb_getTotalRegisteredUsers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalRegisteredUsers);
			return cb_getTotalRegisteredUsers;
		}

		static int n_GetTotalRegisteredUsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalRegisteredUsers;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalRegisteredUsers;
		public virtual unsafe int TotalRegisteredUsers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getTotalRegisteredUsers' and count(parameter)=0]"
			[Register ("getTotalRegisteredUsers", "()I", "GetGetTotalRegisteredUsersHandler")]
			get {
				if (id_getTotalRegisteredUsers == IntPtr.Zero)
					id_getTotalRegisteredUsers = JNIEnv.GetMethodID (class_ref, "getTotalRegisteredUsers", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalRegisteredUsers);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalRegisteredUsers", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTypingTextColor;
#pragma warning disable 0169
		static Delegate GetGetTypingTextColorHandler ()
		{
			if (cb_getTypingTextColor == null)
				cb_getTypingTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTypingTextColor);
			return cb_getTypingTextColor;
		}

		static int n_GetTypingTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TypingTextColor;
		}
#pragma warning restore 0169

		static IntPtr id_getTypingTextColor;
		public virtual unsafe int TypingTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getTypingTextColor' and count(parameter)=0]"
			[Register ("getTypingTextColor", "()I", "GetGetTypingTextColorHandler")]
			get {
				if (id_getTypingTextColor == IntPtr.Zero)
					id_getTypingTextColor = JNIEnv.GetMethodID (class_ref, "getTypingTextColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTypingTextColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypingTextColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_clearAll;
#pragma warning disable 0169
		static Delegate GetClearAllHandler ()
		{
			if (cb_clearAll == null)
				cb_clearAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ClearAll);
			return cb_clearAll;
		}

		static bool n_ClearAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearAll ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()Z", "GetClearAllHandler")]
		public virtual unsafe bool ClearAll ()
		{
			if (id_clearAll == IntPtr.Zero)
				id_clearAll = JNIEnv.GetMethodID (class_ref, "clearAll", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clearAll);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAll", "()Z"));
			} finally {
			}
		}

		static Delegate cb_disableImageCompression;
#pragma warning disable 0169
		static Delegate GetDisableImageCompressionHandler ()
		{
			if (cb_disableImageCompression == null)
				cb_disableImageCompression = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DisableImageCompression);
			return cb_disableImageCompression;
		}

		static IntPtr n_DisableImageCompression (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisableImageCompression ());
		}
#pragma warning restore 0169

		static IntPtr id_disableImageCompression;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='disableImageCompression' and count(parameter)=0]"
		[Register ("disableImageCompression", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetDisableImageCompressionHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting DisableImageCompression ()
		{
			if (id_disableImageCompression == IntPtr.Zero)
				id_disableImageCompression = JNIEnv.GetMethodID (class_ref, "disableImageCompression", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableImageCompression), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableImageCompression", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disableLocationSharingViaMap;
#pragma warning disable 0169
		static Delegate GetDisableLocationSharingViaMapHandler ()
		{
			if (cb_disableLocationSharingViaMap == null)
				cb_disableLocationSharingViaMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DisableLocationSharingViaMap);
			return cb_disableLocationSharingViaMap;
		}

		static IntPtr n_DisableLocationSharingViaMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisableLocationSharingViaMap ());
		}
#pragma warning restore 0169

		static IntPtr id_disableLocationSharingViaMap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='disableLocationSharingViaMap' and count(parameter)=0]"
		[Register ("disableLocationSharingViaMap", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetDisableLocationSharingViaMapHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting DisableLocationSharingViaMap ()
		{
			if (id_disableLocationSharingViaMap == IntPtr.Zero)
				id_disableLocationSharingViaMap = JNIEnv.GetMethodID (class_ref, "disableLocationSharingViaMap", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableLocationSharingViaMap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableLocationSharingViaMap", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disableMessageSearch;
#pragma warning disable 0169
		static Delegate GetDisableMessageSearchHandler ()
		{
			if (cb_disableMessageSearch == null)
				cb_disableMessageSearch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DisableMessageSearch);
			return cb_disableMessageSearch;
		}

		static IntPtr n_DisableMessageSearch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisableMessageSearch ());
		}
#pragma warning restore 0169

		static IntPtr id_disableMessageSearch;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='disableMessageSearch' and count(parameter)=0]"
		[Register ("disableMessageSearch", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetDisableMessageSearchHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting DisableMessageSearch ()
		{
			if (id_disableMessageSearch == IntPtr.Zero)
				id_disableMessageSearch = JNIEnv.GetMethodID (class_ref, "disableMessageSearch", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableMessageSearch), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableMessageSearch", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disableProfileOption;
#pragma warning disable 0169
		static Delegate GetDisableProfileOptionHandler ()
		{
			if (cb_disableProfileOption == null)
				cb_disableProfileOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DisableProfileOption);
			return cb_disableProfileOption;
		}

		static IntPtr n_DisableProfileOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisableProfileOption ());
		}
#pragma warning restore 0169

		static IntPtr id_disableProfileOption;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='disableProfileOption' and count(parameter)=0]"
		[Register ("disableProfileOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetDisableProfileOptionHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting DisableProfileOption ()
		{
			if (id_disableProfileOption == IntPtr.Zero)
				id_disableProfileOption = JNIEnv.GetMethodID (class_ref, "disableProfileOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableProfileOption), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableProfileOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableCreateAnyContact;
#pragma warning disable 0169
		static Delegate GetEnableCreateAnyContactHandler ()
		{
			if (cb_enableCreateAnyContact == null)
				cb_enableCreateAnyContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableCreateAnyContact);
			return cb_enableCreateAnyContact;
		}

		static IntPtr n_EnableCreateAnyContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableCreateAnyContact ());
		}
#pragma warning restore 0169

		static IntPtr id_enableCreateAnyContact;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='enableCreateAnyContact' and count(parameter)=0]"
		[Register ("enableCreateAnyContact", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetEnableCreateAnyContactHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting EnableCreateAnyContact ()
		{
			if (id_enableCreateAnyContact == IntPtr.Zero)
				id_enableCreateAnyContact = JNIEnv.GetMethodID (class_ref, "enableCreateAnyContact", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableCreateAnyContact), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableCreateAnyContact", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableImageCompression;
#pragma warning disable 0169
		static Delegate GetEnableImageCompressionHandler ()
		{
			if (cb_enableImageCompression == null)
				cb_enableImageCompression = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableImageCompression);
			return cb_enableImageCompression;
		}

		static IntPtr n_EnableImageCompression (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableImageCompression ());
		}
#pragma warning restore 0169

		static IntPtr id_enableImageCompression;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='enableImageCompression' and count(parameter)=0]"
		[Register ("enableImageCompression", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetEnableImageCompressionHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting EnableImageCompression ()
		{
			if (id_enableImageCompression == IntPtr.Zero)
				id_enableImageCompression = JNIEnv.GetMethodID (class_ref, "enableImageCompression", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableImageCompression), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableImageCompression", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableLocationSharingViaMap;
#pragma warning disable 0169
		static Delegate GetEnableLocationSharingViaMapHandler ()
		{
			if (cb_enableLocationSharingViaMap == null)
				cb_enableLocationSharingViaMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableLocationSharingViaMap);
			return cb_enableLocationSharingViaMap;
		}

		static IntPtr n_EnableLocationSharingViaMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableLocationSharingViaMap ());
		}
#pragma warning restore 0169

		static IntPtr id_enableLocationSharingViaMap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='enableLocationSharingViaMap' and count(parameter)=0]"
		[Register ("enableLocationSharingViaMap", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetEnableLocationSharingViaMapHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting EnableLocationSharingViaMap ()
		{
			if (id_enableLocationSharingViaMap == IntPtr.Zero)
				id_enableLocationSharingViaMap = JNIEnv.GetMethodID (class_ref, "enableLocationSharingViaMap", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableLocationSharingViaMap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableLocationSharingViaMap", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableMessageSearch;
#pragma warning disable 0169
		static Delegate GetEnableMessageSearchHandler ()
		{
			if (cb_enableMessageSearch == null)
				cb_enableMessageSearch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableMessageSearch);
			return cb_enableMessageSearch;
		}

		static IntPtr n_EnableMessageSearch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableMessageSearch ());
		}
#pragma warning restore 0169

		static IntPtr id_enableMessageSearch;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='enableMessageSearch' and count(parameter)=0]"
		[Register ("enableMessageSearch", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetEnableMessageSearchHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting EnableMessageSearch ()
		{
			if (id_enableMessageSearch == IntPtr.Zero)
				id_enableMessageSearch = JNIEnv.GetMethodID (class_ref, "enableMessageSearch", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableMessageSearch), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableMessageSearch", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableProfileOption;
#pragma warning disable 0169
		static Delegate GetEnableProfileOptionHandler ()
		{
			if (cb_enableProfileOption == null)
				cb_enableProfileOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableProfileOption);
			return cb_enableProfileOption;
		}

		static IntPtr n_EnableProfileOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableProfileOption ());
		}
#pragma warning restore 0169

		static IntPtr id_enableProfileOption;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='enableProfileOption' and count(parameter)=0]"
		[Register ("enableProfileOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetEnableProfileOptionHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting EnableProfileOption ()
		{
			if (id_enableProfileOption == IntPtr.Zero)
				id_enableProfileOption = JNIEnv.GetMethodID (class_ref, "enableProfileOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableProfileOption), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableProfileOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableRegisteredUsersContactCall;
#pragma warning disable 0169
		static Delegate GetEnableRegisteredUsersContactCallHandler ()
		{
			if (cb_enableRegisteredUsersContactCall == null)
				cb_enableRegisteredUsersContactCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableRegisteredUsersContactCall);
			return cb_enableRegisteredUsersContactCall;
		}

		static IntPtr n_EnableRegisteredUsersContactCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableRegisteredUsersContactCall ());
		}
#pragma warning restore 0169

		static IntPtr id_enableRegisteredUsersContactCall;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='enableRegisteredUsersContactCall' and count(parameter)=0]"
		[Register ("enableRegisteredUsersContactCall", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetEnableRegisteredUsersContactCallHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting EnableRegisteredUsersContactCall ()
		{
			if (id_enableRegisteredUsersContactCall == IntPtr.Zero)
				id_enableRegisteredUsersContactCall = JNIEnv.GetMethodID (class_ref, "enableRegisteredUsersContactCall", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableRegisteredUsersContactCall), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableRegisteredUsersContactCall", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_;
#pragma warning disable 0169
		static Delegate GetGetActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_Handler ()
		{
			if (cb_getActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_ == null)
				cb_getActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_);
			return cb_getActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_;
		}

		static IntPtr n_GetActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetActivityCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getActivityCallback' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.ApplozicSetting.RequestCode']]"
		[Register ("getActivityCallback", "(Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;)Ljava/lang/String;", "GetGetActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_Handler")]
		public virtual unsafe string GetActivityCallback (global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode p0)
		{
			if (id_getActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_ == IntPtr.Zero)
				id_getActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_ = JNIEnv.GetMethodID (class_ref, "getActivityCallback", "(Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActivityCallback_Lcom_applozic_mobicomkit_uiwidgets_ApplozicSetting_RequestCode_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActivityCallback", "(Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting$RequestCode;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetColor_Ljava_lang_String_Handler ()
		{
			if (cb_getColor_Ljava_lang_String_ == null)
				cb_getColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetColor_Ljava_lang_String_);
			return cb_getColor_Ljava_lang_String_;
		}

		static int n_GetColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetColor (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getColor_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getColor", "(Ljava/lang/String;)I", "GetGetColor_Ljava_lang_String_Handler")]
		public virtual unsafe int GetColor (string p0)
		{
			if (id_getColor_Ljava_lang_String_ == IntPtr.Zero)
				id_getColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getColor", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_hideConversationContactImage;
#pragma warning disable 0169
		static Delegate GetHideConversationContactImageHandler ()
		{
			if (cb_hideConversationContactImage == null)
				cb_hideConversationContactImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideConversationContactImage);
			return cb_hideConversationContactImage;
		}

		static IntPtr n_HideConversationContactImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideConversationContactImage ());
		}
#pragma warning restore 0169

		static IntPtr id_hideConversationContactImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='hideConversationContactImage' and count(parameter)=0]"
		[Register ("hideConversationContactImage", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetHideConversationContactImageHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting HideConversationContactImage ()
		{
			if (id_hideConversationContactImage == IntPtr.Zero)
				id_hideConversationContactImage = JNIEnv.GetMethodID (class_ref, "hideConversationContactImage", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideConversationContactImage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideConversationContactImage", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideInviteFriendsButton;
#pragma warning disable 0169
		static Delegate GetHideInviteFriendsButtonHandler ()
		{
			if (cb_hideInviteFriendsButton == null)
				cb_hideInviteFriendsButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideInviteFriendsButton);
			return cb_hideInviteFriendsButton;
		}

		static IntPtr n_HideInviteFriendsButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideInviteFriendsButton ());
		}
#pragma warning restore 0169

		static IntPtr id_hideInviteFriendsButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='hideInviteFriendsButton' and count(parameter)=0]"
		[Register ("hideInviteFriendsButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetHideInviteFriendsButtonHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting HideInviteFriendsButton ()
		{
			if (id_hideInviteFriendsButton == IntPtr.Zero)
				id_hideInviteFriendsButton = JNIEnv.GetMethodID (class_ref, "hideInviteFriendsButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideInviteFriendsButton), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideInviteFriendsButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideOnlineStatusInMasterList;
#pragma warning disable 0169
		static Delegate GetHideOnlineStatusInMasterListHandler ()
		{
			if (cb_hideOnlineStatusInMasterList == null)
				cb_hideOnlineStatusInMasterList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideOnlineStatusInMasterList);
			return cb_hideOnlineStatusInMasterList;
		}

		static IntPtr n_HideOnlineStatusInMasterList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideOnlineStatusInMasterList ());
		}
#pragma warning restore 0169

		static IntPtr id_hideOnlineStatusInMasterList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='hideOnlineStatusInMasterList' and count(parameter)=0]"
		[Register ("hideOnlineStatusInMasterList", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetHideOnlineStatusInMasterListHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting HideOnlineStatusInMasterList ()
		{
			if (id_hideOnlineStatusInMasterList == IntPtr.Zero)
				id_hideOnlineStatusInMasterList = JNIEnv.GetMethodID (class_ref, "hideOnlineStatusInMasterList", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideOnlineStatusInMasterList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideOnlineStatusInMasterList", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hidePriceOption;
#pragma warning disable 0169
		static Delegate GetHidePriceOptionHandler ()
		{
			if (cb_hidePriceOption == null)
				cb_hidePriceOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HidePriceOption);
			return cb_hidePriceOption;
		}

		static IntPtr n_HidePriceOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HidePriceOption ());
		}
#pragma warning restore 0169

		static IntPtr id_hidePriceOption;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='hidePriceOption' and count(parameter)=0]"
		[Register ("hidePriceOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetHidePriceOptionHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting HidePriceOption ()
		{
			if (id_hidePriceOption == IntPtr.Zero)
				id_hidePriceOption = JNIEnv.GetMethodID (class_ref, "hidePriceOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hidePriceOption), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hidePriceOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideProfileLogout;
#pragma warning disable 0169
		static Delegate GetHideProfileLogoutHandler ()
		{
			if (cb_hideProfileLogout == null)
				cb_hideProfileLogout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideProfileLogout);
			return cb_hideProfileLogout;
		}

		static IntPtr n_HideProfileLogout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideProfileLogout ());
		}
#pragma warning restore 0169

		static IntPtr id_hideProfileLogout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='hideProfileLogout' and count(parameter)=0]"
		[Register ("hideProfileLogout", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetHideProfileLogoutHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting HideProfileLogout ()
		{
			if (id_hideProfileLogout == IntPtr.Zero)
				id_hideProfileLogout = JNIEnv.GetMethodID (class_ref, "hideProfileLogout", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideProfileLogout), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideProfileLogout", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideStartNewButton;
#pragma warning disable 0169
		static Delegate GetHideStartNewButtonHandler ()
		{
			if (cb_hideStartNewButton == null)
				cb_hideStartNewButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideStartNewButton);
			return cb_hideStartNewButton;
		}

		static IntPtr n_HideStartNewButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideStartNewButton ());
		}
#pragma warning restore 0169

		static IntPtr id_hideStartNewButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='hideStartNewButton' and count(parameter)=0]"
		[Register ("hideStartNewButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetHideStartNewButtonHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting HideStartNewButton ()
		{
			if (id_hideStartNewButton == IntPtr.Zero)
				id_hideStartNewButton = JNIEnv.GetMethodID (class_ref, "hideStartNewButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideStartNewButton), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideStartNewButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideStartNewFloatingActionButton;
#pragma warning disable 0169
		static Delegate GetHideStartNewFloatingActionButtonHandler ()
		{
			if (cb_hideStartNewFloatingActionButton == null)
				cb_hideStartNewFloatingActionButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideStartNewFloatingActionButton);
			return cb_hideStartNewFloatingActionButton;
		}

		static IntPtr n_HideStartNewFloatingActionButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideStartNewFloatingActionButton ());
		}
#pragma warning restore 0169

		static IntPtr id_hideStartNewFloatingActionButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='hideStartNewFloatingActionButton' and count(parameter)=0]"
		[Register ("hideStartNewFloatingActionButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetHideStartNewFloatingActionButtonHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting HideStartNewFloatingActionButton ()
		{
			if (id_hideStartNewFloatingActionButton == IntPtr.Zero)
				id_hideStartNewFloatingActionButton = JNIEnv.GetMethodID (class_ref, "hideStartNewFloatingActionButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideStartNewFloatingActionButton), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideStartNewFloatingActionButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideStartNewGroupButton;
#pragma warning disable 0169
		static Delegate GetHideStartNewGroupButtonHandler ()
		{
			if (cb_hideStartNewGroupButton == null)
				cb_hideStartNewGroupButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideStartNewGroupButton);
			return cb_hideStartNewGroupButton;
		}

		static IntPtr n_HideStartNewGroupButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideStartNewGroupButton ());
		}
#pragma warning restore 0169

		static IntPtr id_hideStartNewGroupButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='hideStartNewGroupButton' and count(parameter)=0]"
		[Register ("hideStartNewGroupButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetHideStartNewGroupButtonHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting HideStartNewGroupButton ()
		{
			if (id_hideStartNewGroupButton == IntPtr.Zero)
				id_hideStartNewGroupButton = JNIEnv.GetMethodID (class_ref, "hideStartNewGroupButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideStartNewGroupButton), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideStartNewGroupButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideUserProfileFragment;
#pragma warning disable 0169
		static Delegate GetHideUserProfileFragmentHandler ()
		{
			if (cb_hideUserProfileFragment == null)
				cb_hideUserProfileFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideUserProfileFragment);
			return cb_hideUserProfileFragment;
		}

		static IntPtr n_HideUserProfileFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideUserProfileFragment ());
		}
#pragma warning restore 0169

		static IntPtr id_hideUserProfileFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='hideUserProfileFragment' and count(parameter)=0]"
		[Register ("hideUserProfileFragment", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetHideUserProfileFragmentHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting HideUserProfileFragment ()
		{
			if (id_hideUserProfileFragment == IntPtr.Zero)
				id_hideUserProfileFragment = JNIEnv.GetMethodID (class_ref, "hideUserProfileFragment", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideUserProfileFragment), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideUserProfileFragment", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActivityCallbacks_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetActivityCallbacks_Ljava_util_Map_Handler ()
		{
			if (cb_setActivityCallbacks_Ljava_util_Map_ == null)
				cb_setActivityCallbacks_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetActivityCallbacks_Ljava_util_Map_);
			return cb_setActivityCallbacks_Ljava_util_Map_;
		}

		static IntPtr n_SetActivityCallbacks_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetActivityCallbacks (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setActivityCallbacks_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setActivityCallbacks' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;com.applozic.mobicomkit.uiwidgets.ApplozicSetting.RequestCode, java.lang.String&gt;']]"
		[Register ("setActivityCallbacks", "(Ljava/util/Map;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetActivityCallbacks_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetActivityCallbacks (global::System.Collections.Generic.IDictionary<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode, string> p0)
		{
			if (id_setActivityCallbacks_Ljava_util_Map_ == IntPtr.Zero)
				id_setActivityCallbacks_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setActivityCallbacks", "(Ljava/util/Map;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting.RequestCode, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setActivityCallbacks_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActivityCallbacks", "(Ljava/util/Map;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setAttachmentIconsBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetAttachmentIconsBackgroundColor_IHandler ()
		{
			if (cb_setAttachmentIconsBackgroundColor_I == null)
				cb_setAttachmentIconsBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAttachmentIconsBackgroundColor_I);
			return cb_setAttachmentIconsBackgroundColor_I;
		}

		static IntPtr n_SetAttachmentIconsBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAttachmentIconsBackgroundColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setAttachmentIconsBackgroundColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setAttachmentIconsBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAttachmentIconsBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetAttachmentIconsBackgroundColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetAttachmentIconsBackgroundColor (int p0)
		{
			if (id_setAttachmentIconsBackgroundColor_I == IntPtr.Zero)
				id_setAttachmentIconsBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setAttachmentIconsBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAttachmentIconsBackgroundColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttachmentIconsBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setChannelCustomMesssageBgColor_I;
#pragma warning disable 0169
		static Delegate GetSetChannelCustomMesssageBgColor_IHandler ()
		{
			if (cb_setChannelCustomMesssageBgColor_I == null)
				cb_setChannelCustomMesssageBgColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetChannelCustomMesssageBgColor_I);
			return cb_setChannelCustomMesssageBgColor_I;
		}

		static IntPtr n_SetChannelCustomMesssageBgColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetChannelCustomMesssageBgColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setChannelCustomMesssageBgColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setChannelCustomMesssageBgColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChannelCustomMesssageBgColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetChannelCustomMesssageBgColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetChannelCustomMesssageBgColor (int p0)
		{
			if (id_setChannelCustomMesssageBgColor_I == IntPtr.Zero)
				id_setChannelCustomMesssageBgColor_I = JNIEnv.GetMethodID (class_ref, "setChannelCustomMesssageBgColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setChannelCustomMesssageBgColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannelCustomMesssageBgColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setChannelCustomMesssageBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetChannelCustomMesssageBorderColor_IHandler ()
		{
			if (cb_setChannelCustomMesssageBorderColor_I == null)
				cb_setChannelCustomMesssageBorderColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetChannelCustomMesssageBorderColor_I);
			return cb_setChannelCustomMesssageBorderColor_I;
		}

		static IntPtr n_SetChannelCustomMesssageBorderColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetChannelCustomMesssageBorderColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setChannelCustomMesssageBorderColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setChannelCustomMesssageBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChannelCustomMesssageBorderColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetChannelCustomMesssageBorderColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetChannelCustomMesssageBorderColor (int p0)
		{
			if (id_setChannelCustomMesssageBorderColor_I == IntPtr.Zero)
				id_setChannelCustomMesssageBorderColor_I = JNIEnv.GetMethodID (class_ref, "setChannelCustomMesssageBorderColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setChannelCustomMesssageBorderColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannelCustomMesssageBorderColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setChannelCustomMesssageTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetChannelCustomMesssageTextColor_IHandler ()
		{
			if (cb_setChannelCustomMesssageTextColor_I == null)
				cb_setChannelCustomMesssageTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetChannelCustomMesssageTextColor_I);
			return cb_setChannelCustomMesssageTextColor_I;
		}

		static IntPtr n_SetChannelCustomMesssageTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetChannelCustomMesssageTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setChannelCustomMesssageTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setChannelCustomMesssageTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChannelCustomMesssageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetChannelCustomMesssageTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetChannelCustomMesssageTextColor (int p0)
		{
			if (id_setChannelCustomMesssageTextColor_I == IntPtr.Zero)
				id_setChannelCustomMesssageTextColor_I = JNIEnv.GetMethodID (class_ref, "setChannelCustomMesssageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setChannelCustomMesssageTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannelCustomMesssageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setChatBackgroundColorOrDrawableResource_I;
#pragma warning disable 0169
		static Delegate GetSetChatBackgroundColorOrDrawableResource_IHandler ()
		{
			if (cb_setChatBackgroundColorOrDrawableResource_I == null)
				cb_setChatBackgroundColorOrDrawableResource_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetChatBackgroundColorOrDrawableResource_I);
			return cb_setChatBackgroundColorOrDrawableResource_I;
		}

		static IntPtr n_SetChatBackgroundColorOrDrawableResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetChatBackgroundColorOrDrawableResource (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setChatBackgroundColorOrDrawableResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setChatBackgroundColorOrDrawableResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChatBackgroundColorOrDrawableResource", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetChatBackgroundColorOrDrawableResource_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetChatBackgroundColorOrDrawableResource (int p0)
		{
			if (id_setChatBackgroundColorOrDrawableResource_I == IntPtr.Zero)
				id_setChatBackgroundColorOrDrawableResource_I = JNIEnv.GetMethodID (class_ref, "setChatBackgroundColorOrDrawableResource", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setChatBackgroundColorOrDrawableResource_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChatBackgroundColorOrDrawableResource", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setColor_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetColor_Ljava_lang_String_IHandler ()
		{
			if (cb_setColor_Ljava_lang_String_I == null)
				cb_setColor_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SetColor_Ljava_lang_String_I);
			return cb_setColor_Ljava_lang_String_I;
		}

		static IntPtr n_SetColor_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetColor (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setColor_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setColor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setColor", "(Ljava/lang/String;I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetColor_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetColor (string p0, int p1)
		{
			if (id_setColor_Ljava_lang_String_I == IntPtr.Zero)
				id_setColor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setColor", "(Ljava/lang/String;I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setColor_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(Ljava/lang/String;I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCompressedImageSizeInMB_I;
#pragma warning disable 0169
		static Delegate GetSetCompressedImageSizeInMB_IHandler ()
		{
			if (cb_setCompressedImageSizeInMB_I == null)
				cb_setCompressedImageSizeInMB_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetCompressedImageSizeInMB_I);
			return cb_setCompressedImageSizeInMB_I;
		}

		static IntPtr n_SetCompressedImageSizeInMB_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCompressedImageSizeInMB (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setCompressedImageSizeInMB_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setCompressedImageSizeInMB' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCompressedImageSizeInMB", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetCompressedImageSizeInMB_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetCompressedImageSizeInMB (int p0)
		{
			if (id_setCompressedImageSizeInMB_I == IntPtr.Zero)
				id_setCompressedImageSizeInMB_I = JNIEnv.GetMethodID (class_ref, "setCompressedImageSizeInMB", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCompressedImageSizeInMB_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCompressedImageSizeInMB", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setConversationDateTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetConversationDateTextColor_IHandler ()
		{
			if (cb_setConversationDateTextColor_I == null)
				cb_setConversationDateTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetConversationDateTextColor_I);
			return cb_setConversationDateTextColor_I;
		}

		static IntPtr n_SetConversationDateTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetConversationDateTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setConversationDateTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setConversationDateTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConversationDateTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetConversationDateTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetConversationDateTextColor (int p0)
		{
			if (id_setConversationDateTextColor_I == IntPtr.Zero)
				id_setConversationDateTextColor_I = JNIEnv.GetMethodID (class_ref, "setConversationDateTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setConversationDateTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationDateTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setConversationDayTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetConversationDayTextColor_IHandler ()
		{
			if (cb_setConversationDayTextColor_I == null)
				cb_setConversationDayTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetConversationDayTextColor_I);
			return cb_setConversationDayTextColor_I;
		}

		static IntPtr n_SetConversationDayTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetConversationDayTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setConversationDayTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setConversationDayTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setConversationDayTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetConversationDayTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetConversationDayTextColor (int p0)
		{
			if (id_setConversationDayTextColor_I == IntPtr.Zero)
				id_setConversationDayTextColor_I = JNIEnv.GetMethodID (class_ref, "setConversationDayTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setConversationDayTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationDayTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEditTextBackgroundColorOrDrawableResource_I;
#pragma warning disable 0169
		static Delegate GetSetEditTextBackgroundColorOrDrawableResource_IHandler ()
		{
			if (cb_setEditTextBackgroundColorOrDrawableResource_I == null)
				cb_setEditTextBackgroundColorOrDrawableResource_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetEditTextBackgroundColorOrDrawableResource_I);
			return cb_setEditTextBackgroundColorOrDrawableResource_I;
		}

		static IntPtr n_SetEditTextBackgroundColorOrDrawableResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEditTextBackgroundColorOrDrawableResource (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setEditTextBackgroundColorOrDrawableResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setEditTextBackgroundColorOrDrawableResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setEditTextBackgroundColorOrDrawableResource", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetEditTextBackgroundColorOrDrawableResource_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetEditTextBackgroundColorOrDrawableResource (int p0)
		{
			if (id_setEditTextBackgroundColorOrDrawableResource_I == IntPtr.Zero)
				id_setEditTextBackgroundColorOrDrawableResource_I = JNIEnv.GetMethodID (class_ref, "setEditTextBackgroundColorOrDrawableResource", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEditTextBackgroundColorOrDrawableResource_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEditTextBackgroundColorOrDrawableResource", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEditTextLayoutBackgroundColorOrDrawableResource_I;
#pragma warning disable 0169
		static Delegate GetSetEditTextLayoutBackgroundColorOrDrawableResource_IHandler ()
		{
			if (cb_setEditTextLayoutBackgroundColorOrDrawableResource_I == null)
				cb_setEditTextLayoutBackgroundColorOrDrawableResource_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetEditTextLayoutBackgroundColorOrDrawableResource_I);
			return cb_setEditTextLayoutBackgroundColorOrDrawableResource_I;
		}

		static IntPtr n_SetEditTextLayoutBackgroundColorOrDrawableResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetEditTextLayoutBackgroundColorOrDrawableResource (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setEditTextLayoutBackgroundColorOrDrawableResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setEditTextLayoutBackgroundColorOrDrawableResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setEditTextLayoutBackgroundColorOrDrawableResource", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetEditTextLayoutBackgroundColorOrDrawableResource_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetEditTextLayoutBackgroundColorOrDrawableResource (int p0)
		{
			if (id_setEditTextLayoutBackgroundColorOrDrawableResource_I == IntPtr.Zero)
				id_setEditTextLayoutBackgroundColorOrDrawableResource_I = JNIEnv.GetMethodID (class_ref, "setEditTextLayoutBackgroundColorOrDrawableResource", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEditTextLayoutBackgroundColorOrDrawableResource_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEditTextLayoutBackgroundColorOrDrawableResource", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHideGroupAddButton_Z;
#pragma warning disable 0169
		static Delegate GetSetHideGroupAddButton_ZHandler ()
		{
			if (cb_setHideGroupAddButton_Z == null)
				cb_setHideGroupAddButton_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetHideGroupAddButton_Z);
			return cb_setHideGroupAddButton_Z;
		}

		static IntPtr n_SetHideGroupAddButton_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHideGroupAddButton (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setHideGroupAddButton_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setHideGroupAddButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHideGroupAddButton", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetHideGroupAddButton_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetHideGroupAddButton (bool p0)
		{
			if (id_setHideGroupAddButton_Z == IntPtr.Zero)
				id_setHideGroupAddButton_Z = JNIEnv.GetMethodID (class_ref, "setHideGroupAddButton", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHideGroupAddButton_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHideGroupAddButton", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHideGroupExitButton_Z;
#pragma warning disable 0169
		static Delegate GetSetHideGroupExitButton_ZHandler ()
		{
			if (cb_setHideGroupExitButton_Z == null)
				cb_setHideGroupExitButton_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetHideGroupExitButton_Z);
			return cb_setHideGroupExitButton_Z;
		}

		static IntPtr n_SetHideGroupExitButton_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHideGroupExitButton (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setHideGroupExitButton_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setHideGroupExitButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHideGroupExitButton", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetHideGroupExitButton_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetHideGroupExitButton (bool p0)
		{
			if (id_setHideGroupExitButton_Z == IntPtr.Zero)
				id_setHideGroupExitButton_Z = JNIEnv.GetMethodID (class_ref, "setHideGroupExitButton", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHideGroupExitButton_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHideGroupExitButton", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHideGroupNameEditButton_Z;
#pragma warning disable 0169
		static Delegate GetSetHideGroupNameEditButton_ZHandler ()
		{
			if (cb_setHideGroupNameEditButton_Z == null)
				cb_setHideGroupNameEditButton_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetHideGroupNameEditButton_Z);
			return cb_setHideGroupNameEditButton_Z;
		}

		static IntPtr n_SetHideGroupNameEditButton_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHideGroupNameEditButton (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setHideGroupNameEditButton_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setHideGroupNameEditButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHideGroupNameEditButton", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetHideGroupNameEditButton_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetHideGroupNameEditButton (bool p0)
		{
			if (id_setHideGroupNameEditButton_Z == IntPtr.Zero)
				id_setHideGroupNameEditButton_Z = JNIEnv.GetMethodID (class_ref, "setHideGroupNameEditButton", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHideGroupNameEditButton_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHideGroupNameEditButton", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHideGroupRemoveMemberOption_Z;
#pragma warning disable 0169
		static Delegate GetSetHideGroupRemoveMemberOption_ZHandler ()
		{
			if (cb_setHideGroupRemoveMemberOption_Z == null)
				cb_setHideGroupRemoveMemberOption_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetHideGroupRemoveMemberOption_Z);
			return cb_setHideGroupRemoveMemberOption_Z;
		}

		static IntPtr n_SetHideGroupRemoveMemberOption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHideGroupRemoveMemberOption (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setHideGroupRemoveMemberOption_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setHideGroupRemoveMemberOption' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHideGroupRemoveMemberOption", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetHideGroupRemoveMemberOption_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetHideGroupRemoveMemberOption (bool p0)
		{
			if (id_setHideGroupRemoveMemberOption_Z == IntPtr.Zero)
				id_setHideGroupRemoveMemberOption_Z = JNIEnv.GetMethodID (class_ref, "setHideGroupRemoveMemberOption", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHideGroupRemoveMemberOption_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHideGroupRemoveMemberOption", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setLocationSharingViaMap_Z;
#pragma warning disable 0169
		static Delegate GetSetLocationSharingViaMap_ZHandler ()
		{
			if (cb_setLocationSharingViaMap_Z == null)
				cb_setLocationSharingViaMap_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetLocationSharingViaMap_Z);
			return cb_setLocationSharingViaMap_Z;
		}

		static IntPtr n_SetLocationSharingViaMap_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetLocationSharingViaMap (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setLocationSharingViaMap_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setLocationSharingViaMap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLocationSharingViaMap", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetLocationSharingViaMap_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetLocationSharingViaMap (bool p0)
		{
			if (id_setLocationSharingViaMap_Z == IntPtr.Zero)
				id_setLocationSharingViaMap_Z = JNIEnv.GetMethodID (class_ref, "setLocationSharingViaMap", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLocationSharingViaMap_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocationSharingViaMap", "(Z)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMaxAttachmentAllowed_I;
#pragma warning disable 0169
		static Delegate GetSetMaxAttachmentAllowed_IHandler ()
		{
			if (cb_setMaxAttachmentAllowed_I == null)
				cb_setMaxAttachmentAllowed_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMaxAttachmentAllowed_I);
			return cb_setMaxAttachmentAllowed_I;
		}

		static IntPtr n_SetMaxAttachmentAllowed_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMaxAttachmentAllowed (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMaxAttachmentAllowed_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setMaxAttachmentAllowed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxAttachmentAllowed", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetMaxAttachmentAllowed_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetMaxAttachmentAllowed (int p0)
		{
			if (id_setMaxAttachmentAllowed_I == IntPtr.Zero)
				id_setMaxAttachmentAllowed_I = JNIEnv.GetMethodID (class_ref, "setMaxAttachmentAllowed", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMaxAttachmentAllowed_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxAttachmentAllowed", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMaxAttachmentSize_I;
#pragma warning disable 0169
		static Delegate GetSetMaxAttachmentSize_IHandler ()
		{
			if (cb_setMaxAttachmentSize_I == null)
				cb_setMaxAttachmentSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMaxAttachmentSize_I);
			return cb_setMaxAttachmentSize_I;
		}

		static IntPtr n_SetMaxAttachmentSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMaxAttachmentSize (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMaxAttachmentSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setMaxAttachmentSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxAttachmentSize", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetMaxAttachmentSize_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetMaxAttachmentSize (int p0)
		{
			if (id_setMaxAttachmentSize_I == IntPtr.Zero)
				id_setMaxAttachmentSize_I = JNIEnv.GetMethodID (class_ref, "setMaxAttachmentSize", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMaxAttachmentSize_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxAttachmentSize", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMessageEditTextHintColor_I;
#pragma warning disable 0169
		static Delegate GetSetMessageEditTextHintColor_IHandler ()
		{
			if (cb_setMessageEditTextHintColor_I == null)
				cb_setMessageEditTextHintColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMessageEditTextHintColor_I);
			return cb_setMessageEditTextHintColor_I;
		}

		static IntPtr n_SetMessageEditTextHintColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMessageEditTextHintColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMessageEditTextHintColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setMessageEditTextHintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMessageEditTextHintColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetMessageEditTextHintColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetMessageEditTextHintColor (int p0)
		{
			if (id_setMessageEditTextHintColor_I == IntPtr.Zero)
				id_setMessageEditTextHintColor_I = JNIEnv.GetMethodID (class_ref, "setMessageEditTextHintColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMessageEditTextHintColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageEditTextHintColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMessageEditTextTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetMessageEditTextTextColor_IHandler ()
		{
			if (cb_setMessageEditTextTextColor_I == null)
				cb_setMessageEditTextTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMessageEditTextTextColor_I);
			return cb_setMessageEditTextTextColor_I;
		}

		static IntPtr n_SetMessageEditTextTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMessageEditTextTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMessageEditTextTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setMessageEditTextTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMessageEditTextTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetMessageEditTextTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetMessageEditTextTextColor (int p0)
		{
			if (id_setMessageEditTextTextColor_I == IntPtr.Zero)
				id_setMessageEditTextTextColor_I = JNIEnv.GetMethodID (class_ref, "setMessageEditTextTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMessageEditTextTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageEditTextTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMessageTimeTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetMessageTimeTextColor_IHandler ()
		{
			if (cb_setMessageTimeTextColor_I == null)
				cb_setMessageTimeTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMessageTimeTextColor_I);
			return cb_setMessageTimeTextColor_I;
		}

		static IntPtr n_SetMessageTimeTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMessageTimeTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMessageTimeTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setMessageTimeTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMessageTimeTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetMessageTimeTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetMessageTimeTextColor (int p0)
		{
			if (id_setMessageTimeTextColor_I == IntPtr.Zero)
				id_setMessageTimeTextColor_I = JNIEnv.GetMethodID (class_ref, "setMessageTimeTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMessageTimeTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageTimeTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNoConversationLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNoConversationLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setNoConversationLabel_Ljava_lang_String_ == null)
				cb_setNoConversationLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNoConversationLabel_Ljava_lang_String_);
			return cb_setNoConversationLabel_Ljava_lang_String_;
		}

		static IntPtr n_SetNoConversationLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNoConversationLabel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setNoConversationLabel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setNoConversationLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNoConversationLabel", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetNoConversationLabel_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetNoConversationLabel (string p0)
		{
			if (id_setNoConversationLabel_Ljava_lang_String_ == IntPtr.Zero)
				id_setNoConversationLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNoConversationLabel", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNoConversationLabel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNoConversationLabel", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNoConversationLabelTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetNoConversationLabelTextColor_IHandler ()
		{
			if (cb_setNoConversationLabelTextColor_I == null)
				cb_setNoConversationLabelTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetNoConversationLabelTextColor_I);
			return cb_setNoConversationLabelTextColor_I;
		}

		static IntPtr n_SetNoConversationLabelTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNoConversationLabelTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setNoConversationLabelTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setNoConversationLabelTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNoConversationLabelTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetNoConversationLabelTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetNoConversationLabelTextColor (int p0)
		{
			if (id_setNoConversationLabelTextColor_I == IntPtr.Zero)
				id_setNoConversationLabelTextColor_I = JNIEnv.GetMethodID (class_ref, "setNoConversationLabelTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNoConversationLabelTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNoConversationLabelTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setReceivedContactMessageTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetReceivedContactMessageTextColor_IHandler ()
		{
			if (cb_setReceivedContactMessageTextColor_I == null)
				cb_setReceivedContactMessageTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetReceivedContactMessageTextColor_I);
			return cb_setReceivedContactMessageTextColor_I;
		}

		static IntPtr n_SetReceivedContactMessageTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetReceivedContactMessageTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setReceivedContactMessageTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setReceivedContactMessageTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReceivedContactMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetReceivedContactMessageTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetReceivedContactMessageTextColor (int p0)
		{
			if (id_setReceivedContactMessageTextColor_I == IntPtr.Zero)
				id_setReceivedContactMessageTextColor_I = JNIEnv.GetMethodID (class_ref, "setReceivedContactMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReceivedContactMessageTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceivedContactMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setReceivedMessageBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetReceivedMessageBackgroundColor_IHandler ()
		{
			if (cb_setReceivedMessageBackgroundColor_I == null)
				cb_setReceivedMessageBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetReceivedMessageBackgroundColor_I);
			return cb_setReceivedMessageBackgroundColor_I;
		}

		static IntPtr n_SetReceivedMessageBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetReceivedMessageBackgroundColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setReceivedMessageBackgroundColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setReceivedMessageBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReceivedMessageBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetReceivedMessageBackgroundColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetReceivedMessageBackgroundColor (int p0)
		{
			if (id_setReceivedMessageBackgroundColor_I == IntPtr.Zero)
				id_setReceivedMessageBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setReceivedMessageBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReceivedMessageBackgroundColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceivedMessageBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setReceivedMessageBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetReceivedMessageBorderColor_IHandler ()
		{
			if (cb_setReceivedMessageBorderColor_I == null)
				cb_setReceivedMessageBorderColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetReceivedMessageBorderColor_I);
			return cb_setReceivedMessageBorderColor_I;
		}

		static IntPtr n_SetReceivedMessageBorderColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetReceivedMessageBorderColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setReceivedMessageBorderColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setReceivedMessageBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReceivedMessageBorderColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetReceivedMessageBorderColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetReceivedMessageBorderColor (int p0)
		{
			if (id_setReceivedMessageBorderColor_I == IntPtr.Zero)
				id_setReceivedMessageBorderColor_I = JNIEnv.GetMethodID (class_ref, "setReceivedMessageBorderColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReceivedMessageBorderColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceivedMessageBorderColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setReceivedMessageLinkTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetReceivedMessageLinkTextColor_IHandler ()
		{
			if (cb_setReceivedMessageLinkTextColor_I == null)
				cb_setReceivedMessageLinkTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetReceivedMessageLinkTextColor_I);
			return cb_setReceivedMessageLinkTextColor_I;
		}

		static IntPtr n_SetReceivedMessageLinkTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetReceivedMessageLinkTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setReceivedMessageLinkTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setReceivedMessageLinkTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReceivedMessageLinkTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetReceivedMessageLinkTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetReceivedMessageLinkTextColor (int p0)
		{
			if (id_setReceivedMessageLinkTextColor_I == IntPtr.Zero)
				id_setReceivedMessageLinkTextColor_I = JNIEnv.GetMethodID (class_ref, "setReceivedMessageLinkTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReceivedMessageLinkTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceivedMessageLinkTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setReceivedMessageTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetReceivedMessageTextColor_IHandler ()
		{
			if (cb_setReceivedMessageTextColor_I == null)
				cb_setReceivedMessageTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetReceivedMessageTextColor_I);
			return cb_setReceivedMessageTextColor_I;
		}

		static IntPtr n_SetReceivedMessageTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetReceivedMessageTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setReceivedMessageTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setReceivedMessageTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReceivedMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetReceivedMessageTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetReceivedMessageTextColor (int p0)
		{
			if (id_setReceivedMessageTextColor_I == IntPtr.Zero)
				id_setReceivedMessageTextColor_I = JNIEnv.GetMethodID (class_ref, "setReceivedMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReceivedMessageTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceivedMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSearchNotFoundLabelForChats_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSearchNotFoundLabelForChats_Ljava_lang_String_Handler ()
		{
			if (cb_setSearchNotFoundLabelForChats_Ljava_lang_String_ == null)
				cb_setSearchNotFoundLabelForChats_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSearchNotFoundLabelForChats_Ljava_lang_String_);
			return cb_setSearchNotFoundLabelForChats_Ljava_lang_String_;
		}

		static IntPtr n_SetSearchNotFoundLabelForChats_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSearchNotFoundLabelForChats (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSearchNotFoundLabelForChats_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setSearchNotFoundLabelForChats' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSearchNotFoundLabelForChats", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetSearchNotFoundLabelForChats_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetSearchNotFoundLabelForChats (string p0)
		{
			if (id_setSearchNotFoundLabelForChats_Ljava_lang_String_ == IntPtr.Zero)
				id_setSearchNotFoundLabelForChats_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSearchNotFoundLabelForChats", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSearchNotFoundLabelForChats_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSearchNotFoundLabelForChats", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSendButtonBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetSendButtonBackgroundColor_IHandler ()
		{
			if (cb_setSendButtonBackgroundColor_I == null)
				cb_setSendButtonBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSendButtonBackgroundColor_I);
			return cb_setSendButtonBackgroundColor_I;
		}

		static IntPtr n_SetSendButtonBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSendButtonBackgroundColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setSendButtonBackgroundColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setSendButtonBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSendButtonBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetSendButtonBackgroundColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetSendButtonBackgroundColor (int p0)
		{
			if (id_setSendButtonBackgroundColor_I == IntPtr.Zero)
				id_setSendButtonBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setSendButtonBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSendButtonBackgroundColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSendButtonBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSentContactMessageTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetSentContactMessageTextColor_IHandler ()
		{
			if (cb_setSentContactMessageTextColor_I == null)
				cb_setSentContactMessageTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSentContactMessageTextColor_I);
			return cb_setSentContactMessageTextColor_I;
		}

		static IntPtr n_SetSentContactMessageTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSentContactMessageTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setSentContactMessageTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setSentContactMessageTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSentContactMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetSentContactMessageTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetSentContactMessageTextColor (int p0)
		{
			if (id_setSentContactMessageTextColor_I == IntPtr.Zero)
				id_setSentContactMessageTextColor_I = JNIEnv.GetMethodID (class_ref, "setSentContactMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSentContactMessageTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentContactMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSentMessageBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetSentMessageBackgroundColor_IHandler ()
		{
			if (cb_setSentMessageBackgroundColor_I == null)
				cb_setSentMessageBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSentMessageBackgroundColor_I);
			return cb_setSentMessageBackgroundColor_I;
		}

		static IntPtr n_SetSentMessageBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSentMessageBackgroundColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setSentMessageBackgroundColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setSentMessageBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSentMessageBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetSentMessageBackgroundColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetSentMessageBackgroundColor (int p0)
		{
			if (id_setSentMessageBackgroundColor_I == IntPtr.Zero)
				id_setSentMessageBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setSentMessageBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSentMessageBackgroundColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentMessageBackgroundColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSentMessageBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetSentMessageBorderColor_IHandler ()
		{
			if (cb_setSentMessageBorderColor_I == null)
				cb_setSentMessageBorderColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSentMessageBorderColor_I);
			return cb_setSentMessageBorderColor_I;
		}

		static IntPtr n_SetSentMessageBorderColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSentMessageBorderColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setSentMessageBorderColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setSentMessageBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSentMessageBorderColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetSentMessageBorderColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetSentMessageBorderColor (int p0)
		{
			if (id_setSentMessageBorderColor_I == IntPtr.Zero)
				id_setSentMessageBorderColor_I = JNIEnv.GetMethodID (class_ref, "setSentMessageBorderColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSentMessageBorderColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentMessageBorderColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSentMessageLinkTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetSentMessageLinkTextColor_IHandler ()
		{
			if (cb_setSentMessageLinkTextColor_I == null)
				cb_setSentMessageLinkTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSentMessageLinkTextColor_I);
			return cb_setSentMessageLinkTextColor_I;
		}

		static IntPtr n_SetSentMessageLinkTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSentMessageLinkTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setSentMessageLinkTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setSentMessageLinkTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSentMessageLinkTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetSentMessageLinkTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetSentMessageLinkTextColor (int p0)
		{
			if (id_setSentMessageLinkTextColor_I == IntPtr.Zero)
				id_setSentMessageLinkTextColor_I = JNIEnv.GetMethodID (class_ref, "setSentMessageLinkTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSentMessageLinkTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentMessageLinkTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSentMessageTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetSentMessageTextColor_IHandler ()
		{
			if (cb_setSentMessageTextColor_I == null)
				cb_setSentMessageTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSentMessageTextColor_I);
			return cb_setSentMessageTextColor_I;
		}

		static IntPtr n_SetSentMessageTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSentMessageTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setSentMessageTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setSentMessageTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSentMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetSentMessageTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetSentMessageTextColor (int p0)
		{
			if (id_setSentMessageTextColor_I == IntPtr.Zero)
				id_setSentMessageTextColor_I = JNIEnv.GetMethodID (class_ref, "setSentMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSentMessageTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentMessageTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTextForAudioPermissionNotFound_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTextForAudioPermissionNotFound_Ljava_lang_String_Handler ()
		{
			if (cb_setTextForAudioPermissionNotFound_Ljava_lang_String_ == null)
				cb_setTextForAudioPermissionNotFound_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTextForAudioPermissionNotFound_Ljava_lang_String_);
			return cb_setTextForAudioPermissionNotFound_Ljava_lang_String_;
		}

		static IntPtr n_SetTextForAudioPermissionNotFound_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTextForAudioPermissionNotFound (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTextForAudioPermissionNotFound_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setTextForAudioPermissionNotFound' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTextForAudioPermissionNotFound", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetTextForAudioPermissionNotFound_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetTextForAudioPermissionNotFound (string p0)
		{
			if (id_setTextForAudioPermissionNotFound_Ljava_lang_String_ == IntPtr.Zero)
				id_setTextForAudioPermissionNotFound_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTextForAudioPermissionNotFound", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTextForAudioPermissionNotFound_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextForAudioPermissionNotFound", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTotalOnlineUserToFetch_I;
#pragma warning disable 0169
		static Delegate GetSetTotalOnlineUserToFetch_IHandler ()
		{
			if (cb_setTotalOnlineUserToFetch_I == null)
				cb_setTotalOnlineUserToFetch_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTotalOnlineUserToFetch_I);
			return cb_setTotalOnlineUserToFetch_I;
		}

		static IntPtr n_SetTotalOnlineUserToFetch_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTotalOnlineUserToFetch (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setTotalOnlineUserToFetch_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setTotalOnlineUserToFetch' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTotalOnlineUserToFetch", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetTotalOnlineUserToFetch_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetTotalOnlineUserToFetch (int p0)
		{
			if (id_setTotalOnlineUserToFetch_I == IntPtr.Zero)
				id_setTotalOnlineUserToFetch_I = JNIEnv.GetMethodID (class_ref, "setTotalOnlineUserToFetch", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTotalOnlineUserToFetch_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalOnlineUserToFetch", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTotalRegisteredUsersToFetch_I;
#pragma warning disable 0169
		static Delegate GetSetTotalRegisteredUsersToFetch_IHandler ()
		{
			if (cb_setTotalRegisteredUsersToFetch_I == null)
				cb_setTotalRegisteredUsersToFetch_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTotalRegisteredUsersToFetch_I);
			return cb_setTotalRegisteredUsersToFetch_I;
		}

		static IntPtr n_SetTotalRegisteredUsersToFetch_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTotalRegisteredUsersToFetch (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setTotalRegisteredUsersToFetch_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setTotalRegisteredUsersToFetch' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTotalRegisteredUsersToFetch", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetTotalRegisteredUsersToFetch_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetTotalRegisteredUsersToFetch (int p0)
		{
			if (id_setTotalRegisteredUsersToFetch_I == IntPtr.Zero)
				id_setTotalRegisteredUsersToFetch_I = JNIEnv.GetMethodID (class_ref, "setTotalRegisteredUsersToFetch", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTotalRegisteredUsersToFetch_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalRegisteredUsersToFetch", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTypingTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTypingTextColor_IHandler ()
		{
			if (cb_setTypingTextColor_I == null)
				cb_setTypingTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTypingTextColor_I);
			return cb_setTypingTextColor_I;
		}

		static IntPtr n_SetTypingTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTypingTextColor (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setTypingTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='setTypingTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTypingTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetSetTypingTextColor_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting SetTypingTextColor (int p0)
		{
			if (id_setTypingTextColor_I == IntPtr.Zero)
				id_setTypingTextColor_I = JNIEnv.GetMethodID (class_ref, "setTypingTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTypingTextColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTypingTextColor", "(I)Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showActionDialWithoutCalling;
#pragma warning disable 0169
		static Delegate GetShowActionDialWithoutCallingHandler ()
		{
			if (cb_showActionDialWithoutCalling == null)
				cb_showActionDialWithoutCalling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowActionDialWithoutCalling);
			return cb_showActionDialWithoutCalling;
		}

		static IntPtr n_ShowActionDialWithoutCalling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowActionDialWithoutCalling ());
		}
#pragma warning restore 0169

		static IntPtr id_showActionDialWithoutCalling;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showActionDialWithoutCalling' and count(parameter)=0]"
		[Register ("showActionDialWithoutCalling", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowActionDialWithoutCallingHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowActionDialWithoutCalling ()
		{
			if (id_showActionDialWithoutCalling == IntPtr.Zero)
				id_showActionDialWithoutCalling = JNIEnv.GetMethodID (class_ref, "showActionDialWithoutCalling", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showActionDialWithoutCalling), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showActionDialWithoutCalling", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showConversationContactImage;
#pragma warning disable 0169
		static Delegate GetShowConversationContactImageHandler ()
		{
			if (cb_showConversationContactImage == null)
				cb_showConversationContactImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowConversationContactImage);
			return cb_showConversationContactImage;
		}

		static IntPtr n_ShowConversationContactImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowConversationContactImage ());
		}
#pragma warning restore 0169

		static IntPtr id_showConversationContactImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showConversationContactImage' and count(parameter)=0]"
		[Register ("showConversationContactImage", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowConversationContactImageHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowConversationContactImage ()
		{
			if (id_showConversationContactImage == IntPtr.Zero)
				id_showConversationContactImage = JNIEnv.GetMethodID (class_ref, "showConversationContactImage", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showConversationContactImage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showConversationContactImage", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showInviteFriendsButton;
#pragma warning disable 0169
		static Delegate GetShowInviteFriendsButtonHandler ()
		{
			if (cb_showInviteFriendsButton == null)
				cb_showInviteFriendsButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowInviteFriendsButton);
			return cb_showInviteFriendsButton;
		}

		static IntPtr n_ShowInviteFriendsButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowInviteFriendsButton ());
		}
#pragma warning restore 0169

		static IntPtr id_showInviteFriendsButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showInviteFriendsButton' and count(parameter)=0]"
		[Register ("showInviteFriendsButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowInviteFriendsButtonHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowInviteFriendsButton ()
		{
			if (id_showInviteFriendsButton == IntPtr.Zero)
				id_showInviteFriendsButton = JNIEnv.GetMethodID (class_ref, "showInviteFriendsButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showInviteFriendsButton), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showInviteFriendsButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showOnlineStatusInMasterList;
#pragma warning disable 0169
		static Delegate GetShowOnlineStatusInMasterListHandler ()
		{
			if (cb_showOnlineStatusInMasterList == null)
				cb_showOnlineStatusInMasterList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowOnlineStatusInMasterList);
			return cb_showOnlineStatusInMasterList;
		}

		static IntPtr n_ShowOnlineStatusInMasterList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowOnlineStatusInMasterList ());
		}
#pragma warning restore 0169

		static IntPtr id_showOnlineStatusInMasterList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showOnlineStatusInMasterList' and count(parameter)=0]"
		[Register ("showOnlineStatusInMasterList", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowOnlineStatusInMasterListHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowOnlineStatusInMasterList ()
		{
			if (id_showOnlineStatusInMasterList == IntPtr.Zero)
				id_showOnlineStatusInMasterList = JNIEnv.GetMethodID (class_ref, "showOnlineStatusInMasterList", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showOnlineStatusInMasterList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showOnlineStatusInMasterList", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showPriceOption;
#pragma warning disable 0169
		static Delegate GetShowPriceOptionHandler ()
		{
			if (cb_showPriceOption == null)
				cb_showPriceOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowPriceOption);
			return cb_showPriceOption;
		}

		static IntPtr n_ShowPriceOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowPriceOption ());
		}
#pragma warning restore 0169

		static IntPtr id_showPriceOption;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showPriceOption' and count(parameter)=0]"
		[Register ("showPriceOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowPriceOptionHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowPriceOption ()
		{
			if (id_showPriceOption == IntPtr.Zero)
				id_showPriceOption = JNIEnv.GetMethodID (class_ref, "showPriceOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showPriceOption), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showPriceOption", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showProfileLogout;
#pragma warning disable 0169
		static Delegate GetShowProfileLogoutHandler ()
		{
			if (cb_showProfileLogout == null)
				cb_showProfileLogout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowProfileLogout);
			return cb_showProfileLogout;
		}

		static IntPtr n_ShowProfileLogout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowProfileLogout ());
		}
#pragma warning restore 0169

		static IntPtr id_showProfileLogout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showProfileLogout' and count(parameter)=0]"
		[Register ("showProfileLogout", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowProfileLogoutHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowProfileLogout ()
		{
			if (id_showProfileLogout == IntPtr.Zero)
				id_showProfileLogout = JNIEnv.GetMethodID (class_ref, "showProfileLogout", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showProfileLogout), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showProfileLogout", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showStartNewButton;
#pragma warning disable 0169
		static Delegate GetShowStartNewButtonHandler ()
		{
			if (cb_showStartNewButton == null)
				cb_showStartNewButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowStartNewButton);
			return cb_showStartNewButton;
		}

		static IntPtr n_ShowStartNewButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowStartNewButton ());
		}
#pragma warning restore 0169

		static IntPtr id_showStartNewButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showStartNewButton' and count(parameter)=0]"
		[Register ("showStartNewButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowStartNewButtonHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowStartNewButton ()
		{
			if (id_showStartNewButton == IntPtr.Zero)
				id_showStartNewButton = JNIEnv.GetMethodID (class_ref, "showStartNewButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showStartNewButton), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showStartNewButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showStartNewFloatingActionButton;
#pragma warning disable 0169
		static Delegate GetShowStartNewFloatingActionButtonHandler ()
		{
			if (cb_showStartNewFloatingActionButton == null)
				cb_showStartNewFloatingActionButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowStartNewFloatingActionButton);
			return cb_showStartNewFloatingActionButton;
		}

		static IntPtr n_ShowStartNewFloatingActionButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowStartNewFloatingActionButton ());
		}
#pragma warning restore 0169

		static IntPtr id_showStartNewFloatingActionButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showStartNewFloatingActionButton' and count(parameter)=0]"
		[Register ("showStartNewFloatingActionButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowStartNewFloatingActionButtonHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowStartNewFloatingActionButton ()
		{
			if (id_showStartNewFloatingActionButton == IntPtr.Zero)
				id_showStartNewFloatingActionButton = JNIEnv.GetMethodID (class_ref, "showStartNewFloatingActionButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showStartNewFloatingActionButton), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showStartNewFloatingActionButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showStartNewGroupButton;
#pragma warning disable 0169
		static Delegate GetShowStartNewGroupButtonHandler ()
		{
			if (cb_showStartNewGroupButton == null)
				cb_showStartNewGroupButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowStartNewGroupButton);
			return cb_showStartNewGroupButton;
		}

		static IntPtr n_ShowStartNewGroupButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowStartNewGroupButton ());
		}
#pragma warning restore 0169

		static IntPtr id_showStartNewGroupButton;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showStartNewGroupButton' and count(parameter)=0]"
		[Register ("showStartNewGroupButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowStartNewGroupButtonHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowStartNewGroupButton ()
		{
			if (id_showStartNewGroupButton == IntPtr.Zero)
				id_showStartNewGroupButton = JNIEnv.GetMethodID (class_ref, "showStartNewGroupButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showStartNewGroupButton), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showStartNewGroupButton", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showUserProfileFragment;
#pragma warning disable 0169
		static Delegate GetShowUserProfileFragmentHandler ()
		{
			if (cb_showUserProfileFragment == null)
				cb_showUserProfileFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShowUserProfileFragment);
			return cb_showUserProfileFragment;
		}

		static IntPtr n_ShowUserProfileFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowUserProfileFragment ());
		}
#pragma warning restore 0169

		static IntPtr id_showUserProfileFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='ApplozicSetting']/method[@name='showUserProfileFragment' and count(parameter)=0]"
		[Register ("showUserProfileFragment", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;", "GetShowUserProfileFragmentHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting ShowUserProfileFragment ()
		{
			if (id_showUserProfileFragment == IntPtr.Zero)
				id_showUserProfileFragment = JNIEnv.GetMethodID (class_ref, "showUserProfileFragment", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showUserProfileFragment), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.ApplozicSetting> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showUserProfileFragment", "()Lcom/applozic/mobicomkit/uiwidgets/ApplozicSetting;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
