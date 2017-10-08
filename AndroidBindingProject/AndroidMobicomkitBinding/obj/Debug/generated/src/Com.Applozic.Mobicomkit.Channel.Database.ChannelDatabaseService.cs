using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Channel.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/channel/database/ChannelDatabaseService", DoNotGenerateAcw=true)]
	public partial class ChannelDatabaseService : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/channel/database/ChannelDatabaseService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelDatabaseService); }
		}

		protected ChannelDatabaseService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllChannels;
#pragma warning disable 0169
		static Delegate GetGetAllChannelsHandler ()
		{
			if (cb_getAllChannels == null)
				cb_getAllChannels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllChannels);
			return cb_getAllChannels;
		}

		static IntPtr n_GetAllChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Channel>.ToLocalJniHandle (__this.AllChannels);
		}
#pragma warning restore 0169

		static IntPtr id_getAllChannels;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.Channel> AllChannels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getAllChannels' and count(parameter)=0]"
			[Register ("getAllChannels", "()Ljava/util/List;", "GetGetAllChannelsHandler")]
			get {
				if (id_getAllChannels == IntPtr.Zero)
					id_getAllChannels = JNIEnv.GetMethodID (class_ref, "getAllChannels", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Channel>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllChannels), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Channel>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllChannels", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addChannel_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetAddChannel_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_addChannel_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_addChannel_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddChannel_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_addChannel_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_AddChannel_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddChannel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addChannel_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='addChannel' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("addChannel", "(Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetAddChannel_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe void AddChannel (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
		{
			if (id_addChannel_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_addChannel_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "addChannel", "(Lcom/applozic/mobicommons/people/channel/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addChannel_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addChannel", "(Lcom/applozic/mobicommons/people/channel/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_;
#pragma warning disable 0169
		static Delegate GetAddChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_Handler ()
		{
			if (cb_addChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ == null)
				cb_addChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_);
			return cb_addChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_;
		}

		static void n_AddChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddChannelUserMapper (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='addChannelUserMapper' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.ChannelUserMapper']]"
		[Register ("addChannelUserMapper", "(Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;)V", "GetAddChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_Handler")]
		public virtual unsafe void AddChannelUserMapper (global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper p0)
		{
			if (id_addChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ == IntPtr.Zero)
				id_addChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ = JNIEnv.GetMethodID (class_ref, "addChannelUserMapper", "(Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addChannelUserMapper", "(Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteChannel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetDeleteChannel_Ljava_lang_Integer_Handler ()
		{
			if (cb_deleteChannel_Ljava_lang_Integer_ == null)
				cb_deleteChannel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DeleteChannel_Ljava_lang_Integer_);
			return cb_deleteChannel_Ljava_lang_Integer_;
		}

		static int n_DeleteChannel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteChannel (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteChannel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='deleteChannel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("deleteChannel", "(Ljava/lang/Integer;)I", "GetDeleteChannel_Ljava_lang_Integer_Handler")]
		public virtual unsafe int DeleteChannel (global::Java.Lang.Integer p0)
		{
			if (id_deleteChannel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_deleteChannel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "deleteChannel", "(Ljava/lang/Integer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteChannel_Ljava_lang_Integer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteChannel", "(Ljava/lang/Integer;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteChannelUserMappers_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetDeleteChannelUserMappers_Ljava_lang_Integer_Handler ()
		{
			if (cb_deleteChannelUserMappers_Ljava_lang_Integer_ == null)
				cb_deleteChannelUserMappers_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DeleteChannelUserMappers_Ljava_lang_Integer_);
			return cb_deleteChannelUserMappers_Ljava_lang_Integer_;
		}

		static int n_DeleteChannelUserMappers_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DeleteChannelUserMappers (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteChannelUserMappers_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='deleteChannelUserMappers' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("deleteChannelUserMappers", "(Ljava/lang/Integer;)I", "GetDeleteChannelUserMappers_Ljava_lang_Integer_Handler")]
		public virtual unsafe int DeleteChannelUserMappers (global::Java.Lang.Integer p0)
		{
			if (id_deleteChannelUserMappers_Ljava_lang_Integer_ == IntPtr.Zero)
				id_deleteChannelUserMappers_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "deleteChannelUserMappers", "(Ljava/lang/Integer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_deleteChannelUserMappers_Ljava_lang_Integer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteChannelUserMappers", "(Ljava/lang/Integer;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannel_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetGetChannel_Landroid_database_Cursor_Handler ()
		{
			if (cb_getChannel_Landroid_database_Cursor_ == null)
				cb_getChannel_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannel_Landroid_database_Cursor_);
			return cb_getChannel_Landroid_database_Cursor_;
		}

		static IntPtr n_GetChannel_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannel_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getChannel' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getChannel", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannel_Landroid_database_Cursor_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannel (global::Android.Database.ICursor p0)
		{
			if (id_getChannel_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getChannel_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "getChannel", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannel_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannel", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelByChannelKey_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetChannelByChannelKey_Ljava_lang_Integer_Handler ()
		{
			if (cb_getChannelByChannelKey_Ljava_lang_Integer_ == null)
				cb_getChannelByChannelKey_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelByChannelKey_Ljava_lang_Integer_);
			return cb_getChannelByChannelKey_Ljava_lang_Integer_;
		}

		static IntPtr n_GetChannelByChannelKey_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelByChannelKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelByChannelKey_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getChannelByChannelKey' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getChannelByChannelKey", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannelByChannelKey_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannelByChannelKey (global::Java.Lang.Integer p0)
		{
			if (id_getChannelByChannelKey_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getChannelByChannelKey_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getChannelByChannelKey", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelByChannelKey_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelByChannelKey", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelByClientGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChannelByClientGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_getChannelByClientGroupId_Ljava_lang_String_ == null)
				cb_getChannelByClientGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelByClientGroupId_Ljava_lang_String_);
			return cb_getChannelByClientGroupId_Ljava_lang_String_;
		}

		static IntPtr n_GetChannelByClientGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelByClientGroupId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelByClientGroupId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getChannelByClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getChannelByClientGroupId", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannelByClientGroupId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannelByClientGroupId (string p0)
		{
			if (id_getChannelByClientGroupId_Ljava_lang_String_ == IntPtr.Zero)
				id_getChannelByClientGroupId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getChannelByClientGroupId", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelByClientGroupId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelByClientGroupId", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getChannelList_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetGetChannelList_Landroid_database_Cursor_Handler ()
		{
			if (cb_getChannelList_Landroid_database_Cursor_ == null)
				cb_getChannelList_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelList_Landroid_database_Cursor_);
			return cb_getChannelList_Landroid_database_Cursor_;
		}

		static IntPtr n_GetChannelList_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Channel>.ToLocalJniHandle (__this.GetChannelList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelList_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getChannelList' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getChannelList", "(Landroid/database/Cursor;)Ljava/util/List;", "GetGetChannelList_Landroid_database_Cursor_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.Channel> GetChannelList (global::Android.Database.ICursor p0)
		{
			if (id_getChannelList_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getChannelList_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "getChannelList", "(Landroid/database/Cursor;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.Channel> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Channel>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelList_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Channel>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelList", "(Landroid/database/Cursor;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelMemberByName_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChannelMemberByName_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getChannelMemberByName_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getChannelMemberByName_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelMemberByName_Ljava_lang_String_Ljava_lang_String_);
			return cb_getChannelMemberByName_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetChannelMemberByName_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetChannelMemberByName (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelMemberByName_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getChannelMemberByName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getChannelMemberByName", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;", "GetGetChannelMemberByName_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string[] GetChannelMemberByName (string p0, string p1)
		{
			if (id_getChannelMemberByName_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getChannelMemberByName_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getChannelMemberByName", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelMemberByName_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					__ret = (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelMemberByName", "(Ljava/lang/String;Ljava/lang/String;)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getChannelUser_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getChannelUser' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getChannelUser", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper GetChannelUser (global::Android.Database.ICursor p0)
		{
			if (id_getChannelUser_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getChannelUser_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "getChannelUser", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChannelUser_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelUserList_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetChannelUserList_Ljava_lang_Integer_Handler ()
		{
			if (cb_getChannelUserList_Ljava_lang_Integer_ == null)
				cb_getChannelUserList_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelUserList_Ljava_lang_Integer_);
			return cb_getChannelUserList_Ljava_lang_Integer_;
		}

		static IntPtr n_GetChannelUserList_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper>.ToLocalJniHandle (__this.GetChannelUserList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelUserList_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getChannelUserList' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getChannelUserList", "(Ljava/lang/Integer;)Ljava/util/List;", "GetGetChannelUserList_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> GetChannelUserList (global::Java.Lang.Integer p0)
		{
			if (id_getChannelUserList_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getChannelUserList_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getChannelUserList", "(Ljava/lang/Integer;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelUserList_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelUserList", "(Ljava/lang/Integer;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getGroupOfTwoReceiverId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetGroupOfTwoReceiverId_Ljava_lang_Integer_Handler ()
		{
			if (cb_getGroupOfTwoReceiverId_Ljava_lang_Integer_ == null)
				cb_getGroupOfTwoReceiverId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupOfTwoReceiverId_Ljava_lang_Integer_);
			return cb_getGroupOfTwoReceiverId_Ljava_lang_Integer_;
		}

		static IntPtr n_GetGroupOfTwoReceiverId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetGroupOfTwoReceiverId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupOfTwoReceiverId_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getGroupOfTwoReceiverId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getGroupOfTwoReceiverId", "(Ljava/lang/Integer;)Ljava/lang/String;", "GetGetGroupOfTwoReceiverId_Ljava_lang_Integer_Handler")]
		public virtual unsafe string GetGroupOfTwoReceiverId (global::Java.Lang.Integer p0)
		{
			if (id_getGroupOfTwoReceiverId_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getGroupOfTwoReceiverId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getGroupOfTwoReceiverId", "(Ljava/lang/Integer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupOfTwoReceiverId_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupOfTwoReceiverId", "(Ljava/lang/Integer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/channel/database/ChannelDatabaseService;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/channel/database/ChannelDatabaseService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getListOfUsers_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getListOfUsers' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getListOfUsers", "(Landroid/database/Cursor;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> GetListOfUsers (global::Android.Database.ICursor p0)
		{
			if (id_getListOfUsers_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getListOfUsers_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "getListOfUsers", "(Landroid/database/Cursor;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getListOfUsers_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSearchCursorForGroupsLoader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSearchCursorForGroupsLoader_Ljava_lang_String_Handler ()
		{
			if (cb_getSearchCursorForGroupsLoader_Ljava_lang_String_ == null)
				cb_getSearchCursorForGroupsLoader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSearchCursorForGroupsLoader_Ljava_lang_String_);
			return cb_getSearchCursorForGroupsLoader_Ljava_lang_String_;
		}

		static IntPtr n_GetSearchCursorForGroupsLoader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSearchCursorForGroupsLoader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSearchCursorForGroupsLoader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='getSearchCursorForGroupsLoader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSearchCursorForGroupsLoader", "(Ljava/lang/String;)Landroid/support/v4/content/Loader;", "GetGetSearchCursorForGroupsLoader_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Support.V4.Content.Loader GetSearchCursorForGroupsLoader (string p0)
		{
			if (id_getSearchCursorForGroupsLoader_Ljava_lang_String_ == IntPtr.Zero)
				id_getSearchCursorForGroupsLoader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSearchCursorForGroupsLoader", "(Ljava/lang/String;)Landroid/support/v4/content/Loader;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Support.V4.Content.Loader __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.Content.Loader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSearchCursorForGroupsLoader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.Content.Loader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSearchCursorForGroupsLoader", "(Ljava/lang/String;)Landroid/support/v4/content/Loader;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isChannelPresent_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetIsChannelPresent_Ljava_lang_Integer_Handler ()
		{
			if (cb_isChannelPresent_Ljava_lang_Integer_ == null)
				cb_isChannelPresent_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsChannelPresent_Ljava_lang_Integer_);
			return cb_isChannelPresent_Ljava_lang_Integer_;
		}

		static bool n_IsChannelPresent_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsChannelPresent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isChannelPresent_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='isChannelPresent' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("isChannelPresent", "(Ljava/lang/Integer;)Z", "GetIsChannelPresent_Ljava_lang_Integer_Handler")]
		public virtual unsafe bool IsChannelPresent (global::Java.Lang.Integer p0)
		{
			if (id_isChannelPresent_Ljava_lang_Integer_ == IntPtr.Zero)
				id_isChannelPresent_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "isChannelPresent", "(Ljava/lang/Integer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChannelPresent_Ljava_lang_Integer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChannelPresent", "(Ljava/lang/Integer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_isChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_isChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_isChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static bool n_IsChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsChannelUserPresent (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='isChannelUserPresent' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("isChannelUserPresent", "(Ljava/lang/Integer;Ljava/lang/String;)Z", "GetIsChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsChannelUserPresent (global::Java.Lang.Integer p0, string p1)
		{
			if (id_isChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_isChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isChannelUserPresent", "(Ljava/lang/Integer;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChannelUserPresent_Ljava_lang_Integer_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChannelUserPresent", "(Ljava/lang/Integer;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_leaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_leaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_leaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LeaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_leaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static int n_LeaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeaveMemberFromChannel (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_leaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='leaveMemberFromChannel' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("leaveMemberFromChannel", "(Ljava/lang/Integer;Ljava/lang/String;)I", "GetLeaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe int LeaveMemberFromChannel (global::Java.Lang.Integer p0, string p1)
		{
			if (id_leaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_leaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "leaveMemberFromChannel", "(Ljava/lang/Integer;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_leaveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leaveMemberFromChannel", "(Ljava/lang/Integer;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LeaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_);
			return cb_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_LeaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.LeaveMemberFromChannel (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='leaveMemberFromChannel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("leaveMemberFromChannel", "(Ljava/lang/String;Ljava/lang/String;)I", "GetLeaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int LeaveMemberFromChannel (string p0, string p1)
		{
			if (id_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "leaveMemberFromChannel", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leaveMemberFromChannel", "(Ljava/lang/String;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_prepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_;
#pragma warning disable 0169
		static Delegate GetPrepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_Handler ()
		{
			if (cb_prepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ == null)
				cb_prepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_);
			return cb_prepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_;
		}

		static IntPtr n_PrepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareChannelUserMapperValues (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='prepareChannelUserMapperValues' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.ChannelUserMapper']]"
		[Register ("prepareChannelUserMapperValues", "(Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;)Landroid/content/ContentValues;", "GetPrepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_Handler")]
		public virtual unsafe global::Android.Content.ContentValues PrepareChannelUserMapperValues (global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper p0)
		{
			if (id_prepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ == IntPtr.Zero)
				id_prepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ = JNIEnv.GetMethodID (class_ref, "prepareChannelUserMapperValues", "(Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;)Landroid/content/ContentValues;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Content.ContentValues __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepareChannelUserMapperValues_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareChannelUserMapperValues", "(Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;)Landroid/content/ContentValues;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_prepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetPrepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_prepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_prepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_prepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static IntPtr n_PrepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareChannelValues (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='prepareChannelValues' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("prepareChannelValues", "(Lcom/applozic/mobicommons/people/channel/Channel;)Landroid/content/ContentValues;", "GetPrepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe global::Android.Content.ContentValues PrepareChannelValues (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
		{
			if (id_prepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_prepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "prepareChannelValues", "(Lcom/applozic/mobicommons/people/channel/Channel;)Landroid/content/ContentValues;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Content.ContentValues __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepareChannelValues_Lcom_applozic_mobicommons_people_channel_Channel_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareChannelValues", "(Lcom/applozic/mobicommons/people/channel/Channel;)Landroid/content/ContentValues;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_RemoveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static int n_RemoveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RemoveMemberFromChannel (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='removeMemberFromChannel' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMemberFromChannel", "(Ljava/lang/Integer;Ljava/lang/String;)I", "GetRemoveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe int RemoveMemberFromChannel (global::Java.Lang.Integer p0, string p1)
		{
			if (id_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMemberFromChannel", "(Ljava/lang/Integer;Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMemberFromChannel", "(Ljava/lang/Integer;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_RemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_RemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RemoveMemberFromChannel (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='removeMemberFromChannel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMemberFromChannel", "(Ljava/lang/String;Ljava/lang/String;)I", "GetRemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int RemoveMemberFromChannel (string p0, string p1)
		{
			if (id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMemberFromChannel", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMemberFromChannel", "(Ljava/lang/String;Ljava/lang/String;)I"), __args);
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
				cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_UpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_);
			return cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_;
		}

		static int n_UpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UpdateChannel (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='updateChannel' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.feed.GroupInfoUpdate']]"
		[Register ("updateChannel", "(Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)I", "GetUpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_Handler")]
		public virtual unsafe int UpdateChannel (global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate p0)
		{
			if (id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ == IntPtr.Zero)
				id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ = JNIEnv.GetMethodID (class_ref, "updateChannel", "(Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannel", "(Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetUpdateChannel_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateChannel_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_UpdateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateChannel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='updateChannel' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("updateChannel", "(Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetUpdateChannel_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe void UpdateChannel (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
		{
			if (id_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "updateChannel", "(Lcom/applozic/mobicommons/people/channel/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannel", "(Lcom/applozic/mobicommons/people/channel/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static void n_UpdateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateChannelLocalImageURI (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='updateChannelLocalImageURI' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateChannelLocalImageURI", "(Ljava/lang/Integer;Ljava/lang/String;)V", "GetUpdateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateChannelLocalImageURI (global::Java.Lang.Integer p0, string p1)
		{
			if (id_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateChannelLocalImageURI", "(Ljava/lang/Integer;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannelLocalImageURI", "(Ljava/lang/Integer;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_;
#pragma warning disable 0169
		static Delegate GetUpdateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_Handler ()
		{
			if (cb_updateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ == null)
				cb_updateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_);
			return cb_updateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_;
		}

		static void n_UpdateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateChannelUserMapper (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='updateChannelUserMapper' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.ChannelUserMapper']]"
		[Register ("updateChannelUserMapper", "(Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;)V", "GetUpdateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_Handler")]
		public virtual unsafe void UpdateChannelUserMapper (global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper p0)
		{
			if (id_updateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ == IntPtr.Zero)
				id_updateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_ = JNIEnv.GetMethodID (class_ref, "updateChannelUserMapper", "(Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateChannelUserMapper_Lcom_applozic_mobicommons_people_channel_ChannelUserMapper_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannelUserMapper", "(Lcom/applozic/mobicommons/people/channel/ChannelUserMapper;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetUpdateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_Handler ()
		{
			if (cb_updateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_ == null)
				cb_updateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_);
			return cb_updateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_;
		}

		static void n_UpdateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Database.ChannelDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNotificationAfterTime (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.database']/class[@name='ChannelDatabaseService']/method[@name='updateNotificationAfterTime' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Long']]"
		[Register ("updateNotificationAfterTime", "(Ljava/lang/Integer;Ljava/lang/Long;)V", "GetUpdateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_Handler")]
		public virtual unsafe void UpdateNotificationAfterTime (global::Java.Lang.Integer p0, global::Java.Lang.Long p1)
		{
			if (id_updateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_ == IntPtr.Zero)
				id_updateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "updateNotificationAfterTime", "(Ljava/lang/Integer;Ljava/lang/Long;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNotificationAfterTime_Ljava_lang_Integer_Ljava_lang_Long_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNotificationAfterTime", "(Ljava/lang/Integer;Ljava/lang/Long;)V"), __args);
			} finally {
			}
		}

	}
}
