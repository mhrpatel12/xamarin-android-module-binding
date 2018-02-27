using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ConversationActivity", DoNotGenerateAcw=true)]
	public partial class ConversationActivity : global::Android.Support.V7.App.AppCompatActivity, global::Android.Support.V4.App.ActivityCompat.IOnRequestPermissionsResultCallback, global::Android.Support.V7.Widget.SearchView.IOnQueryTextListener, global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.IMessageCommunicator, global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IOnClickReplyInterface, global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IMobicomkitUriListener, global::Android.Gms.Common.Apis.GoogleApiClient.IConnectionCallbacks, global::Android.Gms.Common.Apis.GoogleApiClient.IOnConnectionFailedListener, global::Android.Gms.Location.ILocationListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='ACTIVITY_TO_OPEN_ONCLICK_OF_CALL_BUTTON_META_DATA']"
		[Register ("ACTIVITY_TO_OPEN_ONCLICK_OF_CALL_BUTTON_META_DATA")]
		public const string ActivityToOpenOnclickOfCallButtonMetaData = (string) "activity.open.on.call.button.click";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='CONTACTS_GROUP_ID']"
		[Register ("CONTACTS_GROUP_ID")]
		public const string ContactsGroupId = (string) "CONTACTS_GROUP_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='FASTEST_INTERVAL']"
		[Register ("FASTEST_INTERVAL")]
		protected const long FastestInterval = (long) 1L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='GOOGLE_API_KEY_META_DATA']"
		[Register ("GOOGLE_API_KEY_META_DATA")]
		public const string GoogleApiKeyMetaData = (string) "com.google.android.geo.API_KEY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='LOCATION_SERVICE_ENABLE']"
		[Register ("LOCATION_SERVICE_ENABLE")]
		public const int LocationServiceEnable = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='TAKE_ORDER']"
		[Register ("TAKE_ORDER")]
		public const string TakeOrder = (string) "takeOrder";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='UPDATE_INTERVAL']"
		[Register ("UPDATE_INTERVAL")]
		protected const long UpdateInterval = (long) 500L;

		static IntPtr currentConversationId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='currentConversationId']"
		[Register ("currentConversationId")]
		public global::Java.Lang.Integer CurrentConversationId {
			get {
				if (currentConversationId_jfieldId == IntPtr.Zero)
					currentConversationId_jfieldId = JNIEnv.GetFieldID (class_ref, "currentConversationId", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, currentConversationId_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (currentConversationId_jfieldId == IntPtr.Zero)
					currentConversationId_jfieldId = JNIEnv.GetFieldID (class_ref, "currentConversationId", "Ljava/lang/Integer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentConversationId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr googleApiClient_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='googleApiClient']"
		[Register ("googleApiClient")]
		protected global::Android.Gms.Common.Apis.GoogleApiClient GoogleApiClient {
			get {
				if (googleApiClient_jfieldId == IntPtr.Zero)
					googleApiClient_jfieldId = JNIEnv.GetFieldID (class_ref, "googleApiClient", "Lcom/google/android/gms/common/api/GoogleApiClient;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, googleApiClient_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.GoogleApiClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (googleApiClient_jfieldId == IntPtr.Zero)
					googleApiClient_jfieldId = JNIEnv.GetFieldID (class_ref, "googleApiClient", "Lcom/google/android/gms/common/api/GoogleApiClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, googleApiClient_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr layout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='layout']"
		[Register ("layout")]
		public global::Android.Widget.LinearLayout Layout {
			get {
				if (layout_jfieldId == IntPtr.Zero)
					layout_jfieldId = JNIEnv.GetFieldID (class_ref, "layout", "Landroid/widget/LinearLayout;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, layout_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (layout_jfieldId == IntPtr.Zero)
					layout_jfieldId = JNIEnv.GetFieldID (class_ref, "layout", "Landroid/widget/LinearLayout;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, layout_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mActionBar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='mActionBar']"
		[Register ("mActionBar")]
		protected global::Android.Support.V7.App.ActionBar MActionBar {
			get {
				if (mActionBar_jfieldId == IntPtr.Zero)
					mActionBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mActionBar", "Landroid/support/v7/app/ActionBar;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mActionBar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.App.ActionBar> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mActionBar_jfieldId == IntPtr.Zero)
					mActionBar_jfieldId = JNIEnv.GetFieldID (class_ref, "mActionBar", "Landroid/support/v7/app/ActionBar;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mActionBar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mobiComKitBroadcastReceiver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='mobiComKitBroadcastReceiver']"
		[Register ("mobiComKitBroadcastReceiver")]
		protected global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobiComKitBroadcastReceiver MobiComKitBroadcastReceiver {
			get {
				if (mobiComKitBroadcastReceiver_jfieldId == IntPtr.Zero)
					mobiComKitBroadcastReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mobiComKitBroadcastReceiver", "Lcom/applozic/mobicomkit/uiwidgets/conversation/MobiComKitBroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mobiComKitBroadcastReceiver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobiComKitBroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mobiComKitBroadcastReceiver_jfieldId == IntPtr.Zero)
					mobiComKitBroadcastReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mobiComKitBroadcastReceiver", "Lcom/applozic/mobicomkit/uiwidgets/conversation/MobiComKitBroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mobiComKitBroadcastReceiver_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr snackbar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/field[@name='snackbar']"
		[Register ("snackbar")]
		public global::Android.Support.Design.Widget.Snackbar Snackbar {
			get {
				if (snackbar_jfieldId == IntPtr.Zero)
					snackbar_jfieldId = JNIEnv.GetFieldID (class_ref, "snackbar", "Landroid/support/design/widget/Snackbar;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, snackbar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.Design.Widget.Snackbar> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (snackbar_jfieldId == IntPtr.Zero)
					snackbar_jfieldId = JNIEnv.GetFieldID (class_ref, "snackbar", "Landroid/support/design/widget/Snackbar;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, snackbar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity.SyncMessagesAsyncTask']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ConversationActivity$SyncMessagesAsyncTask", DoNotGenerateAcw=true)]
		public partial class SyncMessagesAsyncTask : global::Android.OS.AsyncTask {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ConversationActivity$SyncMessagesAsyncTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SyncMessagesAsyncTask); }
			}

			protected SyncMessagesAsyncTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ConversationActivity_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity.SyncMessagesAsyncTask']/constructor[@name='ConversationActivity.SyncMessagesAsyncTask' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.activity.ConversationActivity'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/activity/ConversationActivity;Landroid/content/Context;)V", "")]
			public unsafe SyncMessagesAsyncTask (global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __self, global::Android.Content.Context p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (SyncMessagesAsyncTask)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ConversationActivity_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ConversationActivity_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/activity/ConversationActivity;Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ConversationActivity_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_activity_ConversationActivity_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Boolean_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Boolean_ == null)
					cb_doInBackground_arrayLjava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Boolean_);
				return cb_doInBackground_arrayLjava_lang_Boolean_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity.SyncMessagesAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity.SyncMessagesAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean[] p0 = (global::Java.Lang.Boolean[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Boolean));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Boolean_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity.SyncMessagesAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean...']]"
			[Register ("doInBackground", "([Ljava/lang/Boolean;)Ljava/lang/Void;", "GetDoInBackground_arrayLjava_lang_Boolean_Handler")]
			protected virtual unsafe global::Java.Lang.Void DoInBackground (params global:: Java.Lang.Boolean[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Boolean_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Boolean;)Ljava/lang/Void;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Void __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Boolean_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Boolean;)Ljava/lang/Void;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
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
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity.SyncMessagesAsyncTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity.SyncMessagesAsyncTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity.SyncMessagesAsyncTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ConversationActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationActivity); }
		}

		protected ConversationActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/constructor[@name='ConversationActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConversationActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConversationActivity)) {
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

		static IntPtr id_getCapturedImageUri;
		static IntPtr id_setCapturedImageUri_Landroid_net_Uri_;
		public static unsafe global::Android.Net.Uri CapturedImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='getCapturedImageUri' and count(parameter)=0]"
			[Register ("getCapturedImageUri", "()Landroid/net/Uri;", "GetGetCapturedImageUriHandler")]
			get {
				if (id_getCapturedImageUri == IntPtr.Zero)
					id_getCapturedImageUri = JNIEnv.GetStaticMethodID (class_ref, "getCapturedImageUri", "()Landroid/net/Uri;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCapturedImageUri), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='setCapturedImageUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("setCapturedImageUri", "(Landroid/net/Uri;)V", "GetSetCapturedImageUri_Landroid_net_Uri_Handler")]
			set {
				if (id_setCapturedImageUri_Landroid_net_Uri_ == IntPtr.Zero)
					id_setCapturedImageUri_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "setCapturedImageUri", "(Landroid/net/Uri;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setCapturedImageUri_Landroid_net_Uri_, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getChannel;
#pragma warning disable 0169
		static Delegate GetGetChannelHandler ()
		{
			if (cb_getChannel == null)
				cb_getChannel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannel);
			return cb_getChannel;
		}

		static IntPtr n_GetChannel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Channel);
		}
#pragma warning restore 0169

		static IntPtr id_getChannel;
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannelHandler")]
			get {
				if (id_getChannel == IntPtr.Zero)
					id_getChannel = JNIEnv.GetMethodID (class_ref, "getChannel", "()Lcom/applozic/mobicommons/people/channel/Channel;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannel), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannel", "()Lcom/applozic/mobicommons/people/channel/Channel;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContact;
#pragma warning disable 0169
		static Delegate GetGetContactHandler ()
		{
			if (cb_getContact == null)
				cb_getContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContact);
			return cb_getContact;
		}

		static IntPtr n_GetContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Contact);
		}
#pragma warning restore 0169

		static IntPtr id_getContact;
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact Contact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='getContact' and count(parameter)=0]"
			[Register ("getContact", "()Lcom/applozic/mobicommons/people/contact/Contact;", "GetGetContactHandler")]
			get {
				if (id_getContact == IntPtr.Zero)
					id_getContact = JNIEnv.GetMethodID (class_ref, "getContact", "()Lcom/applozic/mobicommons/people/contact/Contact;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContact), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContact", "()Lcom/applozic/mobicommons/people/contact/Contact;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConversationId;
#pragma warning disable 0169
		static Delegate GetGetConversationIdHandler ()
		{
			if (cb_getConversationId == null)
				cb_getConversationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationId);
			return cb_getConversationId;
		}

		static IntPtr n_GetConversationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConversationId);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationId;
		public virtual unsafe global::Java.Lang.Integer ConversationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='getConversationId' and count(parameter)=0]"
			[Register ("getConversationId", "()Ljava/lang/Integer;", "GetGetConversationIdHandler")]
			get {
				if (id_getConversationId == IntPtr.Zero)
					id_getConversationId = JNIEnv.GetMethodID (class_ref, "getConversationId", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationId", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentImageUri);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentImageUri;
		public virtual unsafe global::Android.Net.Uri CurrentImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='getCurrentImageUri' and count(parameter)=0]"
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

		static Delegate cb_getFileObject;
#pragma warning disable 0169
		static Delegate GetGetFileObjectHandler ()
		{
			if (cb_getFileObject == null)
				cb_getFileObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileObject);
			return cb_getFileObject;
		}

		static IntPtr n_GetFileObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FileObject);
		}
#pragma warning restore 0169

		static IntPtr id_getFileObject;
		public virtual unsafe global::Java.IO.File FileObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='getFileObject' and count(parameter)=0]"
			[Register ("getFileObject", "()Ljava/io/File;", "GetGetFileObjectHandler")]
			get {
				if (id_getFileObject == IntPtr.Zero)
					id_getFileObject = JNIEnv.GetMethodID (class_ref, "getFileObject", "()Ljava/io/File;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileObject), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileObject", "()Ljava/io/File;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryCount;
#pragma warning disable 0169
		static Delegate GetGetRetryCountHandler ()
		{
			if (cb_getRetryCount == null)
				cb_getRetryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRetryCount);
			return cb_getRetryCount;
		}

		static int n_GetRetryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetryCount;
		}
#pragma warning restore 0169

		static IntPtr id_getRetryCount;
		public virtual unsafe int RetryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='getRetryCount' and count(parameter)=0]"
			[Register ("getRetryCount", "()I", "GetGetRetryCountHandler")]
			get {
				if (id_getRetryCount == IntPtr.Zero)
					id_getRetryCount = JNIEnv.GetMethodID (class_ref, "getRetryCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRetryCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetryCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSearchListFragment;
#pragma warning disable 0169
		static Delegate GetGetSearchListFragmentHandler ()
		{
			if (cb_getSearchListFragment == null)
				cb_getSearchListFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSearchListFragment);
			return cb_getSearchListFragment;
		}

		static IntPtr n_GetSearchListFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SearchListFragment);
		}
#pragma warning restore 0169

		static Delegate cb_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_;
#pragma warning disable 0169
		static Delegate GetSetSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_Handler ()
		{
			if (cb_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ == null)
				cb_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_);
			return cb_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_;
		}

		static void n_SetSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.ISearchListFragment p0 = (global::Com.Applozic.Mobicommons.People.ISearchListFragment)global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.ISearchListFragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SearchListFragment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSearchListFragment;
		static IntPtr id_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_;
		public virtual unsafe global::Com.Applozic.Mobicommons.People.ISearchListFragment SearchListFragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='getSearchListFragment' and count(parameter)=0]"
			[Register ("getSearchListFragment", "()Lcom/applozic/mobicommons/people/SearchListFragment;", "GetGetSearchListFragmentHandler")]
			get {
				if (id_getSearchListFragment == IntPtr.Zero)
					id_getSearchListFragment = JNIEnv.GetMethodID (class_ref, "getSearchListFragment", "()Lcom/applozic/mobicommons/people/SearchListFragment;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.ISearchListFragment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSearchListFragment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.ISearchListFragment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSearchListFragment", "()Lcom/applozic/mobicommons/people/SearchListFragment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='setSearchListFragment' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.SearchListFragment']]"
			[Register ("setSearchListFragment", "(Lcom/applozic/mobicommons/people/SearchListFragment;)V", "GetSetSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_Handler")]
			set {
				if (id_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ == IntPtr.Zero)
					id_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ = JNIEnv.GetMethodID (class_ref, "setSearchListFragment", "(Lcom/applozic/mobicommons/people/SearchListFragment;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSearchListFragment", "(Lcom/applozic/mobicommons/people/SearchListFragment;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoFileUri;
#pragma warning disable 0169
		static Delegate GetGetVideoFileUriHandler ()
		{
			if (cb_getVideoFileUri == null)
				cb_getVideoFileUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoFileUri);
			return cb_getVideoFileUri;
		}

		static IntPtr n_GetVideoFileUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoFileUri);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoFileUri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetVideoFileUri_Landroid_net_Uri_Handler ()
		{
			if (cb_setVideoFileUri_Landroid_net_Uri_ == null)
				cb_setVideoFileUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoFileUri_Landroid_net_Uri_);
			return cb_setVideoFileUri_Landroid_net_Uri_;
		}

		static void n_SetVideoFileUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VideoFileUri = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoFileUri;
		static IntPtr id_setVideoFileUri_Landroid_net_Uri_;
		public virtual unsafe global::Android.Net.Uri VideoFileUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='getVideoFileUri' and count(parameter)=0]"
			[Register ("getVideoFileUri", "()Landroid/net/Uri;", "GetGetVideoFileUriHandler")]
			get {
				if (id_getVideoFileUri == IntPtr.Zero)
					id_getVideoFileUri = JNIEnv.GetMethodID (class_ref, "getVideoFileUri", "()Landroid/net/Uri;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoFileUri), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoFileUri", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='setVideoFileUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("setVideoFileUri", "(Landroid/net/Uri;)V", "GetSetVideoFileUri_Landroid_net_Uri_Handler")]
			set {
				if (id_setVideoFileUri_Landroid_net_Uri_ == IntPtr.Zero)
					id_setVideoFileUri_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setVideoFileUri", "(Landroid/net/Uri;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoFileUri_Landroid_net_Uri_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoFileUri", "(Landroid/net/Uri;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_addFragment_Landroid_support_v4_app_FragmentActivity_Landroid_support_v4_app_Fragment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='addFragment' and count(parameter)=3 and parameter[1][@type='android.support.v4.app.FragmentActivity'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='java.lang.String']]"
		[Register ("addFragment", "(Landroid/support/v4/app/FragmentActivity;Landroid/support/v4/app/Fragment;Ljava/lang/String;)V", "")]
		public static unsafe void AddFragment (global::Android.Support.V4.App.FragmentActivity p0, global::Android.Support.V4.App.Fragment p1, string p2)
		{
			if (id_addFragment_Landroid_support_v4_app_FragmentActivity_Landroid_support_v4_app_Fragment_Ljava_lang_String_ == IntPtr.Zero)
				id_addFragment_Landroid_support_v4_app_FragmentActivity_Landroid_support_v4_app_Fragment_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addFragment", "(Landroid/support/v4/app/FragmentActivity;Landroid/support/v4/app/Fragment;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addFragment_Landroid_support_v4_app_FragmentActivity_Landroid_support_v4_app_Fragment_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_dismissErrorMessage;
#pragma warning disable 0169
		static Delegate GetDismissErrorMessageHandler ()
		{
			if (cb_dismissErrorMessage == null)
				cb_dismissErrorMessage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DismissErrorMessage);
			return cb_dismissErrorMessage;
		}

		static void n_DismissErrorMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DismissErrorMessage ();
		}
#pragma warning restore 0169

		static IntPtr id_dismissErrorMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='dismissErrorMessage' and count(parameter)=0]"
		[Register ("dismissErrorMessage", "()V", "GetDismissErrorMessageHandler")]
		public virtual unsafe void DismissErrorMessage ()
		{
			if (id_dismissErrorMessage == IntPtr.Zero)
				id_dismissErrorMessage = JNIEnv.GetMethodID (class_ref, "dismissErrorMessage", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dismissErrorMessage);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dismissErrorMessage", "()V"));
			} finally {
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleOnActivityResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleOnActivityResult_ILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='handleOnActivityResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
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

		static Delegate cb_imageCapture;
#pragma warning disable 0169
		static Delegate GetImageCaptureHandler ()
		{
			if (cb_imageCapture == null)
				cb_imageCapture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ImageCapture);
			return cb_imageCapture;
		}

		static void n_ImageCapture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ImageCapture ();
		}
#pragma warning restore 0169

		static IntPtr id_imageCapture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='imageCapture' and count(parameter)=0]"
		[Register ("imageCapture", "()V", "GetImageCaptureHandler")]
		public virtual unsafe void ImageCapture ()
		{
			if (id_imageCapture == IntPtr.Zero)
				id_imageCapture = JNIEnv.GetMethodID (class_ref, "imageCapture", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_imageCapture);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "imageCapture", "()V"));
			} finally {
			}
		}

		static Delegate cb_isAttachment_Z;
