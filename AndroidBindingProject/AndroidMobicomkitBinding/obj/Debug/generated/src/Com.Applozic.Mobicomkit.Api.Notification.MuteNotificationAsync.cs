using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationAsync']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/notification/MuteNotificationAsync", DoNotGenerateAcw=true)]
	public partial class MuteNotificationAsync : global::Android.OS.AsyncTask {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/interface[@name='MuteNotificationAsync.TaskListener']"
		[Register ("com/applozic/mobicomkit/api/notification/MuteNotificationAsync$TaskListener", "", "Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync/ITaskListenerInvoker")]
		public partial interface ITaskListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/interface[@name='MuteNotificationAsync.TaskListener']/method[@name='onCompletion' and count(parameter)=0]"
			[Register ("onCompletion", "()V", "GetOnCompletionHandler:Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync/ITaskListenerInvoker, AndroidMobicomkitBinding")]
			void OnCompletion ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/interface[@name='MuteNotificationAsync.TaskListener']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.feed.ApiResponse'] and parameter[2][@type='java.lang.Exception']]"
			[Register ("onFailure", "(Lcom/applozic/mobicomkit/feed/ApiResponse;Ljava/lang/Exception;)V", "GetOnFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_Handler:Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync/ITaskListenerInvoker, AndroidMobicomkitBinding")]
			void OnFailure (global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0, global::Java.Lang.Exception p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/interface[@name='MuteNotificationAsync.TaskListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.feed.ApiResponse']]"
			[Register ("onSuccess", "(Lcom/applozic/mobicomkit/feed/ApiResponse;)V", "GetOnSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_Handler:Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync/ITaskListenerInvoker, AndroidMobicomkitBinding")]
			void OnSuccess (global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0);

		}

		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/notification/MuteNotificationAsync$TaskListener", DoNotGenerateAcw=true)]
		internal class ITaskListenerInvoker : global::Java.Lang.Object, ITaskListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/api/notification/MuteNotificationAsync$TaskListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ITaskListenerInvoker); }
			}

			IntPtr class_ref;

			public static ITaskListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITaskListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.api.notification.MuteNotificationAsync.TaskListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITaskListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCompletion;
#pragma warning disable 0169
			static Delegate GetOnCompletionHandler ()
			{
				if (cb_onCompletion == null)
					cb_onCompletion = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCompletion);
				return cb_onCompletion;
			}

			static void n_OnCompletion (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync.ITaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync.ITaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCompletion ();
			}
#pragma warning restore 0169

			IntPtr id_onCompletion;
			public unsafe void OnCompletion ()
			{
				if (id_onCompletion == IntPtr.Zero)
					id_onCompletion = JNIEnv.GetMethodID (class_ref, "onCompletion", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompletion);
			}

			static Delegate cb_onFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_Handler ()
			{
				if (cb_onFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_ == null)
					cb_onFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_);
				return cb_onFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_;
			}

			static void n_OnFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync.ITaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync.ITaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_;
			public unsafe void OnFailure (global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0, global::Java.Lang.Exception p1)
			{
				if (id_onFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/applozic/mobicomkit/feed/ApiResponse;Ljava/lang/Exception;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_applozic_mobicomkit_feed_ApiResponse_Ljava_lang_Exception_, __args);
			}

			static Delegate cb_onSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_Handler ()
			{
				if (cb_onSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_ == null)
					cb_onSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_);
				return cb_onSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_;
			}

			static void n_OnSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync.ITaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync.ITaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_;
			public unsafe void OnSuccess (global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0)
			{
				if (id_onSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_ == IntPtr.Zero)
					id_onSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/applozic/mobicomkit/feed/ApiResponse;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_applozic_mobicomkit_feed_ApiResponse_, __args);
			}

		}

		public partial class FailureEventArgs : global::System.EventArgs {

			public FailureEventArgs (global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0, global::Java.Lang.Exception p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0;
			public global::Com.Applozic.Mobicomkit.Feed.ApiResponse P0 {
				get { return p0; }
			}

			global::Java.Lang.Exception p1;
			public global::Java.Lang.Exception P1 {
				get { return p1; }
			}
		}

		public partial class SuccessEventArgs : global::System.EventArgs {

			public SuccessEventArgs (global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0)
			{
				this.p0 = p0;
			}

			global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0;
			public global::Com.Applozic.Mobicomkit.Feed.ApiResponse P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/applozic/mobicomkit/api/notification/MuteNotificationAsync_TaskListenerImplementor")]
		internal sealed partial class ITaskListenerImplementor : global::Java.Lang.Object, ITaskListener {

			object sender;

			public ITaskListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applozic/mobicomkit/api/notification/MuteNotificationAsync_TaskListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnCompletionHandler;
#pragma warning restore 0649

			public void OnCompletion ()
			{
				var __h = OnCompletionHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<FailureEventArgs> OnFailureHandler;
#pragma warning restore 0649

			public void OnFailure (global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0, global::Java.Lang.Exception p1)
			{
				var __h = OnFailureHandler;
				if (__h != null)
					__h (sender, new FailureEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

			public void OnSuccess (global::Com.Applozic.Mobicomkit.Feed.ApiResponse p0)
			{
				var __h = OnSuccessHandler;
				if (__h != null)
					__h (sender, new SuccessEventArgs (p0));
			}

			internal static bool __IsEmpty (ITaskListenerImplementor value)
			{
				return value.OnCompletionHandler == null && value.OnFailureHandler == null && value.OnSuccessHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/notification/MuteNotificationAsync", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuteNotificationAsync); }
		}

		protected MuteNotificationAsync (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_notification_MuteNotificationAsync_TaskListener_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationAsync']/constructor[@name='MuteNotificationAsync' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.api.notification.MuteNotificationAsync.TaskListener'] and parameter[3][@type='com.applozic.mobicomkit.api.notification.MuteNotificationRequest']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/notification/MuteNotificationAsync$TaskListener;Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)V", "")]
		public unsafe MuteNotificationAsync (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync.ITaskListener p1, global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MuteNotificationAsync)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/notification/MuteNotificationAsync$TaskListener;Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/notification/MuteNotificationAsync$TaskListener;Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_notification_MuteNotificationAsync_TaskListener_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_notification_MuteNotificationAsync_TaskListener_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/notification/MuteNotificationAsync$TaskListener;Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_notification_MuteNotificationAsync_TaskListener_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_notification_MuteNotificationAsync_TaskListener_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_, __args);
			} finally {
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Void[] p0 = (global::Java.Lang.Void[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Void));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_Void_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationAsync']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Void...']]"
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationAsync> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationAsync']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
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
}
