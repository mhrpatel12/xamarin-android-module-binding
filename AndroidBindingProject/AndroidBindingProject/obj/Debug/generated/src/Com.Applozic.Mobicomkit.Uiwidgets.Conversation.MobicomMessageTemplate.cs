using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate", DoNotGenerateAcw=true)]
	public partial class MobicomMessageTemplate : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem", DoNotGenerateAcw=true)]
		public partial class MessageContentItem : global::Com.Applozic.Mobicommons.Json.JsonMarker {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageContentItem); }
			}

			protected MessageContentItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']/constructor[@name='MobicomMessageTemplate.MessageContentItem' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.MobicomMessageTemplate']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate;)V", "")]
			public unsafe MessageContentItem (global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (MessageContentItem)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_, __args);
				} finally {
				}
			}

			static Delegate cb_getMessageList;
#pragma warning disable 0169
			static Delegate GetGetMessageListHandler ()
			{
				if (cb_getMessageList == null)
					cb_getMessageList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageList);
				return cb_getMessageList;
			}

			static IntPtr n_GetMessageList (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.MessageList);
			}
#pragma warning restore 0169

			static Delegate cb_setMessageList_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetSetMessageList_Ljava_util_Map_Handler ()
			{
				if (cb_setMessageList_Ljava_util_Map_ == null)
					cb_setMessageList_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageList_Ljava_util_Map_);
				return cb_setMessageList_Ljava_util_Map_;
			}

			static void n_SetMessageList_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.MessageList = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getMessageList;
			static IntPtr id_setMessageList_Ljava_util_Map_;
			public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> MessageList {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']/method[@name='getMessageList' and count(parameter)=0]"
				[Register ("getMessageList", "()Ljava/util/Map;", "GetGetMessageListHandler")]
				get {
					if (id_getMessageList == IntPtr.Zero)
						id_getMessageList = JNIEnv.GetMethodID (class_ref, "getMessageList", "()Ljava/util/Map;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageList), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageList", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']/method[@name='setMessageList' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
				[Register ("setMessageList", "(Ljava/util/Map;)V", "GetSetMessageList_Ljava_util_Map_Handler")]
				set {
					if (id_setMessageList_Ljava_util_Map_ == IntPtr.Zero)
						id_setMessageList_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMessageList", "(Ljava/util/Map;)V");
					IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageList_Ljava_util_Map_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageList", "(Ljava/util/Map;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_isSendMessageOnClick;
#pragma warning disable 0169
			static Delegate GetIsSendMessageOnClickHandler ()
			{
				if (cb_isSendMessageOnClick == null)
					cb_isSendMessageOnClick = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSendMessageOnClick);
				return cb_isSendMessageOnClick;
			}

			static bool n_IsSendMessageOnClick (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.SendMessageOnClick;
			}
#pragma warning restore 0169

			static Delegate cb_setSendMessageOnClick_Z;
#pragma warning disable 0169
			static Delegate GetSetSendMessageOnClick_ZHandler ()
			{
				if (cb_setSendMessageOnClick_Z == null)
					cb_setSendMessageOnClick_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSendMessageOnClick_Z);
				return cb_setSendMessageOnClick_Z;
			}

			static void n_SetSendMessageOnClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SendMessageOnClick = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isSendMessageOnClick;
			static IntPtr id_setSendMessageOnClick_Z;
			public virtual unsafe bool SendMessageOnClick {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']/method[@name='isSendMessageOnClick' and count(parameter)=0]"
				[Register ("isSendMessageOnClick", "()Z", "GetIsSendMessageOnClickHandler")]
				get {
					if (id_isSendMessageOnClick == IntPtr.Zero)
						id_isSendMessageOnClick = JNIEnv.GetMethodID (class_ref, "isSendMessageOnClick", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSendMessageOnClick);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSendMessageOnClick", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']/method[@name='setSendMessageOnClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setSendMessageOnClick", "(Z)V", "GetSetSendMessageOnClick_ZHandler")]
				set {
					if (id_setSendMessageOnClick_Z == IntPtr.Zero)
						id_setSendMessageOnClick_Z = JNIEnv.GetMethodID (class_ref, "setSendMessageOnClick", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSendMessageOnClick_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSendMessageOnClick", "(Z)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_isShowOnReceiverSide;
#pragma warning disable 0169
			static Delegate GetIsShowOnReceiverSideHandler ()
			{
				if (cb_isShowOnReceiverSide == null)
					cb_isShowOnReceiverSide = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowOnReceiverSide);
				return cb_isShowOnReceiverSide;
			}

			static bool n_IsShowOnReceiverSide (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ShowOnReceiverSide;
			}
#pragma warning restore 0169

			static Delegate cb_setShowOnReceiverSide_Z;
#pragma warning disable 0169
			static Delegate GetSetShowOnReceiverSide_ZHandler ()
			{
				if (cb_setShowOnReceiverSide_Z == null)
					cb_setShowOnReceiverSide_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowOnReceiverSide_Z);
				return cb_setShowOnReceiverSide_Z;
			}

			static void n_SetShowOnReceiverSide_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ShowOnReceiverSide = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isShowOnReceiverSide;
			static IntPtr id_setShowOnReceiverSide_Z;
			public virtual unsafe bool ShowOnReceiverSide {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']/method[@name='isShowOnReceiverSide' and count(parameter)=0]"
				[Register ("isShowOnReceiverSide", "()Z", "GetIsShowOnReceiverSideHandler")]
				get {
					if (id_isShowOnReceiverSide == IntPtr.Zero)
						id_isShowOnReceiverSide = JNIEnv.GetMethodID (class_ref, "isShowOnReceiverSide", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShowOnReceiverSide);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowOnReceiverSide", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']/method[@name='setShowOnReceiverSide' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setShowOnReceiverSide", "(Z)V", "GetSetShowOnReceiverSide_ZHandler")]
				set {
					if (id_setShowOnReceiverSide_Z == IntPtr.Zero)
						id_setShowOnReceiverSide_Z = JNIEnv.GetMethodID (class_ref, "setShowOnReceiverSide", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShowOnReceiverSide_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowOnReceiverSide", "(Z)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_isShowOnSenderSide;
#pragma warning disable 0169
			static Delegate GetIsShowOnSenderSideHandler ()
			{
				if (cb_isShowOnSenderSide == null)
					cb_isShowOnSenderSide = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowOnSenderSide);
				return cb_isShowOnSenderSide;
			}

			static bool n_IsShowOnSenderSide (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ShowOnSenderSide;
			}
#pragma warning restore 0169

			static Delegate cb_setShowOnSenderSide_Z;
#pragma warning disable 0169
			static Delegate GetSetShowOnSenderSide_ZHandler ()
			{
				if (cb_setShowOnSenderSide_Z == null)
					cb_setShowOnSenderSide_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowOnSenderSide_Z);
				return cb_setShowOnSenderSide_Z;
			}

			static void n_SetShowOnSenderSide_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ShowOnSenderSide = p0;
			}
#pragma warning restore 0169

			static IntPtr id_isShowOnSenderSide;
			static IntPtr id_setShowOnSenderSide_Z;
			public virtual unsafe bool ShowOnSenderSide {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']/method[@name='isShowOnSenderSide' and count(parameter)=0]"
				[Register ("isShowOnSenderSide", "()Z", "GetIsShowOnSenderSideHandler")]
				get {
					if (id_isShowOnSenderSide == IntPtr.Zero)
						id_isShowOnSenderSide = JNIEnv.GetMethodID (class_ref, "isShowOnSenderSide", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShowOnSenderSide);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowOnSenderSide", "()Z"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate.MessageContentItem']/method[@name='setShowOnSenderSide' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setShowOnSenderSide", "(Z)V", "GetSetShowOnSenderSide_ZHandler")]
				set {
					if (id_setShowOnSenderSide_Z == IntPtr.Zero)
						id_setShowOnSenderSide_Z = JNIEnv.GetMethodID (class_ref, "setShowOnSenderSide", "(Z)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShowOnSenderSide_Z, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowOnSenderSide", "(Z)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobicomMessageTemplate); }
		}

		protected MobicomMessageTemplate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/constructor[@name='MobicomMessageTemplate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobicomMessageTemplate ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MobicomMessageTemplate)) {
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

		static Delegate cb_getAudioMessageList;
#pragma warning disable 0169
		static Delegate GetGetAudioMessageListHandler ()
		{
			if (cb_getAudioMessageList == null)
				cb_getAudioMessageList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioMessageList);
			return cb_getAudioMessageList;
		}

		static IntPtr n_GetAudioMessageList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioMessageList);
		}
#pragma warning restore 0169

		static Delegate cb_setAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
#pragma warning disable 0169
		static Delegate GetSetAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler ()
		{
			if (cb_setAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == null)
				cb_setAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_);
			return cb_setAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		}

		static void n_SetAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AudioMessageList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioMessageList;
		static IntPtr id_setAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem AudioMessageList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getAudioMessageList' and count(parameter)=0]"
			[Register ("getAudioMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;", "GetGetAudioMessageListHandler")]
			get {
				if (id_getAudioMessageList == IntPtr.Zero)
					id_getAudioMessageList = JNIEnv.GetMethodID (class_ref, "getAudioMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioMessageList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setAudioMessageList' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.MobicomMessageTemplate.MessageContentItem']]"
			[Register ("setAudioMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V", "GetSetAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler")]
			set {
				if (id_setAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == IntPtr.Zero)
					id_setAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNIEnv.GetMethodID (class_ref, "setAudioMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBackGroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackGroundColorHandler ()
		{
			if (cb_getBackGroundColor == null)
				cb_getBackGroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBackGroundColor);
			return cb_getBackGroundColor;
		}

		static IntPtr n_GetBackGroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BackGroundColor);
		}
#pragma warning restore 0169

		static Delegate cb_setBackGroundColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBackGroundColor_Ljava_lang_String_Handler ()
		{
			if (cb_setBackGroundColor_Ljava_lang_String_ == null)
				cb_setBackGroundColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackGroundColor_Ljava_lang_String_);
			return cb_setBackGroundColor_Ljava_lang_String_;
		}

		static void n_SetBackGroundColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BackGroundColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBackGroundColor;
		static IntPtr id_setBackGroundColor_Ljava_lang_String_;
		public virtual unsafe string BackGroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getBackGroundColor' and count(parameter)=0]"
			[Register ("getBackGroundColor", "()Ljava/lang/String;", "GetGetBackGroundColorHandler")]
			get {
				if (id_getBackGroundColor == IntPtr.Zero)
					id_getBackGroundColor = JNIEnv.GetMethodID (class_ref, "getBackGroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBackGroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackGroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setBackGroundColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBackGroundColor", "(Ljava/lang/String;)V", "GetSetBackGroundColor_Ljava_lang_String_Handler")]
			set {
				if (id_setBackGroundColor_Ljava_lang_String_ == IntPtr.Zero)
					id_setBackGroundColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBackGroundColor", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBackGroundColor_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackGroundColor", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBorderColor;
#pragma warning disable 0169
		static Delegate GetGetBorderColorHandler ()
		{
			if (cb_getBorderColor == null)
				cb_getBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBorderColor);
			return cb_getBorderColor;
		}

		static IntPtr n_GetBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BorderColor);
		}