#pragma warning disable 0169
		static Delegate GetIsAttachment_ZHandler ()
		{
			if (cb_isAttachment_Z == null)
				cb_isAttachment_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_IsAttachment_Z);
			return cb_isAttachment_Z;
		}

		static void n_IsAttachment_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsAttachment (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isAttachment_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='isAttachment' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isAttachment", "(Z)V", "GetIsAttachment_ZHandler")]
		public virtual unsafe void IsAttachment (bool p0)
		{
			if (id_isAttachment_Z == IntPtr.Zero)
				id_isAttachment_Z = JNIEnv.GetMethodID (class_ref, "isAttachment", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_isAttachment_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAttachment", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_isTakePhoto_Z;
#pragma warning disable 0169
		static Delegate GetIsTakePhoto_ZHandler ()
		{
			if (cb_isTakePhoto_Z == null)
				cb_isTakePhoto_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_IsTakePhoto_Z);
			return cb_isTakePhoto_Z;
		}

		static void n_IsTakePhoto_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsTakePhoto (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isTakePhoto_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='isTakePhoto' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("isTakePhoto", "(Z)V", "GetIsTakePhoto_ZHandler")]
		public virtual unsafe void IsTakePhoto (bool p0)
		{
			if (id_isTakePhoto_Z == IntPtr.Zero)
				id_isTakePhoto_Z = JNIEnv.GetMethodID (class_ref, "isTakePhoto", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_isTakePhoto_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTakePhoto", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetOnClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_OnClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClickOnMessageReply (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='onClickOnMessageReply' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("onClickOnMessageReply", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetOnClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void OnClickOnMessageReply (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "onClickOnMessageReply", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClickOnMessageReply", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnected_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Landroid_os_Bundle_Handler ()
		{
			if (cb_onConnected_Landroid_os_Bundle_ == null)
				cb_onConnected_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnected_Landroid_os_Bundle_);
			return cb_onConnected_Landroid_os_Bundle_;
		}

		static void n_OnConnected_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnected_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onConnected", "(Landroid/os/Bundle;)V", "GetOnConnected_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnConnected (global::Android.OS.Bundle p0)
		{
			if (id_onConnected_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onConnected_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnected", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
#pragma warning disable 0169
		static Delegate GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler ()
		{
			if (cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == null)
				cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_);
			return cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
		}

		static void n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.ConnectionResult p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='onConnectionFailed' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.ConnectionResult']]"
		[Register ("onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V", "GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler")]
		public virtual unsafe void OnConnectionFailed (global::Android.Gms.Common.ConnectionResult p0)
		{
			if (id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == IntPtr.Zero)
				id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionSuspended_I;
#pragma warning disable 0169
		static Delegate GetOnConnectionSuspended_IHandler ()
		{
			if (cb_onConnectionSuspended_I == null)
				cb_onConnectionSuspended_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnConnectionSuspended_I);
			return cb_onConnectionSuspended_I;
		}

		static void n_OnConnectionSuspended_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionSuspended (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionSuspended_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='onConnectionSuspended' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onConnectionSuspended", "(I)V", "GetOnConnectionSuspended_IHandler")]
		public virtual unsafe void OnConnectionSuspended (int p0)
		{
			if (id_onConnectionSuspended_I == IntPtr.Zero)
				id_onConnectionSuspended_I = JNIEnv.GetMethodID (class_ref, "onConnectionSuspended", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionSuspended_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionSuspended", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationChanged_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler")]
		public virtual unsafe void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationChanged_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationChanged", "(Landroid/location/Location;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onQueryTextChange_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnQueryTextChange_Ljava_lang_String_Handler ()
		{
			if (cb_onQueryTextChange_Ljava_lang_String_ == null)
				cb_onQueryTextChange_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnQueryTextChange_Ljava_lang_String_);
			return cb_onQueryTextChange_Ljava_lang_String_;
		}

		static bool n_OnQueryTextChange_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnQueryTextChange (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onQueryTextChange_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='onQueryTextChange' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onQueryTextChange", "(Ljava/lang/String;)Z", "GetOnQueryTextChange_Ljava_lang_String_Handler")]
		public virtual unsafe bool OnQueryTextChange (string p0)
		{
			if (id_onQueryTextChange_Ljava_lang_String_ == IntPtr.Zero)
				id_onQueryTextChange_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onQueryTextChange", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onQueryTextChange_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onQueryTextChange", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onQueryTextSubmit_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnQueryTextSubmit_Ljava_lang_String_Handler ()
		{
			if (cb_onQueryTextSubmit_Ljava_lang_String_ == null)
				cb_onQueryTextSubmit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnQueryTextSubmit_Ljava_lang_String_);
			return cb_onQueryTextSubmit_Ljava_lang_String_;
		}

		static bool n_OnQueryTextSubmit_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnQueryTextSubmit (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onQueryTextSubmit_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='onQueryTextSubmit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onQueryTextSubmit", "(Ljava/lang/String;)Z", "GetOnQueryTextSubmit_Ljava_lang_String_Handler")]
		public virtual unsafe bool OnQueryTextSubmit (string p0)
		{
			if (id_onQueryTextSubmit_Ljava_lang_String_ == IntPtr.Zero)
				id_onQueryTextSubmit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onQueryTextSubmit", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onQueryTextSubmit_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onQueryTextSubmit", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_onQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_onQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_onQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static void n_OnQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p2 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnQuickConversationFragmentItemClick (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='onQuickConversationFragmentItemClick' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[3][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[4][@type='java.lang.Integer'] and parameter[5][@type='java.lang.String']]"
		[Register ("onQuickConversationFragmentItemClick", "(Landroid/view/View;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;Ljava/lang/String;)V", "GetOnQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe void OnQuickConversationFragmentItemClick (global::Android.Views.View p0, global::Com.Applozic.Mobicommons.People.Contact.Contact p1, global::Com.Applozic.Mobicommons.People.Channel.Channel p2, global::Java.Lang.Integer p3, string p4)
		{
			if (id_onQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_onQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onQuickConversationFragmentItemClick", "(Landroid/view/View;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;Ljava/lang/String;)V");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onQuickConversationFragmentItemClick_Landroid_view_View_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onQuickConversationFragmentItemClick", "(Landroid/view/View;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_processAttachment;
#pragma warning disable 0169
		static Delegate GetProcessAttachmentHandler ()
		{
			if (cb_processAttachment == null)
				cb_processAttachment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessAttachment);
			return cb_processAttachment;
		}

		static void n_ProcessAttachment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessAttachment ();
		}
#pragma warning restore 0169

		static IntPtr id_processAttachment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='processAttachment' and count(parameter)=0]"
		[Register ("processAttachment", "()V", "GetProcessAttachmentHandler")]
		public virtual unsafe void ProcessAttachment ()
		{
			if (id_processAttachment == IntPtr.Zero)
				id_processAttachment = JNIEnv.GetMethodID (class_ref, "processAttachment", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processAttachment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processAttachment", "()V"));
			} finally {
			}
		}

		static Delegate cb_processCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetProcessCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_Handler ()
		{
			if (cb_processCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ == null)
				cb_processCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_);
			return cb_processCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_;
		}

		static void n_ProcessCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProcessCall (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_processCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='processCall' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("processCall", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Integer;)V", "GetProcessCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_Handler")]
		public virtual unsafe void ProcessCall (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Java.Lang.Integer p1)
		{
			if (id_processCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ == IntPtr.Zero)
				id_processCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "processCall", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processCall", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processCameraAction;
#pragma warning disable 0169
		static Delegate GetProcessCameraActionHandler ()
		{
			if (cb_processCameraAction == null)
				cb_processCameraAction = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessCameraAction);
			return cb_processCameraAction;
		}

		static void n_ProcessCameraAction (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessCameraAction ();
		}
#pragma warning restore 0169

		static IntPtr id_processCameraAction;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='processCameraAction' and count(parameter)=0]"
		[Register ("processCameraAction", "()V", "GetProcessCameraActionHandler")]
		public virtual unsafe void ProcessCameraAction ()
		{
			if (id_processCameraAction == IntPtr.Zero)
				id_processCameraAction = JNIEnv.GetMethodID (class_ref, "processCameraAction", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processCameraAction);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processCameraAction", "()V"));
			} finally {
			}
		}

		static Delegate cb_processContact;
#pragma warning disable 0169
		static Delegate GetProcessContactHandler ()
		{
			if (cb_processContact == null)
				cb_processContact = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessContact);
			return cb_processContact;
		}

		static void n_ProcessContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessContact ();
		}
#pragma warning restore 0169

		static IntPtr id_processContact;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='processContact' and count(parameter)=0]"
		[Register ("processContact", "()V", "GetProcessContactHandler")]
		public virtual unsafe void ProcessContact ()
		{
			if (id_processContact == IntPtr.Zero)
				id_processContact = JNIEnv.GetMethodID (class_ref, "processContact", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processContact);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processContact", "()V"));
			} finally {
			}
		}

		static Delegate cb_processGalleryPhotoSelection;
#pragma warning disable 0169
		static Delegate GetProcessGalleryPhotoSelectionHandler ()
		{
			if (cb_processGalleryPhotoSelection == null)
				cb_processGalleryPhotoSelection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessGalleryPhotoSelection);
			return cb_processGalleryPhotoSelection;
		}

		static void n_ProcessGalleryPhotoSelection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessGalleryPhotoSelection ();
		}
#pragma warning restore 0169

		static IntPtr id_processGalleryPhotoSelection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='processGalleryPhotoSelection' and count(parameter)=0]"
		[Register ("processGalleryPhotoSelection", "()V", "GetProcessGalleryPhotoSelectionHandler")]
		public virtual unsafe void ProcessGalleryPhotoSelection ()
		{
			if (id_processGalleryPhotoSelection == IntPtr.Zero)
				id_processGalleryPhotoSelection = JNIEnv.GetMethodID (class_ref, "processGalleryPhotoSelection", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processGalleryPhotoSelection);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processGalleryPhotoSelection", "()V"));
			} finally {
			}
		}

		static Delegate cb_processLocation;
