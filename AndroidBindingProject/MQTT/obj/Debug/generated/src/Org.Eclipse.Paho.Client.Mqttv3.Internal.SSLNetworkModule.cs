using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/SSLNetworkModule", DoNotGenerateAcw=true)]
	public partial class SSLNetworkModule : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/SSLNetworkModule", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SSLNetworkModule); }
		}

		protected SSLNetworkModule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljavax_net_ssl_SSLSocketFactory_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/constructor[@name='SSLNetworkModule' and count(parameter)=4 and parameter[1][@type='javax.net.ssl.SSLSocketFactory'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe SSLNetworkModule (global::Javax.Net.Ssl.SSLSocketFactory factory, string host, int port, string resourceContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_host = JNIEnv.NewString (host);
			IntPtr native_resourceContext = JNIEnv.NewString (resourceContext);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (factory);
				__args [1] = new JValue (native_host);
				__args [2] = new JValue (port);
				__args [3] = new JValue (native_resourceContext);
				if (((object) this).GetType () != typeof (SSLNetworkModule)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljavax/net/ssl/SSLSocketFactory;Ljava/lang/String;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljavax/net/ssl/SSLSocketFactory;Ljava/lang/String;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljavax_net_ssl_SSLSocketFactory_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljavax_net_ssl_SSLSocketFactory_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljavax/net/ssl/SSLSocketFactory;Ljava/lang/String;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljavax_net_ssl_SSLSocketFactory_Ljava_lang_String_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljavax_net_ssl_SSLSocketFactory_Ljava_lang_String_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_resourceContext);
			}
		}

		static Delegate cb_getEnabledCiphers;
#pragma warning disable 0169
		static Delegate GetGetEnabledCiphersHandler ()
		{
			if (cb_getEnabledCiphers == null)
				cb_getEnabledCiphers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnabledCiphers);
			return cb_getEnabledCiphers;
		}

		static IntPtr n_GetEnabledCiphers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEnabledCiphers ());
		}
#pragma warning restore 0169

		static IntPtr id_getEnabledCiphers;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/method[@name='getEnabledCiphers' and count(parameter)=0]"
		[Register ("getEnabledCiphers", "()[Ljava/lang/String;", "GetGetEnabledCiphersHandler")]
		public virtual unsafe string[] GetEnabledCiphers ()
		{
			if (id_getEnabledCiphers == IntPtr.Zero)
				id_getEnabledCiphers = JNIEnv.GetMethodID (class_ref, "getEnabledCiphers", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnabledCiphers), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnabledCiphers", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setEnabledCiphers_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEnabledCiphers_arrayLjava_lang_String_Handler ()
		{
			if (cb_setEnabledCiphers_arrayLjava_lang_String_ == null)
				cb_setEnabledCiphers_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEnabledCiphers_arrayLjava_lang_String_);
			return cb_setEnabledCiphers_arrayLjava_lang_String_;
		}

		static void n_SetEnabledCiphers_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_enabledCiphers)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] enabledCiphers = (string[]) JNIEnv.GetArray (native_enabledCiphers, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetEnabledCiphers (enabledCiphers);
			if (enabledCiphers != null)
				JNIEnv.CopyArray (enabledCiphers, native_enabledCiphers);
		}
#pragma warning restore 0169

		static IntPtr id_setEnabledCiphers_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/method[@name='setEnabledCiphers' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setEnabledCiphers", "([Ljava/lang/String;)V", "GetSetEnabledCiphers_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetEnabledCiphers (string[] enabledCiphers)
		{
			if (id_setEnabledCiphers_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setEnabledCiphers_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEnabledCiphers", "([Ljava/lang/String;)V");
			IntPtr native_enabledCiphers = JNIEnv.NewArray (enabledCiphers);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_enabledCiphers);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnabledCiphers_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnabledCiphers", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (enabledCiphers != null) {
					JNIEnv.CopyArray (native_enabledCiphers, enabledCiphers);
					JNIEnv.DeleteLocalRef (native_enabledCiphers);
				}
			}
		}

		static Delegate cb_setSSLhandshakeTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetSSLhandshakeTimeout_IHandler ()
		{
			if (cb_setSSLhandshakeTimeout_I == null)
				cb_setSSLhandshakeTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSSLhandshakeTimeout_I);
			return cb_setSSLhandshakeTimeout_I;
		}

		static void n_SetSSLhandshakeTimeout_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.SSLNetworkModule> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSSLhandshakeTimeout (timeout);
		}
#pragma warning restore 0169

		static IntPtr id_setSSLhandshakeTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='SSLNetworkModule']/method[@name='setSSLhandshakeTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSSLhandshakeTimeout", "(I)V", "GetSetSSLhandshakeTimeout_IHandler")]
		public virtual unsafe void SetSSLhandshakeTimeout (int timeout)
		{
			if (id_setSSLhandshakeTimeout_I == IntPtr.Zero)
				id_setSSLhandshakeTimeout_I = JNIEnv.GetMethodID (class_ref, "setSSLhandshakeTimeout", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeout);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSSLhandshakeTimeout_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSSLhandshakeTimeout", "(I)V"), __args);
			} finally {
			}
		}

	}
}
