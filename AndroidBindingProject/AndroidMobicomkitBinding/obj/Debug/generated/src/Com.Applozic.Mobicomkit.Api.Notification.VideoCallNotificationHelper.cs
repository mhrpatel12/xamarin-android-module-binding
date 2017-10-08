using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/notification/VideoCallNotificationHelper", DoNotGenerateAcw=true)]
	public partial class VideoCallNotificationHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_ANSWERED']"
		[Register ("CALL_ANSWERED")]
		public const string CallAnswered = (string) "CALL_ANSWERED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_AUDIO_ONLY']"
		[Register ("CALL_AUDIO_ONLY")]
		public const string CallAudioOnly = (string) "CALL_AUDIO_ONLY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_CANCELED']"
		[Register ("CALL_CANCELED")]
		public const string CallCanceled = (string) "CALL_CANCELED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_DIALED']"
		[Register ("CALL_DIALED")]
		public const string CallDialed = (string) "CALL_DIALED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_DURATION']"
		[Register ("CALL_DURATION")]
		public const string CallDuration = (string) "CALL_DURATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_END']"
		[Register ("CALL_END")]
		public const string CallEnd = (string) "CALL_END";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_ID']"
		[Register ("CALL_ID")]
		public const string CallId = (string) "CALL_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_MISSED']"
		[Register ("CALL_MISSED")]
		public const string CallMissed = (string) "CALL_MISSED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_REJECTED']"
		[Register ("CALL_REJECTED")]
		public const string CallRejected = (string) "CALL_REJECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='CALL_STARTED']"
		[Register ("CALL_STARTED")]
		public const string CallStarted = (string) "CALL_STARTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='MAX_NOTIFICATION_RING_DURATION']"
		[Register ("MAX_NOTIFICATION_RING_DURATION")]
		public const int MaxNotificationRingDuration = (int) 60000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='MSG_TYPE']"
		[Register ("MSG_TYPE")]
		public const string MsgType = (string) "MSG_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/field[@name='NOTIFICATION_ACTIVITY_NAME']"
		[Register ("NOTIFICATION_ACTIVITY_NAME")]
		public const string NotificationActivityName = (string) "com.applozic.audiovideo.activity.CallActivity";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/notification/VideoCallNotificationHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoCallNotificationHelper); }
		}

		protected VideoCallNotificationHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/constructor[@name='VideoCallNotificationHelper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VideoCallNotificationHelper (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VideoCallNotificationHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/constructor[@name='VideoCallNotificationHelper' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Z)V", "")]
		public unsafe VideoCallNotificationHelper (global::Android.Content.Context p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (VideoCallNotificationHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Z == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static Delegate cb_getAnswerCallMetaData;
#pragma warning disable 0169
		static Delegate GetGetAnswerCallMetaDataHandler ()
		{
			if (cb_getAnswerCallMetaData == null)
				cb_getAnswerCallMetaData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnswerCallMetaData);
			return cb_getAnswerCallMetaData;
		}

		static IntPtr n_GetAnswerCallMetaData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AnswerCallMetaData);
		}
#pragma warning restore 0169

		static IntPtr id_getAnswerCallMetaData;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> AnswerCallMetaData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='getAnswerCallMetaData' and count(parameter)=0]"
			[Register ("getAnswerCallMetaData", "()Ljava/util/Map;", "GetGetAnswerCallMetaDataHandler")]
			get {
				if (id_getAnswerCallMetaData == IntPtr.Zero)
					id_getAnswerCallMetaData = JNIEnv.GetMethodID (class_ref, "getAnswerCallMetaData", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnswerCallMetaData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAnswerCallMetaData", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDialCallMetaData;
#pragma warning disable 0169
		static Delegate GetGetDialCallMetaDataHandler ()
		{
			if (cb_getDialCallMetaData == null)
				cb_getDialCallMetaData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDialCallMetaData);
			return cb_getDialCallMetaData;
		}

		static IntPtr n_GetDialCallMetaData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.DialCallMetaData);
		}
#pragma warning restore 0169

		static IntPtr id_getDialCallMetaData;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> DialCallMetaData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='getDialCallMetaData' and count(parameter)=0]"
			[Register ("getDialCallMetaData", "()Ljava/util/Map;", "GetGetDialCallMetaDataHandler")]
			get {
				if (id_getDialCallMetaData == IntPtr.Zero)
					id_getDialCallMetaData = JNIEnv.GetMethodID (class_ref, "getDialCallMetaData", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDialCallMetaData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDialCallMetaData", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMissedCallMap;
#pragma warning disable 0169
		static Delegate GetGetMissedCallMapHandler ()
		{
			if (cb_getMissedCallMap == null)
				cb_getMissedCallMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMissedCallMap);
			return cb_getMissedCallMap;
		}

		static IntPtr n_GetMissedCallMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.MissedCallMap);
		}