#pragma warning disable 0169
		static Delegate GetProcessLocationHandler ()
		{
			if (cb_processLocation == null)
				cb_processLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessLocation);
			return cb_processLocation;
		}

		static void n_ProcessLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_processLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='processLocation' and count(parameter)=0]"
		[Register ("processLocation", "()V", "GetProcessLocationHandler")]
		public virtual unsafe void ProcessLocation ()
		{
			if (id_processLocation == IntPtr.Zero)
				id_processLocation = JNIEnv.GetMethodID (class_ref, "processLocation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processLocation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processLocation", "()V"));
			} finally {
			}
		}

		static Delegate cb_processVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetProcessVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_Handler ()
		{
			if (cb_processVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ == null)
				cb_processVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_);
			return cb_processVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_;
		}

		static void n_ProcessVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProcessVideoCall (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_processVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='processVideoCall' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("processVideoCall", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Integer;)V", "GetProcessVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_Handler")]
		public virtual unsafe void ProcessVideoCall (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Java.Lang.Integer p1)
		{
			if (id_processVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ == IntPtr.Zero)
				id_processVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "processVideoCall", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processVideoCall_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processVideoCall", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processVideoRecording;
#pragma warning disable 0169
		static Delegate GetProcessVideoRecordingHandler ()
		{
			if (cb_processVideoRecording == null)
				cb_processVideoRecording = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessVideoRecording);
			return cb_processVideoRecording;
		}

		static void n_ProcessVideoRecording (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessVideoRecording ();
		}
#pragma warning restore 0169

		static IntPtr id_processVideoRecording;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='processVideoRecording' and count(parameter)=0]"
		[Register ("processVideoRecording", "()V", "GetProcessVideoRecordingHandler")]
		public virtual unsafe void ProcessVideoRecording ()
		{
			if (id_processVideoRecording == IntPtr.Zero)
				id_processVideoRecording = JNIEnv.GetMethodID (class_ref, "processVideoRecording", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processVideoRecording);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processVideoRecording", "()V"));
			} finally {
			}
		}

		static Delegate cb_processingLocation;
