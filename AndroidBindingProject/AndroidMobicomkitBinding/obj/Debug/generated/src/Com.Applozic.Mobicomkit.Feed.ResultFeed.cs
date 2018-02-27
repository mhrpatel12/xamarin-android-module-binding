using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/ResultFeed", DoNotGenerateAcw=true)]
	public partial class ResultFeed : global::Java.Lang.Object, global::Java.IO.ISerializable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/ResultFeed$RestAPICodes", DoNotGenerateAcw=true)]
		public sealed partial class RestAPICodes : global::Java.Lang.Enum {


			static IntPtr ACCOUNT_INACTIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='ACCOUNT_INACTIVE']"
			[Register ("ACCOUNT_INACTIVE")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes AccountInactive {
				get {
					if (ACCOUNT_INACTIVE_jfieldId == IntPtr.Zero)
						ACCOUNT_INACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCOUNT_INACTIVE", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCOUNT_INACTIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUTHENTICATION_REQUIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='AUTHENTICATION_REQUIRED']"
			[Register ("AUTHENTICATION_REQUIRED")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes AuthenticationRequired {
				get {
					if (AUTHENTICATION_REQUIRED_jfieldId == IntPtr.Zero)
						AUTHENTICATION_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHENTICATION_REQUIRED", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHENTICATION_REQUIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BAD_REQUEST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='BAD_REQUEST']"
			[Register ("BAD_REQUEST")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes BadRequest {
				get {
					if (BAD_REQUEST_jfieldId == IntPtr.Zero)
						BAD_REQUEST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BAD_REQUEST", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BAD_REQUEST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DAILY_LIMIT_OVER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='DAILY_LIMIT_OVER']"
			[Register ("DAILY_LIMIT_OVER")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes DailyLimitOver {
				get {
					if (DAILY_LIMIT_OVER_jfieldId == IntPtr.Zero)
						DAILY_LIMIT_OVER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DAILY_LIMIT_OVER", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DAILY_LIMIT_OVER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FIELD_REQUIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='FIELD_REQUIRED']"
			[Register ("FIELD_REQUIRED")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes FieldRequired {
				get {
					if (FIELD_REQUIRED_jfieldId == IntPtr.Zero)
						FIELD_REQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIELD_REQUIRED", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIELD_REQUIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FORBIDDEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='FORBIDDEN']"
			[Register ("FORBIDDEN")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes Forbidden {
				get {
					if (FORBIDDEN_jfieldId == IntPtr.Zero)
						FORBIDDEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORBIDDEN", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORBIDDEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INCOREECT_REQUIRED_FIELD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='INCOREECT_REQUIRED_FIELD']"
			[Register ("INCOREECT_REQUIRED_FIELD")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes IncoreectRequiredField {
				get {
					if (INCOREECT_REQUIRED_FIELD_jfieldId == IntPtr.Zero)
						INCOREECT_REQUIRED_FIELD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCOREECT_REQUIRED_FIELD", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INCOREECT_REQUIRED_FIELD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INTERNAL_SERVER_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='INTERNAL_SERVER_ERROR']"
			[Register ("INTERNAL_SERVER_ERROR")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes InternalServerError {
				get {
					if (INTERNAL_SERVER_ERROR_jfieldId == IntPtr.Zero)
						INTERNAL_SERVER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_SERVER_ERROR", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_SERVER_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NOT_AUTHORIZED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='NOT_AUTHORIZED']"
			[Register ("NOT_AUTHORIZED")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes NotAuthorized {
				get {
					if (NOT_AUTHORIZED_jfieldId == IntPtr.Zero)
						NOT_AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_AUTHORIZED", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_AUTHORIZED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NOT_FOUND_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='NOT_FOUND']"
			[Register ("NOT_FOUND")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes NotFound {
				get {
					if (NOT_FOUND_jfieldId == IntPtr.Zero)
						NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_FOUND", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_FOUND_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUEST_ALREADY_PROCESSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='REQUEST_ALREADY_PROCESSED']"
			[Register ("REQUEST_ALREADY_PROCESSED")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes RequestAlreadyProcessed {
				get {
					if (REQUEST_ALREADY_PROCESSED_jfieldId == IntPtr.Zero)
						REQUEST_ALREADY_PROCESSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_ALREADY_PROCESSED", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_ALREADY_PROCESSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUEST_TIMEOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='REQUEST_TIMEOUT']"
			[Register ("REQUEST_TIMEOUT")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes RequestTimeout {
				get {
					if (REQUEST_TIMEOUT_jfieldId == IntPtr.Zero)
						REQUEST_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUEST_TIMEOUT", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUEST_TIMEOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SERVICE_UNAVAILABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='SERVICE_UNAVAILABLE']"
			[Register ("SERVICE_UNAVAILABLE")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes ServiceUnavailable {
				get {
					if (SERVICE_UNAVAILABLE_jfieldId == IntPtr.Zero)
						SERVICE_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SERVICE_UNAVAILABLE", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SERVICE_UNAVAILABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUCCESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='SUCCESS']"
			[Register ("SUCCESS")]
			public static global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes Success {
				get {
					if (SUCCESS_jfieldId == IntPtr.Zero)
						SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr code_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='code']"
			[Register ("code")]
			public int Code {
				get {
					if (code_jfieldId == IntPtr.Zero)
						code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, code_jfieldId);
				}
				set {
					if (code_jfieldId == IntPtr.Zero)
						code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, code_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr message_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='message']"
			[Register ("message")]
			public string Message {
				get {
					if (message_jfieldId == IntPtr.Zero)
						message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, message_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (message_jfieldId == IntPtr.Zero)
						message_jfieldId = JNIEnv.GetFieldID (class_ref, "message", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, message_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr reason_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/field[@name='reason']"
			[Register ("reason")]
			public string Reason {
				get {
					if (reason_jfieldId == IntPtr.Zero)
						reason_jfieldId = JNIEnv.GetFieldID (class_ref, "reason", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, reason_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (reason_jfieldId == IntPtr.Zero)
						reason_jfieldId = JNIEnv.GetFieldID (class_ref, "reason", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, reason_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/ResultFeed$RestAPICodes", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RestAPICodes); }
			}

			internal RestAPICodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed.RestAPICodes']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;");
				try {
					return (global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/ResultFeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResultFeed); }
		}

		protected ResultFeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/constructor[@name='ResultFeed' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultFeed ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ResultFeed)) {
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

		static IntPtr id_ctor_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/constructor[@name='ResultFeed' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.feed.ResultFeed.RestAPICodes']]"
		[Register (".ctor", "(Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;)V", "")]
		public unsafe ResultFeed (global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ResultFeed)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;)V", __args);
					return;
				}

				if (id_ctor_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_ == IntPtr.Zero)
					id_ctor_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_, __args);
			} finally {
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCode);
			return cb_getCode;
		}

		static int n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code;
		}
#pragma warning restore 0169

		static Delegate cb_setCode_I;
#pragma warning disable 0169
		static Delegate GetSetCode_IHandler ()
		{
			if (cb_setCode_I == null)
				cb_setCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCode_I);
			return cb_setCode_I;
		}

		static void n_SetCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_I;
		public virtual unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCode", "(I)V", "GetSetCode_IHandler")]
			set {
				if (id_setCode_I == IntPtr.Zero)
					id_setCode_I = JNIEnv.GetMethodID (class_ref, "setCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDetail;
#pragma warning disable 0169
		static Delegate GetGetDetailHandler ()
		{
			if (cb_getDetail == null)
				cb_getDetail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDetail);
			return cb_getDetail;
		}

		static IntPtr n_GetDetail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Detail);
		}
#pragma warning restore 0169

		static Delegate cb_setDetail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDetail_Ljava_lang_String_Handler ()
		{
			if (cb_setDetail_Ljava_lang_String_ == null)
				cb_setDetail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDetail_Ljava_lang_String_);
			return cb_setDetail_Ljava_lang_String_;
		}

		static void n_SetDetail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Detail = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDetail;
		static IntPtr id_setDetail_Ljava_lang_String_;
		public virtual unsafe string Detail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/method[@name='getDetail' and count(parameter)=0]"
			[Register ("getDetail", "()Ljava/lang/String;", "GetGetDetailHandler")]
			get {
				if (id_getDetail == IntPtr.Zero)
					id_getDetail = JNIEnv.GetMethodID (class_ref, "getDetail", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDetail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDetail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/method[@name='setDetail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDetail", "(Ljava/lang/String;)V", "GetSetDetail_Ljava_lang_String_Handler")]
			set {
				if (id_setDetail_Ljava_lang_String_ == IntPtr.Zero)
					id_setDetail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDetail", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDetail_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDetail", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Ljava_lang_String_;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReason;
#pragma warning disable 0169
		static Delegate GetGetReasonHandler ()
		{
			if (cb_getReason == null)
				cb_getReason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReason);
			return cb_getReason;
		}

		static IntPtr n_GetReason (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Reason);
		}
#pragma warning restore 0169

		static Delegate cb_setReason_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReason_Ljava_lang_String_Handler ()
		{
			if (cb_setReason_Ljava_lang_String_ == null)
				cb_setReason_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReason_Ljava_lang_String_);
			return cb_setReason_Ljava_lang_String_;
		}

		static void n_SetReason_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Reason = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReason;
		static IntPtr id_setReason_Ljava_lang_String_;
		public virtual unsafe string Reason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/method[@name='getReason' and count(parameter)=0]"
			[Register ("getReason", "()Ljava/lang/String;", "GetGetReasonHandler")]
			get {
				if (id_getReason == IntPtr.Zero)
					id_getReason = JNIEnv.GetMethodID (class_ref, "getReason", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReason), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReason", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/method[@name='setReason' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReason", "(Ljava/lang/String;)V", "GetSetReason_Ljava_lang_String_Handler")]
			set {
				if (id_setReason_Ljava_lang_String_ == IntPtr.Zero)
					id_setReason_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReason", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReason_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReason", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_;
#pragma warning disable 0169
		static Delegate GetSetRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_Handler ()
		{
			if (cb_setRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_ == null)
				cb_setRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_);
			return cb_setRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_;
		}

		static void n_SetRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRestAPICode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ResultFeed']/method[@name='setRestAPICode' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.feed.ResultFeed.RestAPICodes']]"
		[Register ("setRestAPICode", "(Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;)V", "GetSetRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_Handler")]
		public virtual unsafe void SetRestAPICode (global::Com.Applozic.Mobicomkit.Feed.ResultFeed.RestAPICodes p0)
		{
			if (id_setRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_ == IntPtr.Zero)
				id_setRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_ = JNIEnv.GetMethodID (class_ref, "setRestAPICode", "(Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRestAPICode_Lcom_applozic_mobicomkit_feed_ResultFeed_RestAPICodes_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRestAPICode", "(Lcom/applozic/mobicomkit/feed/ResultFeed$RestAPICodes;)V"), __args);
			} finally {
			}
		}

	}
}
