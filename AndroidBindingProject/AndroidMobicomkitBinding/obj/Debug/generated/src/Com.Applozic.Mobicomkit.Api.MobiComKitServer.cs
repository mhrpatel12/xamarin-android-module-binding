using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/MobiComKitServer", DoNotGenerateAcw=true)]
	public partial class MobiComKitServer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='APP_SERVER_URL']"
		[Register ("APP_SERVER_URL")]
		public const string AppServerUrl = (string) "xxx";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='CONTACT_SYNC_COMPLETE_URL']"
		[Register ("CONTACT_SYNC_COMPLETE_URL")]
		public const string ContactSyncCompleteUrl = (string) "/rest/ws/contact/syncCompleted?suUserKeyString";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='ERROR_BASE_URL']"
		[Register ("ERROR_BASE_URL")]
		public const string ErrorBaseUrl = (string) "https://osu-alpha.appspot.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='FREE_MESSAGE_FAILED_URL']"
		[Register ("FREE_MESSAGE_FAILED_URL")]
		public const string FreeMessageFailedUrl = (string) "/rest/ws/sms/mtext/failed?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='PROD']"
		[Register ("PROD")]
		public const bool Prod = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='PROD_DISPLAY_URL']"
		[Register ("PROD_DISPLAY_URL")]
		public const string ProdDisplayUrl = (string) "https://apps.applozic.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='SERVER_CONTACT_SYNC_URL']"
		[Register ("SERVER_CONTACT_SYNC_URL")]
		public const string ServerContactSyncUrl = (string) "/rest/ws/contact/v1/add";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='SERVER_DEVICE_CONTACT_SYNC_URL']"
		[Register ("SERVER_DEVICE_CONTACT_SYNC_URL")]
		public const string ServerDeviceContactSyncUrl = (string) "/rest/ws/contact/v1/device/add";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='SUBMIT_ERROR_URL']"
		[Register ("SUBMIT_ERROR_URL")]
		public const string SubmitErrorUrl = (string) "https://osu-alpha.appspot.com/rest/ws/error/submit";

		static IntPtr SUPPORT_PHONE_NUMBER_METADATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/field[@name='SUPPORT_PHONE_NUMBER_METADATA']"
		[Register ("SUPPORT_PHONE_NUMBER_METADATA")]
		public static string SupportPhoneNumberMetadata {
			get {
				if (SUPPORT_PHONE_NUMBER_METADATA_jfieldId == IntPtr.Zero)
					SUPPORT_PHONE_NUMBER_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPORT_PHONE_NUMBER_METADATA", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUPPORT_PHONE_NUMBER_METADATA_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SUPPORT_PHONE_NUMBER_METADATA_jfieldId == IntPtr.Zero)
					SUPPORT_PHONE_NUMBER_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPORT_PHONE_NUMBER_METADATA", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SUPPORT_PHONE_NUMBER_METADATA_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/MobiComKitServer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobiComKitServer); }
		}

		protected MobiComKitServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitServer']/constructor[@name='MobiComKitServer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MobiComKitServer (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MobiComKitServer)) {
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

	}
}
