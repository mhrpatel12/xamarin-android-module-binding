using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Channel.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/channel/service/ChannelService", DoNotGenerateAcw=true)]
	public partial class ChannelService : global::Java.Lang.Object {


		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/field[@name='context']"
		[Register ("context")]
		public global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr isUpdateTitle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/field[@name='isUpdateTitle']"
		[Register ("isUpdateTitle")]
		public static bool IsUpdateTitle {
			get {
				if (isUpdateTitle_jfieldId == IntPtr.Zero)
					isUpdateTitle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUpdateTitle", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isUpdateTitle_jfieldId);
			}
			set {
				if (isUpdateTitle_jfieldId == IntPtr.Zero)
					isUpdateTitle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUpdateTitle", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isUpdateTitle_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/channel/service/ChannelService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelService); }
		}

		protected ChannelService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getChannelList;
#pragma warning disable 0169
		static Delegate GetGetChannelListHandler ()
		{
			if (cb_getChannelList == null)
				cb_getChannelList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelList);
			return cb_getChannelList;
		}

		static IntPtr n_GetChannelList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Channel>.ToLocalJniHandle (__this.ChannelList);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.Channel> ChannelList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getChannelList' and count(parameter)=0]"
			[Register ("getChannelList", "()Ljava/util/List;", "GetGetChannelListHandler")]
			get {
				if (id_getChannelList == IntPtr.Zero)
					id_getChannelList = JNIEnv.GetMethodID (class_ref, "getChannelList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Channel>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Channel>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_addMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_addMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.AddMemberToChannelProcess (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='addMemberToChannelProcess' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToChannelProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;", "GetAddMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe string AddMemberToChannelProcess (global::Java.Lang.Integer p0, string p1)
		{
			if (id_addMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToChannelProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToChannelProcess_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToChannelProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_);
			return cb_addMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.AddMemberToChannelProcess (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='addMemberToChannelProcess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToChannelProcess", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetAddMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string AddMemberToChannelProcess (string p0, string p1)
		{
			if (id_addMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToChannelProcess", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToChannelProcess_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToChannelProcess", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_addMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_addMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToChannelProcessWithResponse (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='addMemberToChannelProcessWithResponse' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToChannelProcessWithResponse", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToChannelProcessWithResponse (global::Java.Lang.Integer p0, string p1)
		{
			if (id_addMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToChannelProcessWithResponse", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToChannelProcessWithResponse_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToChannelProcessWithResponse", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_);
			return cb_addMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToChannelProcessWithResponse (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='addMemberToChannelProcessWithResponse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToChannelProcessWithResponse", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToChannelProcessWithResponse (string p0, string p1)
		{
			if (id_addMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToChannelProcessWithResponse", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToChannelProcessWithResponse_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToChannelProcessWithResponse", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_addMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_addMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToChannelWithResponseProcess (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='addMemberToChannelWithResponseProcess' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToChannelWithResponseProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToChannelWithResponseProcess (global::Java.Lang.Integer p0, string p1)
		{
			if (id_addMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToChannelWithResponseProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToChannelWithResponseProcess_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToChannelWithResponseProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_addMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == null)
				cb_addMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_);
			return cb_addMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		}

		static bool n_AddMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddMemberToContactGroup (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='addMemberToContactGroup' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addMemberToContactGroup", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Z", "GetAddMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe bool AddMemberToContactGroup (string p0, string p1, global::System.Collections.Generic.IList<string> p2)
		{
			if (id_addMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_addMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addMemberToContactGroup", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToContactGroup_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToContactGroup", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_ == null)
				cb_addMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_);
			return cb_addMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.AddMemberToMultipleChannelsProcess (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='addMemberToMultipleChannelsProcess' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToMultipleChannelsProcess", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;", "GetAddMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_Handler")]
		public virtual unsafe string AddMemberToMultipleChannelsProcess (global::System.Collections.Generic.ICollection<string> p0, string p1)
		{
			if (id_addMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToMultipleChannelsProcess", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToMultipleChannelsProcess_Ljava_util_Set_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToMultipleChannelsProcess", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_ == null)
				cb_addMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_);
			return cb_addMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.AddMemberToMultipleChannelsProcessByChannelKeys (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='addMemberToMultipleChannelsProcessByChannelKeys' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.Integer&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToMultipleChannelsProcessByChannelKeys", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;", "GetAddMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_Handler")]
		public virtual unsafe string AddMemberToMultipleChannelsProcessByChannelKeys (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0, string p1)
		{
			if (id_addMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToMultipleChannelsProcessByChannelKeys", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToMultipleChannelsProcessByChannelKeys_Ljava_util_Set_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToMultipleChannelsProcessByChannelKeys", "(Ljava/util/Set;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
#pragma warning disable 0169
		static Delegate GetCreateChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler ()
		{
			if (cb_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == null)
				cb_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_);
			return cb_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		}

		static IntPtr n_CreateChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='createChannel' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.people.ChannelInfo']]"
		[Register ("createChannel", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetCreateChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel CreateChannel (global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0)
		{
			if (id_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == IntPtr.Zero)
				id_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNIEnv.GetMethodID (class_ref, "createChannel", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createChannel", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
#pragma warning disable 0169
		static Delegate GetCreateChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler ()
		{
			if (cb_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == null)
				cb_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_);
			return cb_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		}

		static IntPtr n_CreateChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateChannelWithResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='createChannelWithResponse' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.people.ChannelInfo']]"
		[Register ("createChannelWithResponse", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicomkit/feed/ChannelFeedApiResponse;", "GetCreateChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeedApiResponse CreateChannelWithResponse (global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0)
		{
			if (id_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == IntPtr.Zero)
				id_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNIEnv.GetMethodID (class_ref, "createChannelWithResponse", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicomkit/feed/ChannelFeedApiResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeedApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeedApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeedApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createChannelWithResponse", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicomkit/feed/ChannelFeedApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
#pragma warning disable 0169
		static Delegate GetCreateGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler ()
		{
			if (cb_createGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == null)
				cb_createGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_);
			return cb_createGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		}

		static IntPtr n_CreateGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateGroupOfTwo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='createGroupOfTwo' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.people.ChannelInfo']]"
		[Register ("createGroupOfTwo", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetCreateGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel CreateGroupOfTwo (global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0)
		{
			if (id_createGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == IntPtr.Zero)
				id_createGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNIEnv.GetMethodID (class_ref, "createGroupOfTwo", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createGroupOfTwo_Lcom_applozic_mobicomkit_api_people_ChannelInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createGroupOfTwo", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createMultipleChannels_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetCreateMultipleChannels_Ljava_util_List_Handler ()
		{
			if (cb_createMultipleChannels_Ljava_util_List_ == null)
				cb_createMultipleChannels_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateMultipleChannels_Ljava_util_List_);
			return cb_createMultipleChannels_Ljava_util_List_;
		}

		static void n_CreateMultipleChannels_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateMultipleChannels (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createMultipleChannels_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='createMultipleChannels' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.people.ChannelInfo&gt;']]"
		[Register ("createMultipleChannels", "(Ljava/util/List;)V", "GetCreateMultipleChannels_Ljava_util_List_Handler")]
		public virtual unsafe void CreateMultipleChannels (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> p0)
		{
			if (id_createMultipleChannels_Ljava_util_List_ == IntPtr.Zero)
				id_createMultipleChannels_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "createMultipleChannels", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createMultipleChannels_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createMultipleChannels", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_;
#pragma warning disable 0169
		static Delegate GetGetChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_Handler ()
		{
			if (cb_getChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_ == null)
				cb_getChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_);
			return cb_getChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_;
		}

		static IntPtr n_GetChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getChannel' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.feed.ChannelFeed']]"
		[Register ("getChannel", "(Lcom/applozic/mobicomkit/feed/ChannelFeed;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannel (global::Com.Applozic.Mobicomkit.Feed.ChannelFeed p0)
		{
			if (id_getChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_ == IntPtr.Zero)
				id_getChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_ = JNIEnv.GetMethodID (class_ref, "getChannel", "(Lcom/applozic/mobicomkit/feed/ChannelFeed;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannel_Lcom_applozic_mobicomkit_feed_ChannelFeed_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannel", "(Lcom/applozic/mobicomkit/feed/ChannelFeed;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetChannel_Ljava_lang_Integer_Handler ()
		{
			if (cb_getChannel_Ljava_lang_Integer_ == null)
				cb_getChannel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannel_Ljava_lang_Integer_);
			return cb_getChannel_Ljava_lang_Integer_;
		}

		static IntPtr n_GetChannel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getChannel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getChannel", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannel_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannel (global::Java.Lang.Integer p0)
		{
			if (id_getChannel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getChannel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getChannel", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannel_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannel", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelByChannelKey_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetChannelByChannelKey_Ljava_lang_Integer_Handler ()
		{
			if (cb_getChannelByChannelKey_Ljava_lang_Integer_ == null)
				cb_getChannelByChannelKey_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelByChannelKey_Ljava_lang_Integer_);
			return cb_getChannelByChannelKey_Ljava_lang_Integer_;
		}

		static IntPtr n_GetChannelByChannelKey_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelByChannelKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelByChannelKey_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getChannelByChannelKey' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getChannelByChannelKey", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannelByChannelKey_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannelByChannelKey (global::Java.Lang.Integer p0)
		{
			if (id_getChannelByChannelKey_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getChannelByChannelKey_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getChannelByChannelKey", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelByChannelKey_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelByChannelKey", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelByClientGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChannelByClientGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_getChannelByClientGroupId_Ljava_lang_String_ == null)
				cb_getChannelByClientGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelByClientGroupId_Ljava_lang_String_);
			return cb_getChannelByClientGroupId_Ljava_lang_String_;
		}

		static IntPtr n_GetChannelByClientGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelByClientGroupId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelByClientGroupId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getChannelByClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getChannelByClientGroupId", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannelByClientGroupId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannelByClientGroupId (string p0)
		{
			if (id_getChannelByClientGroupId_Ljava_lang_String_ == IntPtr.Zero)
				id_getChannelByClientGroupId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getChannelByClientGroupId", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelByClientGroupId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelByClientGroupId", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getChannelInfo_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetChannelInfo_Ljava_lang_Integer_Handler ()
		{
			if (cb_getChannelInfo_Ljava_lang_Integer_ == null)
				cb_getChannelInfo_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelInfo_Ljava_lang_Integer_);
			return cb_getChannelInfo_Ljava_lang_Integer_;
		}

		static IntPtr n_GetChannelInfo_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelInfo_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getChannelInfo' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getChannelInfo", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannelInfo_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannelInfo (global::Java.Lang.Integer p0)
		{
			if (id_getChannelInfo_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getChannelInfo_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getChannelInfo", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelInfo_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelInfo", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChannelInfo_Ljava_lang_String_Handler ()
		{
			if (cb_getChannelInfo_Ljava_lang_String_ == null)
				cb_getChannelInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelInfo_Ljava_lang_String_);
			return cb_getChannelInfo_Ljava_lang_String_;
		}

		static IntPtr n_GetChannelInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelInfo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getChannelInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getChannelInfo", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannelInfo_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannelInfo (string p0)
		{
			if (id_getChannelInfo_Ljava_lang_String_ == IntPtr.Zero)
				id_getChannelInfo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getChannelInfo", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelInfo_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelInfo", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getChannelInfoFromLocalDb_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetChannelInfoFromLocalDb_Ljava_lang_Integer_Handler ()
		{
			if (cb_getChannelInfoFromLocalDb_Ljava_lang_Integer_ == null)
				cb_getChannelInfoFromLocalDb_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelInfoFromLocalDb_Ljava_lang_Integer_);
			return cb_getChannelInfoFromLocalDb_Ljava_lang_Integer_;
		}

		static IntPtr n_GetChannelInfoFromLocalDb_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelInfoFromLocalDb (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelInfoFromLocalDb_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getChannelInfoFromLocalDb' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getChannelInfoFromLocalDb", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;", "GetGetChannelInfoFromLocalDb_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Channel GetChannelInfoFromLocalDb (global::Java.Lang.Integer p0)
		{
			if (id_getChannelInfoFromLocalDb_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getChannelInfoFromLocalDb_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getChannelInfoFromLocalDb", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Channel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelInfoFromLocalDb_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelInfoFromLocalDb", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Channel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getGroupInfoFromClientGroupIds_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetGroupInfoFromClientGroupIds_Ljava_util_List_Handler ()
		{
			if (cb_getGroupInfoFromClientGroupIds_Ljava_util_List_ == null)
				cb_getGroupInfoFromClientGroupIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupInfoFromClientGroupIds_Ljava_util_List_);
			return cb_getGroupInfoFromClientGroupIds_Ljava_util_List_;
		}

		static IntPtr n_GetGroupInfoFromClientGroupIds_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.ToLocalJniHandle (__this.GetGroupInfoFromClientGroupIds (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupInfoFromClientGroupIds_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getGroupInfoFromClientGroupIds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getGroupInfoFromClientGroupIds", "(Ljava/util/List;)Ljava/util/List;", "GetGetGroupInfoFromClientGroupIds_Ljava_util_List_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> GetGroupInfoFromClientGroupIds (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getGroupInfoFromClientGroupIds_Ljava_util_List_ == IntPtr.Zero)
				id_getGroupInfoFromClientGroupIds_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getGroupInfoFromClientGroupIds", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupInfoFromClientGroupIds_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupInfoFromClientGroupIds", "(Ljava/util/List;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getGroupInfoFromGroupIds_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetGroupInfoFromGroupIds_Ljava_util_List_Handler ()
		{
			if (cb_getGroupInfoFromGroupIds_Ljava_util_List_ == null)
				cb_getGroupInfoFromGroupIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupInfoFromGroupIds_Ljava_util_List_);
			return cb_getGroupInfoFromGroupIds_Ljava_util_List_;
		}

		static IntPtr n_GetGroupInfoFromGroupIds_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.ToLocalJniHandle (__this.GetGroupInfoFromGroupIds (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupInfoFromGroupIds_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getGroupInfoFromGroupIds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getGroupInfoFromGroupIds", "(Ljava/util/List;)Ljava/util/List;", "GetGetGroupInfoFromGroupIds_Ljava_util_List_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> GetGroupInfoFromGroupIds (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getGroupInfoFromGroupIds_Ljava_util_List_ == IntPtr.Zero)
				id_getGroupInfoFromGroupIds_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getGroupInfoFromGroupIds", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupInfoFromGroupIds_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupInfoFromGroupIds", "(Ljava/util/List;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ == null)
				cb_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_);
			return cb_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_;
		}

		static IntPtr n_GetGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.ToLocalJniHandle (__this.GetGroupInfoFromGroupIds (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getGroupInfoFromGroupIds' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getGroupInfoFromGroupIds", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;", "GetGetGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> GetGroupInfoFromGroupIds (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getGroupInfoFromGroupIds", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupInfoFromGroupIds", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getGroupOfTwoReceiverUserId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetGroupOfTwoReceiverUserId_Ljava_lang_Integer_Handler ()
		{
			if (cb_getGroupOfTwoReceiverUserId_Ljava_lang_Integer_ == null)
				cb_getGroupOfTwoReceiverUserId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupOfTwoReceiverUserId_Ljava_lang_Integer_);
			return cb_getGroupOfTwoReceiverUserId_Ljava_lang_Integer_;
		}

		static IntPtr n_GetGroupOfTwoReceiverUserId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetGroupOfTwoReceiverUserId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupOfTwoReceiverUserId_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getGroupOfTwoReceiverUserId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getGroupOfTwoReceiverUserId", "(Ljava/lang/Integer;)Ljava/lang/String;", "GetGetGroupOfTwoReceiverUserId_Ljava_lang_Integer_Handler")]
		public virtual unsafe string GetGroupOfTwoReceiverUserId (global::Java.Lang.Integer p0)
		{
			if (id_getGroupOfTwoReceiverUserId_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getGroupOfTwoReceiverUserId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getGroupOfTwoReceiverUserId", "(Ljava/lang/Integer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupOfTwoReceiverUserId_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupOfTwoReceiverUserId", "(Ljava/lang/Integer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/channel/service/ChannelService;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/channel/service/ChannelService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getListOfUsersFromChannelUserMapper_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetListOfUsersFromChannelUserMapper_Ljava_lang_Integer_Handler ()
		{
			if (cb_getListOfUsersFromChannelUserMapper_Ljava_lang_Integer_ == null)
				cb_getListOfUsersFromChannelUserMapper_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetListOfUsersFromChannelUserMapper_Ljava_lang_Integer_);
			return cb_getListOfUsersFromChannelUserMapper_Ljava_lang_Integer_;
		}

		static IntPtr n_GetListOfUsersFromChannelUserMapper_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper>.ToLocalJniHandle (__this.GetListOfUsersFromChannelUserMapper (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getListOfUsersFromChannelUserMapper_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getListOfUsersFromChannelUserMapper' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getListOfUsersFromChannelUserMapper", "(Ljava/lang/Integer;)Ljava/util/List;", "GetGetListOfUsersFromChannelUserMapper_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> GetListOfUsersFromChannelUserMapper (global::Java.Lang.Integer p0)
		{
			if (id_getListOfUsersFromChannelUserMapper_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getListOfUsersFromChannelUserMapper_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getListOfUsersFromChannelUserMapper", "(Ljava/lang/Integer;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getListOfUsersFromChannelUserMapper_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListOfUsersFromChannelUserMapper", "(Ljava/lang/Integer;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_);
			return cb_getMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMembersFromContactGroup (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='getMembersFromContactGroup' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMembersFromContactGroup", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;", "GetGetMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeed GetMembersFromContactGroup (string p0, string p1)
		{
			if (id_getMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMembersFromContactGroup", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembersFromContactGroup_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMembersFromContactGroup", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_isUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_isUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_isUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static bool n_IsUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsUserAlreadyPresentInChannel (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='isUserAlreadyPresentInChannel' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("isUserAlreadyPresentInChannel", "(Ljava/lang/Integer;Ljava/lang/String;)Z", "GetIsUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsUserAlreadyPresentInChannel (global::Java.Lang.Integer p0, string p1)
		{
			if (id_isUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_isUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isUserAlreadyPresentInChannel", "(Ljava/lang/Integer;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUserAlreadyPresentInChannel_Ljava_lang_Integer_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUserAlreadyPresentInChannel", "(Ljava/lang/Integer;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_);
			return cb_isUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_IsUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsUserAlreadyPresentInChannel (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='isUserAlreadyPresentInChannel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isUserAlreadyPresentInChannel", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetIsUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsUserAlreadyPresentInChannel (string p0, string p1)
		{
			if (id_isUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isUserAlreadyPresentInChannel", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUserAlreadyPresentInChannel_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUserAlreadyPresentInChannel", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_leaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_leaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_leaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LeaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_leaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static IntPtr n_LeaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.LeaveMemberFromChannelProcess (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_leaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='leaveMemberFromChannelProcess' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("leaveMemberFromChannelProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;", "GetLeaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe string LeaveMemberFromChannelProcess (global::Java.Lang.Integer p0, string p1)
		{
			if (id_leaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_leaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "leaveMemberFromChannelProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_leaveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leaveMemberFromChannelProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_leaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_leaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_leaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LeaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_);
			return cb_leaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_LeaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.LeaveMemberFromChannelProcess (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_leaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='leaveMemberFromChannelProcess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("leaveMemberFromChannelProcess", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetLeaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string LeaveMemberFromChannelProcess (string p0, string p1)
		{
			if (id_leaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_leaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "leaveMemberFromChannelProcess", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_leaveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leaveMemberFromChannelProcess", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_muteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_;
#pragma warning disable 0169
		static Delegate GetMuteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_Handler ()
		{
			if (cb_muteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ == null)
				cb_muteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MuteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_);
			return cb_muteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_;
		}

		static IntPtr n_MuteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MuteNotifications (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_muteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='muteNotifications' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.notification.MuteNotificationRequest']]"
		[Register ("muteNotifications", "(Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetMuteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse MuteNotifications (global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest p0)
		{
			if (id_muteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ == IntPtr.Zero)
				id_muteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ = JNIEnv.GetMethodID (class_ref, "muteNotifications", "(Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_muteNotifications_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "muteNotifications", "(Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_processChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetProcessChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_Handler ()
		{
			if (cb_processChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_ == null)
				cb_processChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_);
			return cb_processChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_;
		}

		static IntPtr n_ProcessChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ProcessChannelDeleteConversation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_processChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='processChannelDeleteConversation' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[2][@type='android.content.Context']]"
		[Register ("processChannelDeleteConversation", "(Lcom/applozic/mobicommons/people/channel/Channel;Landroid/content/Context;)Ljava/lang/String;", "GetProcessChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_Handler")]
		public virtual unsafe string ProcessChannelDeleteConversation (global::Com.Applozic.Mobicommons.People.Channel.Channel p0, global::Android.Content.Context p1)
		{
			if (id_processChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_ == IntPtr.Zero)
				id_processChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "processChannelDeleteConversation", "(Lcom/applozic/mobicommons/people/channel/Channel;Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_processChannelDeleteConversation_Lcom_applozic_mobicommons_people_channel_Channel_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processChannelDeleteConversation", "(Lcom/applozic/mobicommons/people/channel/Channel;Landroid/content/Context;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_processChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z;
#pragma warning disable 0169
		static Delegate GetProcessChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_ZHandler ()
		{
			if (cb_processChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z == null)
				cb_processChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_ProcessChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z);
			return cb_processChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z;
		}

		static void n_ProcessChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessChannelFeed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_processChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='processChannelFeed' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.feed.ChannelFeed'] and parameter[2][@type='boolean']]"
		[Register ("processChannelFeed", "(Lcom/applozic/mobicomkit/feed/ChannelFeed;Z)V", "GetProcessChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_ZHandler")]
		public virtual unsafe void ProcessChannelFeed (global::Com.Applozic.Mobicomkit.Feed.ChannelFeed p0, bool p1)
		{
			if (id_processChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z == IntPtr.Zero)
				id_processChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z = JNIEnv.GetMethodID (class_ref, "processChannelFeed", "(Lcom/applozic/mobicomkit/feed/ChannelFeed;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processChannelFeed_Lcom_applozic_mobicomkit_feed_ChannelFeed_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processChannelFeed", "(Lcom/applozic/mobicomkit/feed/ChannelFeed;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z;
#pragma warning disable 0169
		static Delegate GetProcessChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_ZHandler ()
		{
			if (cb_processChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z == null)
				cb_processChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_ProcessChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z);
			return cb_processChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z;
		}

		static void n_ProcessChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed[] p0 = (global::Com.Applozic.Mobicomkit.Feed.ChannelFeed[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Applozic.Mobicomkit.Feed.ChannelFeed));
			__this.ProcessChannelFeedList (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_processChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='processChannelFeedList' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.feed.ChannelFeed[]'] and parameter[2][@type='boolean']]"
		[Register ("processChannelFeedList", "([Lcom/applozic/mobicomkit/feed/ChannelFeed;Z)V", "GetProcessChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_ZHandler")]
		public virtual unsafe void ProcessChannelFeedList (global::Com.Applozic.Mobicomkit.Feed.ChannelFeed[] p0, bool p1)
		{
			if (id_processChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z == IntPtr.Zero)
				id_processChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z = JNIEnv.GetMethodID (class_ref, "processChannelFeedList", "([Lcom/applozic/mobicomkit/feed/ChannelFeed;Z)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processChannelFeedList_arrayLcom_applozic_mobicomkit_feed_ChannelFeed_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processChannelFeedList", "([Lcom/applozic/mobicomkit/feed/ChannelFeed;Z)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_processChannelList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetProcessChannelList_Ljava_util_List_Handler ()
		{
			if (cb_processChannelList_Ljava_util_List_ == null)
				cb_processChannelList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessChannelList_Ljava_util_List_);
			return cb_processChannelList_Ljava_util_List_;
		}

		static void n_ProcessChannelList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessChannelList (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processChannelList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='processChannelList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.feed.ChannelFeed&gt;']]"
		[Register ("processChannelList", "(Ljava/util/List;)V", "GetProcessChannelList_Ljava_util_List_Handler")]
		public virtual unsafe void ProcessChannelList (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> p0)
		{
			if (id_processChannelList_Ljava_util_List_ == IntPtr.Zero)
				id_processChannelList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "processChannelList", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processChannelList_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processChannelList", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processIsUserPresentInChannel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetProcessIsUserPresentInChannel_Ljava_lang_Integer_Handler ()
		{
			if (cb_processIsUserPresentInChannel_Ljava_lang_Integer_ == null)
				cb_processIsUserPresentInChannel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ProcessIsUserPresentInChannel_Ljava_lang_Integer_);
			return cb_processIsUserPresentInChannel_Ljava_lang_Integer_;
		}

		static bool n_ProcessIsUserPresentInChannel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ProcessIsUserPresentInChannel (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_processIsUserPresentInChannel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='processIsUserPresentInChannel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("processIsUserPresentInChannel", "(Ljava/lang/Integer;)Z", "GetProcessIsUserPresentInChannel_Ljava_lang_Integer_Handler")]
		public virtual unsafe bool ProcessIsUserPresentInChannel (global::Java.Lang.Integer p0)
		{
			if (id_processIsUserPresentInChannel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_processIsUserPresentInChannel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "processIsUserPresentInChannel", "(Ljava/lang/Integer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_processIsUserPresentInChannel_Ljava_lang_Integer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processIsUserPresentInChannel", "(Ljava/lang/Integer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_processIsUserPresentInChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessIsUserPresentInChannel_Ljava_lang_String_Handler ()
		{
			if (cb_processIsUserPresentInChannel_Ljava_lang_String_ == null)
				cb_processIsUserPresentInChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ProcessIsUserPresentInChannel_Ljava_lang_String_);
			return cb_processIsUserPresentInChannel_Ljava_lang_String_;
		}

		static bool n_ProcessIsUserPresentInChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ProcessIsUserPresentInChannel (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_processIsUserPresentInChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='processIsUserPresentInChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("processIsUserPresentInChannel", "(Ljava/lang/String;)Z", "GetProcessIsUserPresentInChannel_Ljava_lang_String_Handler")]
		public virtual unsafe bool ProcessIsUserPresentInChannel (string p0)
		{
			if (id_processIsUserPresentInChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_processIsUserPresentInChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processIsUserPresentInChannel", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_processIsUserPresentInChannel_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processIsUserPresentInChannel", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_removeMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_removeMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_removeMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static IntPtr n_RemoveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.RemoveMemberFromChannelProcess (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='removeMemberFromChannelProcess' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMemberFromChannelProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;", "GetRemoveMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe string RemoveMemberFromChannelProcess (global::Java.Lang.Integer p0, string p1)
		{
			if (id_removeMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMemberFromChannelProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeMemberFromChannelProcess_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMemberFromChannelProcess", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_RemoveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.RemoveMemberFromChannelProcess (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='removeMemberFromChannelProcess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMemberFromChannelProcess", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetRemoveMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string RemoveMemberFromChannelProcess (string p0, string p1)
		{
			if (id_removeMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMemberFromChannelProcess", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeMemberFromChannelProcess_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMemberFromChannelProcess", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_syncChannels;
#pragma warning disable 0169
		static Delegate GetSyncChannelsHandler ()
		{
			if (cb_syncChannels == null)
				cb_syncChannels = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncChannels);
			return cb_syncChannels;
		}

		static void n_SyncChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncChannels ();
		}
#pragma warning restore 0169

		static IntPtr id_syncChannels;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='syncChannels' and count(parameter)=0]"
		[Register ("syncChannels", "()V", "GetSyncChannelsHandler")]
		public virtual unsafe void SyncChannels ()
		{
			if (id_syncChannels == IntPtr.Zero)
				id_syncChannels = JNIEnv.GetMethodID (class_ref, "syncChannels", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncChannels);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncChannels", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_;
#pragma warning disable 0169
		static Delegate GetUpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_Handler ()
		{
			if (cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ == null)
				cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_);
			return cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_;
		}

		static IntPtr n_UpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UpdateChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='updateChannel' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.feed.GroupInfoUpdate']]"
		[Register ("updateChannel", "(Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)Ljava/lang/String;", "GetUpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_Handler")]
		public virtual unsafe string UpdateChannel (global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate p0)
		{
			if (id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ == IntPtr.Zero)
				id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ = JNIEnv.GetMethodID (class_ref, "updateChannel", "(Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannel", "(Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetUpdateChannel_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateChannel_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_UpdateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateChannel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='updateChannel' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("updateChannel", "(Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetUpdateChannel_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe void UpdateChannel (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
		{
			if (id_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "updateChannel", "(Lcom/applozic/mobicommons/people/channel/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateChannel_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannel", "(Lcom/applozic/mobicommons/people/channel/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static void n_UpdateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateChannelLocalImageURI (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelService']/method[@name='updateChannelLocalImageURI' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateChannelLocalImageURI", "(Ljava/lang/Integer;Ljava/lang/String;)V", "GetUpdateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateChannelLocalImageURI (global::Java.Lang.Integer p0, string p1)
		{
			if (id_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateChannelLocalImageURI", "(Ljava/lang/Integer;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateChannelLocalImageURI_Ljava_lang_Integer_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannelLocalImageURI", "(Ljava/lang/Integer;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
