using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.File {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='LocalStorageProvider']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/file/LocalStorageProvider", DoNotGenerateAcw=true)]
	public partial class LocalStorageProvider : global::Android.Provider.DocumentsProvider {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='LocalStorageProvider']/field[@name='AUTHORITY']"
		[Register ("AUTHORITY")]
		public const string Authority = (string) "com.ianhanniballake.localstorage.documents";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/file/LocalStorageProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalStorageProvider); }
		}

		protected LocalStorageProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='LocalStorageProvider']/constructor[@name='LocalStorageProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocalStorageProvider ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LocalStorageProvider)) {
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

		static Delegate cb_onCreate;
#pragma warning disable 0169
		static Delegate GetOnCreateHandler ()
		{
			if (cb_onCreate == null)
				cb_onCreate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnCreate);
			return cb_onCreate;
		}

		static bool n_OnCreate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.File.LocalStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.File.LocalStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnCreate ();
		}
#pragma warning restore 0169

		static IntPtr id_onCreate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='LocalStorageProvider']/method[@name='onCreate' and count(parameter)=0]"
		[Register ("onCreate", "()Z", "GetOnCreateHandler")]
		public override unsafe bool OnCreate ()
		{
			if (id_onCreate == IntPtr.Zero)
				id_onCreate = JNIEnv.GetMethodID (class_ref, "onCreate", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCreate);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "()Z"));
			} finally {
			}
		}

		static Delegate cb_openDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_;
#pragma warning disable 0169
		static Delegate GetOpenDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_Handler ()
		{
			if (cb_openDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_ == null)
				cb_openDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_);
			return cb_openDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_;
		}

		static IntPtr n_OpenDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicommons.File.LocalStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.File.LocalStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.CancellationSignal p2 = global::Java.Lang.Object.GetObject<global::Android.OS.CancellationSignal> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenDocument (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='LocalStorageProvider']/method[@name='openDocument' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.CancellationSignal']]"
		[Register ("openDocument", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/CancellationSignal;)Landroid/os/ParcelFileDescriptor;", "GetOpenDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_Handler")]
		public override unsafe global::Android.OS.ParcelFileDescriptor OpenDocument (string p0, string p1, global::Android.OS.CancellationSignal p2)
		{
			if (id_openDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_ == IntPtr.Zero)
				id_openDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_ = JNIEnv.GetMethodID (class_ref, "openDocument", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/CancellationSignal;)Landroid/os/ParcelFileDescriptor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::Android.OS.ParcelFileDescriptor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openDocument_Ljava_lang_String_Ljava_lang_String_Landroid_os_CancellationSignal_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.ParcelFileDescriptor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openDocument", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/CancellationSignal;)Landroid/os/ParcelFileDescriptor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_queryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_queryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
				cb_queryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_);
			return cb_queryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_QueryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicommons.File.LocalStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.File.LocalStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.QueryChildDocuments (p0, p1, p2));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_queryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='LocalStorageProvider']/method[@name='queryChildDocuments' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String']]"
		[Register ("queryChildDocuments", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQueryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe global::Android.Database.ICursor QueryChildDocuments (string p0, string[] p1, string p2)
		{
			if (id_queryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_queryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queryChildDocuments", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryChildDocuments_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryChildDocuments", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_queryDocument_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueryDocument_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_queryDocument_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_queryDocument_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryDocument_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_queryDocument_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_QueryDocument_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicommons.File.LocalStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.File.LocalStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.QueryDocument (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_queryDocument_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='LocalStorageProvider']/method[@name='queryDocument' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("queryDocument", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;", "GetQueryDocument_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public override unsafe global::Android.Database.ICursor QueryDocument (string p0, string[] p1)
		{
			if (id_queryDocument_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_queryDocument_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queryDocument", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryDocument_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryDocument", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_queryRoots_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueryRoots_arrayLjava_lang_String_Handler ()
		{
			if (cb_queryRoots_arrayLjava_lang_String_ == null)
				cb_queryRoots_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_QueryRoots_arrayLjava_lang_String_);
			return cb_queryRoots_arrayLjava_lang_String_;
		}

		static IntPtr n_QueryRoots_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.File.LocalStorageProvider __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.File.LocalStorageProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.QueryRoots (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_queryRoots_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='LocalStorageProvider']/method[@name='queryRoots' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("queryRoots", "([Ljava/lang/String;)Landroid/database/Cursor;", "GetQueryRoots_arrayLjava_lang_String_Handler")]
		public override unsafe global::Android.Database.ICursor QueryRoots (string[] p0)
		{
			if (id_queryRoots_arrayLjava_lang_String_ == IntPtr.Zero)
				id_queryRoots_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queryRoots", "([Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_queryRoots_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queryRoots", "([Ljava/lang/String;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