#pragma warning restore 0169

		static Delegate cb_setBorderColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_Ljava_lang_String_Handler ()
		{
			if (cb_setBorderColor_Ljava_lang_String_ == null)
				cb_setBorderColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBorderColor_Ljava_lang_String_);
			return cb_setBorderColor_Ljava_lang_String_;
		}

		static void n_SetBorderColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BorderColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBorderColor;
		static IntPtr id_setBorderColor_Ljava_lang_String_;
		public virtual unsafe string BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getBorderColor' and count(parameter)=0]"
			[Register ("getBorderColor", "()Ljava/lang/String;", "GetGetBorderColorHandler")]
			get {
				if (id_getBorderColor == IntPtr.Zero)
					id_getBorderColor = JNIEnv.GetMethodID (class_ref, "getBorderColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBorderColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBorderColor", "(Ljava/lang/String;)V", "GetSetBorderColor_Ljava_lang_String_Handler")]
			set {
				if (id_setBorderColor_Ljava_lang_String_ == IntPtr.Zero)
					id_setBorderColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBorderColor", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBorderColor_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBorderColor", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContactMessageList;
#pragma warning disable 0169
		static Delegate GetGetContactMessageListHandler ()
		{
			if (cb_getContactMessageList == null)
				cb_getContactMessageList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactMessageList);
			return cb_getContactMessageList;
		}

		static IntPtr n_GetContactMessageList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContactMessageList);
		}
