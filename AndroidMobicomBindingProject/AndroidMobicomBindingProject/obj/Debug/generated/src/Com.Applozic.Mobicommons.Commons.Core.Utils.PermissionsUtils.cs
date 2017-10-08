using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/core/utils/PermissionsUtils", DoNotGenerateAcw=true)]
	public partial class PermissionsUtils : global::Java.Lang.Object {


		static IntPtr PERMISSIONS_LOCATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='PERMISSIONS_LOCATION']"
		[Register ("PERMISSIONS_LOCATION")]
		public static IList<string> PermissionsLocation {
			get {
				if (PERMISSIONS_LOCATION_jfieldId == IntPtr.Zero)
					PERMISSIONS_LOCATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSIONS_LOCATION", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PERMISSIONS_LOCATION_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERMISSIONS_LOCATION_jfieldId == IntPtr.Zero)
					PERMISSIONS_LOCATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSIONS_LOCATION", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PERMISSIONS_LOCATION_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PERMISSIONS_RECORD_AUDIO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='PERMISSIONS_RECORD_AUDIO']"
		[Register ("PERMISSIONS_RECORD_AUDIO")]
		public static IList<string> PermissionsRecordAudio {
			get {
				if (PERMISSIONS_RECORD_AUDIO_jfieldId == IntPtr.Zero)
					PERMISSIONS_RECORD_AUDIO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSIONS_RECORD_AUDIO", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PERMISSIONS_RECORD_AUDIO_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERMISSIONS_RECORD_AUDIO_jfieldId == IntPtr.Zero)
					PERMISSIONS_RECORD_AUDIO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSIONS_RECORD_AUDIO", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PERMISSIONS_RECORD_AUDIO_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PERMISSIONS_STORAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='PERMISSIONS_STORAGE']"
		[Register ("PERMISSIONS_STORAGE")]
		public static IList<string> PermissionsStorage {
			get {
				if (PERMISSIONS_STORAGE_jfieldId == IntPtr.Zero)
					PERMISSIONS_STORAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSIONS_STORAGE", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PERMISSIONS_STORAGE_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERMISSIONS_STORAGE_jfieldId == IntPtr.Zero)
					PERMISSIONS_STORAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSIONS_STORAGE", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PERMISSIONS_STORAGE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PERMISSION_CALL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='PERMISSION_CALL']"
		[Register ("PERMISSION_CALL")]
		public static IList<string> PermissionCall {
			get {
				if (PERMISSION_CALL_jfieldId == IntPtr.Zero)
					PERMISSION_CALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION_CALL", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PERMISSION_CALL_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERMISSION_CALL_jfieldId == IntPtr.Zero)
					PERMISSION_CALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION_CALL", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PERMISSION_CALL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PERMISSION_CAMERA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='PERMISSION_CAMERA']"
		[Register ("PERMISSION_CAMERA")]
		public static IList<string> PermissionCamera {
			get {
				if (PERMISSION_CAMERA_jfieldId == IntPtr.Zero)
					PERMISSION_CAMERA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION_CAMERA", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PERMISSION_CAMERA_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERMISSION_CAMERA_jfieldId == IntPtr.Zero)
					PERMISSION_CAMERA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION_CAMERA", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PERMISSION_CAMERA_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PERMISSION_CONTACT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='PERMISSION_CONTACT']"
		[Register ("PERMISSION_CONTACT")]
		public static IList<string> PermissionContact {
			get {
				if (PERMISSION_CONTACT_jfieldId == IntPtr.Zero)
					PERMISSION_CONTACT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION_CONTACT", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, PERMISSION_CONTACT_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERMISSION_CONTACT_jfieldId == IntPtr.Zero)
					PERMISSION_CONTACT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERMISSION_CONTACT", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, PERMISSION_CONTACT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='REQUEST_AUDIO_RECORD']"
		[Register ("REQUEST_AUDIO_RECORD")]
		public const int RequestAudioRecord = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='REQUEST_CALL_PHONE']"
		[Register ("REQUEST_CALL_PHONE")]
		public const int RequestCallPhone = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='REQUEST_CAMERA']"
		[Register ("REQUEST_CAMERA")]
		public const int RequestCamera = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='REQUEST_CAMERA_FOR_PROFILE_PHOTO']"
		[Register ("REQUEST_CAMERA_FOR_PROFILE_PHOTO")]
		public const int RequestCameraForProfilePhoto = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='REQUEST_CONTACT']"
		[Register ("REQUEST_CONTACT")]
		public const int RequestContact = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='REQUEST_LOCATION']"
		[Register ("REQUEST_LOCATION")]
		public const int RequestLocation = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='REQUEST_PHONE_STATE']"
		[Register ("REQUEST_PHONE_STATE")]
		public const int RequestPhoneState = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='REQUEST_STORAGE']"
		[Register ("REQUEST_STORAGE")]
		public const int RequestStorage = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/field[@name='REQUEST_STORAGE_FOR_PROFILE_PHOTO']"
		[Register ("REQUEST_STORAGE_FOR_PROFILE_PHOTO")]
		public const int RequestStorageForProfilePhoto = (int) 8;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/core/utils/PermissionsUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PermissionsUtils); }
		}

		protected PermissionsUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/constructor[@name='PermissionsUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PermissionsUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PermissionsUtils)) {
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

		static IntPtr id_checkSelfForCallPermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='checkSelfForCallPermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("checkSelfForCallPermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool CheckSelfForCallPermission (global::Android.App.Activity p0)
		{
			if (id_checkSelfForCallPermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_checkSelfForCallPermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "checkSelfForCallPermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSelfForCallPermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkSelfForCameraPermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='checkSelfForCameraPermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("checkSelfForCameraPermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool CheckSelfForCameraPermission (global::Android.App.Activity p0)
		{
			if (id_checkSelfForCameraPermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_checkSelfForCameraPermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "checkSelfForCameraPermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSelfForCameraPermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkSelfForContactPermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='checkSelfForContactPermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("checkSelfForContactPermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool CheckSelfForContactPermission (global::Android.App.Activity p0)
		{
			if (id_checkSelfForContactPermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_checkSelfForContactPermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "checkSelfForContactPermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSelfForContactPermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkSelfForStoragePermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='checkSelfForStoragePermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("checkSelfForStoragePermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool CheckSelfForStoragePermission (global::Android.App.Activity p0)
		{
			if (id_checkSelfForStoragePermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_checkSelfForStoragePermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "checkSelfForStoragePermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSelfForStoragePermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkSelfPermissionForAudioRecording_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='checkSelfPermissionForAudioRecording' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("checkSelfPermissionForAudioRecording", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool CheckSelfPermissionForAudioRecording (global::Android.App.Activity p0)
		{
			if (id_checkSelfPermissionForAudioRecording_Landroid_app_Activity_ == IntPtr.Zero)
				id_checkSelfPermissionForAudioRecording_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "checkSelfPermissionForAudioRecording", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSelfPermissionForAudioRecording_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_checkSelfPermissionForLocation_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='checkSelfPermissionForLocation' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("checkSelfPermissionForLocation", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool CheckSelfPermissionForLocation (global::Android.App.Activity p0)
		{
			if (id_checkSelfPermissionForLocation_Landroid_app_Activity_ == IntPtr.Zero)
				id_checkSelfPermissionForLocation_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "checkSelfPermissionForLocation", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkSelfPermissionForLocation_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isAudioRecordingPermissionGranted_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='isAudioRecordingPermissionGranted' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isAudioRecordingPermissionGranted", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsAudioRecordingPermissionGranted (global::Android.Content.Context p0)
		{
			if (id_isAudioRecordingPermissionGranted_Landroid_content_Context_ == IntPtr.Zero)
				id_isAudioRecordingPermissionGranted_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isAudioRecordingPermissionGranted", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAudioRecordingPermissionGranted_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isCallPermissionGranted_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='isCallPermissionGranted' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isCallPermissionGranted", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsCallPermissionGranted (global::Android.Content.Context p0)
		{
			if (id_isCallPermissionGranted_Landroid_content_Context_ == IntPtr.Zero)
				id_isCallPermissionGranted_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isCallPermissionGranted", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCallPermissionGranted_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isCameraPermissionGranted_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='isCameraPermissionGranted' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isCameraPermissionGranted", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsCameraPermissionGranted (global::Android.Content.Context p0)
		{
			if (id_isCameraPermissionGranted_Landroid_content_Context_ == IntPtr.Zero)
				id_isCameraPermissionGranted_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isCameraPermissionGranted", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isCameraPermissionGranted_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='requestPermissions' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int']]"
		[Register ("requestPermissions", "(Landroid/app/Activity;[Ljava/lang/String;I)V", "")]
		public static unsafe void RequestPermissions (global::Android.App.Activity p0, string[] p1, int p2)
		{
			if (id_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I == IntPtr.Zero)
				id_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "requestPermissions", "(Landroid/app/Activity;[Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_shouldShowRequestForAudioPermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='shouldShowRequestForAudioPermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("shouldShowRequestForAudioPermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool ShouldShowRequestForAudioPermission (global::Android.App.Activity p0)
		{
			if (id_shouldShowRequestForAudioPermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_shouldShowRequestForAudioPermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "shouldShowRequestForAudioPermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_shouldShowRequestForAudioPermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shouldShowRequestForCallPermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='shouldShowRequestForCallPermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("shouldShowRequestForCallPermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool ShouldShowRequestForCallPermission (global::Android.App.Activity p0)
		{
			if (id_shouldShowRequestForCallPermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_shouldShowRequestForCallPermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "shouldShowRequestForCallPermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_shouldShowRequestForCallPermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shouldShowRequestForCameraPermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='shouldShowRequestForCameraPermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("shouldShowRequestForCameraPermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool ShouldShowRequestForCameraPermission (global::Android.App.Activity p0)
		{
			if (id_shouldShowRequestForCameraPermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_shouldShowRequestForCameraPermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "shouldShowRequestForCameraPermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_shouldShowRequestForCameraPermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shouldShowRequestForContactPermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='shouldShowRequestForContactPermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("shouldShowRequestForContactPermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool ShouldShowRequestForContactPermission (global::Android.App.Activity p0)
		{
			if (id_shouldShowRequestForContactPermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_shouldShowRequestForContactPermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "shouldShowRequestForContactPermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_shouldShowRequestForContactPermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shouldShowRequestForLocationPermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='shouldShowRequestForLocationPermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("shouldShowRequestForLocationPermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool ShouldShowRequestForLocationPermission (global::Android.App.Activity p0)
		{
			if (id_shouldShowRequestForLocationPermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_shouldShowRequestForLocationPermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "shouldShowRequestForLocationPermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_shouldShowRequestForLocationPermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shouldShowRequestForStoragePermission_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='shouldShowRequestForStoragePermission' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("shouldShowRequestForStoragePermission", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool ShouldShowRequestForStoragePermission (global::Android.App.Activity p0)
		{
			if (id_shouldShowRequestForStoragePermission_Landroid_app_Activity_ == IntPtr.Zero)
				id_shouldShowRequestForStoragePermission_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "shouldShowRequestForStoragePermission", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_shouldShowRequestForStoragePermission_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_verifyPermissions_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='PermissionsUtils']/method[@name='verifyPermissions' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("verifyPermissions", "([I)Z", "")]
		public static unsafe bool VerifyPermissions (int[] p0)
		{
			if (id_verifyPermissions_arrayI == IntPtr.Zero)
				id_verifyPermissions_arrayI = JNIEnv.GetStaticMethodID (class_ref, "verifyPermissions", "([I)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_verifyPermissions_arrayI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
