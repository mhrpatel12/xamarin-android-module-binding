using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/Message", DoNotGenerateAcw=true)]
	public partial class Message : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/Message$ContentType", DoNotGenerateAcw=true)]
		public sealed partial class ContentType : global::Java.Lang.Enum {


			static IntPtr ATTACHMENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='ATTACHMENT']"
			[Register ("ATTACHMENT")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType Attachment {
				get {
					if (ATTACHMENT_jfieldId == IntPtr.Zero)
						ATTACHMENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATTACHMENT", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATTACHMENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUDIO_MSG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='AUDIO_MSG']"
			[Register ("AUDIO_MSG")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType AudioMsg {
				get {
					if (AUDIO_MSG_jfieldId == IntPtr.Zero)
						AUDIO_MSG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_MSG", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_MSG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CHANNEL_CUSTOM_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='CHANNEL_CUSTOM_MESSAGE']"
			[Register ("CHANNEL_CUSTOM_MESSAGE")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType ChannelCustomMessage {
				get {
					if (CHANNEL_CUSTOM_MESSAGE_jfieldId == IntPtr.Zero)
						CHANNEL_CUSTOM_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANNEL_CUSTOM_MESSAGE", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANNEL_CUSTOM_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONTACT_MSG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='CONTACT_MSG']"
			[Register ("CONTACT_MSG")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType ContactMsg {
				get {
					if (CONTACT_MSG_jfieldId == IntPtr.Zero)
						CONTACT_MSG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTACT_MSG", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTACT_MSG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CUSTOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='CUSTOM']"
			[Register ("CUSTOM")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType Custom {
				get {
					if (CUSTOM_jfieldId == IntPtr.Zero)
						CUSTOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUSTOM", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUSTOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HIDDEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='HIDDEN']"
			[Register ("HIDDEN")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType Hidden {
				get {
					if (HIDDEN_jfieldId == IntPtr.Zero)
						HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIDDEN", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIDDEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOCATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='LOCATION']"
			[Register ("LOCATION")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType Location {
				get {
					if (LOCATION_jfieldId == IntPtr.Zero)
						LOCATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCATION", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PRICE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='PRICE']"
			[Register ("PRICE")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType Price {
				get {
					if (PRICE_jfieldId == IntPtr.Zero)
						PRICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRICE", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRICE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXT_HTML_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='TEXT_HTML']"
			[Register ("TEXT_HTML")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType TextHtml {
				get {
					if (TEXT_HTML_jfieldId == IntPtr.Zero)
						TEXT_HTML_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_HTML", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_HTML_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXT_URL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='TEXT_URL']"
			[Register ("TEXT_URL")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType TextUrl {
				get {
					if (TEXT_URL_jfieldId == IntPtr.Zero)
						TEXT_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_URL", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_URL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_CALL_NOTIFICATION_MSG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='VIDEO_CALL_NOTIFICATION_MSG']"
			[Register ("VIDEO_CALL_NOTIFICATION_MSG")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType VideoCallNotificationMsg {
				get {
					if (VIDEO_CALL_NOTIFICATION_MSG_jfieldId == IntPtr.Zero)
						VIDEO_CALL_NOTIFICATION_MSG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_CALL_NOTIFICATION_MSG", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_CALL_NOTIFICATION_MSG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_CALL_STATUS_MSG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='VIDEO_CALL_STATUS_MSG']"
			[Register ("VIDEO_CALL_STATUS_MSG")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType VideoCallStatusMsg {
				get {
					if (VIDEO_CALL_STATUS_MSG_jfieldId == IntPtr.Zero)
						VIDEO_CALL_STATUS_MSG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_CALL_STATUS_MSG", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_CALL_STATUS_MSG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_MSG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/field[@name='VIDEO_MSG']"
			[Register ("VIDEO_MSG")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType VideoMsg {
				get {
					if (VIDEO_MSG_jfieldId == IntPtr.Zero)
						VIDEO_MSG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_MSG", "Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_MSG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/Message$ContentType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ContentType); }
			}

			internal ContentType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Short Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Short;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Short;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ContentType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$ContentType;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ContentType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.GroupMessageMetaData']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData", DoNotGenerateAcw=true)]
		public sealed partial class GroupMessageMetaData : global::Java.Lang.Enum {


			static IntPtr FALSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.GroupMessageMetaData']/field[@name='FALSE']"
			[Register ("FALSE")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData False {
				get {
					if (FALSE_jfieldId == IntPtr.Zero)
						FALSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FALSE", "Lcom/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FALSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HIDE_KEY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.GroupMessageMetaData']/field[@name='HIDE_KEY']"
			[Register ("HIDE_KEY")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData HideKey {
				get {
					if (HIDE_KEY_jfieldId == IntPtr.Zero)
						HIDE_KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIDE_KEY", "Lcom/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIDE_KEY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr KEY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.GroupMessageMetaData']/field[@name='KEY']"
			[Register ("KEY")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData Key {
				get {
					if (KEY_jfieldId == IntPtr.Zero)
						KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY", "Lcom/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRUE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.GroupMessageMetaData']/field[@name='TRUE']"
			[Register ("TRUE")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData True {
				get {
					if (TRUE_jfieldId == IntPtr.Zero)
						TRUE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRUE", "Lcom/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRUE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GroupMessageMetaData); }
			}

			internal GroupMessageMetaData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.GroupMessageMetaData']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.GroupMessageMetaData']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.GroupMessageMetaData']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$GroupMessageMetaData;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.GroupMessageMetaData));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/Message$MessageType", DoNotGenerateAcw=true)]
		public sealed partial class MessageType : global::Java.Lang.Enum {


			static IntPtr CALL_INCOMING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/field[@name='CALL_INCOMING']"
			[Register ("CALL_INCOMING")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType CallIncoming {
				get {
					if (CALL_INCOMING_jfieldId == IntPtr.Zero)
						CALL_INCOMING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CALL_INCOMING", "Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CALL_INCOMING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CALL_OUTGOING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/field[@name='CALL_OUTGOING']"
			[Register ("CALL_OUTGOING")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType CallOutgoing {
				get {
					if (CALL_OUTGOING_jfieldId == IntPtr.Zero)
						CALL_OUTGOING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CALL_OUTGOING", "Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CALL_OUTGOING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DATE_TEMP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/field[@name='DATE_TEMP']"
			[Register ("DATE_TEMP")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType DateTemp {
				get {
					if (DATE_TEMP_jfieldId == IntPtr.Zero)
						DATE_TEMP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATE_TEMP", "Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATE_TEMP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DRAFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/field[@name='DRAFT']"
			[Register ("DRAFT")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType Draft {
				get {
					if (DRAFT_jfieldId == IntPtr.Zero)
						DRAFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DRAFT", "Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DRAFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INBOX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/field[@name='INBOX']"
			[Register ("INBOX")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType Inbox {
				get {
					if (INBOX_jfieldId == IntPtr.Zero)
						INBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INBOX", "Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INBOX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MT_INBOX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/field[@name='MT_INBOX']"
			[Register ("MT_INBOX")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType MtInbox {
				get {
					if (MT_INBOX_jfieldId == IntPtr.Zero)
						MT_INBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MT_INBOX", "Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MT_INBOX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MT_OUTBOX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/field[@name='MT_OUTBOX']"
			[Register ("MT_OUTBOX")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType MtOutbox {
				get {
					if (MT_OUTBOX_jfieldId == IntPtr.Zero)
						MT_OUTBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MT_OUTBOX", "Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MT_OUTBOX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OUTBOX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/field[@name='OUTBOX']"
			[Register ("OUTBOX")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType Outbox {
				get {
					if (OUTBOX_jfieldId == IntPtr.Zero)
						OUTBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OUTBOX", "Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OUTBOX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OUTBOX_SENT_FROM_DEVICE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/field[@name='OUTBOX_SENT_FROM_DEVICE']"
			[Register ("OUTBOX_SENT_FROM_DEVICE")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType OutboxSentFromDevice {
				get {
					if (OUTBOX_SENT_FROM_DEVICE_jfieldId == IntPtr.Zero)
						OUTBOX_SENT_FROM_DEVICE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OUTBOX_SENT_FROM_DEVICE", "Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OUTBOX_SENT_FROM_DEVICE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/Message$MessageType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageType); }
			}

			internal MessageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Short Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Short;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Short;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MessageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MetaDataType']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/Message$MetaDataType", DoNotGenerateAcw=true)]
		public sealed partial class MetaDataType : global::Java.Lang.Enum {


			static IntPtr AL_REPLY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MetaDataType']/field[@name='AL_REPLY']"
			[Register ("AL_REPLY")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType AlReply {
				get {
					if (AL_REPLY_jfieldId == IntPtr.Zero)
						AL_REPLY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AL_REPLY", "Lcom/applozic/mobicomkit/api/conversation/Message$MetaDataType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AL_REPLY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ARCHIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MetaDataType']/field[@name='ARCHIVE']"
			[Register ("ARCHIVE")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType Archive {
				get {
					if (ARCHIVE_jfieldId == IntPtr.Zero)
						ARCHIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ARCHIVE", "Lcom/applozic/mobicomkit/api/conversation/Message$MetaDataType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ARCHIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HIDDEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MetaDataType']/field[@name='HIDDEN']"
			[Register ("HIDDEN")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType Hidden {
				get {
					if (HIDDEN_jfieldId == IntPtr.Zero)
						HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIDDEN", "Lcom/applozic/mobicomkit/api/conversation/Message$MetaDataType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIDDEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr KEY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MetaDataType']/field[@name='KEY']"
			[Register ("KEY")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType Key {
				get {
					if (KEY_jfieldId == IntPtr.Zero)
						KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEY", "Lcom/applozic/mobicomkit/api/conversation/Message$MetaDataType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PUSHNOTIFICATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MetaDataType']/field[@name='PUSHNOTIFICATION']"
			[Register ("PUSHNOTIFICATION")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType Pushnotification {
				get {
					if (PUSHNOTIFICATION_jfieldId == IntPtr.Zero)
						PUSHNOTIFICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUSHNOTIFICATION", "Lcom/applozic/mobicomkit/api/conversation/Message$MetaDataType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUSHNOTIFICATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/Message$MetaDataType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MetaDataType); }
			}

			internal MetaDataType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MetaDataType']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MetaDataType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$MetaDataType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$MetaDataType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.MetaDataType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$MetaDataType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$MetaDataType;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MetaDataType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ReplyMessage']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/Message$ReplyMessage", DoNotGenerateAcw=true)]
		public sealed partial class ReplyMessage : global::Java.Lang.Enum {


			static IntPtr HIDE_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ReplyMessage']/field[@name='HIDE_MESSAGE']"
			[Register ("HIDE_MESSAGE")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage HideMessage {
				get {
					if (HIDE_MESSAGE_jfieldId == IntPtr.Zero)
						HIDE_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIDE_MESSAGE", "Lcom/applozic/mobicomkit/api/conversation/Message$ReplyMessage;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIDE_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NON_HIDDEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ReplyMessage']/field[@name='NON_HIDDEN']"
			[Register ("NON_HIDDEN")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage NonHidden {
				get {
					if (NON_HIDDEN_jfieldId == IntPtr.Zero)
						NON_HIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NON_HIDDEN", "Lcom/applozic/mobicomkit/api/conversation/Message$ReplyMessage;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NON_HIDDEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REPLY_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ReplyMessage']/field[@name='REPLY_MESSAGE']"
			[Register ("REPLY_MESSAGE")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage ReplyMessage {
				get {
					if (REPLY_MESSAGE_jfieldId == IntPtr.Zero)
						REPLY_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPLY_MESSAGE", "Lcom/applozic/mobicomkit/api/conversation/Message$ReplyMessage;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPLY_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/Message$ReplyMessage", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ReplyMessage); }
			}

			internal ReplyMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Integer Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ReplyMessage']/method[@name='getValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ReplyMessage']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$ReplyMessage;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$ReplyMessage;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.ReplyMessage']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$ReplyMessage;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$ReplyMessage;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.ReplyMessage));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Source']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/Message$Source", DoNotGenerateAcw=true)]
		public sealed partial class Source : global::Java.Lang.Enum {


			static IntPtr API_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Source']/field[@name='API']"
			[Register ("API")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source Api {
				get {
					if (API_jfieldId == IntPtr.Zero)
						API_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "API", "Lcom/applozic/mobicomkit/api/conversation/Message$Source;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, API_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEVICE_NATIVE_APP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Source']/field[@name='DEVICE_NATIVE_APP']"
			[Register ("DEVICE_NATIVE_APP")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source DeviceNativeApp {
				get {
					if (DEVICE_NATIVE_APP_jfieldId == IntPtr.Zero)
						DEVICE_NATIVE_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_NATIVE_APP", "Lcom/applozic/mobicomkit/api/conversation/Message$Source;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_NATIVE_APP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MT_MOBILE_APP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Source']/field[@name='MT_MOBILE_APP']"
			[Register ("MT_MOBILE_APP")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source MtMobileApp {
				get {
					if (MT_MOBILE_APP_jfieldId == IntPtr.Zero)
						MT_MOBILE_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MT_MOBILE_APP", "Lcom/applozic/mobicomkit/api/conversation/Message$Source;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MT_MOBILE_APP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WEB_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Source']/field[@name='WEB']"
			[Register ("WEB")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source Web {
				get {
					if (WEB_jfieldId == IntPtr.Zero)
						WEB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB", "Lcom/applozic/mobicomkit/api/conversation/Message$Source;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEB_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/Message$Source", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Source); }
			}

			internal Source (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Short Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Source']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Short;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Short;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Source']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$Source;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$Source;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Source']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$Source;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$Source;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Source));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/Message$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr DELIVERED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']/field[@name='DELIVERED']"
			[Register ("DELIVERED")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status Delivered {
				get {
					if (DELIVERED_jfieldId == IntPtr.Zero)
						DELIVERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELIVERED", "Lcom/applozic/mobicomkit/api/conversation/Message$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELIVERED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DELIVERED_AND_READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']/field[@name='DELIVERED_AND_READ']"
			[Register ("DELIVERED_AND_READ")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status DeliveredAndRead {
				get {
					if (DELIVERED_AND_READ_jfieldId == IntPtr.Zero)
						DELIVERED_AND_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELIVERED_AND_READ", "Lcom/applozic/mobicomkit/api/conversation/Message$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELIVERED_AND_READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/applozic/mobicomkit/api/conversation/Message$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']/field[@name='READ']"
			[Register ("READ")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status Read {
				get {
					if (READ_jfieldId == IntPtr.Zero)
						READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ", "Lcom/applozic/mobicomkit/api/conversation/Message$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']/field[@name='SENT']"
			[Register ("SENT")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status Sent {
				get {
					if (SENT_jfieldId == IntPtr.Zero)
						SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SENT", "Lcom/applozic/mobicomkit/api/conversation/Message$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNREAD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']/field[@name='UNREAD']"
			[Register ("UNREAD")]
			public static global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status Unread {
				get {
					if (UNREAD_jfieldId == IntPtr.Zero)
						UNREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNREAD", "Lcom/applozic/mobicomkit/api/conversation/Message$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNREAD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/Message$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Short Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Short;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Short;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$Status;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$Status;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/conversation/Message$Status;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Conversation.Message.Status));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/Message", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Message); }
		}

		protected Message (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/constructor[@name='Message' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register (".ctor", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "")]
		public unsafe Message (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Message)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", __args);
					return;
				}

				if (id_ctor_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
					id_ctor_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_api_conversation_Message_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/constructor[@name='Message' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Message (string p0, string p1)
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
				if (((object) this).GetType () != typeof (Message)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/constructor[@name='Message' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Message ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Message)) {
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

		static Delegate cb_getApplicationId;
#pragma warning disable 0169
		static Delegate GetGetApplicationIdHandler ()
		{
			if (cb_getApplicationId == null)
				cb_getApplicationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationId);
			return cb_getApplicationId;
		}

		static IntPtr n_GetApplicationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationId);
		}
#pragma warning restore 0169

		static Delegate cb_setApplicationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationId_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationId_Ljava_lang_String_ == null)
				cb_setApplicationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationId_Ljava_lang_String_);
			return cb_setApplicationId_Ljava_lang_String_;
		}

		static void n_SetApplicationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplicationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationId;
		static IntPtr id_setApplicationId_Ljava_lang_String_;
		public virtual unsafe string ApplicationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getApplicationId' and count(parameter)=0]"
			[Register ("getApplicationId", "()Ljava/lang/String;", "GetGetApplicationIdHandler")]
			get {
				if (id_getApplicationId == IntPtr.Zero)
					id_getApplicationId = JNIEnv.GetMethodID (class_ref, "getApplicationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setApplicationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationId", "(Ljava/lang/String;)V", "GetSetApplicationId_Ljava_lang_String_Handler")]
			set {
				if (id_setApplicationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isAttDownloadInProgress;
#pragma warning disable 0169
		static Delegate GetIsAttDownloadInProgressHandler ()
		{
			if (cb_isAttDownloadInProgress == null)
				cb_isAttDownloadInProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAttDownloadInProgress);
			return cb_isAttDownloadInProgress;
		}

		static bool n_IsAttDownloadInProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AttDownloadInProgress;
		}
#pragma warning restore 0169

		static Delegate cb_setAttDownloadInProgress_Z;
#pragma warning disable 0169
		static Delegate GetSetAttDownloadInProgress_ZHandler ()
		{
			if (cb_setAttDownloadInProgress_Z == null)
				cb_setAttDownloadInProgress_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAttDownloadInProgress_Z);
			return cb_setAttDownloadInProgress_Z;
		}

		static void n_SetAttDownloadInProgress_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AttDownloadInProgress = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isAttDownloadInProgress;
		static IntPtr id_setAttDownloadInProgress_Z;
		public virtual unsafe bool AttDownloadInProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isAttDownloadInProgress' and count(parameter)=0]"
			[Register ("isAttDownloadInProgress", "()Z", "GetIsAttDownloadInProgressHandler")]
			get {
				if (id_isAttDownloadInProgress == IntPtr.Zero)
					id_isAttDownloadInProgress = JNIEnv.GetMethodID (class_ref, "isAttDownloadInProgress", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAttDownloadInProgress);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAttDownloadInProgress", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setAttDownloadInProgress' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAttDownloadInProgress", "(Z)V", "GetSetAttDownloadInProgress_ZHandler")]
			set {
				if (id_setAttDownloadInProgress_Z == IntPtr.Zero)
					id_setAttDownloadInProgress_Z = JNIEnv.GetMethodID (class_ref, "setAttDownloadInProgress", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttDownloadInProgress_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttDownloadInProgress", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Canceled;
		}
#pragma warning restore 0169

		static Delegate cb_setCanceled_Z;
#pragma warning disable 0169
		static Delegate GetSetCanceled_ZHandler ()
		{
			if (cb_setCanceled_Z == null)
				cb_setCanceled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCanceled_Z);
			return cb_setCanceled_Z;
		}

		static void n_SetCanceled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Canceled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCanceled;
		static IntPtr id_setCanceled_Z;
		public virtual unsafe bool Canceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				if (id_isCanceled == IntPtr.Zero)
					id_isCanceled = JNIEnv.GetMethodID (class_ref, "isCanceled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCanceled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCanceled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setCanceled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCanceled", "(Z)V", "GetSetCanceled_ZHandler")]
			set {
				if (id_setCanceled_Z == IntPtr.Zero)
					id_setCanceled_Z = JNIEnv.GetMethodID (class_ref, "setCanceled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCanceled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCanceled", "(Z)V"), __args);
				} finally {
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientGroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientGroupId;
		static IntPtr id_setClientGroupId_Ljava_lang_String_;
		public virtual unsafe string ClientGroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getClientGroupId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connected = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		static IntPtr id_setConnected_Z;
		public virtual unsafe bool Connected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isConnected' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setConnected' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getContactIds;
#pragma warning disable 0169
		static Delegate GetGetContactIdsHandler ()
		{
			if (cb_getContactIds == null)
				cb_getContactIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactIds);
			return cb_getContactIds;
		}

		static IntPtr n_GetContactIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContactIds);
		}
#pragma warning restore 0169

		static Delegate cb_setContactIds_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContactIds_Ljava_lang_String_Handler ()
		{
			if (cb_setContactIds_Ljava_lang_String_ == null)
				cb_setContactIds_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContactIds_Ljava_lang_String_);
			return cb_setContactIds_Ljava_lang_String_;
		}

		static void n_SetContactIds_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactIds = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactIds;
		static IntPtr id_setContactIds_Ljava_lang_String_;
		public virtual unsafe string ContactIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getContactIds' and count(parameter)=0]"
			[Register ("getContactIds", "()Ljava/lang/String;", "GetGetContactIdsHandler")]
			get {
				if (id_getContactIds == IntPtr.Zero)
					id_getContactIds = JNIEnv.GetMethodID (class_ref, "getContactIds", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactIds), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactIds", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setContactIds' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContactIds", "(Ljava/lang/String;)V", "GetSetContactIds_Ljava_lang_String_Handler")]
			set {
				if (id_setContactIds_Ljava_lang_String_ == IntPtr.Zero)
					id_setContactIds_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContactIds", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactIds_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactIds", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConversationId;
#pragma warning disable 0169
		static Delegate GetGetConversationIdHandler ()
		{
			if (cb_getConversationId == null)
				cb_getConversationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationId);
			return cb_getConversationId;
		}

		static IntPtr n_GetConversationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConversationId);
		}
#pragma warning restore 0169

		static Delegate cb_setConversationId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetConversationId_Ljava_lang_Integer_Handler ()
		{
			if (cb_setConversationId_Ljava_lang_Integer_ == null)
				cb_setConversationId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConversationId_Ljava_lang_Integer_);
			return cb_setConversationId_Ljava_lang_Integer_;
		}

		static void n_SetConversationId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConversationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationId;
		static IntPtr id_setConversationId_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer ConversationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getConversationId' and count(parameter)=0]"
			[Register ("getConversationId", "()Ljava/lang/Integer;", "GetGetConversationIdHandler")]
			get {
				if (id_getConversationId == IntPtr.Zero)
					id_getConversationId = JNIEnv.GetMethodID (class_ref, "getConversationId", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationId", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setConversationId", "(Ljava/lang/Integer;)V", "GetSetConversationId_Ljava_lang_Integer_Handler")]
			set {
				if (id_setConversationId_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setConversationId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setConversationId", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConversationId_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationId", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCreatedAtTime;
#pragma warning disable 0169
		static Delegate GetGetCreatedAtTimeHandler ()
		{
			if (cb_getCreatedAtTime == null)
				cb_getCreatedAtTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedAtTime);
			return cb_getCreatedAtTime;
		}

		static IntPtr n_GetCreatedAtTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreatedAtTime);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedAtTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetCreatedAtTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setCreatedAtTime_Ljava_lang_Long_ == null)
				cb_setCreatedAtTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedAtTime_Ljava_lang_Long_);
			return cb_setCreatedAtTime_Ljava_lang_Long_;
		}

		static void n_SetCreatedAtTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreatedAtTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedAtTime;
		static IntPtr id_setCreatedAtTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long CreatedAtTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getCreatedAtTime' and count(parameter)=0]"
			[Register ("getCreatedAtTime", "()Ljava/lang/Long;", "GetGetCreatedAtTimeHandler")]
			get {
				if (id_getCreatedAtTime == IntPtr.Zero)
					id_getCreatedAtTime = JNIEnv.GetMethodID (class_ref, "getCreatedAtTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreatedAtTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreatedAtTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setCreatedAtTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setCreatedAtTime", "(Ljava/lang/Long;)V", "GetSetCreatedAtTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setCreatedAtTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setCreatedAtTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setCreatedAtTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCreatedAtTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreatedAtTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentId;
#pragma warning disable 0169
		static Delegate GetGetCurrentIdHandler ()
		{
			if (cb_getCurrentId == null)
				cb_getCurrentId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentId);
			return cb_getCurrentId;
		}

		static IntPtr n_GetCurrentId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentId);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentId;
		public virtual unsafe string CurrentId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getCurrentId' and count(parameter)=0]"
			[Register ("getCurrentId", "()Ljava/lang/String;", "GetGetCurrentIdHandler")]
			get {
				if (id_getCurrentId == IntPtr.Zero)
					id_getCurrentId = JNIEnv.GetMethodID (class_ref, "getCurrentId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDelivered;
#pragma warning disable 0169
		static Delegate GetGetDeliveredHandler ()
		{
			if (cb_getDelivered == null)
				cb_getDelivered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDelivered);
			return cb_getDelivered;
		}

		static IntPtr n_GetDelivered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Delivered);
		}
#pragma warning restore 0169

		static Delegate cb_setDelivered_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetDelivered_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setDelivered_Ljava_lang_Boolean_ == null)
				cb_setDelivered_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDelivered_Ljava_lang_Boolean_);
			return cb_setDelivered_Ljava_lang_Boolean_;
		}

		static void n_SetDelivered_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Delivered = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDelivered;
		static IntPtr id_setDelivered_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean Delivered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getDelivered' and count(parameter)=0]"
			[Register ("getDelivered", "()Ljava/lang/Boolean;", "GetGetDeliveredHandler")]
			get {
				if (id_getDelivered == IntPtr.Zero)
					id_getDelivered = JNIEnv.GetMethodID (class_ref, "getDelivered", "()Ljava/lang/Boolean;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDelivered), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelivered", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setDelivered' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setDelivered", "(Ljava/lang/Boolean;)V", "GetSetDelivered_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setDelivered_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setDelivered_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setDelivered", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDelivered_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelivered", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceKeyString;
#pragma warning disable 0169
		static Delegate GetGetDeviceKeyStringHandler ()
		{
			if (cb_getDeviceKeyString == null)
				cb_getDeviceKeyString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceKeyString);
			return cb_getDeviceKeyString;
		}

		static IntPtr n_GetDeviceKeyString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceKeyString);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceKeyString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceKeyString_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceKeyString_Ljava_lang_String_ == null)
				cb_setDeviceKeyString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceKeyString_Ljava_lang_String_);
			return cb_setDeviceKeyString_Ljava_lang_String_;
		}

		static void n_SetDeviceKeyString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceKeyString = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceKeyString;
		static IntPtr id_setDeviceKeyString_Ljava_lang_String_;
		public virtual unsafe string DeviceKeyString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getDeviceKeyString' and count(parameter)=0]"
			[Register ("getDeviceKeyString", "()Ljava/lang/String;", "GetGetDeviceKeyStringHandler")]
			get {
				if (id_getDeviceKeyString == IntPtr.Zero)
					id_getDeviceKeyString = JNIEnv.GetMethodID (class_ref, "getDeviceKeyString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceKeyString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceKeyString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setDeviceKeyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceKeyString", "(Ljava/lang/String;)V", "GetSetDeviceKeyString_Ljava_lang_String_Handler")]
			set {
				if (id_setDeviceKeyString_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceKeyString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceKeyString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceKeyString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceKeyString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmailIds;
#pragma warning disable 0169
		static Delegate GetGetEmailIdsHandler ()
		{
			if (cb_getEmailIds == null)
				cb_getEmailIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmailIds);
			return cb_getEmailIds;
		}

		static IntPtr n_GetEmailIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmailIds);
		}
#pragma warning restore 0169

		static Delegate cb_setEmailIds_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmailIds_Ljava_lang_String_Handler ()
		{
			if (cb_setEmailIds_Ljava_lang_String_ == null)
				cb_setEmailIds_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmailIds_Ljava_lang_String_);
			return cb_setEmailIds_Ljava_lang_String_;
		}

		static void n_SetEmailIds_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmailIds = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmailIds;
		static IntPtr id_setEmailIds_Ljava_lang_String_;
		public virtual unsafe string EmailIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getEmailIds' and count(parameter)=0]"
			[Register ("getEmailIds", "()Ljava/lang/String;", "GetGetEmailIdsHandler")]
			get {
				if (id_getEmailIds == IntPtr.Zero)
					id_getEmailIds = JNIEnv.GetMethodID (class_ref, "getEmailIds", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmailIds), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmailIds", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setEmailIds' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmailIds", "(Ljava/lang/String;)V", "GetSetEmailIds_Ljava_lang_String_Handler")]
			set {
				if (id_setEmailIds_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmailIds_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmailIds", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmailIds_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailIds", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFileMetaKeyStrings;
#pragma warning disable 0169
		static Delegate GetGetFileMetaKeyStringsHandler ()
		{
			if (cb_getFileMetaKeyStrings == null)
				cb_getFileMetaKeyStrings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileMetaKeyStrings);
			return cb_getFileMetaKeyStrings;
		}

		static IntPtr n_GetFileMetaKeyStrings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileMetaKeyStrings);
		}
#pragma warning restore 0169

		static Delegate cb_setFileMetaKeyStrings_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFileMetaKeyStrings_Ljava_lang_String_Handler ()
		{
			if (cb_setFileMetaKeyStrings_Ljava_lang_String_ == null)
				cb_setFileMetaKeyStrings_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFileMetaKeyStrings_Ljava_lang_String_);
			return cb_setFileMetaKeyStrings_Ljava_lang_String_;
		}

		static void n_SetFileMetaKeyStrings_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FileMetaKeyStrings = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFileMetaKeyStrings;
		static IntPtr id_setFileMetaKeyStrings_Ljava_lang_String_;
		public virtual unsafe string FileMetaKeyStrings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getFileMetaKeyStrings' and count(parameter)=0]"
			[Register ("getFileMetaKeyStrings", "()Ljava/lang/String;", "GetGetFileMetaKeyStringsHandler")]
			get {
				if (id_getFileMetaKeyStrings == IntPtr.Zero)
					id_getFileMetaKeyStrings = JNIEnv.GetMethodID (class_ref, "getFileMetaKeyStrings", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileMetaKeyStrings), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileMetaKeyStrings", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setFileMetaKeyStrings' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFileMetaKeyStrings", "(Ljava/lang/String;)V", "GetSetFileMetaKeyStrings_Ljava_lang_String_Handler")]
			set {
				if (id_setFileMetaKeyStrings_Ljava_lang_String_ == IntPtr.Zero)
					id_setFileMetaKeyStrings_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFileMetaKeyStrings", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFileMetaKeyStrings_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFileMetaKeyStrings", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFileMetas;
#pragma warning disable 0169
		static Delegate GetGetFileMetasHandler ()
		{
			if (cb_getFileMetas == null)
				cb_getFileMetas = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileMetas);
			return cb_getFileMetas;
		}

		static IntPtr n_GetFileMetas (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileMetas);
		}
#pragma warning restore 0169

		static Delegate cb_setFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_;
#pragma warning disable 0169
		static Delegate GetSetFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_Handler ()
		{
			if (cb_setFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_ == null)
				cb_setFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_);
			return cb_setFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_;
		}

		static void n_SetFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileMeta p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileMeta> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FileMetas = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFileMetas;
		static IntPtr id_setFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Attachment.FileMeta FileMetas {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getFileMetas' and count(parameter)=0]"
			[Register ("getFileMetas", "()Lcom/applozic/mobicomkit/api/attachment/FileMeta;", "GetGetFileMetasHandler")]
			get {
				if (id_getFileMetas == IntPtr.Zero)
					id_getFileMetas = JNIEnv.GetMethodID (class_ref, "getFileMetas", "()Lcom/applozic/mobicomkit/api/attachment/FileMeta;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileMeta> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileMetas), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileMeta> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileMetas", "()Lcom/applozic/mobicomkit/api/attachment/FileMeta;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setFileMetas' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.attachment.FileMeta']]"
			[Register ("setFileMetas", "(Lcom/applozic/mobicomkit/api/attachment/FileMeta;)V", "GetSetFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_Handler")]
			set {
				if (id_setFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_ == IntPtr.Zero)
					id_setFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_ = JNIEnv.GetMethodID (class_ref, "setFileMetas", "(Lcom/applozic/mobicomkit/api/attachment/FileMeta;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFileMetas_Lcom_applozic_mobicomkit_api_attachment_FileMeta_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFileMetas", "(Lcom/applozic/mobicomkit/api/attachment/FileMeta;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFilePaths;
#pragma warning disable 0169
		static Delegate GetGetFilePathsHandler ()
		{
			if (cb_getFilePaths == null)
				cb_getFilePaths = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilePaths);
			return cb_getFilePaths;
		}

		static IntPtr n_GetFilePaths (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.FilePaths);
		}
#pragma warning restore 0169

		static Delegate cb_setFilePaths_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetFilePaths_Ljava_util_List_Handler ()
		{
			if (cb_setFilePaths_Ljava_util_List_ == null)
				cb_setFilePaths_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilePaths_Ljava_util_List_);
			return cb_setFilePaths_Ljava_util_List_;
		}

		static void n_SetFilePaths_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FilePaths = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFilePaths;
		static IntPtr id_setFilePaths_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> FilePaths {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getFilePaths' and count(parameter)=0]"
			[Register ("getFilePaths", "()Ljava/util/List;", "GetGetFilePathsHandler")]
			get {
				if (id_getFilePaths == IntPtr.Zero)
					id_getFilePaths = JNIEnv.GetMethodID (class_ref, "getFilePaths", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilePaths), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilePaths", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setFilePaths' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setFilePaths", "(Ljava/util/List;)V", "GetSetFilePaths_Ljava_util_List_Handler")]
			set {
				if (id_setFilePaths_Ljava_util_List_ == IntPtr.Zero)
					id_setFilePaths_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setFilePaths", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFilePaths_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilePaths", "(Ljava/util/List;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupId;
		static IntPtr id_setGroupId_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer GroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getGroupId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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

		static Delegate cb_hasAttachment;
#pragma warning disable 0169
		static Delegate GetHasAttachmentHandler ()
		{
			if (cb_hasAttachment == null)
				cb_hasAttachment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAttachment);
			return cb_hasAttachment;
		}

		static bool n_HasAttachment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAttachment;
		}
#pragma warning restore 0169

		static IntPtr id_hasAttachment;
		public virtual unsafe bool HasAttachment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='hasAttachment' and count(parameter)=0]"
			[Register ("hasAttachment", "()Z", "GetHasAttachmentHandler")]
			get {
				if (id_hasAttachment == IntPtr.Zero)
					id_hasAttachment = JNIEnv.GetMethodID (class_ref, "hasAttachment", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasAttachment);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasAttachment", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHidden;
#pragma warning disable 0169
		static Delegate GetIsHiddenHandler ()
		{
			if (cb_isHidden == null)
				cb_isHidden = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHidden);
			return cb_isHidden;
		}

		static bool n_IsHidden (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Hidden;
		}
#pragma warning restore 0169

		static Delegate cb_setHidden_Z;
#pragma warning disable 0169
		static Delegate GetSetHidden_ZHandler ()
		{
			if (cb_setHidden_Z == null)
				cb_setHidden_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHidden_Z);
			return cb_setHidden_Z;
		}

		static void n_SetHidden_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hidden = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isHidden;
		static IntPtr id_setHidden_Z;
		public virtual unsafe bool Hidden {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isHidden' and count(parameter)=0]"
			[Register ("isHidden", "()Z", "GetIsHiddenHandler")]
			get {
				if (id_isHidden == IntPtr.Zero)
					id_isHidden = JNIEnv.GetMethodID (class_ref, "isHidden", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHidden);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHidden", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setHidden' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHidden", "(Z)V", "GetSetHidden_ZHandler")]
			set {
				if (id_setHidden_Z == IntPtr.Zero)
					id_setHidden_Z = JNIEnv.GetMethodID (class_ref, "setHidden", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHidden_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHidden", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAttachmentDownloaded;
#pragma warning disable 0169
		static Delegate GetIsAttachmentDownloadedHandler ()
		{
			if (cb_isAttachmentDownloaded == null)
				cb_isAttachmentDownloaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAttachmentDownloaded);
			return cb_isAttachmentDownloaded;
		}

		static bool n_IsAttachmentDownloaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAttachmentDownloaded;
		}
#pragma warning restore 0169

		static IntPtr id_isAttachmentDownloaded;
		public virtual unsafe bool IsAttachmentDownloaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isAttachmentDownloaded' and count(parameter)=0]"
			[Register ("isAttachmentDownloaded", "()Z", "GetIsAttachmentDownloadedHandler")]
			get {
				if (id_isAttachmentDownloaded == IntPtr.Zero)
					id_isAttachmentDownloaded = JNIEnv.GetMethodID (class_ref, "isAttachmentDownloaded", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAttachmentDownloaded);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAttachmentDownloaded", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isAttachmentUploadInProgress;
#pragma warning disable 0169
		static Delegate GetIsAttachmentUploadInProgressHandler ()
		{
			if (cb_isAttachmentUploadInProgress == null)
				cb_isAttachmentUploadInProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAttachmentUploadInProgress);
			return cb_isAttachmentUploadInProgress;
		}

		static bool n_IsAttachmentUploadInProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAttachmentUploadInProgress;
		}
#pragma warning restore 0169

		static IntPtr id_isAttachmentUploadInProgress;
		public virtual unsafe bool IsAttachmentUploadInProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isAttachmentUploadInProgress' and count(parameter)=0]"
			[Register ("isAttachmentUploadInProgress", "()Z", "GetIsAttachmentUploadInProgressHandler")]
			get {
				if (id_isAttachmentUploadInProgress == IntPtr.Zero)
					id_isAttachmentUploadInProgress = JNIEnv.GetMethodID (class_ref, "isAttachmentUploadInProgress", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAttachmentUploadInProgress);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAttachmentUploadInProgress", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isCall;
#pragma warning disable 0169
		static Delegate GetIsCallHandler ()
		{
			if (cb_isCall == null)
				cb_isCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCall);
			return cb_isCall;
		}

		static bool n_IsCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCall;
		}
#pragma warning restore 0169

		static IntPtr id_isCall;
		public virtual unsafe bool IsCall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isCall' and count(parameter)=0]"
			[Register ("isCall", "()Z", "GetIsCallHandler")]
			get {
				if (id_isCall == IntPtr.Zero)
					id_isCall = JNIEnv.GetMethodID (class_ref, "isCall", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCall);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCall", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isChannelCustomMessage;
#pragma warning disable 0169
		static Delegate GetIsChannelCustomMessageHandler ()
		{
			if (cb_isChannelCustomMessage == null)
				cb_isChannelCustomMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChannelCustomMessage);
			return cb_isChannelCustomMessage;
		}

		static bool n_IsChannelCustomMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChannelCustomMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isChannelCustomMessage;
		public virtual unsafe bool IsChannelCustomMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isChannelCustomMessage' and count(parameter)=0]"
			[Register ("isChannelCustomMessage", "()Z", "GetIsChannelCustomMessageHandler")]
			get {
				if (id_isChannelCustomMessage == IntPtr.Zero)
					id_isChannelCustomMessage = JNIEnv.GetMethodID (class_ref, "isChannelCustomMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChannelCustomMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChannelCustomMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isConsideredForCount;
#pragma warning disable 0169
		static Delegate GetIsConsideredForCountHandler ()
		{
			if (cb_isConsideredForCount == null)
				cb_isConsideredForCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConsideredForCount);
			return cb_isConsideredForCount;
		}

		static bool n_IsConsideredForCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConsideredForCount;
		}
#pragma warning restore 0169

		static IntPtr id_isConsideredForCount;
		public virtual unsafe bool IsConsideredForCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isConsideredForCount' and count(parameter)=0]"
			[Register ("isConsideredForCount", "()Z", "GetIsConsideredForCountHandler")]
			get {
				if (id_isConsideredForCount == IntPtr.Zero)
					id_isConsideredForCount = JNIEnv.GetMethodID (class_ref, "isConsideredForCount", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConsideredForCount);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConsideredForCount", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isContactMessage;
#pragma warning disable 0169
		static Delegate GetIsContactMessageHandler ()
		{
			if (cb_isContactMessage == null)
				cb_isContactMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsContactMessage);
			return cb_isContactMessage;
		}

		static bool n_IsContactMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsContactMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isContactMessage;
		public virtual unsafe bool IsContactMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isContactMessage' and count(parameter)=0]"
			[Register ("isContactMessage", "()Z", "GetIsContactMessageHandler")]
			get {
				if (id_isContactMessage == IntPtr.Zero)
					id_isContactMessage = JNIEnv.GetMethodID (class_ref, "isContactMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isContactMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isContactMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isCustom;
#pragma warning disable 0169
		static Delegate GetIsCustomHandler ()
		{
			if (cb_isCustom == null)
				cb_isCustom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCustom);
			return cb_isCustom;
		}

		static bool n_IsCustom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCustom;
		}
#pragma warning restore 0169

		static IntPtr id_isCustom;
		public virtual unsafe bool IsCustom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isCustom' and count(parameter)=0]"
			[Register ("isCustom", "()Z", "GetIsCustomHandler")]
			get {
				if (id_isCustom == IntPtr.Zero)
					id_isCustom = JNIEnv.GetMethodID (class_ref, "isCustom", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCustom);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCustom", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDeliveredAndRead;
#pragma warning disable 0169
		static Delegate GetIsDeliveredAndReadHandler ()
		{
			if (cb_isDeliveredAndRead == null)
				cb_isDeliveredAndRead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeliveredAndRead);
			return cb_isDeliveredAndRead;
		}

		static bool n_IsDeliveredAndRead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeliveredAndRead;
		}
#pragma warning restore 0169

		static IntPtr id_isDeliveredAndRead;
		public virtual unsafe bool IsDeliveredAndRead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isDeliveredAndRead' and count(parameter)=0]"
			[Register ("isDeliveredAndRead", "()Z", "GetIsDeliveredAndReadHandler")]
			get {
				if (id_isDeliveredAndRead == IntPtr.Zero)
					id_isDeliveredAndRead = JNIEnv.GetMethodID (class_ref, "isDeliveredAndRead", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDeliveredAndRead);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeliveredAndRead", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDummyEmptyMessage;
#pragma warning disable 0169
		static Delegate GetIsDummyEmptyMessageHandler ()
		{
			if (cb_isDummyEmptyMessage == null)
				cb_isDummyEmptyMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDummyEmptyMessage);
			return cb_isDummyEmptyMessage;
		}

		static bool n_IsDummyEmptyMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDummyEmptyMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isDummyEmptyMessage;
		public virtual unsafe bool IsDummyEmptyMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isDummyEmptyMessage' and count(parameter)=0]"
			[Register ("isDummyEmptyMessage", "()Z", "GetIsDummyEmptyMessageHandler")]
			get {
				if (id_isDummyEmptyMessage == IntPtr.Zero)
					id_isDummyEmptyMessage = JNIEnv.GetMethodID (class_ref, "isDummyEmptyMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDummyEmptyMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDummyEmptyMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isGroupMessage;
#pragma warning disable 0169
		static Delegate GetIsGroupMessageHandler ()
		{
			if (cb_isGroupMessage == null)
				cb_isGroupMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGroupMessage);
			return cb_isGroupMessage;
		}

		static bool n_IsGroupMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGroupMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isGroupMessage;
		public virtual unsafe bool IsGroupMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isGroupMessage' and count(parameter)=0]"
			[Register ("isGroupMessage", "()Z", "GetIsGroupMessageHandler")]
			get {
				if (id_isGroupMessage == IntPtr.Zero)
					id_isGroupMessage = JNIEnv.GetMethodID (class_ref, "isGroupMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isGroupMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGroupMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isIncomingCall;
#pragma warning disable 0169
		static Delegate GetIsIncomingCallHandler ()
		{
			if (cb_isIncomingCall == null)
				cb_isIncomingCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIncomingCall);
			return cb_isIncomingCall;
		}

		static bool n_IsIncomingCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIncomingCall;
		}
#pragma warning restore 0169

		static IntPtr id_isIncomingCall;
		public virtual unsafe bool IsIncomingCall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isIncomingCall' and count(parameter)=0]"
			[Register ("isIncomingCall", "()Z", "GetIsIncomingCallHandler")]
			get {
				if (id_isIncomingCall == IntPtr.Zero)
					id_isIncomingCall = JNIEnv.GetMethodID (class_ref, "isIncomingCall", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIncomingCall);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isIncomingCall", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLocalMessage;
#pragma warning disable 0169
		static Delegate GetIsLocalMessageHandler ()
		{
			if (cb_isLocalMessage == null)
				cb_isLocalMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocalMessage);
			return cb_isLocalMessage;
		}

		static bool n_IsLocalMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocalMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isLocalMessage;
		public virtual unsafe bool IsLocalMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isLocalMessage' and count(parameter)=0]"
			[Register ("isLocalMessage", "()Z", "GetIsLocalMessageHandler")]
			get {
				if (id_isLocalMessage == IntPtr.Zero)
					id_isLocalMessage = JNIEnv.GetMethodID (class_ref, "isLocalMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocalMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLocalMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLocationMessage;
#pragma warning disable 0169
		static Delegate GetIsLocationMessageHandler ()
		{
			if (cb_isLocationMessage == null)
				cb_isLocationMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocationMessage);
			return cb_isLocationMessage;
		}

		static bool n_IsLocationMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocationMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isLocationMessage;
		public virtual unsafe bool IsLocationMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isLocationMessage' and count(parameter)=0]"
			[Register ("isLocationMessage", "()Z", "GetIsLocationMessageHandler")]
			get {
				if (id_isLocationMessage == IntPtr.Zero)
					id_isLocationMessage = JNIEnv.GetMethodID (class_ref, "isLocationMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocationMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLocationMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isOutgoingCall;
#pragma warning disable 0169
		static Delegate GetIsOutgoingCallHandler ()
		{
			if (cb_isOutgoingCall == null)
				cb_isOutgoingCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOutgoingCall);
			return cb_isOutgoingCall;
		}

		static bool n_IsOutgoingCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOutgoingCall;
		}
#pragma warning restore 0169

		static IntPtr id_isOutgoingCall;
		public virtual unsafe bool IsOutgoingCall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isOutgoingCall' and count(parameter)=0]"
			[Register ("isOutgoingCall", "()Z", "GetIsOutgoingCallHandler")]
			get {
				if (id_isOutgoingCall == IntPtr.Zero)
					id_isOutgoingCall = JNIEnv.GetMethodID (class_ref, "isOutgoingCall", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOutgoingCall);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOutgoingCall", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isReadStatus;
#pragma warning disable 0169
		static Delegate GetIsReadStatusHandler ()
		{
			if (cb_isReadStatus == null)
				cb_isReadStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReadStatus);
			return cb_isReadStatus;
		}

		static bool n_IsReadStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReadStatus;
		}
#pragma warning restore 0169

		static IntPtr id_isReadStatus;
		public virtual unsafe bool IsReadStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isReadStatus' and count(parameter)=0]"
			[Register ("isReadStatus", "()Z", "GetIsReadStatusHandler")]
			get {
				if (id_isReadStatus == IntPtr.Zero)
					id_isReadStatus = JNIEnv.GetMethodID (class_ref, "isReadStatus", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReadStatus);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReadStatus", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isReadStatusForUpdate;
#pragma warning disable 0169
		static Delegate GetIsReadStatusForUpdateHandler ()
		{
			if (cb_isReadStatusForUpdate == null)
				cb_isReadStatusForUpdate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReadStatusForUpdate);
			return cb_isReadStatusForUpdate;
		}

		static bool n_IsReadStatusForUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReadStatusForUpdate;
		}
#pragma warning restore 0169

		static IntPtr id_isReadStatusForUpdate;
		public virtual unsafe bool IsReadStatusForUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isReadStatusForUpdate' and count(parameter)=0]"
			[Register ("isReadStatusForUpdate", "()Z", "GetIsReadStatusForUpdateHandler")]
			get {
				if (id_isReadStatusForUpdate == IntPtr.Zero)
					id_isReadStatusForUpdate = JNIEnv.GetMethodID (class_ref, "isReadStatusForUpdate", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReadStatusForUpdate);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReadStatusForUpdate", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSelfDestruct;
#pragma warning disable 0169
		static Delegate GetIsSelfDestructHandler ()
		{
			if (cb_isSelfDestruct == null)
				cb_isSelfDestruct = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSelfDestruct);
			return cb_isSelfDestruct;
		}

		static bool n_IsSelfDestruct (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSelfDestruct;
		}
#pragma warning restore 0169

		static IntPtr id_isSelfDestruct;
		public virtual unsafe bool IsSelfDestruct {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isSelfDestruct' and count(parameter)=0]"
			[Register ("isSelfDestruct", "()Z", "GetIsSelfDestructHandler")]
			get {
				if (id_isSelfDestruct == IntPtr.Zero)
					id_isSelfDestruct = JNIEnv.GetMethodID (class_ref, "isSelfDestruct", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSelfDestruct);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSelfDestruct", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSentToMany;
#pragma warning disable 0169
		static Delegate GetIsSentToManyHandler ()
		{
			if (cb_isSentToMany == null)
				cb_isSentToMany = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSentToMany);
			return cb_isSentToMany;
		}

		static bool n_IsSentToMany (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSentToMany;
		}
#pragma warning restore 0169

		static IntPtr id_isSentToMany;
		public virtual unsafe bool IsSentToMany {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isSentToMany' and count(parameter)=0]"
			[Register ("isSentToMany", "()Z", "GetIsSentToManyHandler")]
			get {
				if (id_isSentToMany == IntPtr.Zero)
					id_isSentToMany = JNIEnv.GetMethodID (class_ref, "isSentToMany", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSentToMany);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSentToMany", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSentViaApp;
#pragma warning disable 0169
		static Delegate GetIsSentViaAppHandler ()
		{
			if (cb_isSentViaApp == null)
				cb_isSentViaApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSentViaApp);
			return cb_isSentViaApp;
		}

		static bool n_IsSentViaApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSentViaApp;
		}
#pragma warning restore 0169

		static IntPtr id_isSentViaApp;
		public virtual unsafe bool IsSentViaApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isSentViaApp' and count(parameter)=0]"
			[Register ("isSentViaApp", "()Z", "GetIsSentViaAppHandler")]
			get {
				if (id_isSentViaApp == IntPtr.Zero)
					id_isSentViaApp = JNIEnv.GetMethodID (class_ref, "isSentViaApp", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSentViaApp);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSentViaApp", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSentViaCarrier;
#pragma warning disable 0169
		static Delegate GetIsSentViaCarrierHandler ()
		{
			if (cb_isSentViaCarrier == null)
				cb_isSentViaCarrier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSentViaCarrier);
			return cb_isSentViaCarrier;
		}

		static bool n_IsSentViaCarrier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSentViaCarrier;
		}
#pragma warning restore 0169

		static IntPtr id_isSentViaCarrier;
		public virtual unsafe bool IsSentViaCarrier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isSentViaCarrier' and count(parameter)=0]"
			[Register ("isSentViaCarrier", "()Z", "GetIsSentViaCarrierHandler")]
			get {
				if (id_isSentViaCarrier == IntPtr.Zero)
					id_isSentViaCarrier = JNIEnv.GetMethodID (class_ref, "isSentViaCarrier", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSentViaCarrier);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSentViaCarrier", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTempDateType;
#pragma warning disable 0169
		static Delegate GetIsTempDateTypeHandler ()
		{
			if (cb_isTempDateType == null)
				cb_isTempDateType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTempDateType);
			return cb_isTempDateType;
		}

		static bool n_IsTempDateType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTempDateType;
		}
#pragma warning restore 0169

		static IntPtr id_isTempDateType;
		public virtual unsafe bool IsTempDateType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isTempDateType' and count(parameter)=0]"
			[Register ("isTempDateType", "()Z", "GetIsTempDateTypeHandler")]
			get {
				if (id_isTempDateType == IntPtr.Zero)
					id_isTempDateType = JNIEnv.GetMethodID (class_ref, "isTempDateType", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTempDateType);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTempDateType", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTypeOutbox;
#pragma warning disable 0169
		static Delegate GetIsTypeOutboxHandler ()
		{
			if (cb_isTypeOutbox == null)
				cb_isTypeOutbox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTypeOutbox);
			return cb_isTypeOutbox;
		}

		static bool n_IsTypeOutbox (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTypeOutbox;
		}
#pragma warning restore 0169

		static IntPtr id_isTypeOutbox;
		public virtual unsafe bool IsTypeOutbox {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isTypeOutbox' and count(parameter)=0]"
			[Register ("isTypeOutbox", "()Z", "GetIsTypeOutboxHandler")]
			get {
				if (id_isTypeOutbox == IntPtr.Zero)
					id_isTypeOutbox = JNIEnv.GetMethodID (class_ref, "isTypeOutbox", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTypeOutbox);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTypeOutbox", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUpdateMessage;
#pragma warning disable 0169
		static Delegate GetIsUpdateMessageHandler ()
		{
			if (cb_isUpdateMessage == null)
				cb_isUpdateMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUpdateMessage);
			return cb_isUpdateMessage;
		}

		static bool n_IsUpdateMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUpdateMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isUpdateMessage;
		public virtual unsafe bool IsUpdateMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isUpdateMessage' and count(parameter)=0]"
			[Register ("isUpdateMessage", "()Z", "GetIsUpdateMessageHandler")]
			get {
				if (id_isUpdateMessage == IntPtr.Zero)
					id_isUpdateMessage = JNIEnv.GetMethodID (class_ref, "isUpdateMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUpdateMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUpdateMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUploadRequired;
#pragma warning disable 0169
		static Delegate GetIsUploadRequiredHandler ()
		{
			if (cb_isUploadRequired == null)
				cb_isUploadRequired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUploadRequired);
			return cb_isUploadRequired;
		}

		static bool n_IsUploadRequired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUploadRequired;
		}
#pragma warning restore 0169

		static IntPtr id_isUploadRequired;
		public virtual unsafe bool IsUploadRequired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isUploadRequired' and count(parameter)=0]"
			[Register ("isUploadRequired", "()Z", "GetIsUploadRequiredHandler")]
			get {
				if (id_isUploadRequired == IntPtr.Zero)
					id_isUploadRequired = JNIEnv.GetMethodID (class_ref, "isUploadRequired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUploadRequired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUploadRequired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isVideoCallMessage;
#pragma warning disable 0169
		static Delegate GetIsVideoCallMessageHandler ()
		{
			if (cb_isVideoCallMessage == null)
				cb_isVideoCallMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVideoCallMessage);
			return cb_isVideoCallMessage;
		}

		static bool n_IsVideoCallMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVideoCallMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isVideoCallMessage;
		public virtual unsafe bool IsVideoCallMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isVideoCallMessage' and count(parameter)=0]"
			[Register ("isVideoCallMessage", "()Z", "GetIsVideoCallMessageHandler")]
			get {
				if (id_isVideoCallMessage == IntPtr.Zero)
					id_isVideoCallMessage = JNIEnv.GetMethodID (class_ref, "isVideoCallMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVideoCallMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVideoCallMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isVideoNotificationMessage;
#pragma warning disable 0169
		static Delegate GetIsVideoNotificationMessageHandler ()
		{
			if (cb_isVideoNotificationMessage == null)
				cb_isVideoNotificationMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVideoNotificationMessage);
			return cb_isVideoNotificationMessage;
		}

		static bool n_IsVideoNotificationMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVideoNotificationMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isVideoNotificationMessage;
		public virtual unsafe bool IsVideoNotificationMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isVideoNotificationMessage' and count(parameter)=0]"
			[Register ("isVideoNotificationMessage", "()Z", "GetIsVideoNotificationMessageHandler")]
			get {
				if (id_isVideoNotificationMessage == IntPtr.Zero)
					id_isVideoNotificationMessage = JNIEnv.GetMethodID (class_ref, "isVideoNotificationMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVideoNotificationMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVideoNotificationMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isVideoOrAudioCallMessage;
#pragma warning disable 0169
		static Delegate GetIsVideoOrAudioCallMessageHandler ()
		{
			if (cb_isVideoOrAudioCallMessage == null)
				cb_isVideoOrAudioCallMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVideoOrAudioCallMessage);
			return cb_isVideoOrAudioCallMessage;
		}

		static bool n_IsVideoOrAudioCallMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVideoOrAudioCallMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isVideoOrAudioCallMessage;
		public virtual unsafe bool IsVideoOrAudioCallMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isVideoOrAudioCallMessage' and count(parameter)=0]"
			[Register ("isVideoOrAudioCallMessage", "()Z", "GetIsVideoOrAudioCallMessageHandler")]
			get {
				if (id_isVideoOrAudioCallMessage == IntPtr.Zero)
					id_isVideoOrAudioCallMessage = JNIEnv.GetMethodID (class_ref, "isVideoOrAudioCallMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVideoOrAudioCallMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVideoOrAudioCallMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getKeyString;
#pragma warning disable 0169
		static Delegate GetGetKeyStringHandler ()
		{
			if (cb_getKeyString == null)
				cb_getKeyString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeyString);
			return cb_getKeyString;
		}

		static IntPtr n_GetKeyString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KeyString);
		}
#pragma warning restore 0169

		static Delegate cb_setKeyString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKeyString_Ljava_lang_String_Handler ()
		{
			if (cb_setKeyString_Ljava_lang_String_ == null)
				cb_setKeyString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKeyString_Ljava_lang_String_);
			return cb_setKeyString_Ljava_lang_String_;
		}

		static void n_SetKeyString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.KeyString = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKeyString;
		static IntPtr id_setKeyString_Ljava_lang_String_;
		public virtual unsafe string KeyString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getKeyString' and count(parameter)=0]"
			[Register ("getKeyString", "()Ljava/lang/String;", "GetGetKeyStringHandler")]
			get {
				if (id_getKeyString == IntPtr.Zero)
					id_getKeyString = JNIEnv.GetMethodID (class_ref, "getKeyString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeyString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setKeyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKeyString", "(Ljava/lang/String;)V", "GetSetKeyString_Ljava_lang_String_Handler")]
			set {
				if (id_setKeyString_Ljava_lang_String_ == IntPtr.Zero)
					id_setKeyString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKeyString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeyString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeyString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessageId;
#pragma warning disable 0169
		static Delegate GetGetMessageIdHandler ()
		{
			if (cb_getMessageId == null)
				cb_getMessageId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageId);
			return cb_getMessageId;
		}

		static IntPtr n_GetMessageId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessageId);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageId_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetMessageId_Ljava_lang_Long_Handler ()
		{
			if (cb_setMessageId_Ljava_lang_Long_ == null)
				cb_setMessageId_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageId_Ljava_lang_Long_);
			return cb_setMessageId_Ljava_lang_Long_;
		}

		static void n_SetMessageId_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageId;
		static IntPtr id_setMessageId_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long MessageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getMessageId' and count(parameter)=0]"
			[Register ("getMessageId", "()Ljava/lang/Long;", "GetGetMessageIdHandler")]
			get {
				if (id_getMessageId == IntPtr.Zero)
					id_getMessageId = JNIEnv.GetMethodID (class_ref, "getMessageId", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageId", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setMessageId' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setMessageId", "(Ljava/lang/Long;)V", "GetSetMessageId_Ljava_lang_Long_Handler")]
			set {
				if (id_setMessageId_Ljava_lang_Long_ == IntPtr.Zero)
					id_setMessageId_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setMessageId", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageId_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageId", "(Ljava/lang/Long;)V"), __args);
				} finally {
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		static IntPtr id_setMetadata_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getMetadata' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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

		static Delegate cb_getPairedMessageKeyString;
#pragma warning disable 0169
		static Delegate GetGetPairedMessageKeyStringHandler ()
		{
			if (cb_getPairedMessageKeyString == null)
				cb_getPairedMessageKeyString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPairedMessageKeyString);
			return cb_getPairedMessageKeyString;
		}

		static IntPtr n_GetPairedMessageKeyString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PairedMessageKeyString);
		}
#pragma warning restore 0169

		static Delegate cb_setPairedMessageKeyString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPairedMessageKeyString_Ljava_lang_String_Handler ()
		{
			if (cb_setPairedMessageKeyString_Ljava_lang_String_ == null)
				cb_setPairedMessageKeyString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPairedMessageKeyString_Ljava_lang_String_);
			return cb_setPairedMessageKeyString_Ljava_lang_String_;
		}

		static void n_SetPairedMessageKeyString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PairedMessageKeyString = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPairedMessageKeyString;
		static IntPtr id_setPairedMessageKeyString_Ljava_lang_String_;
		public virtual unsafe string PairedMessageKeyString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getPairedMessageKeyString' and count(parameter)=0]"
			[Register ("getPairedMessageKeyString", "()Ljava/lang/String;", "GetGetPairedMessageKeyStringHandler")]
			get {
				if (id_getPairedMessageKeyString == IntPtr.Zero)
					id_getPairedMessageKeyString = JNIEnv.GetMethodID (class_ref, "getPairedMessageKeyString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPairedMessageKeyString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPairedMessageKeyString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setPairedMessageKeyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPairedMessageKeyString", "(Ljava/lang/String;)V", "GetSetPairedMessageKeyString_Ljava_lang_String_Handler")]
			set {
				if (id_setPairedMessageKeyString_Ljava_lang_String_ == IntPtr.Zero)
					id_setPairedMessageKeyString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPairedMessageKeyString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPairedMessageKeyString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPairedMessageKeyString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getScheduledAt;
#pragma warning disable 0169
		static Delegate GetGetScheduledAtHandler ()
		{
			if (cb_getScheduledAt == null)
				cb_getScheduledAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScheduledAt);
			return cb_getScheduledAt;
		}

		static IntPtr n_GetScheduledAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScheduledAt);
		}
#pragma warning restore 0169

		static Delegate cb_setScheduledAt_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetScheduledAt_Ljava_lang_Long_Handler ()
		{
			if (cb_setScheduledAt_Ljava_lang_Long_ == null)
				cb_setScheduledAt_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScheduledAt_Ljava_lang_Long_);
			return cb_setScheduledAt_Ljava_lang_Long_;
		}

		static void n_SetScheduledAt_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScheduledAt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScheduledAt;
		static IntPtr id_setScheduledAt_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long ScheduledAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getScheduledAt' and count(parameter)=0]"
			[Register ("getScheduledAt", "()Ljava/lang/Long;", "GetGetScheduledAtHandler")]
			get {
				if (id_getScheduledAt == IntPtr.Zero)
					id_getScheduledAt = JNIEnv.GetMethodID (class_ref, "getScheduledAt", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScheduledAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScheduledAt", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setScheduledAt' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setScheduledAt", "(Ljava/lang/Long;)V", "GetSetScheduledAt_Ljava_lang_Long_Handler")]
			set {
				if (id_setScheduledAt_Ljava_lang_Long_ == IntPtr.Zero)
					id_setScheduledAt_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setScheduledAt", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScheduledAt_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScheduledAt", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSendToDevice;
#pragma warning disable 0169
		static Delegate GetIsSendToDeviceHandler ()
		{
			if (cb_isSendToDevice == null)
				cb_isSendToDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSendToDevice);
			return cb_isSendToDevice;
		}

		static bool n_IsSendToDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SendToDevice;
		}
#pragma warning restore 0169

		static Delegate cb_setSendToDevice_Z;
#pragma warning disable 0169
		static Delegate GetSetSendToDevice_ZHandler ()
		{
			if (cb_setSendToDevice_Z == null)
				cb_setSendToDevice_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSendToDevice_Z);
			return cb_setSendToDevice_Z;
		}

		static void n_SetSendToDevice_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendToDevice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSendToDevice;
		static IntPtr id_setSendToDevice_Z;
		public virtual unsafe bool SendToDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isSendToDevice' and count(parameter)=0]"
			[Register ("isSendToDevice", "()Z", "GetIsSendToDeviceHandler")]
			get {
				if (id_isSendToDevice == IntPtr.Zero)
					id_isSendToDevice = JNIEnv.GetMethodID (class_ref, "isSendToDevice", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSendToDevice);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSendToDevice", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setSendToDevice' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSendToDevice", "(Z)V", "GetSetSendToDevice_ZHandler")]
			set {
				if (id_setSendToDevice_Z == IntPtr.Zero)
					id_setSendToDevice_Z = JNIEnv.GetMethodID (class_ref, "setSendToDevice", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSendToDevice_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSendToDevice", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSent;
#pragma warning disable 0169
		static Delegate GetIsSentHandler ()
		{
			if (cb_isSent == null)
				cb_isSent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSent);
			return cb_isSent;
		}

		static bool n_IsSent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sent;
		}
#pragma warning restore 0169

		static Delegate cb_setSent_Z;
#pragma warning disable 0169
		static Delegate GetSetSent_ZHandler ()
		{
			if (cb_setSent_Z == null)
				cb_setSent_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSent_Z);
			return cb_setSent_Z;
		}

		static void n_SetSent_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sent = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSent;
		static IntPtr id_setSent_Z;
		public virtual unsafe bool Sent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isSent' and count(parameter)=0]"
			[Register ("isSent", "()Z", "GetIsSentHandler")]
			get {
				if (id_isSent == IntPtr.Zero)
					id_isSent = JNIEnv.GetMethodID (class_ref, "isSent", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSent);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSent", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setSent' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSent", "(Z)V", "GetSetSent_ZHandler")]
			set {
				if (id_setSent_Z == IntPtr.Zero)
					id_setSent_Z = JNIEnv.GetMethodID (class_ref, "setSent", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSent_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSent", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSentMessageTimeAtServer;
#pragma warning disable 0169
		static Delegate GetGetSentMessageTimeAtServerHandler ()
		{
			if (cb_getSentMessageTimeAtServer == null)
				cb_getSentMessageTimeAtServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSentMessageTimeAtServer);
			return cb_getSentMessageTimeAtServer;
		}

		static long n_GetSentMessageTimeAtServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentMessageTimeAtServer;
		}
#pragma warning restore 0169

		static Delegate cb_setSentMessageTimeAtServer_J;
#pragma warning disable 0169
		static Delegate GetSetSentMessageTimeAtServer_JHandler ()
		{
			if (cb_setSentMessageTimeAtServer_J == null)
				cb_setSentMessageTimeAtServer_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSentMessageTimeAtServer_J);
			return cb_setSentMessageTimeAtServer_J;
		}

		static void n_SetSentMessageTimeAtServer_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SentMessageTimeAtServer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSentMessageTimeAtServer;
		static IntPtr id_setSentMessageTimeAtServer_J;
		public virtual unsafe long SentMessageTimeAtServer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getSentMessageTimeAtServer' and count(parameter)=0]"
			[Register ("getSentMessageTimeAtServer", "()J", "GetGetSentMessageTimeAtServerHandler")]
			get {
				if (id_getSentMessageTimeAtServer == IntPtr.Zero)
					id_getSentMessageTimeAtServer = JNIEnv.GetMethodID (class_ref, "getSentMessageTimeAtServer", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSentMessageTimeAtServer);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentMessageTimeAtServer", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setSentMessageTimeAtServer' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSentMessageTimeAtServer", "(J)V", "GetSetSentMessageTimeAtServer_JHandler")]
			set {
				if (id_setSentMessageTimeAtServer_J == IntPtr.Zero)
					id_setSentMessageTimeAtServer_J = JNIEnv.GetMethodID (class_ref, "setSentMessageTimeAtServer", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSentMessageTimeAtServer_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentMessageTimeAtServer", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSentToServer;
#pragma warning disable 0169
		static Delegate GetIsSentToServerHandler ()
		{
			if (cb_isSentToServer == null)
				cb_isSentToServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSentToServer);
			return cb_isSentToServer;
		}

		static bool n_IsSentToServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentToServer;
		}
#pragma warning restore 0169

		static Delegate cb_setSentToServer_Z;
#pragma warning disable 0169
		static Delegate GetSetSentToServer_ZHandler ()
		{
			if (cb_setSentToServer_Z == null)
				cb_setSentToServer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSentToServer_Z);
			return cb_setSentToServer_Z;
		}

		static void n_SetSentToServer_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SentToServer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSentToServer;
		static IntPtr id_setSentToServer_Z;
		public virtual unsafe bool SentToServer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isSentToServer' and count(parameter)=0]"
			[Register ("isSentToServer", "()Z", "GetIsSentToServerHandler")]
			get {
				if (id_isSentToServer == IntPtr.Zero)
					id_isSentToServer = JNIEnv.GetMethodID (class_ref, "isSentToServer", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSentToServer);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSentToServer", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setSentToServer' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSentToServer", "(Z)V", "GetSetSentToServer_ZHandler")]
			set {
				if (id_setSentToServer_Z == IntPtr.Zero)
					id_setSentToServer_Z = JNIEnv.GetMethodID (class_ref, "setSentToServer", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSentToServer_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentToServer", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isShared;
#pragma warning disable 0169
		static Delegate GetIsSharedHandler ()
		{
			if (cb_isShared == null)
				cb_isShared = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShared);
			return cb_isShared;
		}

		static bool n_IsShared (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Shared;
		}
#pragma warning restore 0169

		static Delegate cb_setShared_Z;
#pragma warning disable 0169
		static Delegate GetSetShared_ZHandler ()
		{
			if (cb_setShared_Z == null)
				cb_setShared_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShared_Z);
			return cb_setShared_Z;
		}

		static void n_SetShared_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shared = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isShared;
		static IntPtr id_setShared_Z;
		public virtual unsafe bool Shared {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isShared' and count(parameter)=0]"
			[Register ("isShared", "()Z", "GetIsSharedHandler")]
			get {
				if (id_isShared == IntPtr.Zero)
					id_isShared = JNIEnv.GetMethodID (class_ref, "isShared", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShared);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShared", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setShared' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShared", "(Z)V", "GetSetShared_ZHandler")]
			set {
				if (id_setShared_Z == IntPtr.Zero)
					id_setShared_Z = JNIEnv.GetMethodID (class_ref, "setShared", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShared_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShared", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isStoreOnDevice;
#pragma warning disable 0169
		static Delegate GetIsStoreOnDeviceHandler ()
		{
			if (cb_isStoreOnDevice == null)
				cb_isStoreOnDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStoreOnDevice);
			return cb_isStoreOnDevice;
		}

		static bool n_IsStoreOnDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StoreOnDevice;
		}
#pragma warning restore 0169

		static Delegate cb_setStoreOnDevice_Z;
#pragma warning disable 0169
		static Delegate GetSetStoreOnDevice_ZHandler ()
		{
			if (cb_setStoreOnDevice_Z == null)
				cb_setStoreOnDevice_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetStoreOnDevice_Z);
			return cb_setStoreOnDevice_Z;
		}

		static void n_SetStoreOnDevice_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StoreOnDevice = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isStoreOnDevice;
		static IntPtr id_setStoreOnDevice_Z;
		public virtual unsafe bool StoreOnDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isStoreOnDevice' and count(parameter)=0]"
			[Register ("isStoreOnDevice", "()Z", "GetIsStoreOnDeviceHandler")]
			get {
				if (id_isStoreOnDevice == IntPtr.Zero)
					id_isStoreOnDevice = JNIEnv.GetMethodID (class_ref, "isStoreOnDevice", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStoreOnDevice);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStoreOnDevice", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setStoreOnDevice' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStoreOnDevice", "(Z)V", "GetSetStoreOnDevice_ZHandler")]
			set {
				if (id_setStoreOnDevice_Z == IntPtr.Zero)
					id_setStoreOnDevice_Z = JNIEnv.GetMethodID (class_ref, "setStoreOnDevice", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStoreOnDevice_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStoreOnDevice", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSuUserKeyString;
#pragma warning disable 0169
		static Delegate GetGetSuUserKeyStringHandler ()
		{
			if (cb_getSuUserKeyString == null)
				cb_getSuUserKeyString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuUserKeyString);
			return cb_getSuUserKeyString;
		}

		static IntPtr n_GetSuUserKeyString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SuUserKeyString);
		}
#pragma warning restore 0169

		static Delegate cb_setSuUserKeyString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSuUserKeyString_Ljava_lang_String_Handler ()
		{
			if (cb_setSuUserKeyString_Ljava_lang_String_ == null)
				cb_setSuUserKeyString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSuUserKeyString_Ljava_lang_String_);
			return cb_setSuUserKeyString_Ljava_lang_String_;
		}

		static void n_SetSuUserKeyString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SuUserKeyString = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSuUserKeyString;
		static IntPtr id_setSuUserKeyString_Ljava_lang_String_;
		public virtual unsafe string SuUserKeyString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getSuUserKeyString' and count(parameter)=0]"
			[Register ("getSuUserKeyString", "()Ljava/lang/String;", "GetGetSuUserKeyStringHandler")]
			get {
				if (id_getSuUserKeyString == IntPtr.Zero)
					id_getSuUserKeyString = JNIEnv.GetMethodID (class_ref, "getSuUserKeyString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSuUserKeyString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuUserKeyString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setSuUserKeyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSuUserKeyString", "(Ljava/lang/String;)V", "GetSetSuUserKeyString_Ljava_lang_String_Handler")]
			set {
				if (id_setSuUserKeyString_Ljava_lang_String_ == IntPtr.Zero)
					id_setSuUserKeyString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSuUserKeyString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSuUserKeyString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuUserKeyString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTimeToLive;
#pragma warning disable 0169
		static Delegate GetGetTimeToLiveHandler ()
		{
			if (cb_getTimeToLive == null)
				cb_getTimeToLive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeToLive);
			return cb_getTimeToLive;
		}

		static IntPtr n_GetTimeToLive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeToLive);
		}
#pragma warning restore 0169

		static Delegate cb_setTimeToLive_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTimeToLive_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTimeToLive_Ljava_lang_Integer_ == null)
				cb_setTimeToLive_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimeToLive_Ljava_lang_Integer_);
			return cb_setTimeToLive_Ljava_lang_Integer_;
		}

		static void n_SetTimeToLive_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TimeToLive = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeToLive;
		static IntPtr id_setTimeToLive_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TimeToLive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getTimeToLive' and count(parameter)=0]"
			[Register ("getTimeToLive", "()Ljava/lang/Integer;", "GetGetTimeToLiveHandler")]
			get {
				if (id_getTimeToLive == IntPtr.Zero)
					id_getTimeToLive = JNIEnv.GetMethodID (class_ref, "getTimeToLive", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeToLive), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeToLive", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setTimeToLive' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTimeToLive", "(Ljava/lang/Integer;)V", "GetSetTimeToLive_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTimeToLive_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTimeToLive_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTimeToLive", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeToLive_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeToLive", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTo;
#pragma warning disable 0169
		static Delegate GetGetToHandler ()
		{
			if (cb_getTo == null)
				cb_getTo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTo);
			return cb_getTo;
		}

		static IntPtr n_GetTo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.To);
		}
#pragma warning restore 0169

		static Delegate cb_setTo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTo_Ljava_lang_String_Handler ()
		{
			if (cb_setTo_Ljava_lang_String_ == null)
				cb_setTo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTo_Ljava_lang_String_);
			return cb_setTo_Ljava_lang_String_;
		}

		static void n_SetTo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.To = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTo;
		static IntPtr id_setTo_Ljava_lang_String_;
		public virtual unsafe string To {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getTo' and count(parameter)=0]"
			[Register ("getTo", "()Ljava/lang/String;", "GetGetToHandler")]
			get {
				if (id_getTo == IntPtr.Zero)
					id_getTo = JNIEnv.GetMethodID (class_ref, "getTo", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTo), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setTo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTo", "(Ljava/lang/String;)V", "GetSetTo_Ljava_lang_String_Handler")]
			set {
				if (id_setTo_Ljava_lang_String_ == IntPtr.Zero)
					id_setTo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTo", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTo_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTo", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TopicId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTopicId;
		static IntPtr id_setTopicId_Ljava_lang_String_;
		public virtual unsafe string TopicId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getTopicId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setTopicId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_Short_Handler ()
		{
			if (cb_setType_Ljava_lang_Short_ == null)
				cb_setType_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_Short_);
			return cb_setType_Ljava_lang_Short_;
		}

		static void n_SetType_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/Short;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setType", "(Ljava/lang/Short;)V", "GetSetType_Ljava_lang_Short_Handler")]
			set {
				if (id_setType_Ljava_lang_Short_ == IntPtr.Zero)
					id_setType_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetContentType);
			return cb_getContentType;
		}

		static short n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetContentType ();
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getContentType' and count(parameter)=0]"
		[Register ("getContentType", "()S", "GetGetContentTypeHandler")]
		public virtual unsafe short GetContentType ()
		{
			if (id_getContentType == IntPtr.Zero)
				id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()S");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getContentType);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()S"));
			} finally {
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetMessage ());
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getMessage' and count(parameter)=0]"
		[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
		public virtual unsafe string GetMessage ()
		{
			if (id_getMessage == IntPtr.Zero)
				id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMetaDataValueForKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMetaDataValueForKey_Ljava_lang_String_Handler ()
		{
			if (cb_getMetaDataValueForKey_Ljava_lang_String_ == null)
				cb_getMetaDataValueForKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMetaDataValueForKey_Ljava_lang_String_);
			return cb_getMetaDataValueForKey_Ljava_lang_String_;
		}

		static IntPtr n_GetMetaDataValueForKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMetaDataValueForKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMetaDataValueForKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getMetaDataValueForKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMetaDataValueForKey", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetMetaDataValueForKey_Ljava_lang_String_Handler")]
		public virtual unsafe string GetMetaDataValueForKey (string p0)
		{
			if (id_getMetaDataValueForKey_Ljava_lang_String_ == IntPtr.Zero)
				id_getMetaDataValueForKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMetaDataValueForKey", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetaDataValueForKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetaDataValueForKey", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSource);
			return cb_getSource;
		}

		static IntPtr n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSource ());
		}
#pragma warning restore 0169

		static IntPtr id_getSource;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getSource' and count(parameter)=0]"
		[Register ("getSource", "()Ljava/lang/Short;", "GetGetSourceHandler")]
		public virtual unsafe global::Java.Lang.Short GetSource ()
		{
			if (id_getSource == IntPtr.Zero)
				id_getSource = JNIEnv.GetMethodID (class_ref, "getSource", "()Ljava/lang/Short;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSource), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSource", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetStatus);
			return cb_getStatus;
		}

		static short n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetStatus ();
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()S", "GetGetStatusHandler")]
		public virtual unsafe short GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()S");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getStatus);
				else
					return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()S"));
			} finally {
			}
		}

		static Delegate cb_isRead;
#pragma warning disable 0169
		static Delegate GetIsReadHandler ()
		{
			if (cb_isRead == null)
				cb_isRead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsRead);
			return cb_isRead;
		}

		static IntPtr n_IsRead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsRead ());
		}
#pragma warning restore 0169

		static IntPtr id_isRead;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isRead' and count(parameter)=0]"
		[Register ("isRead", "()Ljava/lang/Boolean;", "GetIsReadHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsRead ()
		{
			if (id_isRead == IntPtr.Zero)
				id_isRead = JNIEnv.GetMethodID (class_ref, "isRead", "()Ljava/lang/Boolean;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isRead), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRead", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isReplyMessage;
#pragma warning disable 0169
		static Delegate GetIsReplyMessageHandler ()
		{
			if (cb_isReplyMessage == null)
				cb_isReplyMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IsReplyMessage);
			return cb_isReplyMessage;
		}

		static int n_IsReplyMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReplyMessage ();
		}
#pragma warning restore 0169

		static IntPtr id_isReplyMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='isReplyMessage' and count(parameter)=0]"
		[Register ("isReplyMessage", "()I", "GetIsReplyMessageHandler")]
		public virtual unsafe int IsReplyMessage ()
		{
			if (id_isReplyMessage == IntPtr.Zero)
				id_isReplyMessage = JNIEnv.GetMethodID (class_ref, "isReplyMessage", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_isReplyMessage);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReplyMessage", "()I"));
			} finally {
			}
		}

		static Delegate cb_processContactIds_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetProcessContactIds_Landroid_content_Context_Handler ()
		{
			if (cb_processContactIds_Landroid_content_Context_ == null)
				cb_processContactIds_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessContactIds_Landroid_content_Context_);
			return cb_processContactIds_Landroid_content_Context_;
		}

		static void n_ProcessContactIds_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessContactIds (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processContactIds_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='processContactIds' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("processContactIds", "(Landroid/content/Context;)V", "GetProcessContactIds_Landroid_content_Context_Handler")]
		public virtual unsafe void ProcessContactIds (global::Android.Content.Context p0)
		{
			if (id_processContactIds_Landroid_content_Context_ == IntPtr.Zero)
				id_processContactIds_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "processContactIds", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processContactIds_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processContactIds", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setContentType_S;
#pragma warning disable 0169
		static Delegate GetSetContentType_SHandler ()
		{
			if (cb_setContentType_S == null)
				cb_setContentType_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetContentType_S);
			return cb_setContentType_S;
		}

		static void n_SetContentType_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContentType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContentType_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setContentType", "(S)V", "GetSetContentType_SHandler")]
		public virtual unsafe void SetContentType (short p0)
		{
			if (id_setContentType_S == IntPtr.Zero)
				id_setContentType_S = JNIEnv.GetMethodID (class_ref, "setContentType", "(S)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentType_S, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentType", "(S)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMessage (string p0)
		{
			if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRead_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetRead_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setRead_Ljava_lang_Boolean_ == null)
				cb_setRead_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRead_Ljava_lang_Boolean_);
			return cb_setRead_Ljava_lang_Boolean_;
		}

		static void n_SetRead_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRead (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRead_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setRead' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setRead", "(Ljava/lang/Boolean;)V", "GetSetRead_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetRead (global::Java.Lang.Boolean p0)
		{
			if (id_setRead_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setRead_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setRead", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRead_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRead", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setReplyMessage_I;
#pragma warning disable 0169
		static Delegate GetSetReplyMessage_IHandler ()
		{
			if (cb_setReplyMessage_I == null)
				cb_setReplyMessage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReplyMessage_I);
			return cb_setReplyMessage_I;
		}

		static void n_SetReplyMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReplyMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setReplyMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setReplyMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReplyMessage", "(I)V", "GetSetReplyMessage_IHandler")]
		public virtual unsafe void SetReplyMessage (int p0)
		{
			if (id_setReplyMessage_I == IntPtr.Zero)
				id_setReplyMessage_I = JNIEnv.GetMethodID (class_ref, "setReplyMessage", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReplyMessage_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReplyMessage", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSource_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetSource_Ljava_lang_Short_Handler ()
		{
			if (cb_setSource_Ljava_lang_Short_ == null)
				cb_setSource_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSource_Ljava_lang_Short_);
			return cb_setSource_Ljava_lang_Short_;
		}

		static void n_SetSource_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSource_Ljava_lang_Short_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
		[Register ("setSource", "(Ljava/lang/Short;)V", "GetSetSource_Ljava_lang_Short_Handler")]
		public virtual unsafe void SetSource (global::Java.Lang.Short p0)
		{
			if (id_setSource_Ljava_lang_Short_ == IntPtr.Zero)
				id_setSource_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setSource", "(Ljava/lang/Short;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSource_Ljava_lang_Short_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSource", "(Ljava/lang/Short;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStatus_S;
#pragma warning disable 0169
		static Delegate GetSetStatus_SHandler ()
		{
			if (cb_setStatus_S == null)
				cb_setStatus_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetStatus_S);
			return cb_setStatus_S;
		}

		static void n_SetStatus_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatus_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setStatus", "(S)V", "GetSetStatus_SHandler")]
		public virtual unsafe void SetStatus (short p0)
		{
			if (id_setStatus_S == IntPtr.Zero)
				id_setStatus_S = JNIEnv.GetMethodID (class_ref, "setStatus", "(S)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_S, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(S)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTempDateType_S;
#pragma warning disable 0169
		static Delegate GetSetTempDateType_SHandler ()
		{
			if (cb_setTempDateType_S == null)
				cb_setTempDateType_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTempDateType_S);
			return cb_setTempDateType_S;
		}

		static void n_SetTempDateType_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTempDateType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTempDateType_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='Message']/method[@name='setTempDateType' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setTempDateType", "(S)V", "GetSetTempDateType_SHandler")]
		public virtual unsafe void SetTempDateType (short p0)
		{
			if (id_setTempDateType_S == IntPtr.Zero)
				id_setTempDateType_S = JNIEnv.GetMethodID (class_ref, "setTempDateType", "(S)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTempDateType_S, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTempDateType", "(S)V"), __args);
			} finally {
			}
		}

	}
}