#pragma warning restore 0169

		static Delegate cb_setContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
#pragma warning disable 0169
		static Delegate GetSetContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler ()
		{
			if (cb_setContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == null)
				cb_setContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_);
			return cb_setContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		}

		static void n_SetContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactMessageList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactMessageList;
		static IntPtr id_setContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem ContactMessageList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getContactMessageList' and count(parameter)=0]"
			[Register ("getContactMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;", "GetGetContactMessageListHandler")]
			get {
				if (id_getContactMessageList == IntPtr.Zero)
					id_getContactMessageList = JNIEnv.GetMethodID (class_ref, "getContactMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactMessageList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setContactMessageList' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.MobicomMessageTemplate.MessageContentItem']]"
			[Register ("setContactMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V", "GetSetContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler")]
			set {
				if (id_setContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == IntPtr.Zero)
					id_setContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNIEnv.GetMethodID (class_ref, "setContactMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCornerRadius;
#pragma warning disable 0169
		static Delegate GetGetCornerRadiusHandler ()
		{
			if (cb_getCornerRadius == null)
				cb_getCornerRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCornerRadius);
			return cb_getCornerRadius;
		}

		static int n_GetCornerRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CornerRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setCornerRadius_I;
#pragma warning disable 0169
		static Delegate GetSetCornerRadius_IHandler ()
		{
			if (cb_setCornerRadius_I == null)
				cb_setCornerRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCornerRadius_I);
			return cb_setCornerRadius_I;
		}

		static void n_SetCornerRadius_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CornerRadius = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCornerRadius;
		static IntPtr id_setCornerRadius_I;
		public virtual unsafe int CornerRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getCornerRadius' and count(parameter)=0]"
			[Register ("getCornerRadius", "()I", "GetGetCornerRadiusHandler")]
			get {
				if (id_getCornerRadius == IntPtr.Zero)
					id_getCornerRadius = JNIEnv.GetMethodID (class_ref, "getCornerRadius", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCornerRadius);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCornerRadius", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setCornerRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCornerRadius", "(I)V", "GetSetCornerRadius_IHandler")]
			set {
				if (id_setCornerRadius_I == IntPtr.Zero)
					id_setCornerRadius_I = JNIEnv.GetMethodID (class_ref, "setCornerRadius", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCornerRadius_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCornerRadius", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled;
		}
#pragma warning restore 0169

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled;
		static IntPtr id_setEnabled_Z;
		public virtual unsafe bool Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
			set {
				if (id_setEnabled_Z == IntPtr.Zero)
					id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHideOnSend;
#pragma warning disable 0169
		static Delegate GetGetHideOnSendHandler ()
		{
			if (cb_getHideOnSend == null)
				cb_getHideOnSend = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHideOnSend);
			return cb_getHideOnSend;
		}

		static bool n_GetHideOnSend (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideOnSend;
		}
#pragma warning restore 0169

		static Delegate cb_setHideOnSend_Z;
#pragma warning disable 0169
		static Delegate GetSetHideOnSend_ZHandler ()
		{
			if (cb_setHideOnSend_Z == null)
				cb_setHideOnSend_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHideOnSend_Z);
			return cb_setHideOnSend_Z;
		}

		static void n_SetHideOnSend_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideOnSend = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHideOnSend;
		static IntPtr id_setHideOnSend_Z;
		public virtual unsafe bool HideOnSend {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getHideOnSend' and count(parameter)=0]"
			[Register ("getHideOnSend", "()Z", "GetGetHideOnSendHandler")]
			get {
				if (id_getHideOnSend == IntPtr.Zero)
					id_getHideOnSend = JNIEnv.GetMethodID (class_ref, "getHideOnSend", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getHideOnSend);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHideOnSend", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setHideOnSend' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHideOnSend", "(Z)V", "GetSetHideOnSend_ZHandler")]
			set {
				if (id_setHideOnSend_Z == IntPtr.Zero)
					id_setHideOnSend_Z = JNIEnv.GetMethodID (class_ref, "setHideOnSend", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHideOnSend_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHideOnSend", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageMessageList;
#pragma warning disable 0169
		static Delegate GetGetImageMessageListHandler ()
		{
			if (cb_getImageMessageList == null)
				cb_getImageMessageList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageMessageList);
			return cb_getImageMessageList;
		}

		static IntPtr n_GetImageMessageList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageMessageList);
		}
