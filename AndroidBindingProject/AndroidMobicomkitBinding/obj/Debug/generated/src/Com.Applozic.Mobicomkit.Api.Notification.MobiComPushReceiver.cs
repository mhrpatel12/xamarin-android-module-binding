using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/notification/MobiComPushReceiver", DoNotGenerateAcw=true)]
	public partial class MobiComPushReceiver : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/field[@name='BLOCKED_TO']"
		[Register ("BLOCKED_TO")]
		public const string BlockedTo = (string) "BLOCKED_TO";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/field[@name='MTCOM_PREFIX']"
		[Register ("MTCOM_PREFIX")]
		public const string MtcomPrefix = (string) "APPLOZIC_";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/field[@name='UNBLOCKED_TO']"
		[Register ("UNBLOCKED_TO")]
		public const string UnblockedTo = (string) "UNBLOCKED_TO";

		static IntPtr notificationKeyList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/field[@name='notificationKeyList']"
		[Register ("notificationKeyList")]
		public static global::System.Collections.IList NotificationKeyList {
			get {
				if (notificationKeyList_jfieldId == IntPtr.Zero)
					notificationKeyList_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "notificationKeyList", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, notificationKeyList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/notification/MobiComPushReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobiComPushReceiver); }
		}

		protected MobiComPushReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/constructor[@name='MobiComPushReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobiComPushReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MobiComPushReceiver)) {
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

		static IntPtr id_addPushNotificationId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='addPushNotificationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPushNotificationId", "(Ljava/lang/String;)V", "")]
		public static unsafe void AddPushNotificationId (string p0)
		{
			if (id_addPushNotificationId_Ljava_lang_String_ == IntPtr.Zero)
				id_addPushNotificationId_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addPushNotificationId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addPushNotificationId_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isMobiComPushNotification_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='isMobiComPushNotification' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("isMobiComPushNotification", "(Landroid/content/Intent;)Z", "")]
		public static unsafe bool IsMobiComPushNotification (global::Android.Content.Intent p0)
		{
			if (id_isMobiComPushNotification_Landroid_content_Intent_ == IntPtr.Zero)
				id_isMobiComPushNotification_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "isMobiComPushNotification", "(Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMobiComPushNotification_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isMobiComPushNotification_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='isMobiComPushNotification' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("isMobiComPushNotification", "(Landroid/os/Bundle;)Z", "")]
		public static unsafe bool IsMobiComPushNotification (global::Android.OS.Bundle p0)
		{
			if (id_isMobiComPushNotification_Landroid_os_Bundle_ == IntPtr.Zero)
				id_isMobiComPushNotification_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "isMobiComPushNotification", "(Landroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMobiComPushNotification_Landroid_os_Bundle_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isMobiComPushNotification_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='isMobiComPushNotification' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("isMobiComPushNotification", "(Ljava/util/Map;)Z", "")]
		public static unsafe bool IsMobiComPushNotification (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_isMobiComPushNotification_Ljava_util_Map_ == IntPtr.Zero)
				id_isMobiComPushNotification_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "isMobiComPushNotification", "(Ljava/util/Map;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMobiComPushNotification_Ljava_util_Map_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_processMessage_Landroid_content_Context_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='processMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("processMessage", "(Landroid/content/Context;Landroid/os/Bundle;)V", "")]
		public static unsafe void ProcessMessage (global::Android.Content.Context p0, global::Android.OS.Bundle p1)
		{
			if (id_processMessage_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
				id_processMessage_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "processMessage", "(Landroid/content/Context;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_processMessage_Landroid_content_Context_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_processMessage_Landroid_content_Context_Landroid_os_Bundle_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='processMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("processMessage", "(Landroid/content/Context;Landroid/os/Bundle;Ljava/util/Map;)V", "")]
		public static unsafe void ProcessMessage (global::Android.Content.Context p0, global::Android.OS.Bundle p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_processMessage_Landroid_content_Context_Landroid_os_Bundle_Ljava_util_Map_ == IntPtr.Zero)
				id_processMessage_Landroid_content_Context_Landroid_os_Bundle_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "processMessage", "(Landroid/content/Context;Landroid/os/Bundle;Ljava/util/Map;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_processMessage_Landroid_content_Context_Landroid_os_Bundle_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_processMessage_Landroid_content_Context_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='processMessage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("processMessage", "(Landroid/content/Context;Ljava/util/Map;)V", "")]
		public static unsafe void ProcessMessage (global::Android.Content.Context p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_processMessage_Landroid_content_Context_Ljava_util_Map_ == IntPtr.Zero)
				id_processMessage_Landroid_content_Context_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "processMessage", "(Landroid/content/Context;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_processMessage_Landroid_content_Context_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_processMessageAsync_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='processMessageAsync' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("processMessageAsync", "(Landroid/content/Context;Landroid/content/Intent;)V", "")]
		public static unsafe void ProcessMessageAsync (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_processMessageAsync_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_processMessageAsync_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "processMessageAsync", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_processMessageAsync_Landroid_content_Context_Landroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_processMessageAsync_Landroid_content_Context_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='processMessageAsync' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("processMessageAsync", "(Landroid/content/Context;Landroid/os/Bundle;)V", "")]
		public static unsafe void ProcessMessageAsync (global::Android.Content.Context p0, global::Android.OS.Bundle p1)
		{
			if (id_processMessageAsync_Landroid_content_Context_Landroid_os_Bundle_ == IntPtr.Zero)
				id_processMessageAsync_Landroid_content_Context_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "processMessageAsync", "(Landroid/content/Context;Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_processMessageAsync_Landroid_content_Context_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_processMessageAsync_Landroid_content_Context_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='processMessageAsync' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("processMessageAsync", "(Landroid/content/Context;Ljava/util/Map;)V", "")]
		public static unsafe void ProcessMessageAsync (global::Android.Content.Context p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_processMessageAsync_Landroid_content_Context_Ljava_util_Map_ == IntPtr.Zero)
				id_processMessageAsync_Landroid_content_Context_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "processMessageAsync", "(Landroid/content/Context;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_processMessageAsync_Landroid_content_Context_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_processPushNotificationId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MobiComPushReceiver']/method[@name='processPushNotificationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("processPushNotificationId", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ProcessPushNotificationId (string p0)
		{
			if (id_processPushNotificationId_Ljava_lang_String_ == IntPtr.Zero)
				id_processPushNotificationId_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "processPushNotificationId", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_processPushNotificationId_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
