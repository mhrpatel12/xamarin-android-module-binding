using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Schedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledMessageAdapter']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/schedule/ScheduledMessageAdapter", DoNotGenerateAcw=true)]
	public partial class ScheduledMessageAdapter : global::Android.Widget.ArrayAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/schedule/ScheduledMessageAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScheduledMessageAdapter); }
		}

		protected ScheduledMessageAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_ILjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledMessageAdapter']/constructor[@name='ScheduledMessageAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;ILjava/util/List;)V", "")]
		public unsafe ScheduledMessageAdapter (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (ScheduledMessageAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;ILjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;ILjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ILjava_util_List_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
