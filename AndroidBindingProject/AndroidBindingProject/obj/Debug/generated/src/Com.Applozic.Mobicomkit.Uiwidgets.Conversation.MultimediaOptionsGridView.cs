using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MultimediaOptionsGridView']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/MultimediaOptionsGridView", DoNotGenerateAcw=true)]
	public partial class MultimediaOptionsGridView : global::Java.Lang.Object {


		static IntPtr showPopup_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MultimediaOptionsGridView']/field[@name='showPopup']"
		[Register ("showPopup")]
		public global::Android.Widget.PopupWindow ShowPopup {
			get {
				if (showPopup_jfieldId == IntPtr.Zero)
					showPopup_jfieldId = JNIEnv.GetFieldID (class_ref, "showPopup", "Landroid/widget/PopupWindow;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, showPopup_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.PopupWindow> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (showPopup_jfieldId == IntPtr.Zero)
					showPopup_jfieldId = JNIEnv.GetFieldID (class_ref, "showPopup", "Landroid/widget/PopupWindow;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, showPopup_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/MultimediaOptionsGridView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultimediaOptionsGridView); }
		}

		protected MultimediaOptionsGridView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_support_v4_app_FragmentActivity_Landroid_widget_GridView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MultimediaOptionsGridView']/constructor[@name='MultimediaOptionsGridView' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.FragmentActivity'] and parameter[2][@type='android.widget.GridView']]"
		[Register (".ctor", "(Landroid/support/v4/app/FragmentActivity;Landroid/widget/GridView;)V", "")]
		public unsafe MultimediaOptionsGridView (global::Android.Support.V4.App.FragmentActivity p0, global::Android.Widget.GridView p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MultimediaOptionsGridView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/support/v4/app/FragmentActivity;Landroid/widget/GridView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/support/v4/app/FragmentActivity;Landroid/widget/GridView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_support_v4_app_FragmentActivity_Landroid_widget_GridView_ == IntPtr.Zero)
					id_ctor_Landroid_support_v4_app_FragmentActivity_Landroid_widget_GridView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v4/app/FragmentActivity;Landroid/widget/GridView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v4_app_FragmentActivity_Landroid_widget_GridView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_support_v4_app_FragmentActivity_Landroid_widget_GridView_, __args);
			} finally {
			}
		}

		static Delegate cb_executeMethod_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetExecuteMethod_Ljava_lang_String_Handler ()
		{
			if (cb_executeMethod_Ljava_lang_String_ == null)
				cb_executeMethod_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ExecuteMethod_Ljava_lang_String_);
			return cb_executeMethod_Ljava_lang_String_;
		}

		static void n_ExecuteMethod_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MultimediaOptionsGridView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MultimediaOptionsGridView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExecuteMethod (p0);
		}
#pragma warning restore 0169

		static IntPtr id_executeMethod_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MultimediaOptionsGridView']/method[@name='executeMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("executeMethod", "(Ljava/lang/String;)V", "GetExecuteMethod_Ljava_lang_String_Handler")]
		public virtual unsafe void ExecuteMethod (string p0)
		{
			if (id_executeMethod_Ljava_lang_String_ == IntPtr.Zero)
				id_executeMethod_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "executeMethod", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_executeMethod_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeMethod", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMultimediaClickListener_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetMultimediaClickListener_Ljava_util_List_Handler ()
		{
			if (cb_setMultimediaClickListener_Ljava_util_List_ == null)
				cb_setMultimediaClickListener_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMultimediaClickListener_Ljava_util_List_);
			return cb_setMultimediaClickListener_Ljava_util_List_;
		}

		static void n_SetMultimediaClickListener_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MultimediaOptionsGridView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MultimediaOptionsGridView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMultimediaClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMultimediaClickListener_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MultimediaOptionsGridView']/method[@name='setMultimediaClickListener' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setMultimediaClickListener", "(Ljava/util/List;)V", "GetSetMultimediaClickListener_Ljava_util_List_Handler")]
		public virtual unsafe void SetMultimediaClickListener (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_setMultimediaClickListener_Ljava_util_List_ == IntPtr.Zero)
				id_setMultimediaClickListener_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setMultimediaClickListener", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMultimediaClickListener_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMultimediaClickListener", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
