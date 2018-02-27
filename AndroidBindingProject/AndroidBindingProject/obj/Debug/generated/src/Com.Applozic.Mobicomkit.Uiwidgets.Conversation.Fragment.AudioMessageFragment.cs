using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='AudioMessageFragment']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/fragment/AudioMessageFragment", DoNotGenerateAcw=true)]
	public partial class AudioMessageFragment : global::Android.Support.V4.App.DialogFragment {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/fragment/AudioMessageFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AudioMessageFragment); }
		}

		protected AudioMessageFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='AudioMessageFragment']/constructor[@name='AudioMessageFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AudioMessageFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AudioMessageFragment)) {
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

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='AudioMessageFragment']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/fragment/AudioMessageFragment;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.AudioMessageFragment NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/fragment/AudioMessageFragment;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.AudioMessageFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.AudioMessageFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.AudioMessageFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrepareMediaRecorder ());
		}
#pragma warning restore 0169

		static IntPtr id_prepareMediaRecorder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='AudioMessageFragment']/method[@name='prepareMediaRecorder' and count(parameter)=0]"
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.AudioMessageFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.AudioMessageFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRecording ();
		}
#pragma warning restore 0169

		static IntPtr id_stopRecording;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='AudioMessageFragment']/method[@name='stopRecording' and count(parameter)=0]"
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
