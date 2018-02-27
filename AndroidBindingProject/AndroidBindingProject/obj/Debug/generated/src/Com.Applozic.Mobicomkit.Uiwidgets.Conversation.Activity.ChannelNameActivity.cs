using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ChannelNameActivity", DoNotGenerateAcw=true)]
	public partial class ChannelNameActivity : global::Android.Support.V7.App.AppCompatActivity, global::Android.Support.V4.App.ActivityCompat.IOnRequestPermissionsResultCallback, global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IRemoveInterfaceListener, global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IMobicomkitUriListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']/field[@name='CHANNEL_IMAGE_URL']"
		[Register ("CHANNEL_IMAGE_URL")]
		public const string ChannelImageUrl = (string) "IMAGE_URL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']/field[@name='CHANNEL_NAME']"
		[Register ("CHANNEL_NAME")]
		public const string ChannelName = (string) "CHANNEL_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']/field[@name='REQUEST_CODE_ATTACH_PHOTO']"
		[Register ("REQUEST_CODE_ATTACH_PHOTO")]
		public const int RequestCodeAttachPhoto = (int) 101;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity.ProfilePictureUpload']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ChannelNameActivity$ProfilePictureUpload", DoNotGenerateAcw=true)]
		public partial class ProfilePictureUpload : global::Android.OS.AsyncTask {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ChannelNameActivity$ProfilePictureUpload", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProfilePictureUpload); }
			}

			protected ProfilePictureUpload (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ChannelNameActivity_Landroid_content_Context_Landroid_widget_ImageView_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity.ProfilePictureUpload']/constructor[@name='ChannelNameActivity.ProfilePictureUpload' and count(parameter)=4 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.activity.ChannelNameActivity'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.widget.ImageView'] and parameter[4][@type='com.applozic.mobicomkit.feed.GroupInfoUpdate']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/activity/ChannelNameActivity;Landroid/content/Context;Landroid/widget/ImageView;Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)V", "")]
			public unsafe ProfilePictureUpload (global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity __self, global::Android.Content.Context p1, global::Android.Widget.ImageView p2, global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (((object) this).GetType () != typeof (ProfilePictureUpload)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/widget/ImageView;Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;Landroid/widget/ImageView;Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ChannelNameActivity_Landroid_content_Context_Landroid_widget_ImageView_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ChannelNameActivity_Landroid_content_Context_Landroid_widget_ImageView_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/activity/ChannelNameActivity;Landroid/content/Context;Landroid/widget/ImageView;Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ChannelNameActivity_Landroid_content_Context_Landroid_widget_ImageView_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ChannelNameActivity_Landroid_content_Context_Landroid_widget_ImageView_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_, __args);
				} finally {
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Object_ == null)
					cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
				return cb_doInBackground_arrayLjava_lang_Object_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity.ProfilePictureUpload __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity.ProfilePictureUpload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity.ProfilePictureUpload']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
			[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
			protected override unsafe global::Java.Lang.Object DoInBackground (global::Java.Lang.Object[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Void_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Void_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Void_ == null)
					cb_doInBackground_arrayLjava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Void_);
				return cb_doInBackground_arrayLjava_lang_Void_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity.ProfilePictureUpload __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity.ProfilePictureUpload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Void[] p0 = (global::Java.Lang.Void[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Void));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Void_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity.ProfilePictureUpload']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Void...']]"
			[Register ("doInBackground", "([Ljava/lang/Void;)Ljava/lang/Boolean;", "GetDoInBackground_arrayLjava_lang_Void_Handler")]
			protected virtual unsafe global::Java.Lang.Boolean DoInBackground (params global:: Java.Lang.Void[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Void_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Boolean;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Boolean __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Void_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Boolean;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_onPostExecute_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Ljava_lang_Boolean_Handler ()
			{
				if (cb_onPostExecute_Ljava_lang_Boolean_ == null)
					cb_onPostExecute_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Boolean_);
				return cb_onPostExecute_Ljava_lang_Boolean_;
			}

			static void n_OnPostExecute_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity.ProfilePictureUpload __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity.ProfilePictureUpload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPostExecute_Ljava_lang_Boolean_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity.ProfilePictureUpload']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("onPostExecute", "(Ljava/lang/Boolean;)V", "GetOnPostExecute_Ljava_lang_Boolean_Handler")]
			protected virtual unsafe void OnPostExecute (global::Java.Lang.Boolean p0)
			{
				if (id_onPostExecute_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_onPostExecute_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostExecute_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ChannelNameActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelNameActivity); }
		}

		protected ChannelNameActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']/constructor[@name='ChannelNameActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChannelNameActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChannelNameActivity)) {
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

		static Delegate cb_getCurrentImageUri;
#pragma warning disable 0169
		static Delegate GetGetCurrentImageUriHandler ()
		{
			if (cb_getCurrentImageUri == null)
				cb_getCurrentImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentImageUri);
			return cb_getCurrentImageUri;
		}

		static IntPtr n_GetCurrentImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentImageUri);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentImageUri;
		public virtual unsafe global::Android.Net.Uri CurrentImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']/method[@name='getCurrentImageUri' and count(parameter)=0]"
			[Register ("getCurrentImageUri", "()Landroid/net/Uri;", "GetGetCurrentImageUriHandler")]
			get {
				if (id_getCurrentImageUri == IntPtr.Zero)
					id_getCurrentImageUri = JNIEnv.GetMethodID (class_ref, "getCurrentImageUri", "()Landroid/net/Uri;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentImageUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentImageUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_handleOnActivityResult_ILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetHandleOnActivityResult_ILandroid_content_Intent_Handler ()
		{
			if (cb_handleOnActivityResult_ILandroid_content_Intent_ == null)
				cb_handleOnActivityResult_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_HandleOnActivityResult_ILandroid_content_Intent_);
			return cb_handleOnActivityResult_ILandroid_content_Intent_;
		}

		static void n_HandleOnActivityResult_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleOnActivityResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleOnActivityResult_ILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']/method[@name='handleOnActivityResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
		[Register ("handleOnActivityResult", "(ILandroid/content/Intent;)V", "GetHandleOnActivityResult_ILandroid_content_Intent_Handler")]
		public virtual unsafe void HandleOnActivityResult (int p0, global::Android.Content.Intent p1)
		{
			if (id_handleOnActivityResult_ILandroid_content_Intent_ == IntPtr.Zero)
				id_handleOnActivityResult_ILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "handleOnActivityResult", "(ILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleOnActivityResult_ILandroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleOnActivityResult", "(ILandroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processImagePicker;
#pragma warning disable 0169
		static Delegate GetProcessImagePickerHandler ()
		{
			if (cb_processImagePicker == null)
				cb_processImagePicker = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessImagePicker);
			return cb_processImagePicker;
		}

		static void n_ProcessImagePicker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessImagePicker ();
		}