#pragma warning restore 0169

		static Delegate cb_setImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
#pragma warning disable 0169
		static Delegate GetSetImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler ()
		{
			if (cb_setImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == null)
				cb_setImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_);
			return cb_setImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		}

		static void n_SetImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageMessageList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageMessageList;
		static IntPtr id_setImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem ImageMessageList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getImageMessageList' and count(parameter)=0]"
			[Register ("getImageMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;", "GetGetImageMessageListHandler")]
			get {
				if (id_getImageMessageList == IntPtr.Zero)
					id_getImageMessageList = JNIEnv.GetMethodID (class_ref, "getImageMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageMessageList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setImageMessageList' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.MobicomMessageTemplate.MessageContentItem']]"
			[Register ("setImageMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V", "GetSetImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler")]
			set {
				if (id_setImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == IntPtr.Zero)
					id_setImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNIEnv.GetMethodID (class_ref, "setImageMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocationMessageList;
#pragma warning disable 0169
		static Delegate GetGetLocationMessageListHandler ()
		{
			if (cb_getLocationMessageList == null)
				cb_getLocationMessageList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocationMessageList);
			return cb_getLocationMessageList;
		}

		static IntPtr n_GetLocationMessageList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocationMessageList);
		}
#pragma warning restore 0169

		static Delegate cb_setLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
#pragma warning disable 0169
		static Delegate GetSetLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler ()
		{
			if (cb_setLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == null)
				cb_setLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_);
			return cb_setLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		}

		static void n_SetLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocationMessageList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocationMessageList;
		static IntPtr id_setLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem LocationMessageList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getLocationMessageList' and count(parameter)=0]"
			[Register ("getLocationMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;", "GetGetLocationMessageListHandler")]
			get {
				if (id_getLocationMessageList == IntPtr.Zero)
					id_getLocationMessageList = JNIEnv.GetMethodID (class_ref, "getLocationMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocationMessageList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocationMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setLocationMessageList' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.MobicomMessageTemplate.MessageContentItem']]"
			[Register ("setLocationMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V", "GetSetLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler")]
			set {
				if (id_setLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == IntPtr.Zero)
					id_setLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNIEnv.GetMethodID (class_ref, "setLocationMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocationMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocationMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMessages;
#pragma warning disable 0169
		static Delegate GetGetMessagesHandler ()
		{
			if (cb_getMessages == null)
				cb_getMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessages);
			return cb_getMessages;
		}

		static IntPtr n_GetMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Messages);
		}
#pragma warning restore 0169

		static Delegate cb_setMessages_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetMessages_Ljava_util_Map_Handler ()
		{
			if (cb_setMessages_Ljava_util_Map_ == null)
				cb_setMessages_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessages_Ljava_util_Map_);
			return cb_setMessages_Ljava_util_Map_;
		}

		static void n_SetMessages_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Messages = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages;
		static IntPtr id_setMessages_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Messages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getMessages' and count(parameter)=0]"
			[Register ("getMessages", "()Ljava/util/Map;", "GetGetMessagesHandler")]
			get {
				if (id_getMessages == IntPtr.Zero)
					id_getMessages = JNIEnv.GetMethodID (class_ref, "getMessages", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setMessages' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setMessages", "(Ljava/util/Map;)V", "GetSetMessages_Ljava_util_Map_Handler")]
			set {
				if (id_setMessages_Ljava_util_Map_ == IntPtr.Zero)
					id_setMessages_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMessages", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessages_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessages", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSendMessageOnClick;
#pragma warning disable 0169
		static Delegate GetGetSendMessageOnClickHandler ()
		{
			if (cb_getSendMessageOnClick == null)
				cb_getSendMessageOnClick = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSendMessageOnClick);
			return cb_getSendMessageOnClick;
		}

		static bool n_GetSendMessageOnClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SendMessageOnClick;
		}
#pragma warning restore 0169

		static Delegate cb_setSendMessageOnClick_Z;
#pragma warning disable 0169
		static Delegate GetSetSendMessageOnClick_ZHandler ()
		{
			if (cb_setSendMessageOnClick_Z == null)
				cb_setSendMessageOnClick_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSendMessageOnClick_Z);
			return cb_setSendMessageOnClick_Z;
		}

		static void n_SetSendMessageOnClick_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageOnClick = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSendMessageOnClick;
		static IntPtr id_setSendMessageOnClick_Z;
		public virtual unsafe bool SendMessageOnClick {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getSendMessageOnClick' and count(parameter)=0]"
			[Register ("getSendMessageOnClick", "()Z", "GetGetSendMessageOnClickHandler")]
			get {
				if (id_getSendMessageOnClick == IntPtr.Zero)
					id_getSendMessageOnClick = JNIEnv.GetMethodID (class_ref, "getSendMessageOnClick", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getSendMessageOnClick);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSendMessageOnClick", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setSendMessageOnClick' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSendMessageOnClick", "(Z)V", "GetSetSendMessageOnClick_ZHandler")]
			set {
				if (id_setSendMessageOnClick_Z == IntPtr.Zero)
					id_setSendMessageOnClick_Z = JNIEnv.GetMethodID (class_ref, "setSendMessageOnClick", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSendMessageOnClick_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSendMessageOnClick", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextColor);
			return cb_getTextColor;
		}

		static IntPtr n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TextColor);
		}
