using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Contact {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='MobiComVCFParser']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/contact/MobiComVCFParser", DoNotGenerateAcw=true)]
	public partial class MobiComVCFParser : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='MobiComVCFParser']/field[@name='BEGIN_VCARD']"
		[Register ("BEGIN_VCARD")]
		public const string BeginVcard = (string) "BEGIN:VCARD";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='MobiComVCFParser']/field[@name='END_VCARD']"
		[Register ("END_VCARD")]
		public const string EndVcard = (string) "END:VCARD";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='MobiComVCFParser']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "VERSION:2.1";

		static IntPtr vcfContactData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='MobiComVCFParser']/field[@name='vcfContactData']"
		[Register ("vcfContactData")]
		public global::Com.Applozic.Mobicomkit.Contact.VCFContactData VcfContactData {
			get {
				if (vcfContactData_jfieldId == IntPtr.Zero)
					vcfContactData_jfieldId = JNIEnv.GetFieldID (class_ref, "vcfContactData", "Lcom/applozic/mobicomkit/contact/VCFContactData;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, vcfContactData_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vcfContactData_jfieldId == IntPtr.Zero)
					vcfContactData_jfieldId = JNIEnv.GetFieldID (class_ref, "vcfContactData", "Lcom/applozic/mobicomkit/contact/VCFContactData;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vcfContactData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/contact/MobiComVCFParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobiComVCFParser); }
		}

		protected MobiComVCFParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='MobiComVCFParser']/constructor[@name='MobiComVCFParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobiComVCFParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MobiComVCFParser)) {
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

		static Delegate cb_parseCVFContactData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseCVFContactData_Ljava_lang_String_Handler ()
		{
			if (cb_parseCVFContactData_Ljava_lang_String_ == null)
				cb_parseCVFContactData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseCVFContactData_Ljava_lang_String_);
			return cb_parseCVFContactData_Ljava_lang_String_;
		}

		static IntPtr n_ParseCVFContactData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.MobiComVCFParser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.MobiComVCFParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseCVFContactData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseCVFContactData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='MobiComVCFParser']/method[@name='parseCVFContactData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseCVFContactData", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/contact/VCFContactData;", "GetParseCVFContactData_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Contact.VCFContactData ParseCVFContactData (string p0)
		{
			if (id_parseCVFContactData_Ljava_lang_String_ == IntPtr.Zero)
				id_parseCVFContactData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parseCVFContactData", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/contact/VCFContactData;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Contact.VCFContactData __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parseCVFContactData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseCVFContactData", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/contact/VCFContactData;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_stringToBitMap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStringToBitMap_Ljava_lang_String_Handler ()
		{
			if (cb_stringToBitMap_Ljava_lang_String_ == null)
				cb_stringToBitMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StringToBitMap_Ljava_lang_String_);
			return cb_stringToBitMap_Ljava_lang_String_;
		}

		static IntPtr n_StringToBitMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.MobiComVCFParser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.MobiComVCFParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StringToBitMap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_stringToBitMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='MobiComVCFParser']/method[@name='stringToBitMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringToBitMap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetStringToBitMap_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap StringToBitMap (string p0)
		{
			if (id_stringToBitMap_Ljava_lang_String_ == IntPtr.Zero)
				id_stringToBitMap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "stringToBitMap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_stringToBitMap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stringToBitMap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_validateData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='MobiComVCFParser']/method[@name='validateData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validateData", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ValidateData (string p0)
		{
			if (id_validateData_Ljava_lang_String_ == IntPtr.Zero)
				id_validateData_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "validateData", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validateData_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
