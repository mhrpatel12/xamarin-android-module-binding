using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/ApplozicMqttService", DoNotGenerateAcw=true)]
	public partial class ApplozicMqttService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class NOTIFICATION_TYPE : global::Java.Lang.Enum {


			static IntPtr ACTIVATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='ACTIVATED']"
			[Register ("ACTIVATED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE Activated {
				get {
					if (ACTIVATED_jfieldId == IntPtr.Zero)
						ACTIVATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTIVATED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTIVATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APPLOZIC_TEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='APPLOZIC_TEST']"
			[Register ("APPLOZIC_TEST")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE ApplozicTest {
				get {
					if (APPLOZIC_TEST_jfieldId == IntPtr.Zero)
						APPLOZIC_TEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLOZIC_TEST", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLOZIC_TEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONTACT_SYNC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='CONTACT_SYNC']"
			[Register ("CONTACT_SYNC")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE ContactSync {
				get {
					if (CONTACT_SYNC_jfieldId == IntPtr.Zero)
						CONTACT_SYNC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTACT_SYNC", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTACT_SYNC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONVERSATION_DELETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='CONVERSATION_DELETED']"
			[Register ("CONVERSATION_DELETED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE ConversationDeleted {
				get {
					if (CONVERSATION_DELETED_jfieldId == IntPtr.Zero)
						CONVERSATION_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_DELETED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_DELETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONVERSATION_DELIVERED_AND_READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='CONVERSATION_DELIVERED_AND_READ']"
			[Register ("CONVERSATION_DELIVERED_AND_READ")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE ConversationDeliveredAndRead {
				get {
					if (CONVERSATION_DELIVERED_AND_READ_jfieldId == IntPtr.Zero)
						CONVERSATION_DELIVERED_AND_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_DELIVERED_AND_READ", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_DELIVERED_AND_READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONVERSATION_READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='CONVERSATION_READ']"
			[Register ("CONVERSATION_READ")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE ConversationRead {
				get {
					if (CONVERSATION_READ_jfieldId == IntPtr.Zero)
						CONVERSATION_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONVERSATION_READ", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONVERSATION_READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DEACTIVATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='DEACTIVATED']"
			[Register ("DEACTIVATED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE Deactivated {
				get {
					if (DEACTIVATED_jfieldId == IntPtr.Zero)
						DEACTIVATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEACTIVATED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEACTIVATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GROUP_CONVERSATION_DELETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='GROUP_CONVERSATION_DELETED']"
			[Register ("GROUP_CONVERSATION_DELETED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE GroupConversationDeleted {
				get {
					if (GROUP_CONVERSATION_DELETED_jfieldId == IntPtr.Zero)
						GROUP_CONVERSATION_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP_CONVERSATION_DELETED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUP_CONVERSATION_DELETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GROUP_CONVERSATION_READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='GROUP_CONVERSATION_READ']"
			[Register ("GROUP_CONVERSATION_READ")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE GroupConversationRead {
				get {
					if (GROUP_CONVERSATION_READ_jfieldId == IntPtr.Zero)
						GROUP_CONVERSATION_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP_CONVERSATION_READ", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUP_CONVERSATION_READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GROUP_DELETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='GROUP_DELETED']"
			[Register ("GROUP_DELETED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE GroupDeleted {
				get {
					if (GROUP_DELETED_jfieldId == IntPtr.Zero)
						GROUP_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP_DELETED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUP_DELETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GROUP_LEFT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='GROUP_LEFT']"
			[Register ("GROUP_LEFT")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE GroupLeft {
				get {
					if (GROUP_LEFT_jfieldId == IntPtr.Zero)
						GROUP_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP_LEFT", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUP_LEFT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GROUP_MESSAGE_DELETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='GROUP_MESSAGE_DELETED']"
			[Register ("GROUP_MESSAGE_DELETED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE GroupMessageDeleted {
				get {
					if (GROUP_MESSAGE_DELETED_jfieldId == IntPtr.Zero)
						GROUP_MESSAGE_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP_MESSAGE_DELETED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUP_MESSAGE_DELETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GROUP_SYNC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='GROUP_SYNC']"
			[Register ("GROUP_SYNC")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE GroupSync {
				get {
					if (GROUP_SYNC_jfieldId == IntPtr.Zero)
						GROUP_SYNC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP_SYNC", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUP_SYNC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_DELETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='MESSAGE_DELETED']"
			[Register ("MESSAGE_DELETED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE MessageDeleted {
				get {
					if (MESSAGE_DELETED_jfieldId == IntPtr.Zero)
						MESSAGE_DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_DELETED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_DELETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_DELIVERED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='MESSAGE_DELIVERED']"
			[Register ("MESSAGE_DELIVERED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE MessageDelivered {
				get {
					if (MESSAGE_DELIVERED_jfieldId == IntPtr.Zero)
						MESSAGE_DELIVERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_DELIVERED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_DELIVERED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_DELIVERED_AND_READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='MESSAGE_DELIVERED_AND_READ']"
			[Register ("MESSAGE_DELIVERED_AND_READ")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE MessageDeliveredAndRead {
				get {
					if (MESSAGE_DELIVERED_AND_READ_jfieldId == IntPtr.Zero)
						MESSAGE_DELIVERED_AND_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_DELIVERED_AND_READ", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_DELIVERED_AND_READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_READ_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='MESSAGE_READ']"
			[Register ("MESSAGE_READ")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE MessageRead {
				get {
					if (MESSAGE_READ_jfieldId == IntPtr.Zero)
						MESSAGE_READ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_READ", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_READ_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_RECEIVED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='MESSAGE_RECEIVED']"
			[Register ("MESSAGE_RECEIVED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE MessageReceived {
				get {
					if (MESSAGE_RECEIVED_jfieldId == IntPtr.Zero)
						MESSAGE_RECEIVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_RECEIVED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_RECEIVED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='MESSAGE_SENT']"
			[Register ("MESSAGE_SENT")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE MessageSent {
				get {
					if (MESSAGE_SENT_jfieldId == IntPtr.Zero)
						MESSAGE_SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_SENT", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGE_SENT_UPDATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='MESSAGE_SENT_UPDATE']"
			[Register ("MESSAGE_SENT_UPDATE")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE MessageSentUpdate {
				get {
					if (MESSAGE_SENT_UPDATE_jfieldId == IntPtr.Zero)
						MESSAGE_SENT_UPDATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGE_SENT_UPDATE", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGE_SENT_UPDATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REGISTRATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='REGISTRATION']"
			[Register ("REGISTRATION")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE Registration {
				get {
					if (REGISTRATION_jfieldId == IntPtr.Zero)
						REGISTRATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REGISTRATION", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REGISTRATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_BLOCKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='USER_BLOCKED']"
			[Register ("USER_BLOCKED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE UserBlocked {
				get {
					if (USER_BLOCKED_jfieldId == IntPtr.Zero)
						USER_BLOCKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_BLOCKED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_BLOCKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_CONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='USER_CONNECTED']"
			[Register ("USER_CONNECTED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE UserConnected {
				get {
					if (USER_CONNECTED_jfieldId == IntPtr.Zero)
						USER_CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_CONNECTED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_CONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_DISCONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='USER_DISCONNECTED']"
			[Register ("USER_DISCONNECTED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE UserDisconnected {
				get {
					if (USER_DISCONNECTED_jfieldId == IntPtr.Zero)
						USER_DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_DISCONNECTED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_DISCONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_ONLINE_STATUS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='USER_ONLINE_STATUS']"
			[Register ("USER_ONLINE_STATUS")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE UserOnlineStatus {
				get {
					if (USER_ONLINE_STATUS_jfieldId == IntPtr.Zero)
						USER_ONLINE_STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_ONLINE_STATUS", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_ONLINE_STATUS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_UN_BLOCKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/field[@name='USER_UN_BLOCKED']"
			[Register ("USER_UN_BLOCKED")]
			public static global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE UserUnBlocked {
				get {
					if (USER_UN_BLOCKED_jfieldId == IntPtr.Zero)
						USER_UN_BLOCKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_UN_BLOCKED", "Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_UN_BLOCKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NOTIFICATION_TYPE); }
			}

			internal NOTIFICATION_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/method[@name='getValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService.NOTIFICATION_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/ApplozicMqttService$NOTIFICATION_TYPE;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService.NOTIFICATION_TYPE));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/ApplozicMqttService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicMqttService); }
		}

		protected ApplozicMqttService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_connectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_connectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_connectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_connectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ConnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ConnectPublish (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_connectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='connectPublish' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("connectPublish", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetConnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ConnectPublish (string p0, string p1, string p2)
		{
			if (id_connectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_connectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "connectPublish", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectPublish", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_connectionLost_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetConnectionLost_Ljava_lang_Throwable_Handler ()
		{
			if (cb_connectionLost_Ljava_lang_Throwable_ == null)
				cb_connectionLost_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ConnectionLost_Ljava_lang_Throwable_);
			return cb_connectionLost_Ljava_lang_Throwable_;
		}

		static void n_ConnectionLost_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionLost (p0);
		}
#pragma warning restore 0169

		static IntPtr id_connectionLost_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='connectionLost' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("connectionLost", "(Ljava/lang/Throwable;)V", "GetConnectionLost_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void ConnectionLost (global::Java.Lang.Throwable p0)
		{
			if (id_connectionLost_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_connectionLost_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "connectionLost", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectionLost_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectionLost", "(Ljava/lang/Throwable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
#pragma warning disable 0169
		static Delegate GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_Handler ()
		{
			if (cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ == null)
				cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_);
			return cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
		}

		static void n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttDeliveryToken']]"
		[Register ("deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V", "GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_Handler")]
		public virtual unsafe void DeliveryComplete (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken p0)
		{
			if (id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ == IntPtr.Zero)
				id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_ = JNIEnv.GetMethodID (class_ref, "deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_IMqttDeliveryToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public virtual unsafe void Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_disconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_disconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_disconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DisconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_disconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DisconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectPublish (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_disconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='disconnectPublish' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("disconnectPublish", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetDisconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void DisconnectPublish (string p0, string p1, string p2)
		{
			if (id_disconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnectPublish", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectPublish_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectPublish", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/ApplozicMqttService;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/ApplozicMqttService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetMessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static void n_MessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrived (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='messageArrived' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V", "GetMessageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		public virtual unsafe void MessageArrived (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1)
		{
			if (id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == IntPtr.Zero)
				id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNIEnv.GetMethodID (class_ref, "messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_messageArrived_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "messageArrived", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_publishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPublishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_publishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_publishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PublishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_publishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PublishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.PublishTopic (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_publishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='publishTopic' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("publishTopic", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetPublishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PublishTopic (string p0, string p1, string p2, string p3)
		{
			if (id_publishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_publishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "publishTopic", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_publishTopic_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publishTopic", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_subscribe;
#pragma warning disable 0169
		static Delegate GetSubscribeHandler ()
		{
			if (cb_subscribe == null)
				cb_subscribe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Subscribe);
			return cb_subscribe;
		}

		static void n_Subscribe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe ();
		}
#pragma warning restore 0169

		static IntPtr id_subscribe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='subscribe' and count(parameter)=0]"
		[Register ("subscribe", "()V", "GetSubscribeHandler")]
		public virtual unsafe void Subscribe ()
		{
			if (id_subscribe == IntPtr.Zero)
				id_subscribe = JNIEnv.GetMethodID (class_ref, "subscribe", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "()V"));
			} finally {
			}
		}

		static Delegate cb_subscribeToConversation;
#pragma warning disable 0169
		static Delegate GetSubscribeToConversationHandler ()
		{
			if (cb_subscribeToConversation == null)
				cb_subscribeToConversation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SubscribeToConversation);
			return cb_subscribeToConversation;
		}

		static void n_SubscribeToConversation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubscribeToConversation ();
		}
#pragma warning restore 0169

		static IntPtr id_subscribeToConversation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='subscribeToConversation' and count(parameter)=0]"
		[Register ("subscribeToConversation", "()V", "GetSubscribeToConversationHandler")]
		public virtual unsafe void SubscribeToConversation ()
		{
			if (id_subscribeToConversation == IntPtr.Zero)
				id_subscribeToConversation = JNIEnv.GetMethodID (class_ref, "subscribeToConversation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeToConversation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribeToConversation", "()V"));
			} finally {
			}
		}

		static Delegate cb_subscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_subscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_subscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_subscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_SubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubscribeToTypingTopic (p0);
		}
#pragma warning restore 0169

		static IntPtr id_subscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='subscribeToTypingTopic' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("subscribeToTypingTopic", "(Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe void SubscribeToTypingTopic (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
		{
			if (id_subscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_subscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "subscribeToTypingTopic", "(Lcom/applozic/mobicommons/people/channel/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribeToTypingTopic", "(Lcom/applozic/mobicommons/people/channel/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_typingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetTypingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_typingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_typingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TypingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_typingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_TypingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TypingStarted (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_typingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='typingStarted' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("typingStarted", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetTypingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe void TypingStarted (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1)
		{
			if (id_typingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_typingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "typingStarted", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_typingStarted_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "typingStarted", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_typingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetTypingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_typingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_typingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TypingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_typingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_TypingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TypingStopped (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_typingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='typingStopped' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("typingStopped", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetTypingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe void TypingStopped (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1)
		{
			if (id_typingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_typingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "typingStopped", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_typingStopped_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "typingStopped", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unSubscribe;
#pragma warning disable 0169
		static Delegate GetUnSubscribeHandler ()
		{
			if (cb_unSubscribe == null)
				cb_unSubscribe = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnSubscribe);
			return cb_unSubscribe;
		}

		static void n_UnSubscribe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnSubscribe ();
		}
#pragma warning restore 0169

		static IntPtr id_unSubscribe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='unSubscribe' and count(parameter)=0]"
		[Register ("unSubscribe", "()V", "GetUnSubscribeHandler")]
		public virtual unsafe void UnSubscribe ()
		{
			if (id_unSubscribe == IntPtr.Zero)
				id_unSubscribe = JNIEnv.GetMethodID (class_ref, "unSubscribe", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unSubscribe);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unSubscribe", "()V"));
			} finally {
			}
		}

		static Delegate cb_unSubscribeToConversation;
#pragma warning disable 0169
		static Delegate GetUnSubscribeToConversationHandler ()
		{
			if (cb_unSubscribeToConversation == null)
				cb_unSubscribeToConversation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnSubscribeToConversation);
			return cb_unSubscribeToConversation;
		}

		static void n_UnSubscribeToConversation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnSubscribeToConversation ();
		}
#pragma warning restore 0169

		static IntPtr id_unSubscribeToConversation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='unSubscribeToConversation' and count(parameter)=0]"
		[Register ("unSubscribeToConversation", "()V", "GetUnSubscribeToConversationHandler")]
		public virtual unsafe void UnSubscribeToConversation ()
		{
			if (id_unSubscribeToConversation == IntPtr.Zero)
				id_unSubscribeToConversation = JNIEnv.GetMethodID (class_ref, "unSubscribeToConversation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unSubscribeToConversation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unSubscribeToConversation", "()V"));
			} finally {
			}
		}

		static Delegate cb_unSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetUnSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_unSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_unSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_unSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_UnSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.ApplozicMqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnSubscribeToTypingTopic (p0);
		}
#pragma warning restore 0169

		static IntPtr id_unSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='ApplozicMqttService']/method[@name='unSubscribeToTypingTopic' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("unSubscribeToTypingTopic", "(Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetUnSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe void UnSubscribeToTypingTopic (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
		{
			if (id_unSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_unSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "unSubscribeToTypingTopic", "(Lcom/applozic/mobicommons/people/channel/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unSubscribeToTypingTopic_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unSubscribeToTypingTopic", "(Lcom/applozic/mobicommons/people/channel/Channel;)V"), __args);
			} finally {
			}
		}

	}
}
