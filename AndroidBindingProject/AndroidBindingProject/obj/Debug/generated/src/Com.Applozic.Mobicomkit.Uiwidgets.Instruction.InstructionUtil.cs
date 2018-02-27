using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Instruction {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/instruction/InstructionUtil", DoNotGenerateAcw=true)]
	public partial class InstructionUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/field[@name='SHARED_PREFERENCE_INSTRUCTION_KEY']"
		[Register ("SHARED_PREFERENCE_INSTRUCTION_KEY")]
		public const string SharedPreferenceInstructionKey = (string) "mck.instruction";

		static IntPtr enabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/field[@name='enabled']"
		[Register ("enabled")]
		public static bool Enabled {
			get {
				if (enabled_jfieldId == IntPtr.Zero)
					enabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enabled", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, enabled_jfieldId);
			}
			set {
				if (enabled_jfieldId == IntPtr.Zero)
					enabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "enabled", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, enabled_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/instruction/InstructionUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InstructionUtil); }
		}

		protected InstructionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/constructor[@name='InstructionUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstructionUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InstructionUtil)) {
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

		static IntPtr id_hideInstruction_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/method[@name='hideInstruction' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("hideInstruction", "(Landroid/content/Context;I)V", "")]
		public static unsafe void HideInstruction (global::Android.Content.Context p0, int p1)
		{
			if (id_hideInstruction_Landroid_content_Context_I == IntPtr.Zero)
				id_hideInstruction_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "hideInstruction", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_hideInstruction_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_showInfo_Landroid_content_Context_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/method[@name='showInfo' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("showInfo", "(Landroid/content/Context;ILjava/lang/String;)V", "")]
		public static unsafe void ShowInfo (global::Android.Content.Context p0, int p1, string p2)
		{
			if (id_showInfo_Landroid_content_Context_ILjava_lang_String_ == IntPtr.Zero)
				id_showInfo_Landroid_content_Context_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showInfo", "(Landroid/content/Context;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showInfo_Landroid_content_Context_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_showInstruction_Landroid_content_Context_IZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/method[@name='showInstruction' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("showInstruction", "(Landroid/content/Context;IZI)V", "")]
		public static unsafe void ShowInstruction (global::Android.Content.Context p0, int p1, bool p2, int p3)
		{
			if (id_showInstruction_Landroid_content_Context_IZI == IntPtr.Zero)
				id_showInstruction_Landroid_content_Context_IZI = JNIEnv.GetStaticMethodID (class_ref, "showInstruction", "(Landroid/content/Context;IZI)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showInstruction_Landroid_content_Context_IZI, __args);
			} finally {
			}
		}

		static IntPtr id_showInstruction_Landroid_content_Context_IIZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/method[@name='showInstruction' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
		[Register ("showInstruction", "(Landroid/content/Context;IIZLjava/lang/String;)V", "")]
		public static unsafe void ShowInstruction (global::Android.Content.Context p0, int p1, int p2, bool p3, string p4)
		{
			if (id_showInstruction_Landroid_content_Context_IIZLjava_lang_String_ == IntPtr.Zero)
				id_showInstruction_Landroid_content_Context_IIZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showInstruction", "(Landroid/content/Context;IIZLjava/lang/String;)V");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showInstruction_Landroid_content_Context_IIZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_showInstruction_Landroid_content_Context_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/method[@name='showInstruction' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("showInstruction", "(Landroid/content/Context;IILjava/lang/String;)V", "")]
		public static unsafe void ShowInstruction (global::Android.Content.Context p0, int p1, int p2, string p3)
		{
			if (id_showInstruction_Landroid_content_Context_IILjava_lang_String_ == IntPtr.Zero)
				id_showInstruction_Landroid_content_Context_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "showInstruction", "(Landroid/content/Context;IILjava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showInstruction_Landroid_content_Context_IILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_showToast_Landroid_content_Context_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.instruction']/class[@name='InstructionUtil']/method[@name='showToast' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("showToast", "(Landroid/content/Context;II)V", "")]
		public static unsafe void ShowToast (global::Android.Content.Context p0, int p1, int p2)
		{
			if (id_showToast_Landroid_content_Context_II == IntPtr.Zero)
				id_showToast_Landroid_content_Context_II = JNIEnv.GetStaticMethodID (class_ref, "showToast", "(Landroid/content/Context;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_showToast_Landroid_content_Context_II, __args);
			} finally {
			}
		}

	}
}
