using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DBUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/core/utils/DBUtils", DoNotGenerateAcw=true)]
	public partial class DBUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/core/utils/DBUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DBUtils); }
		}

		protected DBUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DBUtils']/constructor[@name='DBUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DBUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DBUtils)) {
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

		static IntPtr id_existsColumnInTable_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DBUtils']/method[@name='existsColumnInTable' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("existsColumnInTable", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool ExistsColumnInTable (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1, string p2)
		{
			if (id_existsColumnInTable_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_existsColumnInTable_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "existsColumnInTable", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_existsColumnInTable_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_isTableEmpty_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DBUtils']/method[@name='isTableEmpty' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String']]"
		[Register ("isTableEmpty", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsTableEmpty (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1)
		{
			if (id_isTableEmpty_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ == IntPtr.Zero)
				id_isTableEmpty_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isTableEmpty", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isTableEmpty_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isTableExists_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DBUtils']/method[@name='isTableExists' and count(parameter)=2 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='java.lang.String']]"
		[Register ("isTableExists", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsTableExists (global::Android.Database.Sqlite.SQLiteDatabase p0, string p1)
		{
			if (id_isTableExists_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ == IntPtr.Zero)
				id_isTableExists_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isTableExists", "(Landroid/database/sqlite/SQLiteDatabase;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isTableExists_Landroid_database_sqlite_SQLiteDatabase_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
