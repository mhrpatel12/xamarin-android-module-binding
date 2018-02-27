using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Listners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']"
	[Register ("com/applozic/mobicomkit/listners/ApplozicUIListener", "", "Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker")]
	public partial interface IApplozicUIListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onAllMessagesDelivered' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAllMessagesDelivered", "(Ljava/lang/String;)V", "GetOnAllMessagesDelivered_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnAllMessagesDelivered (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onAllMessagesRead' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onAllMessagesRead", "(Ljava/lang/String;)V", "GetOnAllMessagesRead_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnAllMessagesRead (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onChannelUpdated' and count(parameter)=0]"
		[Register ("onChannelUpdated", "()V", "GetOnChannelUpdatedHandler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnChannelUpdated ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onConversationDeleted' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.String']]"
		[Register ("onConversationDeleted", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V", "GetOnConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnConversationDeleted (string p0, global::Java.Lang.Integer p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onConversationRead' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("onConversationRead", "(Ljava/lang/String;Z)V", "GetOnConversationRead_Ljava_lang_String_ZHandler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnConversationRead (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onLoadMore' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onLoadMore", "(Z)V", "GetOnLoadMore_ZHandler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnLoadMore (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onMessageDeleted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onMessageDeleted", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnMessageDeleted_Ljava_lang_String_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnMessageDeleted (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onMessageDelivered' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("onMessageDelivered", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "GetOnMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnMessageDelivered (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onMessageMetadataUpdated' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onMessageMetadataUpdated", "(Ljava/lang/String;)V", "GetOnMessageMetadataUpdated_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnMessageMetadataUpdated (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onMessageReceived' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("onMessageReceived", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetOnMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnMessageReceived (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onMessageSent' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("onMessageSent", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetOnMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnMessageSent (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onMessageSync' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("onMessageSync", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "GetOnMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnMessageSync (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onMqttDisconnected' and count(parameter)=0]"
		[Register ("onMqttDisconnected", "()V", "GetOnMqttDisconnectedHandler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnMqttDisconnected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onUpdateLastSeen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onUpdateLastSeen", "(Ljava/lang/String;)V", "GetOnUpdateLastSeen_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnUpdateLastSeen (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onUpdateTypingStatus' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onUpdateTypingStatus", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnUpdateTypingStatus (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='ApplozicUIListener']/method[@name='onUserDetailUpdated' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onUserDetailUpdated", "(Ljava/lang/String;)V", "GetOnUserDetailUpdated_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Listners.IApplozicUIListenerInvoker, AndroidMobicomkitBinding")]
		void OnUserDetailUpdated (string p0);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/listners/ApplozicUIListener", DoNotGenerateAcw=true)]
	internal class IApplozicUIListenerInvoker : global::Java.Lang.Object, IApplozicUIListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/listners/ApplozicUIListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IApplozicUIListenerInvoker); }
		}

		IntPtr class_ref;

		public static IApplozicUIListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApplozicUIListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.listners.ApplozicUIListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApplozicUIListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAllMessagesDelivered_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAllMessagesDelivered_Ljava_lang_String_Handler ()
		{
			if (cb_onAllMessagesDelivered_Ljava_lang_String_ == null)
				cb_onAllMessagesDelivered_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAllMessagesDelivered_Ljava_lang_String_);
			return cb_onAllMessagesDelivered_Ljava_lang_String_;
		}

		static void n_OnAllMessagesDelivered_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAllMessagesDelivered (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAllMessagesDelivered_Ljava_lang_String_;
		public unsafe void OnAllMessagesDelivered (string p0)
		{
			if (id_onAllMessagesDelivered_Ljava_lang_String_ == IntPtr.Zero)
				id_onAllMessagesDelivered_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAllMessagesDelivered", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAllMessagesDelivered_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onAllMessagesRead_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAllMessagesRead_Ljava_lang_String_Handler ()
		{
			if (cb_onAllMessagesRead_Ljava_lang_String_ == null)
				cb_onAllMessagesRead_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAllMessagesRead_Ljava_lang_String_);
			return cb_onAllMessagesRead_Ljava_lang_String_;
		}

		static void n_OnAllMessagesRead_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAllMessagesRead (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAllMessagesRead_Ljava_lang_String_;
		public unsafe void OnAllMessagesRead (string p0)
		{
			if (id_onAllMessagesRead_Ljava_lang_String_ == IntPtr.Zero)
				id_onAllMessagesRead_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAllMessagesRead", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAllMessagesRead_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onChannelUpdated;
#pragma warning disable 0169
		static Delegate GetOnChannelUpdatedHandler ()
		{
			if (cb_onChannelUpdated == null)
				cb_onChannelUpdated = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnChannelUpdated);
			return cb_onChannelUpdated;
		}

		static void n_OnChannelUpdated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnChannelUpdated ();
		}
#pragma warning restore 0169

		IntPtr id_onChannelUpdated;
		public unsafe void OnChannelUpdated ()
		{
			if (id_onChannelUpdated == IntPtr.Zero)
				id_onChannelUpdated = JNIEnv.GetMethodID (class_ref, "onChannelUpdated", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChannelUpdated);
		}

		static Delegate cb_onConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_onConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_onConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_onConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static void n_OnConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationDeleted (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
		public unsafe void OnConversationDeleted (string p0, global::Java.Lang.Integer p1, string p2)
		{
			if (id_onConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_onConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConversationDeleted", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationDeleted_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onConversationRead_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnConversationRead_Ljava_lang_String_ZHandler ()
		{
			if (cb_onConversationRead_Ljava_lang_String_Z == null)
				cb_onConversationRead_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnConversationRead_Ljava_lang_String_Z);
			return cb_onConversationRead_Ljava_lang_String_Z;
		}

		static void n_OnConversationRead_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationRead (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConversationRead_Ljava_lang_String_Z;
		public unsafe void OnConversationRead (string p0, bool p1)
		{
			if (id_onConversationRead_Ljava_lang_String_Z == IntPtr.Zero)
				id_onConversationRead_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onConversationRead", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationRead_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onLoadMore_Z;
#pragma warning disable 0169
		static Delegate GetOnLoadMore_ZHandler ()
		{
			if (cb_onLoadMore_Z == null)
				cb_onLoadMore_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnLoadMore_Z);
			return cb_onLoadMore_Z;
		}

		static void n_OnLoadMore_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadMore (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLoadMore_Z;
		public unsafe void OnLoadMore (bool p0)
		{
			if (id_onLoadMore_Z == IntPtr.Zero)
				id_onLoadMore_Z = JNIEnv.GetMethodID (class_ref, "onLoadMore", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadMore_Z, __args);
		}

		static Delegate cb_onMessageDeleted_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessageDeleted_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onMessageDeleted_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onMessageDeleted_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageDeleted_Ljava_lang_String_Ljava_lang_String_);
			return cb_onMessageDeleted_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnMessageDeleted_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageDeleted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMessageDeleted_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnMessageDeleted (string p0, string p1)
		{
			if (id_onMessageDeleted_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessageDeleted_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessageDeleted", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageDeleted_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_onMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_onMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_onMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static void n_OnMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageDelivered (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		public unsafe void OnMessageDelivered (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_onMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessageDelivered", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageDelivered_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onMessageMetadataUpdated_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessageMetadataUpdated_Ljava_lang_String_Handler ()
		{
			if (cb_onMessageMetadataUpdated_Ljava_lang_String_ == null)
				cb_onMessageMetadataUpdated_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessageMetadataUpdated_Ljava_lang_String_);
			return cb_onMessageMetadataUpdated_Ljava_lang_String_;
		}

		static void n_OnMessageMetadataUpdated_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageMetadataUpdated (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMessageMetadataUpdated_Ljava_lang_String_;
		public unsafe void OnMessageMetadataUpdated (string p0)
		{
			if (id_onMessageMetadataUpdated_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessageMetadataUpdated_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessageMetadataUpdated", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageMetadataUpdated_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetOnMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_onMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_onMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_onMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_OnMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_;
		public unsafe void OnMessageReceived (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_onMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_onMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "onMessageReceived", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageReceived_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
		}

		static Delegate cb_onMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetOnMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_onMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_onMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_onMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_OnMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageSent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_;
		public unsafe void OnMessageSent (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_onMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_onMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "onMessageSent", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageSent_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
		}

		static Delegate cb_onMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_onMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_onMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_onMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static void n_OnMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessageSync (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		public unsafe void OnMessageSync (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_onMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_onMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMessageSync", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageSync_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onMqttDisconnected;
#pragma warning disable 0169
		static Delegate GetOnMqttDisconnectedHandler ()
		{
			if (cb_onMqttDisconnected == null)
				cb_onMqttDisconnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMqttDisconnected);
			return cb_onMqttDisconnected;
		}

		static void n_OnMqttDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMqttDisconnected ();
		}
#pragma warning restore 0169

		IntPtr id_onMqttDisconnected;
		public unsafe void OnMqttDisconnected ()
		{
			if (id_onMqttDisconnected == IntPtr.Zero)
				id_onMqttDisconnected = JNIEnv.GetMethodID (class_ref, "onMqttDisconnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMqttDisconnected);
		}

		static Delegate cb_onUpdateLastSeen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnUpdateLastSeen_Ljava_lang_String_Handler ()
		{
			if (cb_onUpdateLastSeen_Ljava_lang_String_ == null)
				cb_onUpdateLastSeen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdateLastSeen_Ljava_lang_String_);
			return cb_onUpdateLastSeen_Ljava_lang_String_;
		}

		static void n_OnUpdateLastSeen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateLastSeen (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUpdateLastSeen_Ljava_lang_String_;
		public unsafe void OnUpdateLastSeen (string p0)
		{
			if (id_onUpdateLastSeen_Ljava_lang_String_ == IntPtr.Zero)
				id_onUpdateLastSeen_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onUpdateLastSeen", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateLastSeen_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_);
			return cb_onUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateTypingStatus (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnUpdateTypingStatus (string p0, string p1)
		{
			if (id_onUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onUpdateTypingStatus", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateTypingStatus_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onUserDetailUpdated_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnUserDetailUpdated_Ljava_lang_String_Handler ()
		{
			if (cb_onUserDetailUpdated_Ljava_lang_String_ == null)
				cb_onUserDetailUpdated_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUserDetailUpdated_Ljava_lang_String_);
			return cb_onUserDetailUpdated_Ljava_lang_String_;
		}

		static void n_OnUserDetailUpdated_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUserDetailUpdated (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUserDetailUpdated_Ljava_lang_String_;
		public unsafe void OnUserDetailUpdated (string p0)
		{
			if (id_onUserDetailUpdated_Ljava_lang_String_ == IntPtr.Zero)
				id_onUserDetailUpdated_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onUserDetailUpdated", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserDetailUpdated_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class AllMessagesDeliveredEventArgs : global::System.EventArgs {

		public AllMessagesDeliveredEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class AllMessagesReadEventArgs : global::System.EventArgs {

		public AllMessagesReadEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class ConversationDeletedEventArgs : global::System.EventArgs {

		public ConversationDeletedEventArgs (string p0, global::Java.Lang.Integer p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Java.Lang.Integer p1;
		public global::Java.Lang.Integer P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	public partial class ConversationReadEventArgs : global::System.EventArgs {

		public ConversationReadEventArgs (string p0, bool p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		bool p1;
		public bool P1 {
			get { return p1; }
		}
	}

	public partial class LoadMoreEventArgs : global::System.EventArgs {

		public LoadMoreEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	public partial class MessageDeletedEventArgs : global::System.EventArgs {

		public MessageDeletedEventArgs (string p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class MessageDeliveredEventArgs : global::System.EventArgs {

		public MessageDeliveredEventArgs (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0;
		public global::Com.Applozic.Mobicomkit.Api.Conversation.Message P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class MessageMetadataUpdatedEventArgs : global::System.EventArgs {

		public MessageMetadataUpdatedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class MessageReceivedEventArgs : global::System.EventArgs {

		public MessageReceivedEventArgs (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			this.p0 = p0;
		}

		global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0;
		public global::Com.Applozic.Mobicomkit.Api.Conversation.Message P0 {
			get { return p0; }
		}
	}

	public partial class MessageSentEventArgs : global::System.EventArgs {

		public MessageSentEventArgs (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			this.p0 = p0;
		}

		global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0;
		public global::Com.Applozic.Mobicomkit.Api.Conversation.Message P0 {
			get { return p0; }
		}
	}

	public partial class MessageSyncEventArgs : global::System.EventArgs {

		public MessageSyncEventArgs (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0;
		public global::Com.Applozic.Mobicomkit.Api.Conversation.Message P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class UpdateLastSeenEventArgs : global::System.EventArgs {

		public UpdateLastSeenEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class UpdateTypingStatusEventArgs : global::System.EventArgs {

		public UpdateTypingStatusEventArgs (string p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	public partial class UserDetailUpdatedEventArgs : global::System.EventArgs {

		public UserDetailUpdatedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/applozic/mobicomkit/listners/ApplozicUIListenerImplementor")]
	internal sealed partial class IApplozicUIListenerImplementor : global::Java.Lang.Object, IApplozicUIListener {

		object sender;

		public IApplozicUIListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applozic/mobicomkit/listners/ApplozicUIListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AllMessagesDeliveredEventArgs> OnAllMessagesDeliveredHandler;
#pragma warning restore 0649

		public void OnAllMessagesDelivered (string p0)
		{
			var __h = OnAllMessagesDeliveredHandler;
			if (__h != null)
				__h (sender, new AllMessagesDeliveredEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<AllMessagesReadEventArgs> OnAllMessagesReadHandler;
#pragma warning restore 0649

		public void OnAllMessagesRead (string p0)
		{
			var __h = OnAllMessagesReadHandler;
			if (__h != null)
				__h (sender, new AllMessagesReadEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnChannelUpdatedHandler;
#pragma warning restore 0649

		public void OnChannelUpdated ()
		{
			var __h = OnChannelUpdatedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<ConversationDeletedEventArgs> OnConversationDeletedHandler;
#pragma warning restore 0649

		public void OnConversationDeleted (string p0, global::Java.Lang.Integer p1, string p2)
		{
			var __h = OnConversationDeletedHandler;
			if (__h != null)
				__h (sender, new ConversationDeletedEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<ConversationReadEventArgs> OnConversationReadHandler;
#pragma warning restore 0649

		public void OnConversationRead (string p0, bool p1)
		{
			var __h = OnConversationReadHandler;
			if (__h != null)
				__h (sender, new ConversationReadEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<LoadMoreEventArgs> OnLoadMoreHandler;
#pragma warning restore 0649

		public void OnLoadMore (bool p0)
		{
			var __h = OnLoadMoreHandler;
			if (__h != null)
				__h (sender, new LoadMoreEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MessageDeletedEventArgs> OnMessageDeletedHandler;
#pragma warning restore 0649

		public void OnMessageDeleted (string p0, string p1)
		{
			var __h = OnMessageDeletedHandler;
			if (__h != null)
				__h (sender, new MessageDeletedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<MessageDeliveredEventArgs> OnMessageDeliveredHandler;
#pragma warning restore 0649

		public void OnMessageDelivered (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			var __h = OnMessageDeliveredHandler;
			if (__h != null)
				__h (sender, new MessageDeliveredEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<MessageMetadataUpdatedEventArgs> OnMessageMetadataUpdatedHandler;
#pragma warning restore 0649

		public void OnMessageMetadataUpdated (string p0)
		{
			var __h = OnMessageMetadataUpdatedHandler;
			if (__h != null)
				__h (sender, new MessageMetadataUpdatedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MessageReceivedEventArgs> OnMessageReceivedHandler;
#pragma warning restore 0649

		public void OnMessageReceived (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			var __h = OnMessageReceivedHandler;
			if (__h != null)
				__h (sender, new MessageReceivedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MessageSentEventArgs> OnMessageSentHandler;
#pragma warning restore 0649

		public void OnMessageSent (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			var __h = OnMessageSentHandler;
			if (__h != null)
				__h (sender, new MessageSentEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<MessageSyncEventArgs> OnMessageSyncHandler;
#pragma warning restore 0649

		public void OnMessageSync (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			var __h = OnMessageSyncHandler;
			if (__h != null)
				__h (sender, new MessageSyncEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler OnMqttDisconnectedHandler;
#pragma warning restore 0649

		public void OnMqttDisconnected ()
		{
			var __h = OnMqttDisconnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<UpdateLastSeenEventArgs> OnUpdateLastSeenHandler;
#pragma warning restore 0649

		public void OnUpdateLastSeen (string p0)
		{
			var __h = OnUpdateLastSeenHandler;
			if (__h != null)
				__h (sender, new UpdateLastSeenEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<UpdateTypingStatusEventArgs> OnUpdateTypingStatusHandler;
#pragma warning restore 0649

		public void OnUpdateTypingStatus (string p0, string p1)
		{
			var __h = OnUpdateTypingStatusHandler;
			if (__h != null)
				__h (sender, new UpdateTypingStatusEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<UserDetailUpdatedEventArgs> OnUserDetailUpdatedHandler;
#pragma warning restore 0649

		public void OnUserDetailUpdated (string p0)
		{
			var __h = OnUserDetailUpdatedHandler;
			if (__h != null)
				__h (sender, new UserDetailUpdatedEventArgs (p0));
		}

		internal static bool __IsEmpty (IApplozicUIListenerImplementor value)
		{
			return value.OnAllMessagesDeliveredHandler == null && value.OnAllMessagesReadHandler == null && value.OnChannelUpdatedHandler == null && value.OnConversationDeletedHandler == null && value.OnConversationReadHandler == null && value.OnLoadMoreHandler == null && value.OnMessageDeletedHandler == null && value.OnMessageDeliveredHandler == null && value.OnMessageMetadataUpdatedHandler == null && value.OnMessageReceivedHandler == null && value.OnMessageSentHandler == null && value.OnMessageSyncHandler == null && value.OnMqttDisconnectedHandler == null && value.OnUpdateLastSeenHandler == null && value.OnUpdateTypingStatusHandler == null && value.OnUserDetailUpdatedHandler == null;
		}
	}

}
