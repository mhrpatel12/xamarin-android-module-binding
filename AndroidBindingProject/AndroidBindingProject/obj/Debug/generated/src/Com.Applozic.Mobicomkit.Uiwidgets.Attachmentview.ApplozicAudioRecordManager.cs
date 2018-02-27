using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicAudioRecordManager", DoNotGenerateAcw=true)]
	public partial class ApplozicAudioRecordManager : global::Java.Lang.Object, global::Android.Media.MediaRecorder.IOnErrorListener, global::Android.Media.MediaRecorder.IOnInfoListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicAudioRecordManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicAudioRecordManager); }
		}

		protected ApplozicAudioRecordManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_support_v4_app_FragmentActivity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/constructor[@name='ApplozicAudioRecordManager' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.FragmentActivity']]"
		[Register (".ctor", "(Landroid/support/v4/app/FragmentActivity;)V", "")]
		public unsafe ApplozicAudioRecordManager (global::Android.Support.V4.App.FragmentActivity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ApplozicAudioRecordManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/support/v4/app/FragmentActivity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/support/v4/app/FragmentActivity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_support_v4_app_FragmentActivity_ == IntPtr.Zero)
					id_ctor_Landroid_support_v4_app_FragmentActivity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v4/app/FragmentActivity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v4_app_FragmentActivity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_support_v4_app_FragmentActivity_, __args);
			} finally {
			}
		}

		static Delegate cb_cancelAudio;
#pragma warning disable 0169
		static Delegate GetCancelAudioHandler ()
		{
			if (cb_cancelAudio == null)
				cb_cancelAudio = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelAudio);
			return cb_cancelAudio;
		}

		static void n_CancelAudio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelAudio ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelAudio;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='cancelAudio' and count(parameter)=0]"
		[Register ("cancelAudio", "()V", "GetCancelAudioHandler")]
		public virtual unsafe void CancelAudio ()
		{
			if (id_cancelAudio == IntPtr.Zero)
				id_cancelAudio = JNIEnv.GetMethodID (class_ref, "cancelAudio", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelAudio);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelAudio", "()V"));
			} finally {
			}
		}

		static Delegate cb_onError_Landroid_media_MediaRecorder_II;
