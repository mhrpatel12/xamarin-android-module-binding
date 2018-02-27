using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Instruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/instruction/ApplozicPermissions", DoNotGenerateAcw=true)]
	public partial class ApplozicPermissions : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/instruction/ApplozicPermissions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicPermissions); }
		}

		protected ApplozicPermissions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_Landroid_widget_LinearLayout_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/constructor[@name='ApplozicPermissions' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.widget.LinearLayout']]"
		[Register (".ctor", "(Landroid/app/Activity;Landroid/widget/LinearLayout;)V", "")]
		public unsafe ApplozicPermissions (global::Android.App.Activity p0, global::Android.Widget.LinearLayout p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ApplozicPermissions)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;Landroid/widget/LinearLayout;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;Landroid/widget/LinearLayout;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_Landroid_widget_LinearLayout_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_Landroid_widget_LinearLayout_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;Landroid/widget/LinearLayout;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_Landroid_widget_LinearLayout_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_Landroid_widget_LinearLayout_, __args);
			} finally {
			}
		}

		static Delegate cb_checkRuntimePermissionForCameraAndAudioRecording;
#pragma warning disable 0169
		static Delegate GetCheckRuntimePermissionForCameraAndAudioRecordingHandler ()
		{
			if (cb_checkRuntimePermissionForCameraAndAudioRecording == null)
				cb_checkRuntimePermissionForCameraAndAudioRecording = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckRuntimePermissionForCameraAndAudioRecording);
			return cb_checkRuntimePermissionForCameraAndAudioRecording;
		}

		static void n_CheckRuntimePermissionForCameraAndAudioRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckRuntimePermissionForCameraAndAudioRecording ();
		}
#pragma warning restore 0169

		static IntPtr id_checkRuntimePermissionForCameraAndAudioRecording;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='checkRuntimePermissionForCameraAndAudioRecording' and count(parameter)=0]"
		[Register ("checkRuntimePermissionForCameraAndAudioRecording", "()V", "GetCheckRuntimePermissionForCameraAndAudioRecordingHandler")]
		public virtual unsafe void CheckRuntimePermissionForCameraAndAudioRecording ()
		{
			if (id_checkRuntimePermissionForCameraAndAudioRecording == IntPtr.Zero)
				id_checkRuntimePermissionForCameraAndAudioRecording = JNIEnv.GetMethodID (class_ref, "checkRuntimePermissionForCameraAndAudioRecording", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkRuntimePermissionForCameraAndAudioRecording);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkRuntimePermissionForCameraAndAudioRecording", "()V"));
			} finally {
			}
		}

		static Delegate cb_checkRuntimePermissionForLocation;
#pragma warning disable 0169
		static Delegate GetCheckRuntimePermissionForLocationHandler ()
		{
			if (cb_checkRuntimePermissionForLocation == null)
				cb_checkRuntimePermissionForLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckRuntimePermissionForLocation);
			return cb_checkRuntimePermissionForLocation;
		}

		static void n_CheckRuntimePermissionForLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckRuntimePermissionForLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_checkRuntimePermissionForLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='checkRuntimePermissionForLocation' and count(parameter)=0]"
		[Register ("checkRuntimePermissionForLocation", "()V", "GetCheckRuntimePermissionForLocationHandler")]
		public virtual unsafe void CheckRuntimePermissionForLocation ()
		{
			if (id_checkRuntimePermissionForLocation == IntPtr.Zero)
				id_checkRuntimePermissionForLocation = JNIEnv.GetMethodID (class_ref, "checkRuntimePermissionForLocation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkRuntimePermissionForLocation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkRuntimePermissionForLocation", "()V"));
			} finally {
			}
		}

		static Delegate cb_checkRuntimePermissionForLocationActivity;
