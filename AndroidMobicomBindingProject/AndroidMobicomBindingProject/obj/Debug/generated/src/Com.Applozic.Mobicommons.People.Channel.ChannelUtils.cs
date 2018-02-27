using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.People.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/people/channel/ChannelUtils", DoNotGenerateAcw=true)]
	public partial class ChannelUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/people/channel/ChannelUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelUtils); }
		}

		protected ChannelUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUtils']/constructor[@name='ChannelUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChannelUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChannelUtils)) {
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

		static IntPtr id_fetchGroup_Landroid_content_Context_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUtils']/method[@name='fetchGroup' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("fetchGroup", "(Landroid/content/Context;Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel FetchGroup (global::Android.Content.Context p0, global::Java.Lang.Integer p1)
		{
			if (id_fetchGroup_Landroid_content_Context_Ljava_lang_Integer_ == IntPtr.Zero)
				id_fetchGroup_Landroid_content_Context_Ljava_lang_Integer_ = JNIEnv.GetStaticMethodID (class_ref, "fetchGroup", "(Landroid/content/Context;Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fetchGroup_Landroid_content_Context_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fetchGroup_Landroid_content_Context_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUtils']/method[@name='fetchGroup' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.String']]"
		[Register ("fetchGroup", "(Landroid/content/Context;Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel FetchGroup (global::Android.Content.Context p0, global::Java.Lang.Integer p1, string p2)
		{
			if (id_fetchGroup_Landroid_content_Context_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_fetchGroup_Landroid_content_Context_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fetchGroup", "(Landroid/content/Context;Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fetchGroup_Landroid_content_Context_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getChannelTitleName_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUtils']/method[@name='getChannelTitleName' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[2][@type='java.lang.String']]"
		[Register ("getChannelTitleName", "(Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetChannelTitleName (global::Com.Applozic.Mobicommons.People.Channel.Channel p0, string p1)
		{
			if (id_getChannelTitleName_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_String_ == IntPtr.Zero)
				id_getChannelTitleName_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getChannelTitleName", "(Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChannelTitleName_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getWithUserId_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUtils']/method[@name='getWithUserId' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[2][@type='java.lang.String']]"
		[Register ("getWithUserId", "(Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetWithUserId (global::Com.Applozic.Mobicommons.People.Channel.Channel p0, string p1)
		{
			if (id_getWithUserId_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_String_ == IntPtr.Zero)
				id_getWithUserId_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getWithUserId", "(Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getWithUserId_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isAdminUserId_Ljava_lang_String_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUtils']/method[@name='isAdminUserId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("isAdminUserId", "(Ljava/lang/String;Lcom/applozic/mobicommons/people/channel/Channel;)Z", "")]
		public static unsafe bool IsAdminUserId (string p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1)
		{
			if (id_isAdminUserId_Ljava_lang_String_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_isAdminUserId_Ljava_lang_String_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetStaticMethodID (class_ref, "isAdminUserId", "(Ljava/lang/String;Lcom/applozic/mobicommons/people/channel/Channel;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAdminUserId_Ljava_lang_String_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
