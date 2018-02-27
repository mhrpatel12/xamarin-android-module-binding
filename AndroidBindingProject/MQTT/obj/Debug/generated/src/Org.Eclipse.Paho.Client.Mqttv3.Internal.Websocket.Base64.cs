using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']"
		[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/Base64$Base64Encoder", DoNotGenerateAcw=true)]
		public partial class Base64Encoder : global::Java.Util.Prefs.AbstractPreferences {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/websocket/Base64$Base64Encoder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Base64Encoder); }
			}

			protected Base64Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_websocket_Base64_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/constructor[@name='Base64.Base64Encoder' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.websocket.Base64']]"
			[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/internal/websocket/Base64;)V", "")]
			public unsafe Base64Encoder (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64 __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (Base64Encoder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_websocket_Base64_ == IntPtr.Zero)
						id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_websocket_Base64_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/internal/websocket/Base64;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_websocket_Base64_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_websocket_Base64_, __args);
				} finally {
				}
			}

			static Delegate cb_getBase64String;
#pragma warning disable 0169
			static Delegate GetGetBase64StringHandler ()
			{
				if (cb_getBase64String == null)
					cb_getBase64String = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBase64String);
				return cb_getBase64String;
			}

			static IntPtr n_GetBase64String (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Base64String);
			}
#pragma warning restore 0169

			static IntPtr id_getBase64String;
			public virtual unsafe string Base64String {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='getBase64String' and count(parameter)=0]"
				[Register ("getBase64String", "()Ljava/lang/String;", "GetGetBase64StringHandler")]
				get {
					if (id_getBase64String == IntPtr.Zero)
						id_getBase64String = JNIEnv.GetMethodID (class_ref, "getBase64String", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBase64String), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBase64String", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_childSpi_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetChildSpi_Ljava_lang_String_Handler ()
			{
				if (cb_childSpi_Ljava_lang_String_ == null)
					cb_childSpi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ChildSpi_Ljava_lang_String_);
				return cb_childSpi_Ljava_lang_String_;
			}

			static IntPtr n_ChildSpi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ChildSpi (name));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_childSpi_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='childSpi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;", "GetChildSpi_Ljava_lang_String_Handler")]
			protected override unsafe global::Java.Util.Prefs.AbstractPreferences ChildSpi (string name)
			{
				if (id_childSpi_Ljava_lang_String_ == IntPtr.Zero)
					id_childSpi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);

					global::Java.Util.Prefs.AbstractPreferences __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Prefs.AbstractPreferences> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_childSpi_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Prefs.AbstractPreferences> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "childSpi", "(Ljava/lang/String;)Ljava/util/prefs/AbstractPreferences;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_childrenNamesSpi;
#pragma warning disable 0169
			static Delegate GetChildrenNamesSpiHandler ()
			{
				if (cb_childrenNamesSpi == null)
					cb_childrenNamesSpi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ChildrenNamesSpi);
				return cb_childrenNamesSpi;
			}

			static IntPtr n_ChildrenNamesSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.ChildrenNamesSpi ());
			}
#pragma warning restore 0169

			static IntPtr id_childrenNamesSpi;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='childrenNamesSpi' and count(parameter)=0]"
			[Register ("childrenNamesSpi", "()[Ljava/lang/String;", "GetChildrenNamesSpiHandler")]
			protected override unsafe string[] ChildrenNamesSpi ()
			{
				if (id_childrenNamesSpi == IntPtr.Zero)
					id_childrenNamesSpi = JNIEnv.GetMethodID (class_ref, "childrenNamesSpi", "()[Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_childrenNamesSpi), JniHandleOwnership.TransferLocalRef, typeof (string));
					else
						return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "childrenNamesSpi", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			static Delegate cb_flushSpi;
#pragma warning disable 0169
			static Delegate GetFlushSpiHandler ()
			{
				if (cb_flushSpi == null)
					cb_flushSpi = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FlushSpi);
				return cb_flushSpi;
			}

			static void n_FlushSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FlushSpi ();
			}
#pragma warning restore 0169

			static IntPtr id_flushSpi;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='flushSpi' and count(parameter)=0]"
			[Register ("flushSpi", "()V", "GetFlushSpiHandler")]
			protected override unsafe void FlushSpi ()
			{
				if (id_flushSpi == IntPtr.Zero)
					id_flushSpi = JNIEnv.GetMethodID (class_ref, "flushSpi", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flushSpi);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flushSpi", "()V"));
				} finally {
				}
			}

			static Delegate cb_getSpi_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetSpi_Ljava_lang_String_Handler ()
			{
				if (cb_getSpi_Ljava_lang_String_ == null)
					cb_getSpi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSpi_Ljava_lang_String_);
				return cb_getSpi_Ljava_lang_String_;
			}

			static IntPtr n_GetSpi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GetSpi (key));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getSpi_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='getSpi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getSpi", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSpi_Ljava_lang_String_Handler")]
			protected override unsafe string GetSpi (string key)
			{
				if (id_getSpi_Ljava_lang_String_ == IntPtr.Zero)
					id_getSpi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSpi", "(Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_key = JNIEnv.NewString (key);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_key);

					string __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSpi_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSpi", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
				}
			}

			static Delegate cb_keysSpi;