#pragma warning disable 0169
		static Delegate GetProcessingLocationHandler ()
		{
			if (cb_processingLocation == null)
				cb_processingLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessingLocation);
			return cb_processingLocation;
		}

		static void n_ProcessingLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessingLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_processingLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='processingLocation' and count(parameter)=0]"
		[Register ("processingLocation", "()V", "GetProcessingLocationHandler")]
		public virtual unsafe void ProcessingLocation ()
		{
			if (id_processingLocation == IntPtr.Zero)
				id_processingLocation = JNIEnv.GetMethodID (class_ref, "processingLocation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processingLocation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processingLocation", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static void n_RemoveConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConversation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='removeConversation' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeConversation", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "GetRemoveConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveConversation (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeConversation", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeConversation", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_retry;
#pragma warning disable 0169
		static Delegate GetRetryHandler ()
		{
			if (cb_retry == null)
				cb_retry = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Retry);
			return cb_retry;
		}

		static void n_Retry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retry ();
		}
#pragma warning restore 0169

		static IntPtr id_retry;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='retry' and count(parameter)=0]"
		[Register ("retry", "()V", "GetRetryHandler")]
		public virtual unsafe void Retry ()
		{
			if (id_retry == IntPtr.Zero)
				id_retry = JNIEnv.GetMethodID (class_ref, "retry", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_retry);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "retry", "()V"));
			} finally {
			}
		}

		static Delegate cb_setChildFragmentLayoutBG;
