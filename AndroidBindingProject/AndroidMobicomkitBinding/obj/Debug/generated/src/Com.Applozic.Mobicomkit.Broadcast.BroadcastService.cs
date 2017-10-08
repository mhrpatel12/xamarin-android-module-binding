using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Broadcast {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/broadcast/BroadcastService", DoNotGenerateAcw=true)]
	public partial class BroadcastService : global::Java.Lang.Object {


		static IntPtr callRinging_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/field[@name='callRinging']"
		[Register ("callRinging")]
		public static bool CallRinging {
			get {
				if (callRinging_jfieldId == IntPtr.Zero)
					callRinging_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "callRinging", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, callRinging_jfieldId);
			}
			set {
				if (callRinging_jfieldId == IntPtr.Zero)
					callRinging_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "callRinging", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, callRinging_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr currentConversationId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/field[@name='currentConversationId']"
		[Register ("currentConversationId")]
		public static global::Java.Lang.Integer CurrentConversationId {
			get {
				if (currentConversationId_jfieldId == IntPtr.Zero)
					currentConversationId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "currentConversationId", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, currentConversationId_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (currentConversationId_jfieldId == IntPtr.Zero)
					currentConversationId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "currentConversationId", "Ljava/lang/Integer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, currentConversationId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr currentInfoId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/field[@name='currentInfoId']"
		[Register ("currentInfoId")]
		public static string CurrentInfoId {
			get {
				if (currentInfoId_jfieldId == IntPtr.Zero)
					currentInfoId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "currentInfoId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, currentInfoId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (currentInfoId_jfieldId == IntPtr.Zero)
					currentInfoId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "currentInfoId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, currentInfoId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr currentUserId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/field[@name='currentUserId']"
		[Register ("currentUserId")]
		public static string CurrentUserId {
			get {
				if (currentUserId_jfieldId == IntPtr.Zero)
					currentUserId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "currentUserId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, currentUserId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (currentUserId_jfieldId == IntPtr.Zero)
					currentUserId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "currentUserId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, currentUserId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr lastIndexForChats_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/field[@name='lastIndexForChats']"
		[Register ("lastIndexForChats")]
		public static int LastIndexForChats {
			get {
				if (lastIndexForChats_jfieldId == IntPtr.Zero)
					lastIndexForChats_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "lastIndexForChats", "I");
				return JNIEnv.GetStaticIntField (class_ref, lastIndexForChats_jfieldId);
			}
			set {
				if (lastIndexForChats_jfieldId == IntPtr.Zero)
					lastIndexForChats_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "lastIndexForChats", "I");
				try {
					JNIEnv.SetStaticField (class_ref, lastIndexForChats_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mobiTexterBroadcastReceiverActivated_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/field[@name='mobiTexterBroadcastReceiverActivated']"
		[Register ("mobiTexterBroadcastReceiverActivated")]
		public static bool MobiTexterBroadcastReceiverActivated {
			get {
				if (mobiTexterBroadcastReceiverActivated_jfieldId == IntPtr.Zero)
					mobiTexterBroadcastReceiverActivated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mobiTexterBroadcastReceiverActivated", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, mobiTexterBroadcastReceiverActivated_jfieldId);
			}
			set {
				if (mobiTexterBroadcastReceiverActivated_jfieldId == IntPtr.Zero)
					mobiTexterBroadcastReceiverActivated_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mobiTexterBroadcastReceiverActivated", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, mobiTexterBroadcastReceiverActivated_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr videoCallAcitivityOpend_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/field[@name='videoCallAcitivityOpend']"
		[Register ("videoCallAcitivityOpend")]
		public static bool VideoCallAcitivityOpend {
			get {
				if (videoCallAcitivityOpend_jfieldId == IntPtr.Zero)
					videoCallAcitivityOpend_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "videoCallAcitivityOpend", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, videoCallAcitivityOpend_jfieldId);
			}
			set {
				if (videoCallAcitivityOpend_jfieldId == IntPtr.Zero)
					videoCallAcitivityOpend_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "videoCallAcitivityOpend", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, videoCallAcitivityOpend_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS", DoNotGenerateAcw=true)]
		public sealed partial class INTENT_ACTIONS : global::Java.Lang.Enum {


			static IntPtr CHANNEL_SYNC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='CHANNEL_SYNC']"
			[Register ("CHANNEL_SYNC")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS ChannelSync {
				get {
					if (CHANNEL_SYNC_jfieldId == IntPtr.Zero)
						CHANNEL_SYNC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANNEL_SYNC", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANNEL_SYNC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONTACT_VERIFIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='CONTACT_VERIFIED']"
			[Register ("CONTACT_VERIFIED")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS ContactVerified {
				get {
					if (CONTACT_VERIFIED_jfieldId == IntPtr.Zero)
						CONTACT_VERIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTACT_VERIFIED", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTACT_VERIFIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONVERSATION_READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='CONVERSATION_READ']"
			[Register ("CONVERSATION_READ")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS ConversationRead {
				get {
					if (CONVERSATION_READ_jfieldId == IntPtr.Zero)
						CONVERSATION_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_READ", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DELETE_CONVERSATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='DELETE_CONVERSATION']"
			[Register ("DELETE_CONVERSATION")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS DeleteConversation {
				get {
					if (DELETE_CONVERSATION_jfieldId == IntPtr.Zero)
						DELETE_CONVERSATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE_CONVERSATION", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETE_CONVERSATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DELETE_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='DELETE_MESSAGE']"
			[Register ("DELETE_MESSAGE")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS DeleteMessage {
				get {
					if (DELETE_MESSAGE_jfieldId == IntPtr.Zero)
						DELETE_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETE_MESSAGE", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETE_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FIRST_TIME_SYNC_COMPLETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='FIRST_TIME_SYNC_COMPLETE']"
			[Register ("FIRST_TIME_SYNC_COMPLETE")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS FirstTimeSyncComplete {
				get {
					if (FIRST_TIME_SYNC_COMPLETE_jfieldId == IntPtr.Zero)
						FIRST_TIME_SYNC_COMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIRST_TIME_SYNC_COMPLETE", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIRST_TIME_SYNC_COMPLETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INSTRUCTION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='INSTRUCTION']"
			[Register ("INSTRUCTION")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS Instruction {
				get {
					if (INSTRUCTION_jfieldId == IntPtr.Zero)
						INSTRUCTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTRUCTION", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTRUCTION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOAD_MORE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='LOAD_MORE']"
			[Register ("LOAD_MORE")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS LoadMore {
				get {
					if (LOAD_MORE_jfieldId == IntPtr.Zero)
						LOAD_MORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOAD_MORE", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOAD_MORE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_ATTACHMENT_DOWNLOAD_DONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='MESSAGE_ATTACHMENT_DOWNLOAD_DONE']"
			[Register ("MESSAGE_ATTACHMENT_DOWNLOAD_DONE")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS MessageAttachmentDownloadDone {
				get {
					if (MESSAGE_ATTACHMENT_DOWNLOAD_DONE_jfieldId == IntPtr.Zero)
						MESSAGE_ATTACHMENT_DOWNLOAD_DONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_ATTACHMENT_DOWNLOAD_DONE", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_ATTACHMENT_DOWNLOAD_DONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_ATTACHMENT_DOWNLOAD_FAILD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='MESSAGE_ATTACHMENT_DOWNLOAD_FAILD']"
			[Register ("MESSAGE_ATTACHMENT_DOWNLOAD_FAILD")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS MessageAttachmentDownloadFaild {
				get {
					if (MESSAGE_ATTACHMENT_DOWNLOAD_FAILD_jfieldId == IntPtr.Zero)
						MESSAGE_ATTACHMENT_DOWNLOAD_FAILD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_ATTACHMENT_DOWNLOAD_FAILD", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_ATTACHMENT_DOWNLOAD_FAILD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_DELIVERY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='MESSAGE_DELIVERY']"
			[Register ("MESSAGE_DELIVERY")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS MessageDelivery {
				get {
					if (MESSAGE_DELIVERY_jfieldId == IntPtr.Zero)
						MESSAGE_DELIVERY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_DELIVERY", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_DELIVERY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_DELIVERY_FOR_CONTACT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='MESSAGE_DELIVERY_FOR_CONTACT']"
			[Register ("MESSAGE_DELIVERY_FOR_CONTACT")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS MessageDeliveryForContact {
				get {
					if (MESSAGE_DELIVERY_FOR_CONTACT_jfieldId == IntPtr.Zero)
						MESSAGE_DELIVERY_FOR_CONTACT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_DELIVERY_FOR_CONTACT", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_DELIVERY_FOR_CONTACT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_READ_AND_DELIVERED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='MESSAGE_READ_AND_DELIVERED']"
			[Register ("MESSAGE_READ_AND_DELIVERED")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS MessageReadAndDelivered {
				get {
					if (MESSAGE_READ_AND_DELIVERED_jfieldId == IntPtr.Zero)
						MESSAGE_READ_AND_DELIVERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_READ_AND_DELIVERED", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_READ_AND_DELIVERED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_READ_AND_DELIVERED_FOR_CONTECT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='MESSAGE_READ_AND_DELIVERED_FOR_CONTECT']"
			[Register ("MESSAGE_READ_AND_DELIVERED_FOR_CONTECT")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS MessageReadAndDeliveredForContect {
				get {
					if (MESSAGE_READ_AND_DELIVERED_FOR_CONTECT_jfieldId == IntPtr.Zero)
						MESSAGE_READ_AND_DELIVERED_FOR_CONTECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_READ_AND_DELIVERED_FOR_CONTECT", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_READ_AND_DELIVERED_FOR_CONTECT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_SYNC_ACK_FROM_SERVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='MESSAGE_SYNC_ACK_FROM_SERVER']"
			[Register ("MESSAGE_SYNC_ACK_FROM_SERVER")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS MessageSyncAckFromServer {
				get {
					if (MESSAGE_SYNC_ACK_FROM_SERVER_jfieldId == IntPtr.Zero)
						MESSAGE_SYNC_ACK_FROM_SERVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_SYNC_ACK_FROM_SERVER", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_SYNC_ACK_FROM_SERVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MQTT_DISCONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='MQTT_DISCONNECTED']"
			[Register ("MQTT_DISCONNECTED")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS MqttDisconnected {
				get {
					if (MQTT_DISCONNECTED_jfieldId == IntPtr.Zero)
						MQTT_DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MQTT_DISCONNECTED", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MQTT_DISCONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NOTIFY_USER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='NOTIFY_USER']"
			[Register ("NOTIFY_USER")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS NotifyUser {
				get {
					if (NOTIFY_USER_jfieldId == IntPtr.Zero)
						NOTIFY_USER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOTIFY_USER", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOTIFY_USER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SYNC_MESSAGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='SYNC_MESSAGE']"
			[Register ("SYNC_MESSAGE")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS SyncMessage {
				get {
					if (SYNC_MESSAGE_jfieldId == IntPtr.Zero)
						SYNC_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYNC_MESSAGE", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYNC_MESSAGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPDATE_CHANNEL_NAME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='UPDATE_CHANNEL_NAME']"
			[Register ("UPDATE_CHANNEL_NAME")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS UpdateChannelName {
				get {
					if (UPDATE_CHANNEL_NAME_jfieldId == IntPtr.Zero)
						UPDATE_CHANNEL_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE_CHANNEL_NAME", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATE_CHANNEL_NAME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPDATE_LAST_SEEN_AT_TIME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='UPDATE_LAST_SEEN_AT_TIME']"
			[Register ("UPDATE_LAST_SEEN_AT_TIME")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS UpdateLastSeenAtTime {
				get {
					if (UPDATE_LAST_SEEN_AT_TIME_jfieldId == IntPtr.Zero)
						UPDATE_LAST_SEEN_AT_TIME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE_LAST_SEEN_AT_TIME", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATE_LAST_SEEN_AT_TIME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPDATE_TITLE_SUBTITLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='UPDATE_TITLE_SUBTITLE']"
			[Register ("UPDATE_TITLE_SUBTITLE")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS UpdateTitleSubtitle {
				get {
					if (UPDATE_TITLE_SUBTITLE_jfieldId == IntPtr.Zero)
						UPDATE_TITLE_SUBTITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE_TITLE_SUBTITLE", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATE_TITLE_SUBTITLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPDATE_TYPING_STATUS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='UPDATE_TYPING_STATUS']"
			[Register ("UPDATE_TYPING_STATUS")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS UpdateTypingStatus {
				get {
					if (UPDATE_TYPING_STATUS_jfieldId == IntPtr.Zero)
						UPDATE_TYPING_STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPDATE_TYPING_STATUS", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPDATE_TYPING_STATUS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPLOAD_ATTACHMENT_FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/field[@name='UPLOAD_ATTACHMENT_FAILED']"
			[Register ("UPLOAD_ATTACHMENT_FAILED")]
			public static global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS UploadAttachmentFailed {
				get {
					if (UPLOAD_ATTACHMENT_FAILED_jfieldId == IntPtr.Zero)
						UPLOAD_ATTACHMENT_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOAD_ATTACHMENT_FAILED", "Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOAD_ATTACHMENT_FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (INTENT_ACTIONS); }
			}

			internal INTENT_ACTIONS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService.INTENT_ACTIONS']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/broadcast/BroadcastService$INTENT_ACTIONS;");
				try {
					return (global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Broadcast.BroadcastService.INTENT_ACTIONS));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/broadcast/BroadcastService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BroadcastService); }
		}

		protected BroadcastService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/constructor[@name='BroadcastService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BroadcastService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BroadcastService)) {
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

		static IntPtr id_getIntentFilter;
		public static unsafe global::Android.Content.IntentFilter IntentFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='getIntentFilter' and count(parameter)=0]"
			[Register ("getIntentFilter", "()Landroid/content/IntentFilter;", "GetGetIntentFilterHandler")]
			get {
				if (id_getIntentFilter == IntPtr.Zero)
					id_getIntentFilter = JNIEnv.GetStaticMethodID (class_ref, "getIntentFilter", "()Landroid/content/IntentFilter;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getIntentFilter), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isChannelInfo;
		public static unsafe bool IsChannelInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='isChannelInfo' and count(parameter)=0]"
			[Register ("isChannelInfo", "()Z", "GetIsChannelInfoHandler")]
			get {
				if (id_isChannelInfo == IntPtr.Zero)
					id_isChannelInfo = JNIEnv.GetStaticMethodID (class_ref, "isChannelInfo", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isChannelInfo);
				} finally {
				}
			}
		}

		static IntPtr id_isContextBasedChatEnabled;
		public static unsafe bool IsContextBasedChatEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='isContextBasedChatEnabled' and count(parameter)=0]"
			[Register ("isContextBasedChatEnabled", "()Z", "GetIsContextBasedChatEnabledHandler")]
			get {
				if (id_isContextBasedChatEnabled == IntPtr.Zero)
					id_isContextBasedChatEnabled = JNIEnv.GetStaticMethodID (class_ref, "isContextBasedChatEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isContextBasedChatEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_isIndividual;
		public static unsafe bool IsIndividual {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='isIndividual' and count(parameter)=0]"
			[Register ("isIndividual", "()Z", "GetIsIndividualHandler")]
			get {
				if (id_isIndividual == IntPtr.Zero)
					id_isIndividual = JNIEnv.GetStaticMethodID (class_ref, "isIndividual", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isIndividual);
				} finally {
				}
			}
		}

		static IntPtr id_isQuick;
		public static unsafe bool IsQuick {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='isQuick' and count(parameter)=0]"
			[Register ("isQuick", "()Z", "GetIsQuickHandler")]
			get {
				if (id_isQuick == IntPtr.Zero)
					id_isQuick = JNIEnv.GetStaticMethodID (class_ref, "isQuick", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isQuick);
				} finally {
				}
			}
		}

		static IntPtr id_selectMobiComKitAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='selectMobiComKitAll' and count(parameter)=0]"
		[Register ("selectMobiComKitAll", "()V", "")]
		public static unsafe void SelectMobiComKitAll ()
		{
			if (id_selectMobiComKitAll == IntPtr.Zero)
				id_selectMobiComKitAll = JNIEnv.GetStaticMethodID (class_ref, "selectMobiComKitAll", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_selectMobiComKitAll);
			} finally {
			}
		}

		static IntPtr id_sendBroadcast_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("sendBroadcast", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void SendBroadcast (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_sendBroadcast_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_sendBroadcast_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "sendBroadcast", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendBroadcast_Landroid_content_Context_Landroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_sendConversationDeleteBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendConversationDeleteBroadcast' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Integer'] and parameter[5][@type='java.lang.String']]"
		[Register ("sendConversationDeleteBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V", "")]
		public static unsafe void SendConversationDeleteBroadcast (global::Android.Content.Context p0, string p1, string p2, global::Java.Lang.Integer p3, string p4)
		{
			if (id_sendConversationDeleteBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_sendConversationDeleteBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendConversationDeleteBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendConversationDeleteBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_sendConversationReadBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendConversationReadBroadcast' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("sendConversationReadBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public static unsafe void SendConversationReadBroadcast (global::Android.Content.Context p0, string p1, string p2, bool p3)
		{
			if (id_sendConversationReadBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_sendConversationReadBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "sendConversationReadBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendConversationReadBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_sendDeliveryReportForContactBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendDeliveryReportForContactBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendDeliveryReportForContactBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SendDeliveryReportForContactBroadcast (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_sendDeliveryReportForContactBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendDeliveryReportForContactBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendDeliveryReportForContactBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendDeliveryReportForContactBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_sendFirstTimeSyncCompletedBroadcast_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendFirstTimeSyncCompletedBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("sendFirstTimeSyncCompletedBroadcast", "(Landroid/content/Context;)V", "")]
		public static unsafe void SendFirstTimeSyncCompletedBroadcast (global::Android.Content.Context p0)
		{
			if (id_sendFirstTimeSyncCompletedBroadcast_Landroid_content_Context_ == IntPtr.Zero)
				id_sendFirstTimeSyncCompletedBroadcast_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "sendFirstTimeSyncCompletedBroadcast", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendFirstTimeSyncCompletedBroadcast_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_sendLoadMoreBroadcast_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendLoadMoreBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("sendLoadMoreBroadcast", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SendLoadMoreBroadcast (global::Android.Content.Context p0, bool p1)
		{
			if (id_sendLoadMoreBroadcast_Landroid_content_Context_Z == IntPtr.Zero)
				id_sendLoadMoreBroadcast_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "sendLoadMoreBroadcast", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendLoadMoreBroadcast_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_sendMessageDeleteBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendMessageDeleteBroadcast' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("sendMessageDeleteBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SendMessageDeleteBroadcast (global::Android.Content.Context p0, string p1, string p2, string p3)
		{
			if (id_sendMessageDeleteBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessageDeleteBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendMessageDeleteBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendMessageDeleteBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_sendMessageUpdateBroadcast_Landroid_content_Context_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendMessageUpdateBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("sendMessageUpdateBroadcast", "(Landroid/content/Context;Ljava/lang/String;Lcom/applozic/mobicomkit/api/conversation/Message;)V", "")]
		public static unsafe void SendMessageUpdateBroadcast (global::Android.Content.Context p0, string p1, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p2)
		{
			if (id_sendMessageUpdateBroadcast_Landroid_content_Context_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_sendMessageUpdateBroadcast_Landroid_content_Context_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetStaticMethodID (class_ref, "sendMessageUpdateBroadcast", "(Landroid/content/Context;Ljava/lang/String;Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendMessageUpdateBroadcast_Landroid_content_Context_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendNotificationBroadcast_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendNotificationBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("sendNotificationBroadcast", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/Message;)V", "")]
		public static unsafe void SendNotificationBroadcast (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1)
		{
			if (id_sendNotificationBroadcast_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_sendNotificationBroadcast_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetStaticMethodID (class_ref, "sendNotificationBroadcast", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendNotificationBroadcast_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
			} finally {
			}
		}

		static IntPtr id_sendUpdate_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendUpdate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendUpdate", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SendUpdate (global::Android.Content.Context p0, string p1)
		{
			if (id_sendUpdate_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_sendUpdate_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendUpdate", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendUpdate_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendUpdateLastSeenAtTimeBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendUpdateLastSeenAtTimeBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendUpdateLastSeenAtTimeBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SendUpdateLastSeenAtTimeBroadcast (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_sendUpdateLastSeenAtTimeBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendUpdateLastSeenAtTimeBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendUpdateLastSeenAtTimeBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendUpdateLastSeenAtTimeBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_sendUpdateTypingBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='sendUpdateTypingBroadcast' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("sendUpdateTypingBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SendUpdateTypingBroadcast (global::Android.Content.Context p0, string p1, string p2, string p3, string p4)
		{
			if (id_sendUpdateTypingBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendUpdateTypingBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sendUpdateTypingBroadcast", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendUpdateTypingBroadcast_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_setContextBasedChat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.broadcast']/class[@name='BroadcastService']/method[@name='setContextBasedChat' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setContextBasedChat", "(Z)Z", "")]
		public static unsafe bool SetContextBasedChat (bool p0)
		{
			if (id_setContextBasedChat_Z == IntPtr.Zero)
				id_setContextBasedChat_Z = JNIEnv.GetStaticMethodID (class_ref, "setContextBasedChat", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_setContextBasedChat_Z, __args);
			} finally {
			}
		}

	}
}
