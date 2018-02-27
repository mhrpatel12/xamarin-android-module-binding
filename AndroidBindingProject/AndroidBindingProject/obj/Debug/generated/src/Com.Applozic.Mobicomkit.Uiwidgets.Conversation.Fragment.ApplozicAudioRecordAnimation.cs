using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='ApplozicAudioRecordAnimation']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/fragment/ApplozicAudioRecordAnimation", DoNotGenerateAcw=true)]
	public partial class ApplozicAudioRecordAnimation : global::Android.Views.Animations.Animation {


		static IntPtr NEED_PROXY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='ApplozicAudioRecordAnimation']/field[@name='NEED_PROXY']"
		[Register ("NEED_PROXY")]
		public static bool NeedProxy {
			get {
				if (NEED_PROXY_jfieldId == IntPtr.Zero)
					NEED_PROXY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEED_PROXY", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, NEED_PROXY_jfieldId);
			}
			set {
				if (NEED_PROXY_jfieldId == IntPtr.Zero)
					NEED_PROXY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEED_PROXY", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, NEED_PROXY_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/fragment/ApplozicAudioRecordAnimation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicAudioRecordAnimation); }
		}

		protected ApplozicAudioRecordAnimation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAlpha;
#pragma warning disable 0169
		static Delegate GetGetAlphaHandler ()
		{
			if (cb_getAlpha == null)
				cb_getAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAlpha);
			return cb_getAlpha;
		}

		static float n_GetAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.ApplozicAudioRecordAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.ApplozicAudioRecordAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Alpha;
		}
#pragma warning restore 0169

		static Delegate cb_setAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetAlpha_FHandler ()
		{
			if (cb_setAlpha_F == null)
				cb_setAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAlpha_F);
			return cb_setAlpha_F;
		}

		static void n_SetAlpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.ApplozicAudioRecordAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.ApplozicAudioRecordAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alpha = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAlpha;
		static IntPtr id_setAlpha_F;
		public virtual unsafe float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='ApplozicAudioRecordAnimation']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				if (id_getAlpha == IntPtr.Zero)
					id_getAlpha = JNIEnv.GetMethodID (class_ref, "getAlpha", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAlpha);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlpha", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='ApplozicAudioRecordAnimation']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
			set {
				if (id_setAlpha_F == IntPtr.Zero)
					id_setAlpha_F = JNIEnv.GetMethodID (class_ref, "setAlpha", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlpha_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetX);
			return cb_getX;
		}

		static float n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.ApplozicAudioRecordAnimation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.ApplozicAudioRecordAnimation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='ApplozicAudioRecordAnimation']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "GetGetXHandler")]
		public virtual unsafe float GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getX);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()F"));
			} finally {
			}
		}

		static IntPtr id_getX_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='ApplozicAudioRecordAnimation']/method[@name='getX' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getX", "(Landroid/view/View;)F", "")]
		public static unsafe float GetX (global::Android.Views.View p0)
		{
			if (id_getX_Landroid_view_View_ == IntPtr.Zero)
				id_getX_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "getX", "(Landroid/view/View;)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_getX_Landroid_view_View_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setAlpha_Landroid_view_View_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='ApplozicAudioRecordAnimation']/method[@name='setAlpha' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("setAlpha", "(Landroid/view/View;F)V", "")]
		public static unsafe void SetAlpha (global::Android.Views.View p0, float p1)
		{
			if (id_setAlpha_Landroid_view_View_F == IntPtr.Zero)
				id_setAlpha_Landroid_view_View_F = JNIEnv.GetStaticMethodID (class_ref, "setAlpha", "(Landroid/view/View;F)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAlpha_Landroid_view_View_F, __args);
			} finally {
			}
		}

		static IntPtr id_wrap_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='ApplozicAudioRecordAnimation']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("wrap", "(Landroid/view/View;)Lcom/applozic/mobicomkit/uiwidgets/conversation/fragment/ApplozicAudioRecordAnimation;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.ApplozicAudioRecordAnimation Wrap (global::Android.Views.View p0)
		{
			if (id_wrap_Landroid_view_View_ == IntPtr.Zero)
				id_wrap_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Landroid/view/View;)Lcom/applozic/mobicomkit/uiwidgets/conversation/fragment/ApplozicAudioRecordAnimation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.ApplozicAudioRecordAnimation __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.ApplozicAudioRecordAnimation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
