using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter", DoNotGenerateAcw=true)]
	public partial class DetailedConversationAdapter : global::Android.Support.V7.Widget.RecyclerView.Adapter, global::Android.Widget.IFilterable {


		static IntPtr searchString_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/field[@name='searchString']"
		[Register ("searchString")]
		public string SearchString {
			get {
				if (searchString_jfieldId == IntPtr.Zero)
					searchString_jfieldId = JNIEnv.GetFieldID (class_ref, "searchString", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, searchString_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (searchString_jfieldId == IntPtr.Zero)
					searchString_jfieldId = JNIEnv.GetFieldID (class_ref, "searchString", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, searchString_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder", DoNotGenerateAcw=true)]
		public partial class MyViewHolder : global::Android.Support.V7.Widget.RecyclerView.ViewHolder, global::Android.Views.View.IOnCreateContextMenuListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyViewHolder); }
			}

			protected MyViewHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder']/constructor[@name='DetailedConversationAdapter.MyViewHolder' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.adapter.DetailedConversationAdapter'] and parameter[2][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V", "")]
			public unsafe MyViewHolder (global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __self, global::Android.Views.View p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (MyViewHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args);
				} finally {
				}
			}

			static Delegate cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;
#pragma warning disable 0169
			static Delegate GetOnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_Handler ()
			{
				if (cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ == null)
					cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_);
				return cb_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;
			}

			static void n_OnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter.MyViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter.MyViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IContextMenu p0 = (global::Android.Views.IContextMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IContextMenu> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IContextMenuContextMenuInfo p2 = (global::Android.Views.IContextMenuContextMenuInfo)global::Java.Lang.Object.GetObject<global::Android.Views.IContextMenuContextMenuInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnCreateContextMenu (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder']/method[@name='onCreateContextMenu' and count(parameter)=3 and parameter[1][@type='android.view.ContextMenu'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ContextMenu.ContextMenuInfo']]"
			[Register ("onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", "GetOnCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_Handler")]
			public virtual unsafe void OnCreateContextMenu (global::Android.Views.IContextMenu p0, global::Android.Views.View p1, global::Android.Views.IContextMenuContextMenuInfo p2)
			{
				if (id_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ == IntPtr.Zero)
					id_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_ = JNIEnv.GetMethodID (class_ref, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreateContextMenu_Landroid_view_ContextMenu_Landroid_view_View_Landroid_view_ContextMenu_ContextMenuInfo_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder2']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder2", DoNotGenerateAcw=true)]
		public partial class MyViewHolder2 : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder2", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyViewHolder2); }
			}

			protected MyViewHolder2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder2']/constructor[@name='DetailedConversationAdapter.MyViewHolder2' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.adapter.DetailedConversationAdapter'] and parameter[2][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V", "")]
			public unsafe MyViewHolder2 (global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __self, global::Android.Views.View p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (MyViewHolder2)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder3']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder3", DoNotGenerateAcw=true)]
		public partial class MyViewHolder3 : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder3", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyViewHolder3); }
			}

			protected MyViewHolder3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder3']/constructor[@name='DetailedConversationAdapter.MyViewHolder3' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.adapter.DetailedConversationAdapter'] and parameter[2][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V", "")]
			public unsafe MyViewHolder3 (global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __self, global::Android.Views.View p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (MyViewHolder3)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder4']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder4", DoNotGenerateAcw=true)]
		public partial class MyViewHolder4 : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder4", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyViewHolder4); }
			}

			protected MyViewHolder4 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder4']/constructor[@name='DetailedConversationAdapter.MyViewHolder4' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.adapter.DetailedConversationAdapter'] and parameter[2][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V", "")]
			public unsafe MyViewHolder4 (global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __self, global::Android.Views.View p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (MyViewHolder4)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder5']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder5", DoNotGenerateAcw=true)]
		public partial class MyViewHolder5 : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter$MyViewHolder5", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyViewHolder5); }
			}

			protected MyViewHolder5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter.MyViewHolder5']/constructor[@name='DetailedConversationAdapter.MyViewHolder5' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.adapter.DetailedConversationAdapter'] and parameter[2][@type='android.view.View']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V", "")]
			public unsafe MyViewHolder5 (global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __self, global::Android.Views.View p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (MyViewHolder5)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter;Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_adapter_DetailedConversationAdapter_Landroid_view_View_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/adapter/DetailedConversationAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetailedConversationAdapter); }
		}

		protected DetailedConversationAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/constructor[@name='DetailedConversationAdapter' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;'] and parameter[4][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[5][@type='java.lang.Class'] and parameter[6][@type='com.applozic.mobicommons.emoticon.EmojiconHandler']]"
		[Register (".ctor", "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V", "")]
		public unsafe DetailedConversationAdapter (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p2, global::Com.Applozic.Mobicommons.People.Contact.Contact p3, global::Java.Lang.Class p4, global::Com.Applozic.Mobicommons.Emoticon.IEmojiconHandler p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (DetailedConversationAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/constructor[@name='DetailedConversationAdapter' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;'] and parameter[4][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[5][@type='java.lang.Class'] and parameter[6][@type='com.applozic.mobicommons.emoticon.EmojiconHandler']]"
		[Register (".ctor", "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V", "")]
		public unsafe DetailedConversationAdapter (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p2, global::Com.Applozic.Mobicommons.People.Channel.Channel p3, global::Java.Lang.Class p4, global::Com.Applozic.Mobicommons.Emoticon.IEmojiconHandler p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (DetailedConversationAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/constructor[@name='DetailedConversationAdapter' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;'] and parameter[4][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[5][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[6][@type='java.lang.Class'] and parameter[7][@type='com.applozic.mobicommons.emoticon.EmojiconHandler']]"
		[Register (".ctor", "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V", "")]
		public unsafe DetailedConversationAdapter (global::Android.Content.Context p0, int p1, global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p2, global::Com.Applozic.Mobicommons.People.Contact.Contact p3, global::Com.Applozic.Mobicommons.People.Channel.Channel p4, global::Java.Lang.Class p5, global::Com.Applozic.Mobicommons.Emoticon.IEmojiconHandler p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				if (((object) this).GetType () != typeof (DetailedConversationAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILjava/util/List;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Class;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Class_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getFilter;
#pragma warning disable 0169
		static Delegate GetGetFilterHandler ()
		{
			if (cb_getFilter == null)
				cb_getFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilter);
			return cb_getFilter;
		}

		static IntPtr n_GetFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Filter);
		}
#pragma warning restore 0169

		static IntPtr id_getFilter;
		public virtual unsafe global::Android.Widget.Filter Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Landroid/widget/Filter;", "GetGetFilterHandler")]
			get {
				if (id_getFilter == IntPtr.Zero)
					id_getFilter = JNIEnv.GetMethodID (class_ref, "getFilter", "()Landroid/widget/Filter;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.Filter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.Filter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilter", "()Landroid/widget/Filter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemCount);
			return cb_getItemCount;
		}

		static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public override unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageLayoutParam_Z;
#pragma warning disable 0169
		static Delegate GetGetImageLayoutParam_ZHandler ()
		{
			if (cb_getImageLayoutParam_Z == null)
				cb_getImageLayoutParam_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_GetImageLayoutParam_Z);
			return cb_getImageLayoutParam_Z;
		}

		static IntPtr n_GetImageLayoutParam_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetImageLayoutParam (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getImageLayoutParam_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/method[@name='getImageLayoutParam' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getImageLayoutParam", "(Z)Landroid/view/ViewGroup$LayoutParams;", "GetGetImageLayoutParam_ZHandler")]
		public virtual unsafe global::Android.Views.ViewGroup.LayoutParams GetImageLayoutParam (bool p0)
		{
			if (id_getImageLayoutParam_Z == IntPtr.Zero)
				id_getImageLayoutParam_Z = JNIEnv.GetMethodID (class_ref, "getImageLayoutParam", "(Z)Landroid/view/ViewGroup$LayoutParams;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.LayoutParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageLayoutParam_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.LayoutParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageLayoutParam", "(Z)Landroid/view/ViewGroup$LayoutParams;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
		static Delegate GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
		{
			if (cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
				cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I);
			return cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		}

		static void n_OnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBindViewHolder (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
		[Register ("onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler")]
		public override unsafe void OnBindViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
		{
			if (id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
				id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
		static Delegate GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler ()
		{
			if (cb_onCreateViewHolder_Landroid_view_ViewGroup_I == null)
				cb_onCreateViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnCreateViewHolder_Landroid_view_ViewGroup_I);
			return cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
		}

		static IntPtr n_OnCreateViewHolder_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateViewHolder (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateViewHolder_Landroid_view_ViewGroup_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/method[@name='onCreateViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
		[Register ("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
		public override unsafe global::Android.Support.V7.Widget.RecyclerView.ViewHolder OnCreateViewHolder (global::Android.Views.ViewGroup p0, int p1)
		{
			if (id_onCreateViewHolder_Landroid_view_ViewGroup_I == IntPtr.Zero)
				id_onCreateViewHolder_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Support.V7.Widget.RecyclerView.ViewHolder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateViewHolder_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_refreshContactData;
#pragma warning disable 0169
		static Delegate GetRefreshContactDataHandler ()
		{
			if (cb_refreshContactData == null)
				cb_refreshContactData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RefreshContactData);
			return cb_refreshContactData;
		}

		static void n_RefreshContactData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshContactData ();
		}
#pragma warning restore 0169

		static IntPtr id_refreshContactData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/method[@name='refreshContactData' and count(parameter)=0]"
		[Register ("refreshContactData", "()V", "GetRefreshContactDataHandler")]
		public virtual unsafe void RefreshContactData ()
		{
			if (id_refreshContactData == IntPtr.Zero)
				id_refreshContactData = JNIEnv.GetMethodID (class_ref, "refreshContactData", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshContactData);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshContactData", "()V"));
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAlCustomizationSettings (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/method[@name='setAlCustomizationSettings' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.AlCustomizationSettings']]"
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

		static Delegate cb_setContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_;
#pragma warning disable 0169
		static Delegate GetSetContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_Handler ()
		{
			if (cb_setContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_ == null)
				cb_setContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_);
			return cb_setContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_;
		}

		static void n_SetContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Adapter.DetailedConversationAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListener p0 = (global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListener)global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetContextMenuClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.adapter']/class[@name='DetailedConversationAdapter']/method[@name='setContextMenuClickListener' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.uilistener.ContextMenuClickListener']]"
		[Register ("setContextMenuClickListener", "(Lcom/applozic/mobicomkit/uiwidgets/uilistener/ContextMenuClickListener;)V", "GetSetContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_Handler")]
		public virtual unsafe void SetContextMenuClickListener (global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListener p0)
		{
			if (id_setContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_ == IntPtr.Zero)
				id_setContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_ = JNIEnv.GetMethodID (class_ref, "setContextMenuClickListener", "(Lcom/applozic/mobicomkit/uiwidgets/uilistener/ContextMenuClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContextMenuClickListener_Lcom_applozic_mobicomkit_uiwidgets_uilistener_ContextMenuClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContextMenuClickListener", "(Lcom/applozic/mobicomkit/uiwidgets/uilistener/ContextMenuClickListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListener"
		public event EventHandler<global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.ContextMenuClickEventArgs> ContextMenuClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListener, global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListenerImplementor>(
						ref weak_implementor_SetContextMenuClickListener,
						__CreateIContextMenuClickListenerImplementor,
						SetContextMenuClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListener, global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListenerImplementor>(
						ref weak_implementor_SetContextMenuClickListener,
						global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListenerImplementor.__IsEmpty,
						__v => SetContextMenuClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetContextMenuClickListener;

		global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListenerImplementor __CreateIContextMenuClickListenerImplementor ()
		{
			return new global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListenerImplementor (this);
		}
#endregion
	}
}