#pragma warning disable 0169
		static Delegate GetCheckRuntimePermissionForLocationActivityHandler ()
		{
			if (cb_checkRuntimePermissionForLocationActivity == null)
				cb_checkRuntimePermissionForLocationActivity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckRuntimePermissionForLocationActivity);
			return cb_checkRuntimePermissionForLocationActivity;
		}

		static void n_CheckRuntimePermissionForLocationActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckRuntimePermissionForLocationActivity ();
		}
#pragma warning restore 0169

		static IntPtr id_checkRuntimePermissionForLocationActivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='checkRuntimePermissionForLocationActivity' and count(parameter)=0]"
		[Register ("checkRuntimePermissionForLocationActivity", "()V", "GetCheckRuntimePermissionForLocationActivityHandler")]
		public virtual unsafe void CheckRuntimePermissionForLocationActivity ()
		{
			if (id_checkRuntimePermissionForLocationActivity == IntPtr.Zero)
				id_checkRuntimePermissionForLocationActivity = JNIEnv.GetMethodID (class_ref, "checkRuntimePermissionForLocationActivity", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkRuntimePermissionForLocationActivity);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkRuntimePermissionForLocationActivity", "()V"));
			} finally {
			}
		}

		static Delegate cb_checkRuntimePermissionForStorage;
#pragma warning disable 0169
		static Delegate GetCheckRuntimePermissionForStorageHandler ()
		{
			if (cb_checkRuntimePermissionForStorage == null)
				cb_checkRuntimePermissionForStorage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckRuntimePermissionForStorage);
			return cb_checkRuntimePermissionForStorage;
		}

		static void n_CheckRuntimePermissionForStorage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckRuntimePermissionForStorage ();
		}
#pragma warning restore 0169

		static IntPtr id_checkRuntimePermissionForStorage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='checkRuntimePermissionForStorage' and count(parameter)=0]"
		[Register ("checkRuntimePermissionForStorage", "()V", "GetCheckRuntimePermissionForStorageHandler")]
		public virtual unsafe void CheckRuntimePermissionForStorage ()
		{
			if (id_checkRuntimePermissionForStorage == IntPtr.Zero)
				id_checkRuntimePermissionForStorage = JNIEnv.GetMethodID (class_ref, "checkRuntimePermissionForStorage", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkRuntimePermissionForStorage);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkRuntimePermissionForStorage", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestAudio;
#pragma warning disable 0169
		static Delegate GetRequestAudioHandler ()
		{
			if (cb_requestAudio == null)
				cb_requestAudio = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestAudio);
			return cb_requestAudio;
		}

		static void n_RequestAudio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestAudio ();
		}
#pragma warning restore 0169

		static IntPtr id_requestAudio;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='requestAudio' and count(parameter)=0]"
		[Register ("requestAudio", "()V", "GetRequestAudioHandler")]
		public virtual unsafe void RequestAudio ()
		{
			if (id_requestAudio == IntPtr.Zero)
				id_requestAudio = JNIEnv.GetMethodID (class_ref, "requestAudio", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestAudio);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestAudio", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestCallPermission;
#pragma warning disable 0169
		static Delegate GetRequestCallPermissionHandler ()
		{
			if (cb_requestCallPermission == null)
				cb_requestCallPermission = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestCallPermission);
			return cb_requestCallPermission;
		}

		static void n_RequestCallPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestCallPermission ();
		}
#pragma warning restore 0169

		static IntPtr id_requestCallPermission;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='requestCallPermission' and count(parameter)=0]"
		[Register ("requestCallPermission", "()V", "GetRequestCallPermissionHandler")]
		public virtual unsafe void RequestCallPermission ()
		{
			if (id_requestCallPermission == IntPtr.Zero)
				id_requestCallPermission = JNIEnv.GetMethodID (class_ref, "requestCallPermission", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestCallPermission);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestCallPermission", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestCameraAndRecordPermission;
#pragma warning disable 0169
		static Delegate GetRequestCameraAndRecordPermissionHandler ()
		{
			if (cb_requestCameraAndRecordPermission == null)
				cb_requestCameraAndRecordPermission = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestCameraAndRecordPermission);
			return cb_requestCameraAndRecordPermission;
		}

		static void n_RequestCameraAndRecordPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestCameraAndRecordPermission ();
		}
