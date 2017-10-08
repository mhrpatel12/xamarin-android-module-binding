using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Account.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='RegisteredUsersAsyncTask']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask", DoNotGenerateAcw=true)]
	public partial class RegisteredUsersAsyncTask : global::Android.OS.AsyncTask {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/interface[@name='RegisteredUsersAsyncTask.TaskListener']"
		[Register ("com/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener", "", "Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask/ITaskListenerInvoker")]
		public partial interface ITaskListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/interface[@name='RegisteredUsersAsyncTask.TaskListener']/method[@name='onCompletion' and count(parameter)=0]"
			[Register ("onCompletion", "()V", "GetOnCompletionHandler:Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask/ITaskListenerInvoker, AndroidMobicomkitBinding")]
			void OnCompletion ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/interface[@name='RegisteredUsersAsyncTask.TaskListener']/method[@name='onFailure' and count(parameter)=3 and parameter[1][@type='com.applozic.mobicomkit.feed.RegisteredUsersApiResponse'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.Exception']]"
			[Register ("onFailure", "(Lcom/applozic/mobicomkit/feed/RegisteredUsersApiResponse;[Ljava/lang/String;Ljava/lang/Exception;)V", "GetOnFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_Handler:Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask/ITaskListenerInvoker, AndroidMobicomkitBinding")]
			void OnFailure (global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0, string[] p1, global::Java.Lang.Exception p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/interface[@name='RegisteredUsersAsyncTask.TaskListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.feed.RegisteredUsersApiResponse'] and parameter[2][@type='java.lang.String[]']]"
			[Register ("onSuccess", "(Lcom/applozic/mobicomkit/feed/RegisteredUsersApiResponse;[Ljava/lang/String;)V", "GetOnSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Handler:Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask/ITaskListenerInvoker, AndroidMobicomkitBinding")]
			void OnSuccess (global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0, string[] p1);

		}

		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener", DoNotGenerateAcw=true)]
		internal class ITaskListenerInvoker : global::Java.Lang.Object, ITaskListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.api.account.user.RegisteredUsersAsyncTask.TaskListener"));
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
				global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask.ITaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask.ITaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static Delegate cb_onFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_Handler ()
			{
				if (cb_onFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_ == null)
					cb_onFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_);
				return cb_onFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_;
			}

			static void n_OnFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask.ITaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask.ITaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
				global::Java.Lang.Exception p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0, p1, p2);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_;
			public unsafe void OnFailure (global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0, string[] p1, global::Java.Lang.Exception p2)
			{
				if (id_onFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/applozic/mobicomkit/feed/RegisteredUsersApiResponse;[Ljava/lang/String;Ljava/lang/Exception;)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Ljava_lang_Exception_, __args);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_onSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_Handler ()
			{
				if (cb_onSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_ == null)
					cb_onSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_);
				return cb_onSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_;
			}

			static void n_OnSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask.ITaskListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask.ITaskListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
				string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
				__this.OnSuccess (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_;
			public unsafe void OnSuccess (global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0, string[] p1)
			{
				if (id_onSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_ == IntPtr.Zero)
					id_onSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/applozic/mobicomkit/feed/RegisteredUsersApiResponse;[Ljava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_applozic_mobicomkit_feed_RegisteredUsersApiResponse_arrayLjava_lang_String_, __args);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		public partial class FailureEventArgs : global::System.EventArgs {

			public FailureEventArgs (global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0, string[] p1, global::Java.Lang.Exception p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0;
			public global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse P0 {
				get { return p0; }
			}

			string[] p1;
			public string[] P1 {
				get { return p1; }
			}

			global::Java.Lang.Exception p2;
			public global::Java.Lang.Exception P2 {
				get { return p2; }
			}
		}

		public partial class SuccessEventArgs : global::System.EventArgs {

			public SuccessEventArgs (global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0, string[] p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0;
			public global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse P0 {
				get { return p0; }
			}

			string[] p1;
			public string[] P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask_TaskListenerImplementor")]
		internal sealed partial class ITaskListenerImplementor : global::Java.Lang.Object, ITaskListener {

			object sender;

			public ITaskListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask_TaskListenerImplementor", "()V"),
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

			public void OnFailure (global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0, string[] p1, global::Java.Lang.Exception p2)
			{
				var __h = OnFailureHandler;
				if (__h != null)
					__h (sender, new FailureEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

			public void OnSuccess (global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse p0, string[] p1)
			{
				var __h = OnSuccessHandler;
				if (__h != null)
					__h (sender, new SuccessEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (ITaskListenerImplementor value)
			{
				return value.OnCompletionHandler == null && value.OnFailureHandler == null && value.OnSuccessHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegisteredUsersAsyncTask); }
		}

		protected RegisteredUsersAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_ILcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='RegisteredUsersAsyncTask']/constructor[@name='RegisteredUsersAsyncTask' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.api.account.user.RegisteredUsersAsyncTask.TaskListener'] and parameter[3][@type='int'] and parameter[4][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener;ILcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "")]
		public unsafe RegisteredUsersAsyncTask (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask.ITaskListener p1, int p2, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (RegisteredUsersAsyncTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener;ILcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener;ILcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_ILcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_ILcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener;ILcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_ILcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_ILcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_IJLcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='RegisteredUsersAsyncTask']/constructor[@name='RegisteredUsersAsyncTask' and count(parameter)=7 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.api.account.user.RegisteredUsersAsyncTask.TaskListener'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener;IJLcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;Z)V", "")]
		public unsafe RegisteredUsersAsyncTask (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask.ITaskListener p1, int p2, long p3, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p4, string p5, bool p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				if (((object) this).GetType () != typeof (RegisteredUsersAsyncTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener;IJLcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener;IJLcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_IJLcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_IJLcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/RegisteredUsersAsyncTask$TaskListener;IJLcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_IJLcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_RegisteredUsersAsyncTask_TaskListener_IJLcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p5);
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Void[] p0 = (global::Java.Lang.Void[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Void));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_doInBackground_arrayLjava_lang_Void_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='RegisteredUsersAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Void...']]"
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.RegisteredUsersAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPostExecute_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='RegisteredUsersAsyncTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
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
