using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/stat/Stat", DoNotGenerateAcw=true)]
	public partial class Stat : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/stat/Stat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Stat); }
		}

		protected Stat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']/constructor[@name='Stat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Stat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Stat)) {
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

		static Delegate cb_getNormalSmsCount;
#pragma warning disable 0169
		static Delegate GetGetNormalSmsCountHandler ()
		{
			if (cb_getNormalSmsCount == null)
				cb_getNormalSmsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNormalSmsCount);
			return cb_getNormalSmsCount;
		}

		static int n_GetNormalSmsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NormalSmsCount;
		}
#pragma warning restore 0169

		static Delegate cb_setNormalSmsCount_I;
#pragma warning disable 0169
		static Delegate GetSetNormalSmsCount_IHandler ()
		{
			if (cb_setNormalSmsCount_I == null)
				cb_setNormalSmsCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNormalSmsCount_I);
			return cb_setNormalSmsCount_I;
		}

		static void n_SetNormalSmsCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NormalSmsCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNormalSmsCount;
		static IntPtr id_setNormalSmsCount_I;
		public virtual unsafe int NormalSmsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']/method[@name='getNormalSmsCount' and count(parameter)=0]"
			[Register ("getNormalSmsCount", "()I", "GetGetNormalSmsCountHandler")]
			get {
				if (id_getNormalSmsCount == IntPtr.Zero)
					id_getNormalSmsCount = JNIEnv.GetMethodID (class_ref, "getNormalSmsCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNormalSmsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNormalSmsCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']/method[@name='setNormalSmsCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNormalSmsCount", "(I)V", "GetSetNormalSmsCount_IHandler")]
			set {
				if (id_setNormalSmsCount_I == IntPtr.Zero)
					id_setNormalSmsCount_I = JNIEnv.GetMethodID (class_ref, "setNormalSmsCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNormalSmsCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNormalSmsCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelfDestructSmsCount;
#pragma warning disable 0169
		static Delegate GetGetSelfDestructSmsCountHandler ()
		{
			if (cb_getSelfDestructSmsCount == null)
				cb_getSelfDestructSmsCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelfDestructSmsCount);
			return cb_getSelfDestructSmsCount;
		}

		static int n_GetSelfDestructSmsCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelfDestructSmsCount;
		}
#pragma warning restore 0169

		static Delegate cb_setSelfDestructSmsCount_I;
#pragma warning disable 0169
		static Delegate GetSetSelfDestructSmsCount_IHandler ()
		{
			if (cb_setSelfDestructSmsCount_I == null)
				cb_setSelfDestructSmsCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelfDestructSmsCount_I);
			return cb_setSelfDestructSmsCount_I;
		}

		static void n_SetSelfDestructSmsCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelfDestructSmsCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelfDestructSmsCount;
		static IntPtr id_setSelfDestructSmsCount_I;
		public virtual unsafe int SelfDestructSmsCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']/method[@name='getSelfDestructSmsCount' and count(parameter)=0]"
			[Register ("getSelfDestructSmsCount", "()I", "GetGetSelfDestructSmsCountHandler")]
			get {
				if (id_getSelfDestructSmsCount == IntPtr.Zero)
					id_getSelfDestructSmsCount = JNIEnv.GetMethodID (class_ref, "getSelfDestructSmsCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelfDestructSmsCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelfDestructSmsCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']/method[@name='setSelfDestructSmsCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelfDestructSmsCount", "(I)V", "GetSetSelfDestructSmsCount_IHandler")]
			set {
				if (id_setSelfDestructSmsCount_I == IntPtr.Zero)
					id_setSelfDestructSmsCount_I = JNIEnv.GetMethodID (class_ref, "setSelfDestructSmsCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelfDestructSmsCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelfDestructSmsCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSmsTypeId;
#pragma warning disable 0169
		static Delegate GetGetSmsTypeIdHandler ()
		{
			if (cb_getSmsTypeId == null)
				cb_getSmsTypeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSmsTypeId);
			return cb_getSmsTypeId;
		}

		static IntPtr n_GetSmsTypeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SmsTypeId);
		}
#pragma warning restore 0169

		static Delegate cb_setSmsTypeId_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetSmsTypeId_Ljava_lang_Short_Handler ()
		{
			if (cb_setSmsTypeId_Ljava_lang_Short_ == null)
				cb_setSmsTypeId_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSmsTypeId_Ljava_lang_Short_);
			return cb_setSmsTypeId_Ljava_lang_Short_;
		}

		static void n_SetSmsTypeId_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SmsTypeId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSmsTypeId;
		static IntPtr id_setSmsTypeId_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short SmsTypeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']/method[@name='getSmsTypeId' and count(parameter)=0]"
			[Register ("getSmsTypeId", "()Ljava/lang/Short;", "GetGetSmsTypeIdHandler")]
			get {
				if (id_getSmsTypeId == IntPtr.Zero)
					id_getSmsTypeId = JNIEnv.GetMethodID (class_ref, "getSmsTypeId", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSmsTypeId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSmsTypeId", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']/method[@name='setSmsTypeId' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setSmsTypeId", "(Ljava/lang/Short;)V", "GetSetSmsTypeId_Ljava_lang_Short_Handler")]
			set {
				if (id_setSmsTypeId_Ljava_lang_Short_ == IntPtr.Zero)
					id_setSmsTypeId_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setSmsTypeId", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSmsTypeId_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmsTypeId", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSourceId;
#pragma warning disable 0169
		static Delegate GetGetSourceIdHandler ()
		{
			if (cb_getSourceId == null)
				cb_getSourceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourceId);
			return cb_getSourceId;
		}

		static IntPtr n_GetSourceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceId);
		}
#pragma warning restore 0169

		static Delegate cb_setSourceId_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetSourceId_Ljava_lang_Short_Handler ()
		{
			if (cb_setSourceId_Ljava_lang_Short_ == null)
				cb_setSourceId_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSourceId_Ljava_lang_Short_);
			return cb_setSourceId_Ljava_lang_Short_;
		}

		static void n_SetSourceId_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SourceId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSourceId;
		static IntPtr id_setSourceId_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short SourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']/method[@name='getSourceId' and count(parameter)=0]"
			[Register ("getSourceId", "()Ljava/lang/Short;", "GetGetSourceIdHandler")]
			get {
				if (id_getSourceId == IntPtr.Zero)
					id_getSourceId = JNIEnv.GetMethodID (class_ref, "getSourceId", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSourceId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSourceId", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='Stat']/method[@name='setSourceId' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setSourceId", "(Ljava/lang/Short;)V", "GetSetSourceId_Ljava_lang_Short_Handler")]
			set {
				if (id_setSourceId_Ljava_lang_Short_ == IntPtr.Zero)
					id_setSourceId_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setSourceId", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSourceId_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSourceId", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

	}
}
