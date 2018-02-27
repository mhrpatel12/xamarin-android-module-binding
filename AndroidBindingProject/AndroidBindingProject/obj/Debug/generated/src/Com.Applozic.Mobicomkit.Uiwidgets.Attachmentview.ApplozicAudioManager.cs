using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioManager']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicAudioManager", DoNotGenerateAcw=true)]
	public partial class ApplozicAudioManager : global::Java.Lang.Object, global::Android.Media.AudioManager.IOnAudioFocusChangeListener {


		static IntPtr currentView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioManager']/field[@name='currentView']"
		[Register ("currentView")]
		public global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView CurrentView {
			get {
				if (currentView_jfieldId == IntPtr.Zero)
					currentView_jfieldId = JNIEnv.GetFieldID (class_ref, "currentView", "Lcom/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicDocumentView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, currentView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (currentView_jfieldId == IntPtr.Zero)
					currentView_jfieldId = JNIEnv.GetFieldID (class_ref, "currentView", "Lcom/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicDocumentView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicAudioManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicAudioManager); }
		}

		protected ApplozicAudioManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_audiostop;
#pragma warning disable 0169
		static Delegate GetAudiostopHandler ()
		{
			if (cb_audiostop == null)
				cb_audiostop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Audiostop);
			return cb_audiostop;
		}

		static void n_Audiostop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Audiostop ();
		}
#pragma warning restore 0169

		static IntPtr id_audiostop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioManager']/method[@name='audiostop' and count(parameter)=0]"
		[Register ("audiostop", "()V", "GetAudiostopHandler")]
		public virtual unsafe void Audiostop ()
		{
			if (id_audiostop == IntPtr.Zero)
				id_audiostop = JNIEnv.GetMethodID (class_ref, "audiostop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_audiostop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "audiostop", "()V"));
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicAudioManager;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicAudioManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMediaPlayer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMediaPlayer_Ljava_lang_String_Handler ()
		{
			if (cb_getMediaPlayer_Ljava_lang_String_ == null)
				cb_getMediaPlayer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMediaPlayer_Ljava_lang_String_);
			return cb_getMediaPlayer_Ljava_lang_String_;
		}

		static IntPtr n_GetMediaPlayer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMediaPlayer (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMediaPlayer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioManager']/method[@name='getMediaPlayer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMediaPlayer", "(Ljava/lang/String;)Landroid/media/MediaPlayer;", "GetGetMediaPlayer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Media.MediaPlayer GetMediaPlayer (string p0)
		{
			if (id_getMediaPlayer_Ljava_lang_String_ == IntPtr.Zero)
				id_getMediaPlayer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMediaPlayer", "(Ljava/lang/String;)Landroid/media/MediaPlayer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Media.MediaPlayer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaPlayer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Media.MediaPlayer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaPlayer", "(Ljava/lang/String;)Landroid/media/MediaPlayer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onAudioFocusChange_I;
#pragma warning disable 0169
		static Delegate GetOnAudioFocusChange_IHandler ()
		{
			if (cb_onAudioFocusChange_I == null)
				cb_onAudioFocusChange_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnAudioFocusChange_I);
			return cb_onAudioFocusChange_I;
		}

		static void n_OnAudioFocusChange_I (IntPtr jnienv, IntPtr native__this, int native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Media.AudioFocus p0 = (global::Android.Media.AudioFocus) native_p0;
			__this.OnAudioFocusChange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAudioFocusChange_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioManager']/method[@name='onAudioFocusChange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onAudioFocusChange", "(I)V", "GetOnAudioFocusChange_IHandler")]
		public virtual unsafe void OnAudioFocusChange ([global::Android.Runtime.GeneratedEnum] global::Android.Media.AudioFocus p0)
		{
			if (id_onAudioFocusChange_I == IntPtr.Zero)
				id_onAudioFocusChange_I = JNIEnv.GetMethodID (class_ref, "onAudioFocusChange", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((int) p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioFocusChange_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAudioFocusChange", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_pauseOthersifPlaying;
#pragma warning disable 0169
		static Delegate GetPauseOthersifPlayingHandler ()
		{
			if (cb_pauseOthersifPlaying == null)
				cb_pauseOthersifPlaying = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseOthersifPlaying);
			return cb_pauseOthersifPlaying;
		}

		static void n_PauseOthersifPlaying (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseOthersifPlaying ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseOthersifPlaying;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioManager']/method[@name='pauseOthersifPlaying' and count(parameter)=0]"
		[Register ("pauseOthersifPlaying", "()V", "GetPauseOthersifPlayingHandler")]
		public virtual unsafe void PauseOthersifPlaying ()
		{
			if (id_pauseOthersifPlaying == IntPtr.Zero)
				id_pauseOthersifPlaying = JNIEnv.GetMethodID (class_ref, "pauseOthersifPlaying", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseOthersifPlaying);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseOthersifPlaying", "()V"));
			} finally {
			}
		}

		static Delegate cb_refreshAudioDuration_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRefreshAudioDuration_Ljava_lang_String_Handler ()
		{
			if (cb_refreshAudioDuration_Ljava_lang_String_ == null)
				cb_refreshAudioDuration_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RefreshAudioDuration_Ljava_lang_String_);
			return cb_refreshAudioDuration_Ljava_lang_String_;
		}

		static IntPtr n_RefreshAudioDuration_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.RefreshAudioDuration (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_refreshAudioDuration_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioManager']/method[@name='refreshAudioDuration' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("refreshAudioDuration", "(Ljava/lang/String;)Ljava/lang/String;", "GetRefreshAudioDuration_Ljava_lang_String_Handler")]
		public virtual unsafe string RefreshAudioDuration (string p0)
		{
			if (id_refreshAudioDuration_Ljava_lang_String_ == IntPtr.Zero)
				id_refreshAudioDuration_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "refreshAudioDuration", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refreshAudioDuration_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshAudioDuration", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_Handler ()
		{
			if (cb_updateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_ == null)
				cb_updateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_);
			return cb_updateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_;
		}

		static void n_UpdateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicAudioManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TextView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateAudioDuration (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicAudioManager']/method[@name='updateAudioDuration' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateAudioDuration", "(Landroid/widget/TextView;Ljava/lang/String;)V", "GetUpdateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateAudioDuration (global::Android.Widget.TextView p0, string p1)
		{
			if (id_updateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_ == IntPtr.Zero)
				id_updateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateAudioDuration", "(Landroid/widget/TextView;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateAudioDuration_Landroid_widget_TextView_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateAudioDuration", "(Landroid/widget/TextView;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