#pragma warning restore 0169

		static IntPtr id_requestCameraAndRecordPermission;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='requestCameraAndRecordPermission' and count(parameter)=0]"
		[Register ("requestCameraAndRecordPermission", "()V", "GetRequestCameraAndRecordPermissionHandler")]
		public virtual unsafe void RequestCameraAndRecordPermission ()
		{
			if (id_requestCameraAndRecordPermission == IntPtr.Zero)
				id_requestCameraAndRecordPermission = JNIEnv.GetMethodID (class_ref, "requestCameraAndRecordPermission", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestCameraAndRecordPermission);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestCameraAndRecordPermission", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestCameraPermission;
#pragma warning disable 0169
		static Delegate GetRequestCameraPermissionHandler ()
		{
			if (cb_requestCameraPermission == null)
				cb_requestCameraPermission = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestCameraPermission);
			return cb_requestCameraPermission;
		}

		static void n_RequestCameraPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestCameraPermission ();
		}
#pragma warning restore 0169

		static IntPtr id_requestCameraPermission;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='requestCameraPermission' and count(parameter)=0]"
		[Register ("requestCameraPermission", "()V", "GetRequestCameraPermissionHandler")]
		public virtual unsafe void RequestCameraPermission ()
		{
			if (id_requestCameraPermission == IntPtr.Zero)
				id_requestCameraPermission = JNIEnv.GetMethodID (class_ref, "requestCameraPermission", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestCameraPermission);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestCameraPermission", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestCameraPermissionForProfilePhoto;
#pragma warning disable 0169
		static Delegate GetRequestCameraPermissionForProfilePhotoHandler ()
		{
			if (cb_requestCameraPermissionForProfilePhoto == null)
				cb_requestCameraPermissionForProfilePhoto = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestCameraPermissionForProfilePhoto);
			return cb_requestCameraPermissionForProfilePhoto;
		}

		static void n_RequestCameraPermissionForProfilePhoto (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestCameraPermissionForProfilePhoto ();
		}
#pragma warning restore 0169

		static IntPtr id_requestCameraPermissionForProfilePhoto;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='requestCameraPermissionForProfilePhoto' and count(parameter)=0]"
		[Register ("requestCameraPermissionForProfilePhoto", "()V", "GetRequestCameraPermissionForProfilePhotoHandler")]
		public virtual unsafe void RequestCameraPermissionForProfilePhoto ()
		{
			if (id_requestCameraPermissionForProfilePhoto == IntPtr.Zero)
				id_requestCameraPermissionForProfilePhoto = JNIEnv.GetMethodID (class_ref, "requestCameraPermissionForProfilePhoto", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestCameraPermissionForProfilePhoto);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestCameraPermissionForProfilePhoto", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestContactPermission;
#pragma warning disable 0169
		static Delegate GetRequestContactPermissionHandler ()
		{
			if (cb_requestContactPermission == null)
				cb_requestContactPermission = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestContactPermission);
			return cb_requestContactPermission;
		}

		static void n_RequestContactPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestContactPermission ();
		}
#pragma warning restore 0169

		static IntPtr id_requestContactPermission;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='requestContactPermission' and count(parameter)=0]"
		[Register ("requestContactPermission", "()V", "GetRequestContactPermissionHandler")]
		public virtual unsafe void RequestContactPermission ()
		{
			if (id_requestContactPermission == IntPtr.Zero)
				id_requestContactPermission = JNIEnv.GetMethodID (class_ref, "requestContactPermission", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestContactPermission);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestContactPermission", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestLocationPermissions;
#pragma warning disable 0169
		static Delegate GetRequestLocationPermissionsHandler ()
		{
			if (cb_requestLocationPermissions == null)
				cb_requestLocationPermissions = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestLocationPermissions);
			return cb_requestLocationPermissions;
		}

		static void n_RequestLocationPermissions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestLocationPermissions ();
		}