#pragma warning restore 0169

		static Delegate cb_setTextColor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTextColor_Ljava_lang_String_Handler ()
		{
			if (cb_setTextColor_Ljava_lang_String_ == null)
				cb_setTextColor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextColor_Ljava_lang_String_);
			return cb_setTextColor_Ljava_lang_String_;
		}

		static void n_SetTextColor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextColor;
		static IntPtr id_setTextColor_Ljava_lang_String_;
		public virtual unsafe string TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()Ljava/lang/String;", "GetGetTextColorHandler")]
			get {
				if (id_getTextColor == IntPtr.Zero)
					id_getTextColor = JNIEnv.GetMethodID (class_ref, "getTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTextColor", "(Ljava/lang/String;)V", "GetSetTextColor_Ljava_lang_String_Handler")]
			set {
				if (id_setTextColor_Ljava_lang_String_ == IntPtr.Zero)
					id_setTextColor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTextColor", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextColor_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextColor", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTextMessageList;
#pragma warning disable 0169
		static Delegate GetGetTextMessageListHandler ()
		{
			if (cb_getTextMessageList == null)
				cb_getTextMessageList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextMessageList);
			return cb_getTextMessageList;
		}

		static IntPtr n_GetTextMessageList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextMessageList);
		}
#pragma warning restore 0169

		static Delegate cb_setTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
