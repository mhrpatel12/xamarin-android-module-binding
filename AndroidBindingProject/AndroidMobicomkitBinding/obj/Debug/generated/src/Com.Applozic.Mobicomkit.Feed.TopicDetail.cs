using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/TopicDetail", DoNotGenerateAcw=true)]
	public partial class TopicDetail : global::Com.Applozic.Mobicommons.Json.JsonParcelableMarker {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/TopicDetail", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TopicDetail); }
		}

		protected TopicDetail (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/constructor[@name='TopicDetail' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe TopicDetail (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (TopicDetail)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/constructor[@name='TopicDetail' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TopicDetail ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TopicDetail)) {
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

		static Delegate cb_getJson;
#pragma warning disable 0169
		static Delegate GetGetJsonHandler ()
		{
			if (cb_getJson == null)
				cb_getJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJson);
			return cb_getJson;
		}

		static IntPtr n_GetJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Json);
		}
#pragma warning restore 0169

		static IntPtr id_getJson;
		public virtual unsafe string Json {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='getJson' and count(parameter)=0]"
			[Register ("getJson", "()Ljava/lang/String;", "GetGetJsonHandler")]
			get {
				if (id_getJson == IntPtr.Zero)
					id_getJson = JNIEnv.GetMethodID (class_ref, "getJson", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJson), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJson", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKey1;
#pragma warning disable 0169
		static Delegate GetGetKey1Handler ()
		{
			if (cb_getKey1 == null)
				cb_getKey1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey1);
			return cb_getKey1;
		}

		static IntPtr n_GetKey1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key1);
		}
#pragma warning restore 0169

		static Delegate cb_setKey1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKey1_Ljava_lang_String_Handler ()
		{
			if (cb_setKey1_Ljava_lang_String_ == null)
				cb_setKey1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey1_Ljava_lang_String_);
			return cb_setKey1_Ljava_lang_String_;
		}

		static void n_SetKey1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Key1 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKey1;
		static IntPtr id_setKey1_Ljava_lang_String_;
		public virtual unsafe string Key1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='getKey1' and count(parameter)=0]"
			[Register ("getKey1", "()Ljava/lang/String;", "GetGetKey1Handler")]
			get {
				if (id_getKey1 == IntPtr.Zero)
					id_getKey1 = JNIEnv.GetMethodID (class_ref, "getKey1", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey1), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey1", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='setKey1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKey1", "(Ljava/lang/String;)V", "GetSetKey1_Ljava_lang_String_Handler")]
			set {
				if (id_setKey1_Ljava_lang_String_ == IntPtr.Zero)
					id_setKey1_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKey1", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKey1_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKey1", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getKey2;
#pragma warning disable 0169
		static Delegate GetGetKey2Handler ()
		{
			if (cb_getKey2 == null)
				cb_getKey2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey2);
			return cb_getKey2;
		}

		static IntPtr n_GetKey2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key2);
		}
#pragma warning restore 0169

		static Delegate cb_setKey2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKey2_Ljava_lang_String_Handler ()
		{
			if (cb_setKey2_Ljava_lang_String_ == null)
				cb_setKey2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey2_Ljava_lang_String_);
			return cb_setKey2_Ljava_lang_String_;
		}

		static void n_SetKey2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Key2 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKey2;
		static IntPtr id_setKey2_Ljava_lang_String_;
		public virtual unsafe string Key2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='getKey2' and count(parameter)=0]"
			[Register ("getKey2", "()Ljava/lang/String;", "GetGetKey2Handler")]
			get {
				if (id_getKey2 == IntPtr.Zero)
					id_getKey2 = JNIEnv.GetMethodID (class_ref, "getKey2", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey2), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey2", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='setKey2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKey2", "(Ljava/lang/String;)V", "GetSetKey2_Ljava_lang_String_Handler")]
			set {
				if (id_setKey2_Ljava_lang_String_ == IntPtr.Zero)
					id_setKey2_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKey2", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKey2_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKey2", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLink;
#pragma warning disable 0169
		static Delegate GetGetLinkHandler ()
		{
			if (cb_getLink == null)
				cb_getLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLink);
			return cb_getLink;
		}

		static IntPtr n_GetLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Link);
		}
