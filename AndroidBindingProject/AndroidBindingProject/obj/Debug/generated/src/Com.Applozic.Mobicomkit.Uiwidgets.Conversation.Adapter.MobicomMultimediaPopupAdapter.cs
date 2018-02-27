using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='MobicomMultimediaPopupAdapter']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/MobicomMultimediaPopupAdapter", DoNotGenerateAcw=true)]
	public partial class MobicomMultimediaPopupAdapter : global::Android.Widget.BaseAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/MobicomMultimediaPopupAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobicomMultimediaPopupAdapter); }
		}

		protected MobicomMultimediaPopupAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='MobicomMultimediaPopupAdapter']/constructor[@name='MobicomMultimediaPopupAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Ljava/util/List;)V", "")]
		public unsafe MobicomMultimediaPopupAdapter (global::Android.Content.Context p0, global::System.Collections.Generic.IList<string> p1, global::System.Collections.Generic.IList<string> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (MobicomMultimediaPopupAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/util/List;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/util/List;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='MobicomMultimediaPopupAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='MobicomMultimediaPopupAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
		public override unsafe global::Java.Lang.Object GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getItemId_I;
#pragma warning disable 0169
		static Delegate GetGetItemId_IHandler ()
		{
			if (cb_getItemId_I == null)
				cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
			return cb_getItemId_I;
		}

		static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetItemId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getItemId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='MobicomMultimediaPopupAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
		public override unsafe long GetItemId (int p0)
		{
			if (id_getItemId_I == IntPtr.Zero)
				id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getItemId_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
		static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
		{
			if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
				cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
			return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		}

		static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='MobicomMultimediaPopupAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
		[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
		public override unsafe global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
		{
			if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
				id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Android.Views.View __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_;
#pragma warning disable 0169
		static Delegate GetSetAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_Handler ()
		{
			if (cb_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ == null)
				cb_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_);
			return cb_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_;
		}

		static void n_SetAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.MobicomMultimediaPopupAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAlCustomizationSettings (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='MobicomMultimediaPopupAdapter']/method[@name='setAlCustomizationSettings' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.AlCustomizationSettings']]"
		[Register ("setAlCustomizationSettings", "(Lcom/applozic/mobicomkit/uiwidgets/AlCustomizationSettings;)V", "GetSetAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_Handler")]
		public virtual unsafe void SetAlCustomizationSettings (global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings p0)
		{
			if (id_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ == IntPtr.Zero)
				id_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ = JNIEnv.GetMethodID (class_ref, "setAlCustomizationSettings", "(Lcom/applozic/mobicomkit/uiwidgets/AlCustomizationSettings;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlCustomizationSettings", "(Lcom/applozic/mobicomkit/uiwidgets/AlCustomizationSettings;)V"), __args);
			} finally {
			}
		}

	}
}