#pragma warning restore 0169

		static IntPtr id_requestLocationPermissions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='requestLocationPermissions' and count(parameter)=0]"
		[Register ("requestLocationPermissions", "()V", "GetRequestLocationPermissionsHandler")]
		public virtual unsafe void RequestLocationPermissions ()
		{
			if (id_requestLocationPermissions == IntPtr.Zero)
				id_requestLocationPermissions = JNIEnv.GetMethodID (class_ref, "requestLocationPermissions", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestLocationPermissions);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestLocationPermissions", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestStoragePermissions;
#pragma warning disable 0169
		static Delegate GetRequestStoragePermissionsHandler ()
		{
			if (cb_requestStoragePermissions == null)
				cb_requestStoragePermissions = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestStoragePermissions);
			return cb_requestStoragePermissions;
		}

		static void n_RequestStoragePermissions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestStoragePermissions ();
		}
#pragma warning restore 0169

		static IntPtr id_requestStoragePermissions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='requestStoragePermissions' and count(parameter)=0]"
		[Register ("requestStoragePermissions", "()V", "GetRequestStoragePermissionsHandler")]
		public virtual unsafe void RequestStoragePermissions ()
		{
			if (id_requestStoragePermissions == IntPtr.Zero)
				id_requestStoragePermissions = JNIEnv.GetMethodID (class_ref, "requestStoragePermissions", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestStoragePermissions);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestStoragePermissions", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestStoragePermissionsForProfilePhoto;
#pragma warning disable 0169
		static Delegate GetRequestStoragePermissionsForProfilePhotoHandler ()
		{
			if (cb_requestStoragePermissionsForProfilePhoto == null)
				cb_requestStoragePermissionsForProfilePhoto = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestStoragePermissionsForProfilePhoto);
			return cb_requestStoragePermissionsForProfilePhoto;
		}

		static void n_RequestStoragePermissionsForProfilePhoto (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestStoragePermissionsForProfilePhoto ();
		}
#pragma warning restore 0169

		static IntPtr id_requestStoragePermissionsForProfilePhoto;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='requestStoragePermissionsForProfilePhoto' and count(parameter)=0]"
		[Register ("requestStoragePermissionsForProfilePhoto", "()V", "GetRequestStoragePermissionsForProfilePhotoHandler")]
		public virtual unsafe void RequestStoragePermissionsForProfilePhoto ()
		{
			if (id_requestStoragePermissionsForProfilePhoto == IntPtr.Zero)
				id_requestStoragePermissionsForProfilePhoto = JNIEnv.GetMethodID (class_ref, "requestStoragePermissionsForProfilePhoto", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestStoragePermissionsForProfilePhoto);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestStoragePermissionsForProfilePhoto", "()V"));
			} finally {
			}
		}

		static Delegate cb_showSnackBar_IarrayLjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetShowSnackBar_IarrayLjava_lang_String_IHandler ()
		{
			if (cb_showSnackBar_IarrayLjava_lang_String_I == null)
				cb_showSnackBar_IarrayLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int>) n_ShowSnackBar_IarrayLjava_lang_String_I);
			return cb_showSnackBar_IarrayLjava_lang_String_I;
		}

		static void n_ShowSnackBar_IarrayLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.ShowSnackBar (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_showSnackBar_IarrayLjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='ApplozicPermissions']/method[@name='showSnackBar' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int']]"
		[Register ("showSnackBar", "(I[Ljava/lang/String;I)V", "GetShowSnackBar_IarrayLjava_lang_String_IHandler")]
		public virtual unsafe void ShowSnackBar (int p0, string[] p1, int p2)
		{
			if (id_showSnackBar_IarrayLjava_lang_String_I == IntPtr.Zero)
				id_showSnackBar_IarrayLjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "showSnackBar", "(I[Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showSnackBar_IarrayLjava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSnackBar", "(I[Ljava/lang/String;I)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