#pragma warning restore 0169

		static Delegate cb_setLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLink_Ljava_lang_String_Handler ()
		{
			if (cb_setLink_Ljava_lang_String_ == null)
				cb_setLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLink_Ljava_lang_String_);
			return cb_setLink_Ljava_lang_String_;
		}

		static void n_SetLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Link = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLink;
		static IntPtr id_setLink_Ljava_lang_String_;
		public virtual unsafe string Link {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='getLink' and count(parameter)=0]"
			[Register ("getLink", "()Ljava/lang/String;", "GetGetLinkHandler")]
			get {
				if (id_getLink == IntPtr.Zero)
					id_getLink = JNIEnv.GetMethodID (class_ref, "getLink", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLink), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLink", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='setLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLink", "(Ljava/lang/String;)V", "GetSetLink_Ljava_lang_String_Handler")]
			set {
				if (id_setLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLink", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLink_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLink", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSubtitle;
#pragma warning disable 0169
		static Delegate GetGetSubtitleHandler ()
		{
			if (cb_getSubtitle == null)
				cb_getSubtitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubtitle);
			return cb_getSubtitle;
		}

		static IntPtr n_GetSubtitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Subtitle);
		}
#pragma warning restore 0169

		static Delegate cb_setSubtitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubtitle_Ljava_lang_String_Handler ()
		{
			if (cb_setSubtitle_Ljava_lang_String_ == null)
				cb_setSubtitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubtitle_Ljava_lang_String_);
			return cb_setSubtitle_Ljava_lang_String_;
		}

		static void n_SetSubtitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Subtitle = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSubtitle;
		static IntPtr id_setSubtitle_Ljava_lang_String_;
		public virtual unsafe string Subtitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='getSubtitle' and count(parameter)=0]"
			[Register ("getSubtitle", "()Ljava/lang/String;", "GetGetSubtitleHandler")]
			get {
				if (id_getSubtitle == IntPtr.Zero)
					id_getSubtitle = JNIEnv.GetMethodID (class_ref, "getSubtitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubtitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubtitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='setSubtitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubtitle", "(Ljava/lang/String;)V", "GetSetSubtitle_Ljava_lang_String_Handler")]
			set {
				if (id_setSubtitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setSubtitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSubtitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSubtitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubtitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getValue1;
#pragma warning disable 0169
		static Delegate GetGetValue1Handler ()
		{
			if (cb_getValue1 == null)
				cb_getValue1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue1);
			return cb_getValue1;
		}

		static IntPtr n_GetValue1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value1);
		}
#pragma warning restore 0169

		static Delegate cb_setValue1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue1_Ljava_lang_String_Handler ()
		{
			if (cb_setValue1_Ljava_lang_String_ == null)
				cb_setValue1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue1_Ljava_lang_String_);
			return cb_setValue1_Ljava_lang_String_;
		}

		static void n_SetValue1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value1 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getValue1;
		static IntPtr id_setValue1_Ljava_lang_String_;
		public virtual unsafe string Value1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='getValue1' and count(parameter)=0]"
			[Register ("getValue1", "()Ljava/lang/String;", "GetGetValue1Handler")]
			get {
				if (id_getValue1 == IntPtr.Zero)
					id_getValue1 = JNIEnv.GetMethodID (class_ref, "getValue1", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue1), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue1", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='setValue1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue1", "(Ljava/lang/String;)V", "GetSetValue1_Ljava_lang_String_Handler")]
			set {
				if (id_setValue1_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue1_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue1", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue1_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue1", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getValue2;
#pragma warning disable 0169
		static Delegate GetGetValue2Handler ()
		{
			if (cb_getValue2 == null)
				cb_getValue2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue2);
			return cb_getValue2;
		}

		static IntPtr n_GetValue2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value2);
		}
#pragma warning restore 0169

		static Delegate cb_setValue2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue2_Ljava_lang_String_Handler ()
		{
			if (cb_setValue2_Ljava_lang_String_ == null)
				cb_setValue2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue2_Ljava_lang_String_);
			return cb_setValue2_Ljava_lang_String_;
		}

		static void n_SetValue2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Value2 = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getValue2;
		static IntPtr id_setValue2_Ljava_lang_String_;
		public virtual unsafe string Value2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='getValue2' and count(parameter)=0]"
			[Register ("getValue2", "()Ljava/lang/String;", "GetGetValue2Handler")]
			get {
				if (id_getValue2 == IntPtr.Zero)
					id_getValue2 = JNIEnv.GetMethodID (class_ref, "getValue2", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue2), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue2", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='setValue2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue2", "(Ljava/lang/String;)V", "GetSetValue2_Ljava_lang_String_Handler")]
			set {
				if (id_setValue2_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue2_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue2", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue2_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue2", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Applozic.Mobicomkit.Feed.TopicDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.TopicDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='TopicDetail']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
