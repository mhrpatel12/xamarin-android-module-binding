using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Account.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/ApplozicUser", DoNotGenerateAcw=true)]
	public partial class ApplozicUser : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.AuthenticationType']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/ApplozicUser$AuthenticationType", DoNotGenerateAcw=true)]
		public sealed partial class AuthenticationType : global::Java.Lang.Enum {


			static IntPtr APPLOZIC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.AuthenticationType']/field[@name='APPLOZIC']"
			[Register ("APPLOZIC")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType Applozic {
				get {
					if (APPLOZIC_jfieldId == IntPtr.Zero)
						APPLOZIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLOZIC", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$AuthenticationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLOZIC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CLIENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.AuthenticationType']/field[@name='CLIENT']"
			[Register ("CLIENT")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType Client {
				get {
					if (CLIENT_jfieldId == IntPtr.Zero)
						CLIENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLIENT", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$AuthenticationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLIENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FACEBOOK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.AuthenticationType']/field[@name='FACEBOOK']"
			[Register ("FACEBOOK")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType Facebook {
				get {
					if (FACEBOOK_jfieldId == IntPtr.Zero)
						FACEBOOK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$AuthenticationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FACEBOOK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/ApplozicUser$AuthenticationType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AuthenticationType); }
			}

			internal AuthenticationType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Short Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.AuthenticationType']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Short;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Short;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.AuthenticationType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$AuthenticationType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$AuthenticationType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.AuthenticationType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$AuthenticationType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$AuthenticationType;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.AuthenticationType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.Features']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/ApplozicUser$Features", DoNotGenerateAcw=true)]
		public sealed partial class Features : global::Java.Lang.Enum {


			static IntPtr IP_AUDIO_CALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.Features']/field[@name='IP_AUDIO_CALL']"
			[Register ("IP_AUDIO_CALL")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features IpAudioCall {
				get {
					if (IP_AUDIO_CALL_jfieldId == IntPtr.Zero)
						IP_AUDIO_CALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IP_AUDIO_CALL", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$Features;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IP_AUDIO_CALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IP_VIDEO_CALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.Features']/field[@name='IP_VIDEO_CALL']"
			[Register ("IP_VIDEO_CALL")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features IpVideoCall {
				get {
					if (IP_VIDEO_CALL_jfieldId == IntPtr.Zero)
						IP_VIDEO_CALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IP_VIDEO_CALL", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$Features;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IP_VIDEO_CALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/ApplozicUser$Features", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Features); }
			}

			internal Features (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.Features']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.Features']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$Features;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$Features;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.Features']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$Features;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$Features;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.Features));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName", DoNotGenerateAcw=true)]
		public sealed partial class RoleName : global::Java.Lang.Enum {


			static IntPtr ADMIN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/field[@name='ADMIN']"
			[Register ("ADMIN")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName Admin {
				get {
					if (ADMIN_jfieldId == IntPtr.Zero)
						ADMIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADMIN", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADMIN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APPLICATION_ADMIN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/field[@name='APPLICATION_ADMIN']"
			[Register ("APPLICATION_ADMIN")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName ApplicationAdmin {
				get {
					if (APPLICATION_ADMIN_jfieldId == IntPtr.Zero)
						APPLICATION_ADMIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_ADMIN", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_ADMIN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APPLICATION_BROADCASTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/field[@name='APPLICATION_BROADCASTER']"
			[Register ("APPLICATION_BROADCASTER")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName ApplicationBroadcaster {
				get {
					if (APPLICATION_BROADCASTER_jfieldId == IntPtr.Zero)
						APPLICATION_BROADCASTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_BROADCASTER", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_BROADCASTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APPLICATION_WEB_ADMIN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/field[@name='APPLICATION_WEB_ADMIN']"
			[Register ("APPLICATION_WEB_ADMIN")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName ApplicationWebAdmin {
				get {
					if (APPLICATION_WEB_ADMIN_jfieldId == IntPtr.Zero)
						APPLICATION_WEB_ADMIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_WEB_ADMIN", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_WEB_ADMIN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BOT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/field[@name='BOT']"
			[Register ("BOT")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName Bot {
				get {
					if (BOT_jfieldId == IntPtr.Zero)
						BOT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOT", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BUSINESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/field[@name='BUSINESS']"
			[Register ("BUSINESS")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName Business {
				get {
					if (BUSINESS_jfieldId == IntPtr.Zero)
						BUSINESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUSINESS", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUSINESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUPPORT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/field[@name='SUPPORT']"
			[Register ("SUPPORT")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName Support {
				get {
					if (SUPPORT_jfieldId == IntPtr.Zero)
						SUPPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPORT", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUPPORT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/field[@name='USER']"
			[Register ("USER")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName User {
				get {
					if (USER_jfieldId == IntPtr.Zero)
						USER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RoleName); }
			}

			internal RoleName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleName']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleName;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleName));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType", DoNotGenerateAcw=true)]
		public sealed partial class RoleType : global::Java.Lang.Enum {


			static IntPtr ADMIN_ROLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/field[@name='ADMIN_ROLE']"
			[Register ("ADMIN_ROLE")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType AdminRole {
				get {
					if (ADMIN_ROLE_jfieldId == IntPtr.Zero)
						ADMIN_ROLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADMIN_ROLE", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADMIN_ROLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AGENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/field[@name='AGENT']"
			[Register ("AGENT")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType Agent {
				get {
					if (AGENT_jfieldId == IntPtr.Zero)
						AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AGENT", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AGENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APPLICATION_ADMIN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/field[@name='APPLICATION_ADMIN']"
			[Register ("APPLICATION_ADMIN")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType ApplicationAdmin {
				get {
					if (APPLICATION_ADMIN_jfieldId == IntPtr.Zero)
						APPLICATION_ADMIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_ADMIN", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_ADMIN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr APPLICATION_BROADCASTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/field[@name='APPLICATION_BROADCASTER']"
			[Register ("APPLICATION_BROADCASTER")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType ApplicationBroadcaster {
				get {
					if (APPLICATION_BROADCASTER_jfieldId == IntPtr.Zero)
						APPLICATION_BROADCASTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_BROADCASTER", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_BROADCASTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BOT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/field[@name='BOT']"
			[Register ("BOT")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType Bot {
				get {
					if (BOT_jfieldId == IntPtr.Zero)
						BOT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOT", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BUSINESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/field[@name='BUSINESS']"
			[Register ("BUSINESS")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType Business {
				get {
					if (BUSINESS_jfieldId == IntPtr.Zero)
						BUSINESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUSINESS", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUSINESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUPPORT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/field[@name='SUPPORT']"
			[Register ("SUPPORT")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType Support {
				get {
					if (SUPPORT_jfieldId == IntPtr.Zero)
						SUPPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPORT", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUPPORT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr USER_ROLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/field[@name='USER_ROLE']"
			[Register ("USER_ROLE")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType UserRole {
				get {
					if (USER_ROLE_jfieldId == IntPtr.Zero)
						USER_ROLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USER_ROLE", "Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USER_ROLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RoleType); }
			}

			internal RoleType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Short Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Short;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Short;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser.RoleType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/account/user/ApplozicUser$RoleType;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser.RoleType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/ApplozicUser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicUser); }
		}

		protected ApplozicUser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/constructor[@name='ApplozicUser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApplozicUser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ApplozicUser)) {
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

		static Delegate cb_getAppModuleName;
#pragma warning disable 0169
		static Delegate GetGetAppModuleNameHandler ()
		{
			if (cb_getAppModuleName == null)
				cb_getAppModuleName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppModuleName);
			return cb_getAppModuleName;
		}

		static IntPtr n_GetAppModuleName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppModuleName);
		}
#pragma warning restore 0169

		static Delegate cb_setAppModuleName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppModuleName_Ljava_lang_String_Handler ()
		{
			if (cb_setAppModuleName_Ljava_lang_String_ == null)
				cb_setAppModuleName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppModuleName_Ljava_lang_String_);
			return cb_setAppModuleName_Ljava_lang_String_;
		}

		static void n_SetAppModuleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppModuleName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppModuleName;
		static IntPtr id_setAppModuleName_Ljava_lang_String_;
		public virtual unsafe string AppModuleName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getAppModuleName' and count(parameter)=0]"
			[Register ("getAppModuleName", "()Ljava/lang/String;", "GetGetAppModuleNameHandler")]
			get {
				if (id_getAppModuleName == IntPtr.Zero)
					id_getAppModuleName = JNIEnv.GetMethodID (class_ref, "getAppModuleName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppModuleName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppModuleName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setAppModuleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppModuleName", "(Ljava/lang/String;)V", "GetSetAppModuleName_Ljava_lang_String_Handler")]
			set {
				if (id_setAppModuleName_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppModuleName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppModuleName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppModuleName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppModuleName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAppVersionCode;
#pragma warning disable 0169
		static Delegate GetGetAppVersionCodeHandler ()
		{
			if (cb_getAppVersionCode == null)
				cb_getAppVersionCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppVersionCode);
			return cb_getAppVersionCode;
		}

		static IntPtr n_GetAppVersionCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppVersionCode);
		}
#pragma warning restore 0169

		static Delegate cb_setAppVersionCode_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetAppVersionCode_Ljava_lang_Short_Handler ()
		{
			if (cb_setAppVersionCode_Ljava_lang_Short_ == null)
				cb_setAppVersionCode_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppVersionCode_Ljava_lang_Short_);
			return cb_setAppVersionCode_Ljava_lang_Short_;
		}

		static void n_SetAppVersionCode_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppVersionCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppVersionCode;
		static IntPtr id_setAppVersionCode_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short AppVersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getAppVersionCode' and count(parameter)=0]"
			[Register ("getAppVersionCode", "()Ljava/lang/Short;", "GetGetAppVersionCodeHandler")]
			get {
				if (id_getAppVersionCode == IntPtr.Zero)
					id_getAppVersionCode = JNIEnv.GetMethodID (class_ref, "getAppVersionCode", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppVersionCode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppVersionCode", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setAppVersionCode' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setAppVersionCode", "(Ljava/lang/Short;)V", "GetSetAppVersionCode_Ljava_lang_Short_Handler")]
			set {
				if (id_setAppVersionCode_Ljava_lang_Short_ == IntPtr.Zero)
					id_setAppVersionCode_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setAppVersionCode", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppVersionCode_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppVersionCode", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationId;
#pragma warning disable 0169
		static Delegate GetGetApplicationIdHandler ()
		{
			if (cb_getApplicationId == null)
				cb_getApplicationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationId);
			return cb_getApplicationId;
		}

		static IntPtr n_GetApplicationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationId);
		}
#pragma warning restore 0169

		static Delegate cb_setApplicationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationId_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationId_Ljava_lang_String_ == null)
				cb_setApplicationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationId_Ljava_lang_String_);
			return cb_setApplicationId_Ljava_lang_String_;
		}

		static void n_SetApplicationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplicationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationId;
		static IntPtr id_setApplicationId_Ljava_lang_String_;
		public virtual unsafe string ApplicationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getApplicationId' and count(parameter)=0]"
			[Register ("getApplicationId", "()Ljava/lang/String;", "GetGetApplicationIdHandler")]
			get {
				if (id_getApplicationId == IntPtr.Zero)
					id_getApplicationId = JNIEnv.GetMethodID (class_ref, "getApplicationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setApplicationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationId", "(Ljava/lang/String;)V", "GetSetApplicationId_Ljava_lang_String_Handler")]
			set {
				if (id_setApplicationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAuthenticationTypeId;
#pragma warning disable 0169
		static Delegate GetGetAuthenticationTypeIdHandler ()
		{
			if (cb_getAuthenticationTypeId == null)
				cb_getAuthenticationTypeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthenticationTypeId);
			return cb_getAuthenticationTypeId;
		}

		static IntPtr n_GetAuthenticationTypeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthenticationTypeId);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthenticationTypeId_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetAuthenticationTypeId_Ljava_lang_Short_Handler ()
		{
			if (cb_setAuthenticationTypeId_Ljava_lang_Short_ == null)
				cb_setAuthenticationTypeId_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthenticationTypeId_Ljava_lang_Short_);
			return cb_setAuthenticationTypeId_Ljava_lang_Short_;
		}

		static void n_SetAuthenticationTypeId_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthenticationTypeId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthenticationTypeId;
		static IntPtr id_setAuthenticationTypeId_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short AuthenticationTypeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getAuthenticationTypeId' and count(parameter)=0]"
			[Register ("getAuthenticationTypeId", "()Ljava/lang/Short;", "GetGetAuthenticationTypeIdHandler")]
			get {
				if (id_getAuthenticationTypeId == IntPtr.Zero)
					id_getAuthenticationTypeId = JNIEnv.GetMethodID (class_ref, "getAuthenticationTypeId", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthenticationTypeId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthenticationTypeId", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setAuthenticationTypeId' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setAuthenticationTypeId", "(Ljava/lang/Short;)V", "GetSetAuthenticationTypeId_Ljava_lang_Short_Handler")]
			set {
				if (id_setAuthenticationTypeId_Ljava_lang_Short_ == IntPtr.Zero)
					id_setAuthenticationTypeId_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setAuthenticationTypeId", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuthenticationTypeId_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthenticationTypeId", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContactNumber;
#pragma warning disable 0169
		static Delegate GetGetContactNumberHandler ()
		{
			if (cb_getContactNumber == null)
				cb_getContactNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactNumber);
			return cb_getContactNumber;
		}

		static IntPtr n_GetContactNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContactNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setContactNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContactNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setContactNumber_Ljava_lang_String_ == null)
				cb_setContactNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContactNumber_Ljava_lang_String_);
			return cb_setContactNumber_Ljava_lang_String_;
		}

		static void n_SetContactNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactNumber;
		static IntPtr id_setContactNumber_Ljava_lang_String_;
		public virtual unsafe string ContactNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getContactNumber' and count(parameter)=0]"
			[Register ("getContactNumber", "()Ljava/lang/String;", "GetGetContactNumberHandler")]
			get {
				if (id_getContactNumber == IntPtr.Zero)
					id_getContactNumber = JNIEnv.GetMethodID (class_ref, "getContactNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setContactNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContactNumber", "(Ljava/lang/String;)V", "GetSetContactNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setContactNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setContactNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContactNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCountryCode;
#pragma warning disable 0169
		static Delegate GetGetCountryCodeHandler ()
		{
			if (cb_getCountryCode == null)
				cb_getCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountryCode);
			return cb_getCountryCode;
		}

		static IntPtr n_GetCountryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CountryCode);
		}
#pragma warning restore 0169

		static Delegate cb_setCountryCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountryCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCountryCode_Ljava_lang_String_ == null)
				cb_setCountryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountryCode_Ljava_lang_String_);
			return cb_setCountryCode_Ljava_lang_String_;
		}

		static void n_SetCountryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CountryCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCountryCode;
		static IntPtr id_setCountryCode_Ljava_lang_String_;
		public virtual unsafe string CountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getCountryCode' and count(parameter)=0]"
			[Register ("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler")]
			get {
				if (id_getCountryCode == IntPtr.Zero)
					id_getCountryCode = JNIEnv.GetMethodID (class_ref, "getCountryCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCountryCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCountryCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountryCode", "(Ljava/lang/String;)V", "GetSetCountryCode_Ljava_lang_String_Handler")]
			set {
				if (id_setCountryCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setCountryCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCountryCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCountryCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCountryCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static IntPtr n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceType);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceType_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetDeviceType_Ljava_lang_Short_Handler ()
		{
			if (cb_setDeviceType_Ljava_lang_Short_ == null)
				cb_setDeviceType_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceType_Ljava_lang_Short_);
			return cb_setDeviceType_Ljava_lang_Short_;
		}

		static void n_SetDeviceType_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceType;
		static IntPtr id_setDeviceType_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Ljava/lang/Short;", "GetGetDeviceTypeHandler")]
			get {
				if (id_getDeviceType == IntPtr.Zero)
					id_getDeviceType = JNIEnv.GetMethodID (class_ref, "getDeviceType", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceType", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setDeviceType' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setDeviceType", "(Ljava/lang/Short;)V", "GetSetDeviceType_Ljava_lang_Short_Handler")]
			set {
				if (id_setDeviceType_Ljava_lang_Short_ == IntPtr.Zero)
					id_setDeviceType_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setDeviceType", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceType_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceType", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDisplayName_Ljava_lang_String_Handler ()
		{
			if (cb_setDisplayName_Ljava_lang_String_ == null)
				cb_setDisplayName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplayName_Ljava_lang_String_);
			return cb_setDisplayName_Ljava_lang_String_;
		}

		static void n_SetDisplayName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DisplayName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayName;
		static IntPtr id_setDisplayName_Ljava_lang_String_;
		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDisplayName", "(Ljava/lang/String;)V", "GetSetDisplayName_Ljava_lang_String_Handler")]
			set {
				if (id_setDisplayName_Ljava_lang_String_ == IntPtr.Zero)
					id_setDisplayName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDisplayName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static Delegate cb_setEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmail_Ljava_lang_String_Handler ()
		{
			if (cb_setEmail_Ljava_lang_String_ == null)
				cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmail_Ljava_lang_String_);
			return cb_setEmail_Ljava_lang_String_;
		}

		static void n_SetEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Email = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		static IntPtr id_setEmail_Ljava_lang_String_;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmail", "(Ljava/lang/String;)V", "GetSetEmail_Ljava_lang_String_Handler")]
			set {
				if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmail_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmail", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isEmailVerified;
#pragma warning disable 0169
		static Delegate GetIsEmailVerifiedHandler ()
		{
			if (cb_isEmailVerified == null)
				cb_isEmailVerified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmailVerified);
			return cb_isEmailVerified;
		}

		static bool n_IsEmailVerified (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EmailVerified;
		}
#pragma warning restore 0169

		static Delegate cb_setEmailVerified_Z;
#pragma warning disable 0169
		static Delegate GetSetEmailVerified_ZHandler ()
		{
			if (cb_setEmailVerified_Z == null)
				cb_setEmailVerified_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEmailVerified_Z);
			return cb_setEmailVerified_Z;
		}

		static void n_SetEmailVerified_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EmailVerified = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isEmailVerified;
		static IntPtr id_setEmailVerified_Z;
		public virtual unsafe bool EmailVerified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='isEmailVerified' and count(parameter)=0]"
			[Register ("isEmailVerified", "()Z", "GetIsEmailVerifiedHandler")]
			get {
				if (id_isEmailVerified == IntPtr.Zero)
					id_isEmailVerified = JNIEnv.GetMethodID (class_ref, "isEmailVerified", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmailVerified);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmailVerified", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setEmailVerified' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEmailVerified", "(Z)V", "GetSetEmailVerified_ZHandler")]
			set {
				if (id_setEmailVerified_Z == IntPtr.Zero)
					id_setEmailVerified_Z = JNIEnv.GetMethodID (class_ref, "setEmailVerified", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmailVerified_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailVerified", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isEnableEncryption;
#pragma warning disable 0169
		static Delegate GetIsEnableEncryptionHandler ()
		{
			if (cb_isEnableEncryption == null)
				cb_isEnableEncryption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableEncryption);
			return cb_isEnableEncryption;
		}

		static bool n_IsEnableEncryption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableEncryption;
		}
#pragma warning restore 0169

		static Delegate cb_setEnableEncryption_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableEncryption_ZHandler ()
		{
			if (cb_setEnableEncryption_Z == null)
				cb_setEnableEncryption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnableEncryption_Z);
			return cb_setEnableEncryption_Z;
		}

		static void n_SetEnableEncryption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableEncryption = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isEnableEncryption;
		static IntPtr id_setEnableEncryption_Z;
		public virtual unsafe bool EnableEncryption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='isEnableEncryption' and count(parameter)=0]"
			[Register ("isEnableEncryption", "()Z", "GetIsEnableEncryptionHandler")]
			get {
				if (id_isEnableEncryption == IntPtr.Zero)
					id_isEnableEncryption = JNIEnv.GetMethodID (class_ref, "isEnableEncryption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableEncryption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnableEncryption", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setEnableEncryption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableEncryption", "(Z)V", "GetSetEnableEncryption_ZHandler")]
			set {
				if (id_setEnableEncryption_Z == IntPtr.Zero)
					id_setEnableEncryption_Z = JNIEnv.GetMethodID (class_ref, "setEnableEncryption", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnableEncryption_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnableEncryption", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageLink;
#pragma warning disable 0169
		static Delegate GetGetImageLinkHandler ()
		{
			if (cb_getImageLink == null)
				cb_getImageLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageLink);
			return cb_getImageLink;
		}

		static IntPtr n_GetImageLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageLink);
		}
#pragma warning restore 0169

		static Delegate cb_setImageLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageLink_Ljava_lang_String_Handler ()
		{
			if (cb_setImageLink_Ljava_lang_String_ == null)
				cb_setImageLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageLink_Ljava_lang_String_);
			return cb_setImageLink_Ljava_lang_String_;
		}

		static void n_SetImageLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageLink = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageLink;
		static IntPtr id_setImageLink_Ljava_lang_String_;
		public virtual unsafe string ImageLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getImageLink' and count(parameter)=0]"
			[Register ("getImageLink", "()Ljava/lang/String;", "GetGetImageLinkHandler")]
			get {
				if (id_getImageLink == IntPtr.Zero)
					id_getImageLink = JNIEnv.GetMethodID (class_ref, "getImageLink", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageLink), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageLink", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setImageLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImageLink", "(Ljava/lang/String;)V", "GetSetImageLink_Ljava_lang_String_Handler")]
			set {
				if (id_setImageLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setImageLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImageLink", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageLink_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageLink", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLastMessageAtTime;
#pragma warning disable 0169
		static Delegate GetGetLastMessageAtTimeHandler ()
		{
			if (cb_getLastMessageAtTime == null)
				cb_getLastMessageAtTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastMessageAtTime);
			return cb_getLastMessageAtTime;
		}

		static IntPtr n_GetLastMessageAtTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastMessageAtTime);
		}
#pragma warning restore 0169

		static Delegate cb_setLastMessageAtTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetLastMessageAtTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setLastMessageAtTime_Ljava_lang_Long_ == null)
				cb_setLastMessageAtTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastMessageAtTime_Ljava_lang_Long_);
			return cb_setLastMessageAtTime_Ljava_lang_Long_;
		}

		static void n_SetLastMessageAtTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastMessageAtTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastMessageAtTime;
		static IntPtr id_setLastMessageAtTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long LastMessageAtTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getLastMessageAtTime' and count(parameter)=0]"
			[Register ("getLastMessageAtTime", "()Ljava/lang/Long;", "GetGetLastMessageAtTimeHandler")]
			get {
				if (id_getLastMessageAtTime == IntPtr.Zero)
					id_getLastMessageAtTime = JNIEnv.GetMethodID (class_ref, "getLastMessageAtTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastMessageAtTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastMessageAtTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setLastMessageAtTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setLastMessageAtTime", "(Ljava/lang/Long;)V", "GetSetLastMessageAtTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setLastMessageAtTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setLastMessageAtTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setLastMessageAtTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastMessageAtTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastMessageAtTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static Delegate cb_setMetadata_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetMetadata_Ljava_util_Map_Handler ()
		{
			if (cb_setMetadata_Ljava_util_Map_ == null)
				cb_setMetadata_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetadata_Ljava_util_Map_);
			return cb_setMetadata_Ljava_util_Map_;
		}

		static void n_SetMetadata_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		static IntPtr id_setMetadata_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/util/Map;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetadata", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setMetadata", "(Ljava/util/Map;)V", "GetSetMetadata_Ljava_util_Map_Handler")]
			set {
				if (id_setMetadata_Ljava_util_Map_ == IntPtr.Zero)
					id_setMetadata_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMetadata", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMetadata_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetadata", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNotificationSoundFilePath;
#pragma warning disable 0169
		static Delegate GetGetNotificationSoundFilePathHandler ()
		{
			if (cb_getNotificationSoundFilePath == null)
				cb_getNotificationSoundFilePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationSoundFilePath);
			return cb_getNotificationSoundFilePath;
		}

		static IntPtr n_GetNotificationSoundFilePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NotificationSoundFilePath);
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationSoundFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotificationSoundFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setNotificationSoundFilePath_Ljava_lang_String_ == null)
				cb_setNotificationSoundFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationSoundFilePath_Ljava_lang_String_);
			return cb_setNotificationSoundFilePath_Ljava_lang_String_;
		}

		static void n_SetNotificationSoundFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotificationSoundFilePath = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationSoundFilePath;
		static IntPtr id_setNotificationSoundFilePath_Ljava_lang_String_;
		public virtual unsafe string NotificationSoundFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getNotificationSoundFilePath' and count(parameter)=0]"
			[Register ("getNotificationSoundFilePath", "()Ljava/lang/String;", "GetGetNotificationSoundFilePathHandler")]
			get {
				if (id_getNotificationSoundFilePath == IntPtr.Zero)
					id_getNotificationSoundFilePath = JNIEnv.GetMethodID (class_ref, "getNotificationSoundFilePath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationSoundFilePath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationSoundFilePath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setNotificationSoundFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotificationSoundFilePath", "(Ljava/lang/String;)V", "GetSetNotificationSoundFilePath_Ljava_lang_String_Handler")]
			set {
				if (id_setNotificationSoundFilePath_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotificationSoundFilePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotificationSoundFilePath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationSoundFilePath_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationSoundFilePath", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setPassword_Ljava_lang_String_ == null)
				cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
			return cb_setPassword_Ljava_lang_String_;
		}

		static void n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Password = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		static IntPtr id_setPassword_Ljava_lang_String_;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")]
			set {
				if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_setPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPassword_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPrefContactAPI;
#pragma warning disable 0169
		static Delegate GetGetPrefContactAPIHandler ()
		{
			if (cb_getPrefContactAPI == null)
				cb_getPrefContactAPI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrefContactAPI);
			return cb_getPrefContactAPI;
		}

		static IntPtr n_GetPrefContactAPI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrefContactAPI);
		}
#pragma warning restore 0169

		static Delegate cb_setPrefContactAPI_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetPrefContactAPI_Ljava_lang_Short_Handler ()
		{
			if (cb_setPrefContactAPI_Ljava_lang_Short_ == null)
				cb_setPrefContactAPI_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrefContactAPI_Ljava_lang_Short_);
			return cb_setPrefContactAPI_Ljava_lang_Short_;
		}

		static void n_SetPrefContactAPI_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrefContactAPI = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPrefContactAPI;
		static IntPtr id_setPrefContactAPI_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short PrefContactAPI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getPrefContactAPI' and count(parameter)=0]"
			[Register ("getPrefContactAPI", "()Ljava/lang/Short;", "GetGetPrefContactAPIHandler")]
			get {
				if (id_getPrefContactAPI == IntPtr.Zero)
					id_getPrefContactAPI = JNIEnv.GetMethodID (class_ref, "getPrefContactAPI", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrefContactAPI), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrefContactAPI", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setPrefContactAPI' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setPrefContactAPI", "(Ljava/lang/Short;)V", "GetSetPrefContactAPI_Ljava_lang_Short_Handler")]
			set {
				if (id_setPrefContactAPI_Ljava_lang_Short_ == IntPtr.Zero)
					id_setPrefContactAPI_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setPrefContactAPI", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrefContactAPI_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrefContactAPI", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPushNotificationFormat;
#pragma warning disable 0169
		static Delegate GetGetPushNotificationFormatHandler ()
		{
			if (cb_getPushNotificationFormat == null)
				cb_getPushNotificationFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPushNotificationFormat);
			return cb_getPushNotificationFormat;
		}

		static IntPtr n_GetPushNotificationFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PushNotificationFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setPushNotificationFormat_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetPushNotificationFormat_Ljava_lang_Short_Handler ()
		{
			if (cb_setPushNotificationFormat_Ljava_lang_Short_ == null)
				cb_setPushNotificationFormat_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPushNotificationFormat_Ljava_lang_Short_);
			return cb_setPushNotificationFormat_Ljava_lang_Short_;
		}

		static void n_SetPushNotificationFormat_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PushNotificationFormat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPushNotificationFormat;
		static IntPtr id_setPushNotificationFormat_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short PushNotificationFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getPushNotificationFormat' and count(parameter)=0]"
			[Register ("getPushNotificationFormat", "()Ljava/lang/Short;", "GetGetPushNotificationFormatHandler")]
			get {
				if (id_getPushNotificationFormat == IntPtr.Zero)
					id_getPushNotificationFormat = JNIEnv.GetMethodID (class_ref, "getPushNotificationFormat", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPushNotificationFormat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPushNotificationFormat", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setPushNotificationFormat' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setPushNotificationFormat", "(Ljava/lang/Short;)V", "GetSetPushNotificationFormat_Ljava_lang_Short_Handler")]
			set {
				if (id_setPushNotificationFormat_Ljava_lang_Short_ == IntPtr.Zero)
					id_setPushNotificationFormat_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setPushNotificationFormat", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPushNotificationFormat_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPushNotificationFormat", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRegistrationId;
#pragma warning disable 0169
		static Delegate GetGetRegistrationIdHandler ()
		{
			if (cb_getRegistrationId == null)
				cb_getRegistrationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegistrationId);
			return cb_getRegistrationId;
		}

		static IntPtr n_GetRegistrationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegistrationId);
		}
#pragma warning restore 0169

		static Delegate cb_setRegistrationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRegistrationId_Ljava_lang_String_Handler ()
		{
			if (cb_setRegistrationId_Ljava_lang_String_ == null)
				cb_setRegistrationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRegistrationId_Ljava_lang_String_);
			return cb_setRegistrationId_Ljava_lang_String_;
		}

		static void n_SetRegistrationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegistrationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegistrationId;
		static IntPtr id_setRegistrationId_Ljava_lang_String_;
		public virtual unsafe string RegistrationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getRegistrationId' and count(parameter)=0]"
			[Register ("getRegistrationId", "()Ljava/lang/String;", "GetGetRegistrationIdHandler")]
			get {
				if (id_getRegistrationId == IntPtr.Zero)
					id_getRegistrationId = JNIEnv.GetMethodID (class_ref, "getRegistrationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegistrationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegistrationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setRegistrationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRegistrationId", "(Ljava/lang/String;)V", "GetSetRegistrationId_Ljava_lang_String_Handler")]
			set {
				if (id_setRegistrationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setRegistrationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRegistrationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRegistrationId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegistrationId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTimezone;
#pragma warning disable 0169
		static Delegate GetGetTimezoneHandler ()
		{
			if (cb_getTimezone == null)
				cb_getTimezone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimezone);
			return cb_getTimezone;
		}

		static IntPtr n_GetTimezone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Timezone);
		}
#pragma warning restore 0169

		static Delegate cb_setTimezone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTimezone_Ljava_lang_String_Handler ()
		{
			if (cb_setTimezone_Ljava_lang_String_ == null)
				cb_setTimezone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimezone_Ljava_lang_String_);
			return cb_setTimezone_Ljava_lang_String_;
		}

		static void n_SetTimezone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Timezone = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimezone;
		static IntPtr id_setTimezone_Ljava_lang_String_;
		public virtual unsafe string Timezone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getTimezone' and count(parameter)=0]"
			[Register ("getTimezone", "()Ljava/lang/String;", "GetGetTimezoneHandler")]
			get {
				if (id_getTimezone == IntPtr.Zero)
					id_getTimezone = JNIEnv.GetMethodID (class_ref, "getTimezone", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimezone), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimezone", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setTimezone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTimezone", "(Ljava/lang/String;)V", "GetSetTimezone_Ljava_lang_String_Handler")]
			set {
				if (id_setTimezone_Ljava_lang_String_ == IntPtr.Zero)
					id_setTimezone_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTimezone", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimezone_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimezone", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static void n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserId", "(Ljava/lang/String;)V", "GetSetUserId_Ljava_lang_String_Handler")]
			set {
				if (id_setUserId_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserTypeId;
#pragma warning disable 0169
		static Delegate GetGetUserTypeIdHandler ()
		{
			if (cb_getUserTypeId == null)
				cb_getUserTypeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserTypeId);
			return cb_getUserTypeId;
		}

		static IntPtr n_GetUserTypeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserTypeId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserTypeId_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetUserTypeId_Ljava_lang_Short_Handler ()
		{
			if (cb_setUserTypeId_Ljava_lang_Short_ == null)
				cb_setUserTypeId_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserTypeId_Ljava_lang_Short_);
			return cb_setUserTypeId_Ljava_lang_Short_;
		}

		static void n_SetUserTypeId_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserTypeId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserTypeId;
		static IntPtr id_setUserTypeId_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short UserTypeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getUserTypeId' and count(parameter)=0]"
			[Register ("getUserTypeId", "()Ljava/lang/Short;", "GetGetUserTypeIdHandler")]
			get {
				if (id_getUserTypeId == IntPtr.Zero)
					id_getUserTypeId = JNIEnv.GetMethodID (class_ref, "getUserTypeId", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserTypeId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserTypeId", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setUserTypeId' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setUserTypeId", "(Ljava/lang/Short;)V", "GetSetUserTypeId_Ljava_lang_Short_Handler")]
			set {
				if (id_setUserTypeId_Ljava_lang_Short_ == IntPtr.Zero)
					id_setUserTypeId_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setUserTypeId", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserTypeId_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserTypeId", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFeatures;
#pragma warning disable 0169
		static Delegate GetGetFeaturesHandler ()
		{
			if (cb_getFeatures == null)
				cb_getFeatures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFeatures);
			return cb_getFeatures;
		}

		static IntPtr n_GetFeatures (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GetFeatures ());
		}
#pragma warning restore 0169

		static IntPtr id_getFeatures;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getFeatures' and count(parameter)=0]"
		[Register ("getFeatures", "()Ljava/util/List;", "GetGetFeaturesHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> GetFeatures ()
		{
			if (id_getFeatures == IntPtr.Zero)
				id_getFeatures = JNIEnv.GetMethodID (class_ref, "getFeatures", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFeatures), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFeatures", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRoleName;
#pragma warning disable 0169
		static Delegate GetGetRoleNameHandler ()
		{
			if (cb_getRoleName == null)
				cb_getRoleName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRoleName);
			return cb_getRoleName;
		}

		static IntPtr n_GetRoleName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetRoleName ());
		}
#pragma warning restore 0169

		static IntPtr id_getRoleName;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getRoleName' and count(parameter)=0]"
		[Register ("getRoleName", "()Ljava/lang/String;", "GetGetRoleNameHandler")]
		public virtual unsafe string GetRoleName ()
		{
			if (id_getRoleName == IntPtr.Zero)
				id_getRoleName = JNIEnv.GetMethodID (class_ref, "getRoleName", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRoleName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoleName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRoleType;
#pragma warning disable 0169
		static Delegate GetGetRoleTypeHandler ()
		{
			if (cb_getRoleType == null)
				cb_getRoleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRoleType);
			return cb_getRoleType;
		}

		static IntPtr n_GetRoleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRoleType ());
		}
#pragma warning restore 0169

		static IntPtr id_getRoleType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='getRoleType' and count(parameter)=0]"
		[Register ("getRoleType", "()Ljava/lang/Short;", "GetGetRoleTypeHandler")]
		public virtual unsafe global::Java.Lang.Short GetRoleType ()
		{
			if (id_getRoleType == IntPtr.Zero)
				id_getRoleType = JNIEnv.GetMethodID (class_ref, "getRoleType", "()Ljava/lang/Short;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRoleType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoleType", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFeatures_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetFeatures_Ljava_util_List_Handler ()
		{
			if (cb_setFeatures_Ljava_util_List_ == null)
				cb_setFeatures_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFeatures_Ljava_util_List_);
			return cb_setFeatures_Ljava_util_List_;
		}

		static void n_SetFeatures_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFeatures (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFeatures_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setFeatures' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setFeatures", "(Ljava/util/List;)V", "GetSetFeatures_Ljava_util_List_Handler")]
		public virtual unsafe void SetFeatures (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_setFeatures_Ljava_util_List_ == IntPtr.Zero)
				id_setFeatures_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setFeatures", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFeatures_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFeatures", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRoleName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRoleName_Ljava_lang_String_Handler ()
		{
			if (cb_setRoleName_Ljava_lang_String_ == null)
				cb_setRoleName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRoleName_Ljava_lang_String_);
			return cb_setRoleName_Ljava_lang_String_;
		}

		static void n_SetRoleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRoleName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRoleName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setRoleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRoleName", "(Ljava/lang/String;)V", "GetSetRoleName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRoleName (string p0)
		{
			if (id_setRoleName_Ljava_lang_String_ == IntPtr.Zero)
				id_setRoleName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRoleName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRoleName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRoleName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRoleType_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetRoleType_Ljava_lang_Short_Handler ()
		{
			if (cb_setRoleType_Ljava_lang_Short_ == null)
				cb_setRoleType_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRoleType_Ljava_lang_Short_);
			return cb_setRoleType_Ljava_lang_Short_;
		}

		static void n_SetRoleType_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRoleType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRoleType_Ljava_lang_Short_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='ApplozicUser']/method[@name='setRoleType' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
		[Register ("setRoleType", "(Ljava/lang/Short;)V", "GetSetRoleType_Ljava_lang_Short_Handler")]
		public virtual unsafe void SetRoleType (global::Java.Lang.Short p0)
		{
			if (id_setRoleType_Ljava_lang_Short_ == IntPtr.Zero)
				id_setRoleType_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setRoleType", "(Ljava/lang/Short;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRoleType_Ljava_lang_Short_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRoleType", "(Ljava/lang/Short;)V"), __args);
			} finally {
			}
		}

	}
}