#pragma warning restore 0169

		static IntPtr id_processImagePicker;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']/method[@name='processImagePicker' and count(parameter)=0]"
		[Register ("processImagePicker", "()V", "GetProcessImagePickerHandler")]
		public virtual unsafe void ProcessImagePicker ()
		{
			if (id_processImagePicker == IntPtr.Zero)
				id_processImagePicker = JNIEnv.GetMethodID (class_ref, "processImagePicker", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processImagePicker);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processImagePicker", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeCallBack;
#pragma warning disable 0169
		static Delegate GetRemoveCallBackHandler ()
		{
			if (cb_removeCallBack == null)
				cb_removeCallBack = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveCallBack);
			return cb_removeCallBack;
		}

		static void n_RemoveCallBack (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallBack ();
		}
#pragma warning restore 0169

		static IntPtr id_removeCallBack;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']/method[@name='removeCallBack' and count(parameter)=0]"
		[Register ("removeCallBack", "()V", "GetRemoveCallBackHandler")]
		public virtual unsafe void RemoveCallBack ()
		{
			if (id_removeCallBack == IntPtr.Zero)
				id_removeCallBack = JNIEnv.GetMethodID (class_ref, "removeCallBack", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallBack);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCallBack", "()V"));
			} finally {
			}
		}

		static Delegate cb_showSnackBar_I;
#pragma warning disable 0169
		static Delegate GetShowSnackBar_IHandler ()
		{
			if (cb_showSnackBar_I == null)
				cb_showSnackBar_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ShowSnackBar_I);
			return cb_showSnackBar_I;
		}

		static void n_ShowSnackBar_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ChannelNameActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSnackBar (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showSnackBar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ChannelNameActivity']/method[@name='showSnackBar' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("showSnackBar", "(I)V", "GetShowSnackBar_IHandler")]
		public virtual unsafe void ShowSnackBar (int p0)
		{
			if (id_showSnackBar_I == IntPtr.Zero)
				id_showSnackBar_I = JNIEnv.GetMethodID (class_ref, "showSnackBar", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showSnackBar_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSnackBar", "(I)V"), __args);
			} finally {
			}
		}

	}
}
