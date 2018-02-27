using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Persist {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileFilter']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/persist/PersistanceFileFilter", DoNotGenerateAcw=true)]
	public partial class PersistanceFileFilter : global::Java.Lang.Object, global::Java.IO.IFileFilter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/persist/PersistanceFileFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersistanceFileFilter); }
		}

		protected PersistanceFileFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileFilter']/constructor[@name='PersistanceFileFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PersistanceFileFilter (string fileExtension)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fileExtension = JNIEnv.NewString (fileExtension);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_fileExtension);
				if (((object) this).GetType () != typeof (PersistanceFileFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileExtension);
			}
		}

		static Delegate cb_accept_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_io_File_Handler ()
		{
			if (cb_accept_Ljava_io_File_ == null)
				cb_accept_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Accept_Ljava_io_File_);
			return cb_accept_Ljava_io_File_;
		}

		static bool n_Accept_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pathname)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.PersistanceFileFilter __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.PersistanceFileFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File pathname = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_pathname, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (pathname);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_accept_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileFilter']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("accept", "(Ljava/io/File;)Z", "GetAccept_Ljava_io_File_Handler")]
		public virtual unsafe bool Accept (global::Java.IO.File pathname)
		{
			if (id_accept_Ljava_io_File_ == IntPtr.Zero)
				id_accept_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/io/File;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pathname);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_io_File_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(Ljava/io/File;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
