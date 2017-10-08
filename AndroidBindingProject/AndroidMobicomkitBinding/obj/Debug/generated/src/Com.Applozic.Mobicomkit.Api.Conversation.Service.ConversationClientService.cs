using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/service/ConversationClientService", DoNotGenerateAcw=true)]
	public partial class ConversationClientService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/service/ConversationClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationClientService); }
		}

		protected ConversationClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getConversationCloseByTopicIdUrl;
#pragma warning disable 0169
		static Delegate GetGetConversationCloseByTopicIdUrlHandler ()
		{
			if (cb_getConversationCloseByTopicIdUrl == null)
				cb_getConversationCloseByTopicIdUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationCloseByTopicIdUrl);
			return cb_getConversationCloseByTopicIdUrl;
		}

		static IntPtr n_GetConversationCloseByTopicIdUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversationCloseByTopicIdUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationCloseByTopicIdUrl;
		public virtual unsafe string ConversationCloseByTopicIdUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']/method[@name='getConversationCloseByTopicIdUrl' and count(parameter)=0]"
			[Register ("getConversationCloseByTopicIdUrl", "()Ljava/lang/String;", "GetGetConversationCloseByTopicIdUrlHandler")]
			get {
				if (id_getConversationCloseByTopicIdUrl == IntPtr.Zero)
					id_getConversationCloseByTopicIdUrl = JNIEnv.GetMethodID (class_ref, "getConversationCloseByTopicIdUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationCloseByTopicIdUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationCloseByTopicIdUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConversationCloseUrl;
#pragma warning disable 0169
		static Delegate GetGetConversationCloseUrlHandler ()
		{
			if (cb_getConversationCloseUrl == null)
				cb_getConversationCloseUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationCloseUrl);
			return cb_getConversationCloseUrl;
		}

		static IntPtr n_GetConversationCloseUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversationCloseUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationCloseUrl;
		public virtual unsafe string ConversationCloseUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']/method[@name='getConversationCloseUrl' and count(parameter)=0]"
			[Register ("getConversationCloseUrl", "()Ljava/lang/String;", "GetGetConversationCloseUrlHandler")]
			get {
				if (id_getConversationCloseUrl == IntPtr.Zero)
					id_getConversationCloseUrl = JNIEnv.GetMethodID (class_ref, "getConversationCloseUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationCloseUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationCloseUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConversationUrl;
#pragma warning disable 0169
		static Delegate GetGetConversationUrlHandler ()
		{
			if (cb_getConversationUrl == null)
				cb_getConversationUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationUrl);
			return cb_getConversationUrl;
		}

		static IntPtr n_GetConversationUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversationUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationUrl;
		public virtual unsafe string ConversationUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']/method[@name='getConversationUrl' and count(parameter)=0]"
			[Register ("getConversationUrl", "()Ljava/lang/String;", "GetGetConversationUrlHandler")]
			get {
				if (id_getConversationUrl == IntPtr.Zero)
					id_getConversationUrl = JNIEnv.GetMethodID (class_ref, "getConversationUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCreateConversationUrl;
#pragma warning disable 0169
		static Delegate GetGetCreateConversationUrlHandler ()
		{
			if (cb_getCreateConversationUrl == null)
				cb_getCreateConversationUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreateConversationUrl);
			return cb_getCreateConversationUrl;
		}

		static IntPtr n_GetCreateConversationUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateConversationUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getCreateConversationUrl;
		public virtual unsafe string CreateConversationUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']/method[@name='getCreateConversationUrl' and count(parameter)=0]"
			[Register ("getCreateConversationUrl", "()Ljava/lang/String;", "GetGetCreateConversationUrlHandler")]
			get {
				if (id_getCreateConversationUrl == IntPtr.Zero)
					id_getCreateConversationUrl = JNIEnv.GetMethodID (class_ref, "getCreateConversationUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreateConversationUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreateConversationUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_closeConversation_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetCloseConversation_Ljava_lang_Integer_Handler ()
		{
			if (cb_closeConversation_Ljava_lang_Integer_ == null)
				cb_closeConversation_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CloseConversation_Ljava_lang_Integer_);
			return cb_closeConversation_Ljava_lang_Integer_;
		}

		static IntPtr n_CloseConversation_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.CloseConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_closeConversation_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']/method[@name='closeConversation' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("closeConversation", "(Ljava/lang/Integer;)Ljava/lang/String;", "GetCloseConversation_Ljava_lang_Integer_Handler")]
		public virtual unsafe string CloseConversation (global::Java.Lang.Integer p0)
		{
			if (id_closeConversation_Ljava_lang_Integer_ == IntPtr.Zero)
				id_closeConversation_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "closeConversation", "(Ljava/lang/Integer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_closeConversation_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeConversation", "(Ljava/lang/Integer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_closeConversationByTopicId_Ljava_util_Set_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCloseConversationByTopicId_Ljava_util_Set_Ljava_lang_String_Handler ()
		{
			if (cb_closeConversationByTopicId_Ljava_util_Set_Ljava_lang_String_ == null)
				cb_closeConversationByTopicId_Ljava_util_Set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CloseConversationByTopicId_Ljava_util_Set_Ljava_lang_String_);
			return cb_closeConversationByTopicId_Ljava_util_Set_Ljava_lang_String_;
		}

		static IntPtr n_CloseConversationByTopicId_Ljava_util_Set_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.CloseConversationByTopicId (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_closeConversationByTopicId_Ljava_util_Set_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']/method[@name='closeConversationByTopicId' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("closeConversationByTopicId", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;", "GetCloseConversationByTopicId_Ljava_util_Set_Ljava_lang_String_Handler")]
		public virtual unsafe string CloseConversationByTopicId (global::System.Collections.Generic.ICollection<string> p0, string p1)
		{
			if (id_closeConversationByTopicId_Ljava_util_Set_Ljava_lang_String_ == IntPtr.Zero)
				id_closeConversationByTopicId_Ljava_util_Set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "closeConversationByTopicId", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_closeConversationByTopicId_Ljava_util_Set_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeConversationByTopicId", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
#pragma warning disable 0169
		static Delegate GetCreateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_Handler ()
		{
			if (cb_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ == null)
				cb_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_);
			return cb_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
		}

		static IntPtr n_CreateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']/method[@name='createConversation' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation']]"
		[Register ("createConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Lcom/applozic/mobicomkit/feed/ChannelFeed;", "GetCreateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeed CreateConversation (global::Com.Applozic.Mobicommons.People.Channel.Conversation p0)
		{
			if (id_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ == IntPtr.Zero)
				id_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNIEnv.GetMethodID (class_ref, "createConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Lcom/applozic/mobicomkit/feed/ChannelFeed;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Lcom/applozic/mobicomkit/feed/ChannelFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getConversation_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetConversation_Ljava_lang_Integer_Handler ()
		{
			if (cb_getConversation_Ljava_lang_Integer_ == null)
				cb_getConversation_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversation_Ljava_lang_Integer_);
			return cb_getConversation_Ljava_lang_Integer_;
		}

		static IntPtr n_GetConversation_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversation_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']/method[@name='getConversation' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getConversation", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Conversation;", "GetGetConversation_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Conversation GetConversation (global::Java.Lang.Integer p0)
		{
			if (id_getConversation_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getConversation_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getConversation", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Conversation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Conversation __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversation_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversation", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Conversation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationClientService']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/conversation/service/ConversationClientService;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/conversation/service/ConversationClientService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationClientService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
