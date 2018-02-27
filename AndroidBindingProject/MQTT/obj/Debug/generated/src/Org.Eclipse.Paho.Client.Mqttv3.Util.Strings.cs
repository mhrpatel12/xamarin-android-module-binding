using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/util/Strings", DoNotGenerateAcw=true)]
	public sealed partial class Strings : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/util/Strings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Strings); }
		}

		internal Strings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_containsAny_Ljava_lang_CharSequence_arrayC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='char[]']]"
		[Register ("containsAny", "(Ljava/lang/CharSequence;[C)Z", "")]
		public static unsafe bool ContainsAny (global::Java.Lang.ICharSequence cs, char[] searchChars)
		{
			if (id_containsAny_Ljava_lang_CharSequence_arrayC == IntPtr.Zero)
				id_containsAny_Ljava_lang_CharSequence_arrayC = JNIEnv.GetStaticMethodID (class_ref, "containsAny", "(Ljava/lang/CharSequence;[C)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = JNIEnv.NewArray (searchChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_searchChars);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsAny_Ljava_lang_CharSequence_arrayC, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (searchChars != null) {
					JNIEnv.CopyArray (native_searchChars, searchChars);
					JNIEnv.DeleteLocalRef (native_searchChars);
				}
			}
		}

		public static bool ContainsAny (string cs, char[] searchChars)
		{
			global::Java.Lang.String jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = ContainsAny (jls_cs, searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		static IntPtr id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("containsAny", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool ContainsAny (global::Java.Lang.ICharSequence cs, global::Java.Lang.ICharSequence searchChars)
		{
			if (id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "containsAny", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = CharSequence.ToLocalJniHandle (searchChars);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_searchChars);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsAny_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				JNIEnv.DeleteLocalRef (native_searchChars);
			}
		}

		public static bool ContainsAny (string cs, string searchChars)
		{
			global::Java.Lang.String jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			global::Java.Lang.String jls_searchChars = searchChars == null ? null : new global::Java.Lang.String (searchChars);
			bool __result = ContainsAny (jls_cs, jls_searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			jls_searchChars?.Dispose ();
			return __rsval;
		}

		static IntPtr id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='countMatches' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("countMatches", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int CountMatches (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence sub)
		{
			if (id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "countMatches", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I");
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_sub = CharSequence.ToLocalJniHandle (sub);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_str);
				__args [1] = new JValue (native_sub);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_countMatches_Ljava_lang_CharSequence_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_sub);
			}
		}

		public static int CountMatches (string str, string sub)
		{
			global::Java.Lang.String jls_str = str == null ? null : new global::Java.Lang.String (str);
			global::Java.Lang.String jls_sub = sub == null ? null : new global::Java.Lang.String (sub);
			int __result = CountMatches (jls_str, jls_sub);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_sub?.Dispose ();
			return __rsval;
		}

		static IntPtr id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='equalsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence[]']]"
		[Register ("equalsAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool EqualsAny (global::Java.Lang.ICharSequence cs, global::Java.Lang.ICharSequence[] strs)
		{
			if (id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ == IntPtr.Zero)
				id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "equalsAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_strs = JNIEnv.NewArray (strs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_cs);
				__args [1] = new JValue (native_strs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_equalsAny_Ljava_lang_CharSequence_arrayLjava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (strs != null) {
					JNIEnv.CopyArray (native_strs, strs);
					JNIEnv.DeleteLocalRef (native_strs);
				}
			}
		}

		public static bool EqualsAny (string cs, string[] strs)
		{
			global::Java.Lang.String jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			global::Java.Lang.ICharSequence[] jlca_strs = CharSequence.ArrayFromStringArray(strs);
			bool __result = EqualsAny (jls_cs, jlca_strs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			if (jlca_strs != null) foreach (global::Java.Lang.String s in jlca_strs) s?.Dispose ();
			return __rsval;
		}

		static IntPtr id_isEmpty_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isEmpty", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsEmpty (global::Java.Lang.ICharSequence cs)
		{
			if (id_isEmpty_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/CharSequence;)Z");
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_cs);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_CharSequence_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsEmpty (string cs)
		{
			global::Java.Lang.String jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsEmpty (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

	}
}