#pragma warning disable 0169
		static Delegate GetSetChildFragmentLayoutBGHandler ()
		{
			if (cb_setChildFragmentLayoutBG == null)
				cb_setChildFragmentLayoutBG = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetChildFragmentLayoutBG);
			return cb_setChildFragmentLayoutBG;
		}

		static void n_SetChildFragmentLayoutBG (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChildFragmentLayoutBG ();
		}
#pragma warning restore 0169

		static IntPtr id_setChildFragmentLayoutBG;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='setChildFragmentLayoutBG' and count(parameter)=0]"
		[Register ("setChildFragmentLayoutBG", "()V", "GetSetChildFragmentLayoutBGHandler")]
		public virtual unsafe void SetChildFragmentLayoutBG ()
		{
			if (id_setChildFragmentLayoutBG == IntPtr.Zero)
				id_setChildFragmentLayoutBG = JNIEnv.GetMethodID (class_ref, "setChildFragmentLayoutBG", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChildFragmentLayoutBG);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChildFragmentLayoutBG", "()V"));
			} finally {
			}
		}

		static Delegate cb_setChildFragmentLayoutBGToTransparent;
#pragma warning disable 0169
		static Delegate GetSetChildFragmentLayoutBGToTransparentHandler ()
		{
			if (cb_setChildFragmentLayoutBGToTransparent == null)
				cb_setChildFragmentLayoutBGToTransparent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetChildFragmentLayoutBGToTransparent);
			return cb_setChildFragmentLayoutBGToTransparent;
		}

		static void n_SetChildFragmentLayoutBGToTransparent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChildFragmentLayoutBGToTransparent ();
		}
