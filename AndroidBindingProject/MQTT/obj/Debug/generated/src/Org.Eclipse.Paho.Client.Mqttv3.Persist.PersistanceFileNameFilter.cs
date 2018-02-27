using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Persist {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileNameFilter']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/persist/PersistanceFileNameFilter", DoNotGenerateAcw=true)]
	public partial class PersistanceFileNameFilter : global::Java.Lang.Object, global::Java.IO.IFilenameFilter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/persist/PersistanceFileNameFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersistanceFileNameFilter); }
		}

		protected PersistanceFileNameFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileNameFilter']/constructor[@name='PersistanceFileNameFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PersistanceFileNameFilter (string fileExtension)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fileExtension = JNIEnv.NewString (fileExtension);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_fileExtension);
				if (((object) this).GetType () != typeof (PersistanceFileNameFilter)) {
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

		static Delegate cb_accept_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_accept_Ljava_io_File_Ljava_lang_String_ == null)
				cb_accept_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Accept_Ljava_io_File_Ljava_lang_String_);
			return cb_accept_Ljava_io_File_Ljava_lang_String_;
		}

		static bool n_Accept_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dir, IntPtr native_name)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.PersistanceFileNameFilter __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.PersistanceFileNameFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File dir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_dir, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (dir, name);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_accept_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileNameFilter']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("accept", "(Ljava/io/File;Ljava/lang/String;)Z", "GetAccept_Ljava_io_File_Ljava_lang_String_Handler")]
		public virtual unsafe bool Accept (global::Java.IO.File dir, string name)
		{
			if (id_accept_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_accept_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/io/File;Ljava/lang/String;)Z");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dir);
				__args [1] = new JValue (native_name);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_io_File_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(Ljava/io/File;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
