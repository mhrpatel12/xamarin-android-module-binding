using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Alphanumbericcolor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.alphanumbericcolor']/class[@name='AlphaNumberColorUtil']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/alphanumbericcolor/AlphaNumberColorUtil", DoNotGenerateAcw=true)]
	public partial class AlphaNumberColorUtil : global::Java.Lang.Object {


		static IntPtr alphabetBackgroundColorMap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.alphanumbericcolor']/class[@name='AlphaNumberColorUtil']/field[@name='alphabetBackgroundColorMap']"
		[Register ("alphabetBackgroundColorMap")]
		public static global::System.Collections.IDictionary AlphabetBackgroundColorMap {
			get {
				if (alphabetBackgroundColorMap_jfieldId == IntPtr.Zero)
					alphabetBackgroundColorMap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "alphabetBackgroundColorMap", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, alphabetBackgroundColorMap_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (alphabetBackgroundColorMap_jfieldId == IntPtr.Zero)
					alphabetBackgroundColorMap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "alphabetBackgroundColorMap", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, alphabetBackgroundColorMap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr alphabetTextColorMap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.alphanumbericcolor']/class[@name='AlphaNumberColorUtil']/field[@name='alphabetTextColorMap']"
		[Register ("alphabetTextColorMap")]
		public static global::System.Collections.IDictionary AlphabetTextColorMap {
			get {
				if (alphabetTextColorMap_jfieldId == IntPtr.Zero)
					alphabetTextColorMap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "alphabetTextColorMap", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, alphabetTextColorMap_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (alphabetTextColorMap_jfieldId == IntPtr.Zero)
					alphabetTextColorMap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "alphabetTextColorMap", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, alphabetTextColorMap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr randomAlphabetBackgroundColorMap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.alphanumbericcolor']/class[@name='AlphaNumberColorUtil']/field[@name='randomAlphabetBackgroundColorMap']"
		[Register ("randomAlphabetBackgroundColorMap")]
		public static global::System.Collections.IDictionary RandomAlphabetBackgroundColorMap {
			get {
				if (randomAlphabetBackgroundColorMap_jfieldId == IntPtr.Zero)
					randomAlphabetBackgroundColorMap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "randomAlphabetBackgroundColorMap", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, randomAlphabetBackgroundColorMap_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (randomAlphabetBackgroundColorMap_jfieldId == IntPtr.Zero)
					randomAlphabetBackgroundColorMap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "randomAlphabetBackgroundColorMap", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, randomAlphabetBackgroundColorMap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/alphanumbericcolor/AlphaNumberColorUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlphaNumberColorUtil); }
		}

		protected AlphaNumberColorUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.alphanumbericcolor']/class[@name='AlphaNumberColorUtil']/constructor[@name='AlphaNumberColorUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlphaNumberColorUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AlphaNumberColorUtil)) {
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

	}
}