#pragma warning restore 0169

		static IntPtr id_setChildFragmentLayoutBGToTransparent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='setChildFragmentLayoutBGToTransparent' and count(parameter)=0]"
		[Register ("setChildFragmentLayoutBGToTransparent", "()V", "GetSetChildFragmentLayoutBGToTransparentHandler")]
		public virtual unsafe void SetChildFragmentLayoutBGToTransparent ()
		{
			if (id_setChildFragmentLayoutBGToTransparent == IntPtr.Zero)
				id_setChildFragmentLayoutBGToTransparent = JNIEnv.GetMethodID (class_ref, "setChildFragmentLayoutBGToTransparent", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChildFragmentLayoutBGToTransparent);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChildFragmentLayoutBGToTransparent", "()V"));
			} finally {
			}
		}

		static Delegate cb_showAudioRecordingDialog;
#pragma warning disable 0169
		static Delegate GetShowAudioRecordingDialogHandler ()
		{
			if (cb_showAudioRecordingDialog == null)
				cb_showAudioRecordingDialog = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowAudioRecordingDialog);
			return cb_showAudioRecordingDialog;
		}

		static void n_ShowAudioRecordingDialog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowAudioRecordingDialog ();
		}
#pragma warning restore 0169

		static IntPtr id_showAudioRecordingDialog;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='showAudioRecordingDialog' and count(parameter)=0]"
		[Register ("showAudioRecordingDialog", "()V", "GetShowAudioRecordingDialogHandler")]
		public virtual unsafe void ShowAudioRecordingDialog ()
		{
			if (id_showAudioRecordingDialog == IntPtr.Zero)
				id_showAudioRecordingDialog = JNIEnv.GetMethodID (class_ref, "showAudioRecordingDialog", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showAudioRecordingDialog);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showAudioRecordingDialog", "()V"));
			} finally {
			}
		}

		static Delegate cb_showErrorMessageView_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetShowErrorMessageView_Ljava_lang_String_Handler ()
		{
			if (cb_showErrorMessageView_Ljava_lang_String_ == null)
				cb_showErrorMessageView_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowErrorMessageView_Ljava_lang_String_);
			return cb_showErrorMessageView_Ljava_lang_String_;
		}

		static void n_ShowErrorMessageView_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowErrorMessageView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showErrorMessageView_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='showErrorMessageView' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("showErrorMessageView", "(Ljava/lang/String;)V", "GetShowErrorMessageView_Ljava_lang_String_Handler")]
		public virtual unsafe void ShowErrorMessageView (string p0)
		{
			if (id_showErrorMessageView_Ljava_lang_String_ == IntPtr.Zero)
				id_showErrorMessageView_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showErrorMessageView", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showErrorMessageView_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showErrorMessageView", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSnackBar (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showSnackBar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='showSnackBar' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_showVideoCapture;
#pragma warning disable 0169
		static Delegate GetShowVideoCaptureHandler ()
		{
			if (cb_showVideoCapture == null)
				cb_showVideoCapture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowVideoCapture);
			return cb_showVideoCapture;
		}

		static void n_ShowVideoCapture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowVideoCapture ();
		}