#pragma warning disable 0169
			static Delegate GetKeysSpiHandler ()
			{
				if (cb_keysSpi == null)
					cb_keysSpi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_KeysSpi);
				return cb_keysSpi;
			}

			static IntPtr n_KeysSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.KeysSpi ());
			}
#pragma warning restore 0169

			static IntPtr id_keysSpi;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='keysSpi' and count(parameter)=0]"
			[Register ("keysSpi", "()[Ljava/lang/String;", "GetKeysSpiHandler")]
			protected override unsafe string[] KeysSpi ()
			{
				if (id_keysSpi == IntPtr.Zero)
					id_keysSpi = JNIEnv.GetMethodID (class_ref, "keysSpi", "()[Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_keysSpi), JniHandleOwnership.TransferLocalRef, typeof (string));
					else
						return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keysSpi", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			static Delegate cb_putSpi_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPutSpi_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_putSpi_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_putSpi_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutSpi_Ljava_lang_String_Ljava_lang_String_);
				return cb_putSpi_Ljava_lang_String_Ljava_lang_String_;
			}

			static void n_PutSpi_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
				__this.PutSpi (key, value);
			}
#pragma warning restore 0169

			static IntPtr id_putSpi_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='putSpi' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("putSpi", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutSpi_Ljava_lang_String_Ljava_lang_String_Handler")]
			protected override unsafe void PutSpi (string key, string value)
			{
				if (id_putSpi_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_putSpi_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putSpi", "(Ljava/lang/String;Ljava/lang/String;)V");
				IntPtr native_key = JNIEnv.NewString (key);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_key);
					__args [1] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putSpi_Ljava_lang_String_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putSpi", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static Delegate cb_removeNodeSpi;
#pragma warning disable 0169
			static Delegate GetRemoveNodeSpiHandler ()
			{
				if (cb_removeNodeSpi == null)
					cb_removeNodeSpi = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveNodeSpi);
				return cb_removeNodeSpi;
			}

			static void n_RemoveNodeSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.RemoveNodeSpi ();
			}
#pragma warning restore 0169

			static IntPtr id_removeNodeSpi;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='removeNodeSpi' and count(parameter)=0]"
			[Register ("removeNodeSpi", "()V", "GetRemoveNodeSpiHandler")]
			protected override unsafe void RemoveNodeSpi ()
			{
				if (id_removeNodeSpi == IntPtr.Zero)
					id_removeNodeSpi = JNIEnv.GetMethodID (class_ref, "removeNodeSpi", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeNodeSpi);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeNodeSpi", "()V"));
				} finally {
				}
			}

			static Delegate cb_removeSpi_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRemoveSpi_Ljava_lang_String_Handler ()
			{
				if (cb_removeSpi_Ljava_lang_String_ == null)
					cb_removeSpi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSpi_Ljava_lang_String_);
				return cb_removeSpi_Ljava_lang_String_;
			}

			static void n_RemoveSpi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				__this.RemoveSpi (key);
			}
#pragma warning restore 0169

			static IntPtr id_removeSpi_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='removeSpi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeSpi", "(Ljava/lang/String;)V", "GetRemoveSpi_Ljava_lang_String_Handler")]
			protected override unsafe void RemoveSpi (string key)
			{
				if (id_removeSpi_Ljava_lang_String_ == IntPtr.Zero)
					id_removeSpi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeSpi", "(Ljava/lang/String;)V");
				IntPtr native_key = JNIEnv.NewString (key);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_key);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSpi_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSpi", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_key);
				}
			}

			static Delegate cb_syncSpi;
#pragma warning disable 0169
			static Delegate GetSyncSpiHandler ()
			{
				if (cb_syncSpi == null)
					cb_syncSpi = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncSpi);
				return cb_syncSpi;
			}

			static void n_SyncSpi (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.Base64.Base64Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SyncSpi ();
			}
#pragma warning restore 0169

			static IntPtr id_syncSpi;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64.Base64Encoder']/method[@name='syncSpi' and count(parameter)=0]"
			[Register ("syncSpi", "()V", "GetSyncSpiHandler")]
			protected override unsafe void SyncSpi ()
			{
				if (id_syncSpi == IntPtr.Zero)
					id_syncSpi = JNIEnv.GetMethodID (class_ref, "syncSpi", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncSpi);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncSpi", "()V"));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/websocket/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Base64 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Base64)) {
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

		static IntPtr id_encode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encode (string s)
		{
			if (id_encode_Ljava_lang_String_ == IntPtr.Zero)
				id_encode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_s);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		static IntPtr id_encodeBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='Base64']/method[@name='encodeBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBytes", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBytes (byte[] b)
		{
			if (id_encodeBytes_arrayB == IntPtr.Zero)
				id_encodeBytes_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBytes", "([B)Ljava/lang/String;");
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_b);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBytes_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

	}
}
