using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/fragment/MultimediaOptionFragment", DoNotGenerateAcw=true)]
	public partial class MultimediaOptionFragment : global::Android.Support.V4.App.DialogFragment {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/field[@name='MEDIA_TYPE_VIDEO']"
		[Register ("MEDIA_TYPE_VIDEO")]
		public const int MediaTypeVideo = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/field[@name='REQUEST_CODE_ATTACHE_AUDIO']"
		[Register ("REQUEST_CODE_ATTACHE_AUDIO")]
		public const int RequestCodeAttacheAudio = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/field[@name='REQUEST_CODE_ATTACH_PHOTO']"
		[Register ("REQUEST_CODE_ATTACH_PHOTO")]
		public const int RequestCodeAttachPhoto = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/field[@name='REQUEST_CODE_CAPTURE_VIDEO_ACTIVITY']"
		[Register ("REQUEST_CODE_CAPTURE_VIDEO_ACTIVITY")]
		public const int RequestCodeCaptureVideoActivity = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/field[@name='REQUEST_CODE_CONTACT_SHARE']"
		[Register ("REQUEST_CODE_CONTACT_SHARE")]
		public const int RequestCodeContactShare = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/field[@name='REQUEST_CODE_SEND_LOCATION']"
		[Register ("REQUEST_CODE_SEND_LOCATION")]
		public const int RequestCodeSendLocation = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/field[@name='REQUEST_CODE_TAKE_PHOTO']"
		[Register ("REQUEST_CODE_TAKE_PHOTO")]
		public const int RequestCodeTakePhoto = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/field[@name='REQUEST_MULTI_ATTCAHMENT']"
		[Register ("REQUEST_MULTI_ATTCAHMENT")]
		public const int RequestMultiAttcahment = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/field[@name='RESULT_OK']"
		[Register ("RESULT_OK")]
		public const int ResultOk = (int) -1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/fragment/MultimediaOptionFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultimediaOptionFragment); }
		}

		protected MultimediaOptionFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/constructor[@name='MultimediaOptionFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MultimediaOptionFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MultimediaOptionFragment)) {
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

		static Delegate cb_getCapturedImageUri;
#pragma warning disable 0169
		static Delegate GetGetCapturedImageUriHandler ()
		{
			if (cb_getCapturedImageUri == null)
				cb_getCapturedImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCapturedImageUri);
			return cb_getCapturedImageUri;
		}

		static IntPtr n_GetCapturedImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.MultimediaOptionFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.MultimediaOptionFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CapturedImageUri);
		}
#pragma warning restore 0169

		static IntPtr id_getCapturedImageUri;
		public virtual unsafe global::Android.Net.Uri CapturedImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/method[@name='getCapturedImageUri' and count(parameter)=0]"
			[Register ("getCapturedImageUri", "()Landroid/net/Uri;", "GetGetCapturedImageUriHandler")]
			get {
				if (id_getCapturedImageUri == IntPtr.Zero)
					id_getCapturedImageUri = JNIEnv.GetMethodID (class_ref, "getCapturedImageUri", "()Landroid/net/Uri;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCapturedImageUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCapturedImageUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_show_Landroid_support_v4_app_FragmentManager_I;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_support_v4_app_FragmentManager_IHandler ()
		{
			if (cb_show_Landroid_support_v4_app_FragmentManager_I == null)
				cb_show_Landroid_support_v4_app_FragmentManager_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Show_Landroid_support_v4_app_FragmentManager_I);
			return cb_show_Landroid_support_v4_app_FragmentManager_I;
		}

		static void n_Show_Landroid_support_v4_app_FragmentManager_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.MultimediaOptionFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.MultimediaOptionFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentManager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Show (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_show_Landroid_support_v4_app_FragmentManager_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='MultimediaOptionFragment']/method[@name='show' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.FragmentManager'] and parameter[2][@type='int']]"
		[Register ("show", "(Landroid/support/v4/app/FragmentManager;I)V", "GetShow_Landroid_support_v4_app_FragmentManager_IHandler")]
		public virtual unsafe void Show (global::Android.Support.V4.App.FragmentManager p0, int p1)
		{
			if (id_show_Landroid_support_v4_app_FragmentManager_I == IntPtr.Zero)
				id_show_Landroid_support_v4_app_FragmentManager_I = JNIEnv.GetMethodID (class_ref, "show", "(Landroid/support/v4/app/FragmentManager;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_show_Landroid_support_v4_app_FragmentManager_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "(Landroid/support/v4/app/FragmentManager;I)V"), __args);
			} finally {
			}
		}

	}
}