#pragma warning restore 0169

		static IntPtr id_showVideoCapture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='showVideoCapture' and count(parameter)=0]"
		[Register ("showVideoCapture", "()V", "GetShowVideoCaptureHandler")]
		public virtual unsafe void ShowVideoCapture ()
		{
			if (id_showVideoCapture == IntPtr.Zero)
				id_showVideoCapture = JNIEnv.GetMethodID (class_ref, "showVideoCapture", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showVideoCapture);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showVideoCapture", "()V"));
			} finally {
			}
		}

		static Delegate cb_startContactActivityForResult;
#pragma warning disable 0169
		static Delegate GetStartContactActivityForResultHandler ()
		{
			if (cb_startContactActivityForResult == null)
				cb_startContactActivityForResult = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartContactActivityForResult);
			return cb_startContactActivityForResult;
		}

		static void n_StartContactActivityForResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartContactActivityForResult ();
		}
#pragma warning restore 0169

		static IntPtr id_startContactActivityForResult;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='startContactActivityForResult' and count(parameter)=0]"
		[Register ("startContactActivityForResult", "()V", "GetStartContactActivityForResultHandler")]
		public virtual unsafe void StartContactActivityForResult ()
		{
			if (id_startContactActivityForResult == IntPtr.Zero)
				id_startContactActivityForResult = JNIEnv.GetMethodID (class_ref, "startContactActivityForResult", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startContactActivityForResult);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startContactActivityForResult", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static void n_UpdateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ConversationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLatestMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ConversationActivity']/method[@name='updateLatestMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateLatestMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "GetUpdateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateLatestMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateLatestMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLatestMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
