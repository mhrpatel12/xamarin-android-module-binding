using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.People.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/people/channel/Channel", DoNotGenerateAcw=true)]
	public partial class Channel : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']"
		[global::Android.Runtime.Register ("com/applozic/mobicommons/people/channel/Channel$GroupType", DoNotGenerateAcw=true)]
		public sealed partial class GroupType : global::Java.Lang.Enum {


			static IntPtr BROADCAST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='BROADCAST']"
			[Register ("BROADCAST")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType Broadcast {
				get {
					if (BROADCAST_jfieldId == IntPtr.Zero)
						BROADCAST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BROADCAST", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BROADCAST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BROADCAST_ONE_BY_ONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='BROADCAST_ONE_BY_ONE']"
			[Register ("BROADCAST_ONE_BY_ONE")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType BroadcastOneByOne {
				get {
					if (BROADCAST_ONE_BY_ONE_jfieldId == IntPtr.Zero)
						BROADCAST_ONE_BY_ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BROADCAST_ONE_BY_ONE", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BROADCAST_ONE_BY_ONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONTACT_GROUP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='CONTACT_GROUP']"
			[Register ("CONTACT_GROUP")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType ContactGroup {
				get {
					if (CONTACT_GROUP_jfieldId == IntPtr.Zero)
						CONTACT_GROUP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTACT_GROUP", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTACT_GROUP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GROUPOFTWO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='GROUPOFTWO']"
			[Register ("GROUPOFTWO")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType Groupoftwo {
				get {
					if (GROUPOFTWO_jfieldId == IntPtr.Zero)
						GROUPOFTWO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROUPOFTWO", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROUPOFTWO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='OPEN']"
			[Register ("OPEN")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType Open {
				get {
					if (OPEN_jfieldId == IntPtr.Zero)
						OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PRIVATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='PRIVATE']"
			[Register ("PRIVATE")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType Private {
				get {
					if (PRIVATE_jfieldId == IntPtr.Zero)
						PRIVATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRIVATE", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRIVATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PUBLIC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='PUBLIC']"
			[Register ("PUBLIC")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType Public {
				get {
					if (PUBLIC_jfieldId == IntPtr.Zero)
						PUBLIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUBLIC", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUBLIC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SELF_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='SELF']"
			[Register ("SELF")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType Self {
				get {
					if (SELF_jfieldId == IntPtr.Zero)
						SELF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SELF", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SELF_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SELLER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='SELLER']"
			[Register ("SELLER")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType Seller {
				get {
					if (SELLER_jfieldId == IntPtr.Zero)
						SELLER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SELLER", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SELLER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIRTUAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/field[@name='VIRTUAL']"
			[Register ("VIRTUAL")]
			public static global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType Virtual {
				get {
					if (VIRTUAL_jfieldId == IntPtr.Zero)
						VIRTUAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIRTUAL", "Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIRTUAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicommons/people/channel/Channel$GroupType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GroupType); }
			}

			internal GroupType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Short Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/method[@name='getValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel$GroupType;", "")]
			public static unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel.GroupType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicommons/people/channel/Channel$GroupType;", "")]
			public static unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicommons/people/channel/Channel$GroupType;");
				try {
					return (global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicommons.People.Channel.Channel.GroupType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/people/channel/Channel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Channel); }
		}

		protected Channel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/constructor[@name='Channel' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Integer;Ljava/lang/String;)V", "")]
		public unsafe Channel (global::Java.Lang.Integer p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (Channel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Integer;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/constructor[@name='Channel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/Integer;)V", "")]
		public unsafe Channel (global::Java.Lang.Integer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Channel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Short_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/constructor[@name='Channel' and count(parameter)=6 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Short'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Short;ILjava/lang/String;)V", "")]
		public unsafe Channel (global::Java.Lang.Integer p0, string p1, string p2, global::Java.Lang.Short p3, int p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				if (((object) this).GetType () != typeof (Channel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Short;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Short;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Short_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Short_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Short;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Short_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Short_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/constructor[@name='Channel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Channel ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Channel)) {
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

		static Delegate cb_getAdminKey;
#pragma warning disable 0169
		static Delegate GetGetAdminKeyHandler ()
		{
			if (cb_getAdminKey == null)
				cb_getAdminKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdminKey);
			return cb_getAdminKey;
		}

		static IntPtr n_GetAdminKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdminKey);
		}
#pragma warning restore 0169

		static Delegate cb_setAdminKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdminKey_Ljava_lang_String_Handler ()
		{
			if (cb_setAdminKey_Ljava_lang_String_ == null)
				cb_setAdminKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdminKey_Ljava_lang_String_);
			return cb_setAdminKey_Ljava_lang_String_;
		}

		static void n_SetAdminKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdminKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdminKey;
		static IntPtr id_setAdminKey_Ljava_lang_String_;
		public virtual unsafe string AdminKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getAdminKey' and count(parameter)=0]"
			[Register ("getAdminKey", "()Ljava/lang/String;", "GetGetAdminKeyHandler")]
			get {
				if (id_getAdminKey == IntPtr.Zero)
					id_getAdminKey = JNIEnv.GetMethodID (class_ref, "getAdminKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdminKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdminKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setAdminKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdminKey", "(Ljava/lang/String;)V", "GetSetAdminKey_Ljava_lang_String_Handler")]
			set {
				if (id_setAdminKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setAdminKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdminKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdminKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdminKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getClientGroupId;
#pragma warning disable 0169
		static Delegate GetGetClientGroupIdHandler ()
		{
			if (cb_getClientGroupId == null)
				cb_getClientGroupId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientGroupId);
			return cb_getClientGroupId;
		}

		static IntPtr n_GetClientGroupId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientGroupId);
		}
#pragma warning restore 0169

		static Delegate cb_setClientGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientGroupId_Ljava_lang_String_ == null)
				cb_setClientGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientGroupId_Ljava_lang_String_);
			return cb_setClientGroupId_Ljava_lang_String_;
		}

		static void n_SetClientGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientGroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientGroupId;
		static IntPtr id_setClientGroupId_Ljava_lang_String_;
		public virtual unsafe string ClientGroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getClientGroupId' and count(parameter)=0]"
			[Register ("getClientGroupId", "()Ljava/lang/String;", "GetGetClientGroupIdHandler")]
			get {
				if (id_getClientGroupId == IntPtr.Zero)
					id_getClientGroupId = JNIEnv.GetMethodID (class_ref, "getClientGroupId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientGroupId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientGroupId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientGroupId", "(Ljava/lang/String;)V", "GetSetClientGroupId_Ljava_lang_String_Handler")]
			set {
				if (id_setClientGroupId_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientGroupId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientGroupId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClientGroupId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientGroupId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContacts;
#pragma warning disable 0169
		static Delegate GetGetContactsHandler ()
		{
			if (cb_getContacts == null)
				cb_getContacts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContacts);
			return cb_getContacts;
		}

		static IntPtr n_GetContacts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (__this.Contacts);
		}
#pragma warning restore 0169

		static Delegate cb_setContacts_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetContacts_Ljava_util_List_Handler ()
		{
			if (cb_setContacts_Ljava_util_List_ == null)
				cb_setContacts_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContacts_Ljava_util_List_);
			return cb_setContacts_Ljava_util_List_;
		}

		static void n_SetContacts_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Contacts = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContacts;
		static IntPtr id_setContacts_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> Contacts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getContacts' and count(parameter)=0]"
			[Register ("getContacts", "()Ljava/util/List;", "GetGetContactsHandler")]
			get {
				if (id_getContacts == IntPtr.Zero)
					id_getContacts = JNIEnv.GetMethodID (class_ref, "getContacts", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContacts), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContacts", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setContacts' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicommons.people.contact.Contact&gt;']]"
			[Register ("setContacts", "(Ljava/util/List;)V", "GetSetContacts_Ljava_util_List_Handler")]
			set {
				if (id_setContacts_Ljava_util_List_ == IntPtr.Zero)
					id_setContacts_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setContacts", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContacts_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContacts", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConversationPxy;
#pragma warning disable 0169
		static Delegate GetGetConversationPxyHandler ()
		{
			if (cb_getConversationPxy == null)
				cb_getConversationPxy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationPxy);
			return cb_getConversationPxy;
		}

		static IntPtr n_GetConversationPxy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConversationPxy);
		}
#pragma warning restore 0169

		static Delegate cb_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_;
#pragma warning disable 0169
		static Delegate GetSetConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_Handler ()
		{
			if (cb_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ == null)
				cb_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_);
			return cb_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_;
		}

		static void n_SetConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConversationPxy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationPxy;
		static IntPtr id_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_;
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Conversation ConversationPxy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getConversationPxy' and count(parameter)=0]"
			[Register ("getConversationPxy", "()Lcom/applozic/mobicommons/people/channel/Conversation;", "GetGetConversationPxyHandler")]
			get {
				if (id_getConversationPxy == IntPtr.Zero)
					id_getConversationPxy = JNIEnv.GetMethodID (class_ref, "getConversationPxy", "()Lcom/applozic/mobicommons/people/channel/Conversation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationPxy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationPxy", "()Lcom/applozic/mobicommons/people/channel/Conversation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setConversationPxy' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation']]"
			[Register ("setConversationPxy", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V", "GetSetConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_Handler")]
			set {
				if (id_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ == IntPtr.Zero)
					id_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNIEnv.GetMethodID (class_ref, "setConversationPxy", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationPxy", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeletedAtTime;
#pragma warning disable 0169
		static Delegate GetGetDeletedAtTimeHandler ()
		{
			if (cb_getDeletedAtTime == null)
				cb_getDeletedAtTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeletedAtTime);
			return cb_getDeletedAtTime;
		}

		static IntPtr n_GetDeletedAtTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeletedAtTime);
		}
#pragma warning restore 0169

		static Delegate cb_setDeletedAtTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetDeletedAtTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setDeletedAtTime_Ljava_lang_Long_ == null)
				cb_setDeletedAtTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeletedAtTime_Ljava_lang_Long_);
			return cb_setDeletedAtTime_Ljava_lang_Long_;
		}

		static void n_SetDeletedAtTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeletedAtTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeletedAtTime;
		static IntPtr id_setDeletedAtTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long DeletedAtTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getDeletedAtTime' and count(parameter)=0]"
			[Register ("getDeletedAtTime", "()Ljava/lang/Long;", "GetGetDeletedAtTimeHandler")]
			get {
				if (id_getDeletedAtTime == IntPtr.Zero)
					id_getDeletedAtTime = JNIEnv.GetMethodID (class_ref, "getDeletedAtTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeletedAtTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeletedAtTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setDeletedAtTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setDeletedAtTime", "(Ljava/lang/Long;)V", "GetSetDeletedAtTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setDeletedAtTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setDeletedAtTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setDeletedAtTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeletedAtTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeletedAtTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageUrl;
#pragma warning disable 0169
		static Delegate GetGetImageUrlHandler ()
		{
			if (cb_getImageUrl == null)
				cb_getImageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageUrl);
			return cb_getImageUrl;
		}

		static IntPtr n_GetImageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setImageUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setImageUrl_Ljava_lang_String_ == null)
				cb_setImageUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageUrl_Ljava_lang_String_);
			return cb_setImageUrl_Ljava_lang_String_;
		}

		static void n_SetImageUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageUrl;
		static IntPtr id_setImageUrl_Ljava_lang_String_;
		public virtual unsafe string ImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getImageUrl' and count(parameter)=0]"
			[Register ("getImageUrl", "()Ljava/lang/String;", "GetGetImageUrlHandler")]
			get {
				if (id_getImageUrl == IntPtr.Zero)
					id_getImageUrl = JNIEnv.GetMethodID (class_ref, "getImageUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImageUrl", "(Ljava/lang/String;)V", "GetSetImageUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setImageUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setImageUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImageUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isBroadcastMessage;
#pragma warning disable 0169
		static Delegate GetIsBroadcastMessageHandler ()
		{
			if (cb_isBroadcastMessage == null)
				cb_isBroadcastMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBroadcastMessage);
			return cb_isBroadcastMessage;
		}

		static bool n_IsBroadcastMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBroadcastMessage;
		}
#pragma warning restore 0169

		static IntPtr id_isBroadcastMessage;
		public virtual unsafe bool IsBroadcastMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='isBroadcastMessage' and count(parameter)=0]"
			[Register ("isBroadcastMessage", "()Z", "GetIsBroadcastMessageHandler")]
			get {
				if (id_isBroadcastMessage == IntPtr.Zero)
					id_isBroadcastMessage = JNIEnv.GetMethodID (class_ref, "isBroadcastMessage", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBroadcastMessage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBroadcastMessage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDeleted;
#pragma warning disable 0169
		static Delegate GetIsDeletedHandler ()
		{
			if (cb_isDeleted == null)
				cb_isDeleted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeleted);
			return cb_isDeleted;
		}

		static bool n_IsDeleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDeleted;
		}
#pragma warning restore 0169

		static IntPtr id_isDeleted;
		public virtual unsafe bool IsDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='isDeleted' and count(parameter)=0]"
			[Register ("isDeleted", "()Z", "GetIsDeletedHandler")]
			get {
				if (id_isDeleted == IntPtr.Zero)
					id_isDeleted = JNIEnv.GetMethodID (class_ref, "isDeleted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDeleted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeleted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isGroupDefaultMuted;
#pragma warning disable 0169
		static Delegate GetIsGroupDefaultMutedHandler ()
		{
			if (cb_isGroupDefaultMuted == null)
				cb_isGroupDefaultMuted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGroupDefaultMuted);
			return cb_isGroupDefaultMuted;
		}

		static bool n_IsGroupDefaultMuted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGroupDefaultMuted;
		}
#pragma warning restore 0169

		static IntPtr id_isGroupDefaultMuted;
		public virtual unsafe bool IsGroupDefaultMuted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='isGroupDefaultMuted' and count(parameter)=0]"
			[Register ("isGroupDefaultMuted", "()Z", "GetIsGroupDefaultMutedHandler")]
			get {
				if (id_isGroupDefaultMuted == IntPtr.Zero)
					id_isGroupDefaultMuted = JNIEnv.GetMethodID (class_ref, "isGroupDefaultMuted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isGroupDefaultMuted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGroupDefaultMuted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isNotificationMuted;
#pragma warning disable 0169
		static Delegate GetIsNotificationMutedHandler ()
		{
			if (cb_isNotificationMuted == null)
				cb_isNotificationMuted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotificationMuted);
			return cb_isNotificationMuted;
		}

		static bool n_IsNotificationMuted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNotificationMuted;
		}
#pragma warning restore 0169

		static IntPtr id_isNotificationMuted;
		public virtual unsafe bool IsNotificationMuted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='isNotificationMuted' and count(parameter)=0]"
			[Register ("isNotificationMuted", "()Z", "GetIsNotificationMutedHandler")]
			get {
				if (id_isNotificationMuted == IntPtr.Zero)
					id_isNotificationMuted = JNIEnv.GetMethodID (class_ref, "isNotificationMuted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotificationMuted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotificationMuted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Key);
		}
#pragma warning restore 0169

		static Delegate cb_setKey_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetKey_Ljava_lang_Integer_Handler ()
		{
			if (cb_setKey_Ljava_lang_Integer_ == null)
				cb_setKey_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey_Ljava_lang_Integer_);
			return cb_setKey_Ljava_lang_Integer_;
		}

		static void n_SetKey_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Key = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		static IntPtr id_setKey_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/Integer;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setKey", "(Ljava/lang/Integer;)V", "GetSetKey_Ljava_lang_Integer_Handler")]
			set {
				if (id_setKey_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setKey_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setKey", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKey_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKey", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocalImageUri;
#pragma warning disable 0169
		static Delegate GetGetLocalImageUriHandler ()
		{
			if (cb_getLocalImageUri == null)
				cb_getLocalImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalImageUri);
			return cb_getLocalImageUri;
		}

		static IntPtr n_GetLocalImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalImageUri);
		}
#pragma warning restore 0169

		static Delegate cb_setLocalImageUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocalImageUri_Ljava_lang_String_Handler ()
		{
			if (cb_setLocalImageUri_Ljava_lang_String_ == null)
				cb_setLocalImageUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocalImageUri_Ljava_lang_String_);
			return cb_setLocalImageUri_Ljava_lang_String_;
		}

		static void n_SetLocalImageUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalImageUri = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalImageUri;
		static IntPtr id_setLocalImageUri_Ljava_lang_String_;
		public virtual unsafe string LocalImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getLocalImageUri' and count(parameter)=0]"
			[Register ("getLocalImageUri", "()Ljava/lang/String;", "GetGetLocalImageUriHandler")]
			get {
				if (id_getLocalImageUri == IntPtr.Zero)
					id_getLocalImageUri = JNIEnv.GetMethodID (class_ref, "getLocalImageUri", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalImageUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalImageUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setLocalImageUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocalImageUri", "(Ljava/lang/String;)V", "GetSetLocalImageUri_Ljava_lang_String_Handler")]
			set {
				if (id_setLocalImageUri_Ljava_lang_String_ == IntPtr.Zero)
					id_setLocalImageUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLocalImageUri", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocalImageUri_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalImageUri", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		static IntPtr id_setMetadata_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getMetadata' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNotificationAfterTime;
#pragma warning disable 0169
		static Delegate GetGetNotificationAfterTimeHandler ()
		{
			if (cb_getNotificationAfterTime == null)
				cb_getNotificationAfterTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationAfterTime);
			return cb_getNotificationAfterTime;
		}

		static IntPtr n_GetNotificationAfterTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotificationAfterTime);
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationAfterTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetNotificationAfterTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setNotificationAfterTime_Ljava_lang_Long_ == null)
				cb_setNotificationAfterTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationAfterTime_Ljava_lang_Long_);
			return cb_setNotificationAfterTime_Ljava_lang_Long_;
		}

		static void n_SetNotificationAfterTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotificationAfterTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationAfterTime;
		static IntPtr id_setNotificationAfterTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long NotificationAfterTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getNotificationAfterTime' and count(parameter)=0]"
			[Register ("getNotificationAfterTime", "()Ljava/lang/Long;", "GetGetNotificationAfterTimeHandler")]
			get {
				if (id_getNotificationAfterTime == IntPtr.Zero)
					id_getNotificationAfterTime = JNIEnv.GetMethodID (class_ref, "getNotificationAfterTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationAfterTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationAfterTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setNotificationAfterTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setNotificationAfterTime", "(Ljava/lang/Long;)V", "GetSetNotificationAfterTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setNotificationAfterTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setNotificationAfterTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setNotificationAfterTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationAfterTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationAfterTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_Short_Handler ()
		{
			if (cb_setType_Ljava_lang_Short_ == null)
				cb_setType_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_Short_);
			return cb_setType_Ljava_lang_Short_;
		}

		static void n_SetType_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/Short;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setType", "(Ljava/lang/Short;)V", "GetSetType_Ljava_lang_Short_Handler")]
			set {
				if (id_setType_Ljava_lang_Short_ == IntPtr.Zero)
					id_setType_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUnreadCount;
#pragma warning disable 0169
		static Delegate GetGetUnreadCountHandler ()
		{
			if (cb_getUnreadCount == null)
				cb_getUnreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnreadCount);
			return cb_getUnreadCount;
		}

		static int n_GetUnreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnreadCount;
		}
#pragma warning restore 0169

		static Delegate cb_setUnreadCount_I;
#pragma warning disable 0169
		static Delegate GetSetUnreadCount_IHandler ()
		{
			if (cb_setUnreadCount_I == null)
				cb_setUnreadCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnreadCount_I);
			return cb_setUnreadCount_I;
		}

		static void n_SetUnreadCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnreadCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadCount;
		static IntPtr id_setUnreadCount_I;
		public virtual unsafe int UnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getUnreadCount' and count(parameter)=0]"
			[Register ("getUnreadCount", "()I", "GetGetUnreadCountHandler")]
			get {
				if (id_getUnreadCount == IntPtr.Zero)
					id_getUnreadCount = JNIEnv.GetMethodID (class_ref, "getUnreadCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setUnreadCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnreadCount", "(I)V", "GetSetUnreadCount_IHandler")]
			set {
				if (id_setUnreadCount_I == IntPtr.Zero)
					id_setUnreadCount_I = JNIEnv.GetMethodID (class_ref, "setUnreadCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnreadCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnreadCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUserCount;
#pragma warning disable 0169
		static Delegate GetGetUserCountHandler ()
		{
			if (cb_getUserCount == null)
				cb_getUserCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserCount);
			return cb_getUserCount;
		}

		static int n_GetUserCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserCount;
		}
#pragma warning restore 0169

		static Delegate cb_setUserCount_I;
#pragma warning disable 0169
		static Delegate GetSetUserCount_IHandler ()
		{
			if (cb_setUserCount_I == null)
				cb_setUserCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUserCount_I);
			return cb_setUserCount_I;
		}

		static void n_SetUserCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Channel __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UserCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserCount;
		static IntPtr id_setUserCount_I;
		public virtual unsafe int UserCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='getUserCount' and count(parameter)=0]"
			[Register ("getUserCount", "()I", "GetGetUserCountHandler")]
			get {
				if (id_getUserCount == IntPtr.Zero)
					id_getUserCount = JNIEnv.GetMethodID (class_ref, "getUserCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUserCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Channel']/method[@name='setUserCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUserCount", "(I)V", "GetSetUserCount_IHandler")]
			set {
				if (id_setUserCount_I == IntPtr.Zero)
					id_setUserCount_I = JNIEnv.GetMethodID (class_ref, "setUserCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserCount", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