#pragma warning disable 0169
		static Delegate GetOnError_Landroid_media_MediaRecorder_IIHandler ()
		{
			if (cb_onError_Landroid_media_MediaRecorder_II == null)
				cb_onError_Landroid_media_MediaRecorder_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnError_Landroid_media_MediaRecorder_II);
			return cb_onError_Landroid_media_MediaRecorder_II;
		}

		static void n_OnError_Landroid_media_MediaRecorder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaRecorder p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaRecorderError p1 = (global::Android.Media.MediaRecorderError) native_p1;
			__this.OnError (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onError_Landroid_media_MediaRecorder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='onError' and count(parameter)=3 and parameter[1][@type='android.media.MediaRecorder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onError", "(Landroid/media/MediaRecorder;II)V", "GetOnError_Landroid_media_MediaRecorder_IIHandler")]
		public virtual unsafe void OnError (global::Android.Media.MediaRecorder p0, [global::Android.Runtime.GeneratedEnum] global::Android.Media.MediaRecorderError p1, int p2)
		{
			if (id_onError_Landroid_media_MediaRecorder_II == IntPtr.Zero)
				id_onError_Landroid_media_MediaRecorder_II = JNIEnv.GetMethodID (class_ref, "onError", "(Landroid/media/MediaRecorder;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Landroid_media_MediaRecorder_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "(Landroid/media/MediaRecorder;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onInfo_Landroid_media_MediaRecorder_II;
#pragma warning disable 0169
		static Delegate GetOnInfo_Landroid_media_MediaRecorder_IIHandler ()
		{
			if (cb_onInfo_Landroid_media_MediaRecorder_II == null)
				cb_onInfo_Landroid_media_MediaRecorder_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnInfo_Landroid_media_MediaRecorder_II);
			return cb_onInfo_Landroid_media_MediaRecorder_II;
		}

		static void n_OnInfo_Landroid_media_MediaRecorder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaRecorder p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.MediaRecorderInfo p1 = (global::Android.Media.MediaRecorderInfo) native_p1;
			__this.OnInfo (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onInfo_Landroid_media_MediaRecorder_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='onInfo' and count(parameter)=3 and parameter[1][@type='android.media.MediaRecorder'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onInfo", "(Landroid/media/MediaRecorder;II)V", "GetOnInfo_Landroid_media_MediaRecorder_IIHandler")]
		public virtual unsafe void OnInfo (global::Android.Media.MediaRecorder p0, [global::Android.Runtime.GeneratedEnum] global::Android.Media.MediaRecorderInfo p1, int p2)
		{
			if (id_onInfo_Landroid_media_MediaRecorder_II == IntPtr.Zero)
				id_onInfo_Landroid_media_MediaRecorder_II = JNIEnv.GetMethodID (class_ref, "onInfo", "(Landroid/media/MediaRecorder;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInfo_Landroid_media_MediaRecorder_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInfo", "(Landroid/media/MediaRecorder;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_prepareMediaRecorder;
#pragma warning disable 0169
		static Delegate GetPrepareMediaRecorderHandler ()
		{
			if (cb_prepareMediaRecorder == null)
				cb_prepareMediaRecorder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PrepareMediaRecorder);
			return cb_prepareMediaRecorder;
		}

		static IntPtr n_PrepareMediaRecorder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrepareMediaRecorder ());
		}
#pragma warning restore 0169

		static IntPtr id_prepareMediaRecorder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='prepareMediaRecorder' and count(parameter)=0]"
		[Register ("prepareMediaRecorder", "()Landroid/media/MediaRecorder;", "GetPrepareMediaRecorderHandler")]
		public virtual unsafe global::Android.Media.MediaRecorder PrepareMediaRecorder ()
		{
			if (id_prepareMediaRecorder == IntPtr.Zero)
				id_prepareMediaRecorder = JNIEnv.GetMethodID (class_ref, "prepareMediaRecorder", "()Landroid/media/MediaRecorder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepareMediaRecorder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareMediaRecorder", "()Landroid/media/MediaRecorder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_recordAudio;
#pragma warning disable 0169
		static Delegate GetRecordAudioHandler ()
		{
			if (cb_recordAudio == null)
				cb_recordAudio = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordAudio);
			return cb_recordAudio;
		}

		static void n_RecordAudio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordAudio ();
		}
#pragma warning restore 0169

		static IntPtr id_recordAudio;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='recordAudio' and count(parameter)=0]"
		[Register ("recordAudio", "()V", "GetRecordAudioHandler")]
		public virtual unsafe void RecordAudio ()
		{
			if (id_recordAudio == IntPtr.Zero)
				id_recordAudio = JNIEnv.GetMethodID (class_ref, "recordAudio", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recordAudio);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recordAudio", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendAudio;
#pragma warning disable 0169
		static Delegate GetSendAudioHandler ()
		{
			if (cb_sendAudio == null)
				cb_sendAudio = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAudio);
			return cb_sendAudio;
		}

		static void n_SendAudio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAudio ();
		}
#pragma warning restore 0169

		static IntPtr id_sendAudio;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='sendAudio' and count(parameter)=0]"
		[Register ("sendAudio", "()V", "GetSendAudioHandler")]
		public virtual unsafe void SendAudio ()
		{
			if (id_sendAudio == IntPtr.Zero)
				id_sendAudio = JNIEnv.GetMethodID (class_ref, "sendAudio", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAudio);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAudio", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAudioFileName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAudioFileName_Ljava_lang_String_Handler ()
		{
			if (cb_setAudioFileName_Ljava_lang_String_ == null)
				cb_setAudioFileName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAudioFileName_Ljava_lang_String_);
			return cb_setAudioFileName_Ljava_lang_String_;
		}

		static void n_SetAudioFileName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioFileName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAudioFileName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='setAudioFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAudioFileName", "(Ljava/lang/String;)V", "GetSetAudioFileName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAudioFileName (string p0)
		{
			if (id_setAudioFileName_Ljava_lang_String_ == IntPtr.Zero)
				id_setAudioFileName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAudioFileName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioFileName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioFileName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOutputFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOutputFile_Ljava_lang_String_Handler ()
		{
			if (cb_setOutputFile_Ljava_lang_String_ == null)
				cb_setOutputFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOutputFile_Ljava_lang_String_);
			return cb_setOutputFile_Ljava_lang_String_;
		}

		static void n_SetOutputFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOutputFile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOutputFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='setOutputFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOutputFile", "(Ljava/lang/String;)V", "GetSetOutputFile_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOutputFile (string p0)
		{
			if (id_setOutputFile_Ljava_lang_String_ == IntPtr.Zero)
				id_setOutputFile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOutputFile", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOutputFile_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOutputFile", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTimeStamp_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTimeStamp_Ljava_lang_String_Handler ()
		{
			if (cb_setTimeStamp_Ljava_lang_String_ == null)
				cb_setTimeStamp_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimeStamp_Ljava_lang_String_);
			return cb_setTimeStamp_Ljava_lang_String_;
		}

		static void n_SetTimeStamp_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeStamp (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTimeStamp_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='setTimeStamp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTimeStamp", "(Ljava/lang/String;)V", "GetSetTimeStamp_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTimeStamp (string p0)
		{
			if (id_setTimeStamp_Ljava_lang_String_ == IntPtr.Zero)
				id_setTimeStamp_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTimeStamp", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeStamp_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeStamp", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_stopRecording;
#pragma warning disable 0169
		static Delegate GetStopRecordingHandler ()
		{
			if (cb_stopRecording == null)
				cb_stopRecording = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopRecording);
			return cb_stopRecording;
		}

		static void n_StopRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioRecordManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRecording ();
		}
#pragma warning restore 0169

		static IntPtr id_stopRecording;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioRecordManager']/method[@name='stopRecording' and count(parameter)=0]"
		[Register ("stopRecording", "()V", "GetStopRecordingHandler")]
		public virtual unsafe void StopRecording ()
		{
			if (id_stopRecording == IntPtr.Zero)
				id_stopRecording = JNIEnv.GetMethodID (class_ref, "stopRecording", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopRecording);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopRecording", "()V"));
			} finally {
			}
		}

	}
}
