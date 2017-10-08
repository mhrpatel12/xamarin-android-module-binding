using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/MobiComKitConstants", DoNotGenerateAcw=true)]
	public partial class MobiComKitConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='ACTIVITY_TO_OPEN']"
		[Register ("ACTIVITY_TO_OPEN")]
		public const string ActivityToOpen = (string) "ACTIVITY_TO_OPEN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='AL_MESSAGE']"
		[Register ("AL_MESSAGE")]
		public const string AlMessage = (string) "AL_MESSAGE";

		static IntPtr APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP']"
		[Register ("APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP")]
		public static string ApplicationActivityToOpenOnChatToolbarTap {
			get {
				if (APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP_jfieldId == IntPtr.Zero)
					APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP_jfieldId == IntPtr.Zero)
					APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPLICATION_ACTIVITY_TO_OPEN_ON_CHAT_TOOLBAR_TAP_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='APPLICATION_INFO_RESPONSE']"
		[Register ("APPLICATION_INFO_RESPONSE")]
		public const string ApplicationInfoResponse = (string) "\"success\"";

		static IntPtr APPLICATION_KEY_META_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='APPLICATION_KEY_META_DATA']"
		[Register ("APPLICATION_KEY_META_DATA")]
		public static string ApplicationKeyMetaData {
			get {
				if (APPLICATION_KEY_META_DATA_jfieldId == IntPtr.Zero)
					APPLICATION_KEY_META_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_KEY_META_DATA", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_KEY_META_DATA_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPLICATION_KEY_META_DATA_jfieldId == IntPtr.Zero)
					APPLICATION_KEY_META_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_KEY_META_DATA", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPLICATION_KEY_META_DATA_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr APPLICATION_LOGIN_ACTIVITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='APPLICATION_LOGIN_ACTIVITY']"
		[Register ("APPLICATION_LOGIN_ACTIVITY")]
		public static string ApplicationLoginActivity {
			get {
				if (APPLICATION_LOGIN_ACTIVITY_jfieldId == IntPtr.Zero)
					APPLICATION_LOGIN_ACTIVITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_LOGIN_ACTIVITY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_LOGIN_ACTIVITY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPLICATION_LOGIN_ACTIVITY_jfieldId == IntPtr.Zero)
					APPLICATION_LOGIN_ACTIVITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_LOGIN_ACTIVITY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPLICATION_LOGIN_ACTIVITY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='APPLOZIC_UNREAD_COUNT']"
		[Register ("APPLOZIC_UNREAD_COUNT")]
		public const string ApplozicUnreadCount = (string) "APPLOZIC_UNREAD_COUNT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='APPLOZIC_VIDEO_CALL_ANSWER']"
		[Register ("APPLOZIC_VIDEO_CALL_ANSWER")]
		public const string ApplozicVideoCallAnswer = (string) "applozic.video.call.answer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='APPLOZIC_VIDEO_CALL_REJECTED']"
		[Register ("APPLOZIC_VIDEO_CALL_REJECTED")]
		public const string ApplozicVideoCallRejected = (string) "applozic.video.call.rejected";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='APPLOZIC_VIDEO_DIALED']"
		[Register ("APPLOZIC_VIDEO_DIALED")]
		public const string ApplozicVideoDialed = (string) "applozic.video.call.dialed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='ATTACHMENT']"
		[Register ("ATTACHMENT")]
		public const string Attachment = (string) "Attachment";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='AUDIO']"
		[Register ("AUDIO")]
		public const string Audio = (string) "Audio";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='CONTACT_ID']"
		[Register ("CONTACT_ID")]
		public const string ContactId = (string) "contactId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const string Error = (string) "error";

		static IntPtr GROUP_USER_LIMIT_EXCEED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='GROUP_USER_LIMIT_EXCEED']"
		[Register ("GROUP_USER_LIMIT_EXCEED")]
		public static string GroupUserLimitExceed {
			get {
				if (GROUP_USER_LIMIT_EXCEED_jfieldId == IntPtr.Zero)
					GROUP_USER_LIMIT_EXCEED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP_USER_LIMIT_EXCEED", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUP_USER_LIMIT_EXCEED_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GROUP_USER_LIMIT_EXCEED_jfieldId == IntPtr.Zero)
					GROUP_USER_LIMIT_EXCEED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUP_USER_LIMIT_EXCEED", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, GROUP_USER_LIMIT_EXCEED_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='HIDDEN']"
		[Register ("HIDDEN")]
		public const string Hidden = (string) "HIDDEN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='LOCATION']"
		[Register ("LOCATION")]
		public const string Location = (string) "Location";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='MESSAGE']"
		[Register ("MESSAGE")]
		public const string Message = (string) "MESSAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='MESSAGE_JSON_INTENT']"
		[Register ("MESSAGE_JSON_INTENT")]
		public const string MessageJsonIntent = (string) "message_json";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='PACKAGE_NAME']"
		[Register ("PACKAGE_NAME")]
		public const string PackageName = (string) "com.package.name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='PUSH_NOTIFICATION']"
		[Register ("PUSH_NOTIFICATION")]
		public const string PushNotification = (string) "PUSH_NOTIFICATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='QUICK_LIST']"
		[Register ("QUICK_LIST")]
		public const string QuickList = (string) "QUICK_LIST";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const string Success = (string) "success";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/field[@name='VIDEO']"
		[Register ("VIDEO")]
		public const string Video = (string) "Video";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/MobiComKitConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobiComKitConstants); }
		}

		protected MobiComKitConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitConstants']/constructor[@name='MobiComKitConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobiComKitConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MobiComKitConstants)) {
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

	}
}