#pragma warning disable 0169
		static Delegate GetSetTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler ()
		{
			if (cb_setTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == null)
				cb_setTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_);
			return cb_setTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		}

		static void n_SetTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TextMessageList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTextMessageList;
		static IntPtr id_setTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem TextMessageList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getTextMessageList' and count(parameter)=0]"
			[Register ("getTextMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;", "GetGetTextMessageListHandler")]
			get {
				if (id_getTextMessageList == IntPtr.Zero)
					id_getTextMessageList = JNIEnv.GetMethodID (class_ref, "getTextMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextMessageList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setTextMessageList' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.MobicomMessageTemplate.MessageContentItem']]"
			[Register ("setTextMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V", "GetSetTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler")]
			set {
				if (id_setTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == IntPtr.Zero)
					id_setTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNIEnv.GetMethodID (class_ref, "setTextMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTextMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoMessageList;
#pragma warning disable 0169
		static Delegate GetGetVideoMessageListHandler ()
		{
			if (cb_getVideoMessageList == null)
				cb_getVideoMessageList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoMessageList);
			return cb_getVideoMessageList;
		}

		static IntPtr n_GetVideoMessageList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoMessageList);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
#pragma warning disable 0169
		static Delegate GetSetVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler ()
		{
			if (cb_setVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == null)
				cb_setVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_);
			return cb_setVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		}

		static void n_SetVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VideoMessageList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoMessageList;
		static IntPtr id_setVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem VideoMessageList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='getVideoMessageList' and count(parameter)=0]"
			[Register ("getVideoMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;", "GetGetVideoMessageListHandler")]
			get {
				if (id_getVideoMessageList == IntPtr.Zero)
					id_getVideoMessageList = JNIEnv.GetMethodID (class_ref, "getVideoMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoMessageList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate.MessageContentItem> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoMessageList", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/class[@name='MobicomMessageTemplate']/method[@name='setVideoMessageList' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.MobicomMessageTemplate.MessageContentItem']]"
			[Register ("setVideoMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V", "GetSetVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_Handler")]
			set {
				if (id_setVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ == IntPtr.Zero)
					id_setVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_ = JNIEnv.GetMethodID (class_ref, "setVideoMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoMessageList_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_MessageContentItem_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoMessageList", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate$MessageContentItem;)V"), __args);
				} finally {
				}
			}
		}

	}
}
