using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketNetworkModule']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketNetworkModule", DoNotGenerateAcw=true)]
	public partial class WebSocketNetworkModule : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.TCPNetworkModule {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketNetworkModule", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebSocketNetworkModule); }
		}

		protected WebSocketNetworkModule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljavax_net_SocketFactory_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketNetworkModule']/constructor[@name='WebSocketNetworkModule' and count(parameter)=5 and parameter[1][@type='javax.net.SocketFactory'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljavax/net/SocketFactory;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe WebSocketNetworkModule (global::Javax.Net.SocketFactory factory, string uri, string host, int port, string resourceContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_uri = JNIEnv.NewString (uri);
			IntPtr native_host = JNIEnv.NewString (host);
			IntPtr native_resourceContext = JNIEnv.NewString (resourceContext);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (factory);
				__args [1] = new JValue (native_uri);
				__args [2] = new JValue (native_host);
				__args [3] = new JValue (port);
				__args [4] = new JValue (native_resourceContext);
				if (((object) this).GetType () != typeof (WebSocketNetworkModule)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljavax/net/SocketFactory;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljavax/net/SocketFactory;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljavax_net_SocketFactory_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljavax_net_SocketFactory_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljavax/net/SocketFactory;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljavax_net_SocketFactory_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljavax_net_SocketFactory_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_resourceContext);
			}
		}

	}
}