#pragma warning restore 0169

		static IntPtr id_getMissedCallMap;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> MissedCallMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='getMissedCallMap' and count(parameter)=0]"
			[Register ("getMissedCallMap", "()Ljava/util/Map;", "GetGetMissedCallMapHandler")]
			get {
				if (id_getMissedCallMap == IntPtr.Zero)
					id_getMissedCallMap = JNIEnv.GetMethodID (class_ref, "getMissedCallMap", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMissedCallMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMissedCallMap", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRejectedCallMap;
#pragma warning disable 0169
		static Delegate GetGetRejectedCallMapHandler ()
		{
			if (cb_getRejectedCallMap == null)
				cb_getRejectedCallMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRejectedCallMap);
			return cb_getRejectedCallMap;
		}

		static IntPtr n_GetRejectedCallMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.RejectedCallMap);
		}
#pragma warning restore 0169

		static IntPtr id_getRejectedCallMap;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> RejectedCallMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='getRejectedCallMap' and count(parameter)=0]"
			[Register ("getRejectedCallMap", "()Ljava/util/Map;", "GetGetRejectedCallMapHandler")]
			get {
				if (id_getRejectedCallMap == IntPtr.Zero)
					id_getRejectedCallMap = JNIEnv.GetMethodID (class_ref, "getRejectedCallMap", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRejectedCallMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRejectedCallMap", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoCallStartedMap;
#pragma warning disable 0169
		static Delegate GetGetVideoCallStartedMapHandler ()
		{
			if (cb_getVideoCallStartedMap == null)
				cb_getVideoCallStartedMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoCallStartedMap);
			return cb_getVideoCallStartedMap;
		}

		static IntPtr n_GetVideoCallStartedMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.VideoCallStartedMap);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoCallStartedMap;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> VideoCallStartedMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='getVideoCallStartedMap' and count(parameter)=0]"
			[Register ("getVideoCallStartedMap", "()Ljava/util/Map;", "GetGetVideoCallStartedMapHandler")]
			get {
				if (id_getVideoCallStartedMap == IntPtr.Zero)
					id_getVideoCallStartedMap = JNIEnv.GetMethodID (class_ref, "getVideoCallStartedMap", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoCallStartedMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoCallStartedMap", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoCanceledMap;
#pragma warning disable 0169
		static Delegate GetGetVideoCanceledMapHandler ()
		{
			if (cb_getVideoCanceledMap == null)
				cb_getVideoCanceledMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoCanceledMap);
			return cb_getVideoCanceledMap;
		}

		static IntPtr n_GetVideoCanceledMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.VideoCanceledMap);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoCanceledMap;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> VideoCanceledMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='getVideoCanceledMap' and count(parameter)=0]"
			[Register ("getVideoCanceledMap", "()Ljava/util/Map;", "GetGetVideoCanceledMapHandler")]
			get {
				if (id_getVideoCanceledMap == IntPtr.Zero)
					id_getVideoCanceledMap = JNIEnv.GetMethodID (class_ref, "getVideoCanceledMap", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoCanceledMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoCanceledMap", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_buildVideoCallNotification_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='buildVideoCallNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("buildVideoCallNotification", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/Message;)V", "")]
		public static unsafe void BuildVideoCallNotification (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1)
		{
			if (id_buildVideoCallNotification_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_buildVideoCallNotification_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetStaticMethodID (class_ref, "buildVideoCallNotification", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_buildVideoCallNotification_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
			} finally {
			}
		}

		static IntPtr id_getStatus_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='getStatus' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getStatus", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetStatus (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_getStatus_Ljava_util_Map_ == IntPtr.Zero)
				id_getStatus_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "getStatus", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStatus_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getVideoCallEndMap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetVideoCallEndMap_Ljava_lang_String_Handler ()
		{
			if (cb_getVideoCallEndMap_Ljava_lang_String_ == null)
				cb_getVideoCallEndMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetVideoCallEndMap_Ljava_lang_String_);
			return cb_getVideoCallEndMap_Ljava_lang_String_;
		}

		static IntPtr n_GetVideoCallEndMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetVideoCallEndMap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoCallEndMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='getVideoCallEndMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getVideoCallEndMap", "(Ljava/lang/String;)Ljava/util/Map;", "GetGetVideoCallEndMap_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetVideoCallEndMap (string p0)
		{
			if (id_getVideoCallEndMap_Ljava_lang_String_ == IntPtr.Zero)
				id_getVideoCallEndMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getVideoCallEndMap", "(Ljava/lang/String;)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, string> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoCallEndMap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoCallEndMap", "(Ljava/lang/String;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_handleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetHandleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_handleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_handleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_handleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_HandleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleVideoCallNotificationMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='handleVideoCallNotificationMessages' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("handleVideoCallNotificationMessages", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetHandleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void HandleVideoCallNotificationMessages (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_handleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_handleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "handleVideoCallNotificationMessages", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleVideoCallNotificationMessages_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleVideoCallNotificationMessages", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static IntPtr id_isAudioCall_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='isAudioCall' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("isAudioCall", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Z", "")]
		public static unsafe bool IsAudioCall (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_isAudioCall_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_isAudioCall_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetStaticMethodID (class_ref, "isAudioCall", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAudioCall_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isMissedCall_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='isMissedCall' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("isMissedCall", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Z", "")]
		public static unsafe bool IsMissedCall (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_isMissedCall_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_isMissedCall_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetStaticMethodID (class_ref, "isMissedCall", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMissedCall_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetSendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_sendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_sendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_sendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static IntPtr n_SendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendAudioCallRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='sendAudioCallRequest' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("sendAudioCallRequest", "(Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;", "GetSendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe string SendAudioCallRequest (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_sendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_sendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "sendAudioCallRequest", "(Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendAudioCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAudioCallRequest", "(Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler ()
		{
			if (cb_sendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == null)
				cb_sendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_);
			return cb_sendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		}

		static void n_SendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendCallMissed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='sendCallMissed' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendCallMissed", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V", "GetSendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler")]
		public virtual unsafe void SendCallMissed (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, string p1)
		{
			if (id_sendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == IntPtr.Zero)
				id_sendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendCallMissed", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCallMissed_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendCallMissed", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler ()
		{
			if (cb_sendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == null)
				cb_sendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_);
			return cb_sendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		}

		static void n_SendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendVideoCallAnswer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='sendVideoCallAnswer' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendVideoCallAnswer", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V", "GetSendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler")]
		public virtual unsafe void SendVideoCallAnswer (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, string p1)
		{
			if (id_sendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == IntPtr.Zero)
				id_sendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendVideoCallAnswer", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendVideoCallAnswer_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendVideoCallAnswer", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendVideoCallEnd (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='sendVideoCallEnd' and count(parameter)=3 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendVideoCallEnd", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;Ljava/lang/String;)V", "GetSendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SendVideoCallEnd (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, string p1, string p2)
		{
			if (id_sendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendVideoCallEnd", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendVideoCallEnd_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendVideoCallEnd", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_sendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler ()
		{
			if (cb_sendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == null)
				cb_sendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_);
			return cb_sendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		}

		static void n_SendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendVideoCallMissedMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='sendVideoCallMissedMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendVideoCallMissedMessage", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V", "GetSendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler")]
		public virtual unsafe void SendVideoCallMissedMessage (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, string p1)
		{
			if (id_sendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == IntPtr.Zero)
				id_sendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendVideoCallMissedMessage", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendVideoCallMissedMessage_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendVideoCallMissedMessage", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler ()
		{
			if (cb_sendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == null)
				cb_sendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_);
			return cb_sendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		}

		static void n_SendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendVideoCallReject (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='sendVideoCallReject' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendVideoCallReject", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V", "GetSendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler")]
		public virtual unsafe void SendVideoCallReject (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, string p1)
		{
			if (id_sendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == IntPtr.Zero)
				id_sendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendVideoCallReject", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendVideoCallReject_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendVideoCallReject", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetSendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static IntPtr n_SendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendVideoCallRequest (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='sendVideoCallRequest' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("sendVideoCallRequest", "(Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;", "GetSendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe string SendVideoCallRequest (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "sendVideoCallRequest", "(Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendVideoCallRequest", "(Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z;
#pragma warning disable 0169
		static Delegate GetSendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ZHandler ()
		{
			if (cb_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z == null)
				cb_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_SendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z);
			return cb_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z;
		}

		static IntPtr n_SendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendVideoCallRequest (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='sendVideoCallRequest' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='boolean']]"
		[Register ("sendVideoCallRequest", "(Lcom/applozic/mobicommons/people/contact/Contact;Z)Ljava/lang/String;", "GetSendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_ZHandler")]
		public virtual unsafe string SendVideoCallRequest (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, bool p1)
		{
			if (id_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z == IntPtr.Zero)
				id_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z = JNIEnv.GetMethodID (class_ref, "sendVideoCallRequest", "(Lcom/applozic/mobicommons/people/contact/Contact;Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendVideoCallRequest_Lcom_applozic_mobicommons_people_contact_Contact_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendVideoCallRequest", "(Lcom/applozic/mobicommons/people/contact/Contact;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler ()
		{
			if (cb_sendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == null)
				cb_sendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_);
			return cb_sendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		}

		static void n_SendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.VideoCallNotificationHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendVideoCallStarted (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='VideoCallNotificationHelper']/method[@name='sendVideoCallStarted' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendVideoCallStarted", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V", "GetSendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Handler")]
		public virtual unsafe void SendVideoCallStarted (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, string p1)
		{
			if (id_sendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ == IntPtr.Zero)
				id_sendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendVideoCallStarted", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendVideoCallStarted_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendVideoCallStarted", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
