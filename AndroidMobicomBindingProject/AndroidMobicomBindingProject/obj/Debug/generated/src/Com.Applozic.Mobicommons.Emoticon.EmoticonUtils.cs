using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Emoticon {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.emoticon']/class[@name='EmoticonUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/emoticon/EmoticonUtils", DoNotGenerateAcw=true)]
	public partial class EmoticonUtils : global::Java.Lang.Object {


		static IntPtr spannableFactory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.emoticon']/class[@name='EmoticonUtils']/field[@name='spannableFactory']"
		[Register ("spannableFactory")]
		public static global::Android.Text.SpannableFactory SpannableFactory {
			get {
				if (spannableFactory_jfieldId == IntPtr.Zero)
					spannableFactory_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "spannableFactory", "Landroid/text/Spannable$Factory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, spannableFactory_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Text.SpannableFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/emoticon/EmoticonUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EmoticonUtils); }
		}

		protected EmoticonUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.emoticon']/class[@name='EmoticonUtils']/constructor[@name='EmoticonUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EmoticonUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EmoticonUtils)) {
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

		static IntPtr id_getSmiledText_Landroid_content_Context_Ljava_lang_CharSequence_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.emoticon']/class[@name='EmoticonUtils']/method[@name='getSmiledText' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='com.applozic.mobicommons.emoticon.EmojiconHandler']]"
		[Register ("getSmiledText", "(Landroid/content/Context;Ljava/lang/CharSequence;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)Landroid/text/Spannable;", "")]
		public static unsafe global::Android.Text.ISpannable GetSmiledText (global::Android.Content.Context p0, global::Java.Lang.ICharSequence p1, global::Com.Applozic.Mobicommons.Emoticon.IEmojiconHandler p2)
		{
			if (id_getSmiledText_Landroid_content_Context_Ljava_lang_CharSequence_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_ == IntPtr.Zero)
				id_getSmiledText_Landroid_content_Context_Ljava_lang_CharSequence_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_ = JNIEnv.GetStaticMethodID (class_ref, "getSmiledText", "(Landroid/content/Context;Ljava/lang/CharSequence;Lcom/applozic/mobicommons/emoticon/EmojiconHandler;)Landroid/text/Spannable;");
			IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Android.Text.ISpannable __ret = global::Java.Lang.Object.GetObject<global::Android.Text.ISpannable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSmiledText_Landroid_content_Context_Ljava_lang_CharSequence_Lcom_applozic_mobicommons_emoticon_EmojiconHandler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		public static global::Android.Text.ISpannable GetSmiledText (global::Android.Content.Context p0, string p1, global::Com.Applozic.Mobicommons.Emoticon.IEmojiconHandler p2)
		{
			global::Java.Lang.String jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
			global::Android.Text.ISpannable __result = GetSmiledText (p0, jls_p1, p2);
			var __rsval = __result;
			jls_p1?.Dispose ();
			return __rsval;
		}

	}
}
