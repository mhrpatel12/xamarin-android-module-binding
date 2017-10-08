using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='PhotoDecodeRunnable']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/image/PhotoDecodeRunnable", DoNotGenerateAcw=true)]
	public partial class PhotoDecodeRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='PhotoDecodeRunnable']/field[@name='DECODE_STATE_COMPLETED']"
		[Register ("DECODE_STATE_COMPLETED")]
		public const int DecodeStateCompleted = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='PhotoDecodeRunnable']/field[@name='DECODE_STATE_FAILED']"
		[Register ("DECODE_STATE_FAILED")]
		public const int DecodeStateFailed = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='PhotoDecodeRunnable']/field[@name='DECODE_STATE_STARTED']"
		[Register ("DECODE_STATE_STARTED")]
		public const int DecodeStateStarted = (int) 0;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/interface[@name='PhotoDecodeRunnable.TaskRunnableDecodeMethods']"
		[Register ("com/applozic/mobicommons/commons/image/PhotoDecodeRunnable$TaskRunnableDecodeMethods", "", "Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable/ITaskRunnableDecodeMethodsInvoker")]
		public partial interface ITaskRunnableDecodeMethods : IJavaObject {

			string LocalPath {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/interface[@name='PhotoDecodeRunnable.TaskRunnableDecodeMethods']/method[@name='getLocalPath' and count(parameter)=0]"
				[Register ("getLocalPath", "()Ljava/lang/String;", "GetGetLocalPathHandler:Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable/ITaskRunnableDecodeMethodsInvoker, AndroidMobicomBindingProject")] get;
			}

			int TargetHeight {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/interface[@name='PhotoDecodeRunnable.TaskRunnableDecodeMethods']/method[@name='getTargetHeight' and count(parameter)=0]"
				[Register ("getTargetHeight", "()I", "GetGetTargetHeightHandler:Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable/ITaskRunnableDecodeMethodsInvoker, AndroidMobicomBindingProject")] get;
			}

			int TargetWidth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/interface[@name='PhotoDecodeRunnable.TaskRunnableDecodeMethods']/method[@name='getTargetWidth' and count(parameter)=0]"
				[Register ("getTargetWidth", "()I", "GetGetTargetWidthHandler:Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable/ITaskRunnableDecodeMethodsInvoker, AndroidMobicomBindingProject")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/interface[@name='PhotoDecodeRunnable.TaskRunnableDecodeMethods']/method[@name='handleDecodeState' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("handleDecodeState", "(I)V", "GetHandleDecodeState_IHandler:Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable/ITaskRunnableDecodeMethodsInvoker, AndroidMobicomBindingProject")]
			void HandleDecodeState (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/interface[@name='PhotoDecodeRunnable.TaskRunnableDecodeMethods']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setImage", "(Landroid/graphics/Bitmap;)V", "GetSetImage_Landroid_graphics_Bitmap_Handler:Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable/ITaskRunnableDecodeMethodsInvoker, AndroidMobicomBindingProject")]
			void SetImage (global::Android.Graphics.Bitmap p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/interface[@name='PhotoDecodeRunnable.TaskRunnableDecodeMethods']/method[@name='setImageDecodeThread' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
			[Register ("setImageDecodeThread", "(Ljava/lang/Thread;)V", "GetSetImageDecodeThread_Ljava_lang_Thread_Handler:Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable/ITaskRunnableDecodeMethodsInvoker, AndroidMobicomBindingProject")]
			void SetImageDecodeThread (global::Java.Lang.Thread p0);

		}

		[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/image/PhotoDecodeRunnable$TaskRunnableDecodeMethods", DoNotGenerateAcw=true)]
		internal class ITaskRunnableDecodeMethodsInvoker : global::Java.Lang.Object, ITaskRunnableDecodeMethods {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicommons/commons/image/PhotoDecodeRunnable$TaskRunnableDecodeMethods");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ITaskRunnableDecodeMethodsInvoker); }
			}

			IntPtr class_ref;

			public static ITaskRunnableDecodeMethods GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITaskRunnableDecodeMethods> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicommons.commons.image.PhotoDecodeRunnable.TaskRunnableDecodeMethods"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITaskRunnableDecodeMethodsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getLocalPath;
#pragma warning disable 0169
			static Delegate GetGetLocalPathHandler ()
			{
				if (cb_getLocalPath == null)
					cb_getLocalPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalPath);
				return cb_getLocalPath;
			}

			static IntPtr n_GetLocalPath (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.LocalPath);
			}
#pragma warning restore 0169

			IntPtr id_getLocalPath;
			public unsafe string LocalPath {
				get {
					if (id_getLocalPath == IntPtr.Zero)
						id_getLocalPath = JNIEnv.GetMethodID (class_ref, "getLocalPath", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalPath), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getTargetHeight;
#pragma warning disable 0169
			static Delegate GetGetTargetHeightHandler ()
			{
				if (cb_getTargetHeight == null)
					cb_getTargetHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTargetHeight);
				return cb_getTargetHeight;
			}

			static int n_GetTargetHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TargetHeight;
			}
#pragma warning restore 0169

			IntPtr id_getTargetHeight;
			public unsafe int TargetHeight {
				get {
					if (id_getTargetHeight == IntPtr.Zero)
						id_getTargetHeight = JNIEnv.GetMethodID (class_ref, "getTargetHeight", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTargetHeight);
				}
			}

			static Delegate cb_getTargetWidth;
#pragma warning disable 0169
			static Delegate GetGetTargetWidthHandler ()
			{
				if (cb_getTargetWidth == null)
					cb_getTargetWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTargetWidth);
				return cb_getTargetWidth;
			}

			static int n_GetTargetWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.TargetWidth;
			}
#pragma warning restore 0169

			IntPtr id_getTargetWidth;
			public unsafe int TargetWidth {
				get {
					if (id_getTargetWidth == IntPtr.Zero)
						id_getTargetWidth = JNIEnv.GetMethodID (class_ref, "getTargetWidth", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTargetWidth);
				}
			}

			static Delegate cb_handleDecodeState_I;
#pragma warning disable 0169
			static Delegate GetHandleDecodeState_IHandler ()
			{
				if (cb_handleDecodeState_I == null)
					cb_handleDecodeState_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_HandleDecodeState_I);
				return cb_handleDecodeState_I;
			}

			static void n_HandleDecodeState_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.HandleDecodeState (p0);
			}
#pragma warning restore 0169

			IntPtr id_handleDecodeState_I;
			public unsafe void HandleDecodeState (int p0)
			{
				if (id_handleDecodeState_I == IntPtr.Zero)
					id_handleDecodeState_I = JNIEnv.GetMethodID (class_ref, "handleDecodeState", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleDecodeState_I, __args);
			}

			static Delegate cb_setImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetSetImage_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_setImage_Landroid_graphics_Bitmap_ == null)
					cb_setImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Landroid_graphics_Bitmap_);
				return cb_setImage_Landroid_graphics_Bitmap_;
			}

			static void n_SetImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetImage (p0);
			}
#pragma warning restore 0169

			IntPtr id_setImage_Landroid_graphics_Bitmap_;
			public unsafe void SetImage (global::Android.Graphics.Bitmap p0)
			{
				if (id_setImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_setImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Landroid_graphics_Bitmap_, __args);
			}

			static Delegate cb_setImageDecodeThread_Ljava_lang_Thread_;
#pragma warning disable 0169
			static Delegate GetSetImageDecodeThread_Ljava_lang_Thread_Handler ()
			{
				if (cb_setImageDecodeThread_Ljava_lang_Thread_ == null)
					cb_setImageDecodeThread_Ljava_lang_Thread_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageDecodeThread_Ljava_lang_Thread_);
				return cb_setImageDecodeThread_Ljava_lang_Thread_;
			}

			static void n_SetImageDecodeThread_Ljava_lang_Thread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetImageDecodeThread (p0);
			}
#pragma warning restore 0169

			IntPtr id_setImageDecodeThread_Ljava_lang_Thread_;
			public unsafe void SetImageDecodeThread (global::Java.Lang.Thread p0)
			{
				if (id_setImageDecodeThread_Ljava_lang_Thread_ == IntPtr.Zero)
					id_setImageDecodeThread_Ljava_lang_Thread_ = JNIEnv.GetMethodID (class_ref, "setImageDecodeThread", "(Ljava/lang/Thread;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageDecodeThread_Ljava_lang_Thread_, __args);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/image/PhotoDecodeRunnable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PhotoDecodeRunnable); }
		}

		protected PhotoDecodeRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_applozic_mobicommons_commons_image_PhotoDecodeRunnable_TaskRunnableDecodeMethods_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='PhotoDecodeRunnable']/constructor[@name='PhotoDecodeRunnable' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.commons.image.PhotoDecodeRunnable.TaskRunnableDecodeMethods']]"
		[Register (".ctor", "(Lcom/applozic/mobicommons/commons/image/PhotoDecodeRunnable$TaskRunnableDecodeMethods;)V", "")]
		public unsafe PhotoDecodeRunnable (global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PhotoDecodeRunnable)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/applozic/mobicommons/commons/image/PhotoDecodeRunnable$TaskRunnableDecodeMethods;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/applozic/mobicommons/commons/image/PhotoDecodeRunnable$TaskRunnableDecodeMethods;)V", __args);
					return;
				}

				if (id_ctor_Lcom_applozic_mobicommons_commons_image_PhotoDecodeRunnable_TaskRunnableDecodeMethods_ == IntPtr.Zero)
					id_ctor_Lcom_applozic_mobicommons_commons_image_PhotoDecodeRunnable_TaskRunnableDecodeMethods_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicommons/commons/image/PhotoDecodeRunnable$TaskRunnableDecodeMethods;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicommons_commons_image_PhotoDecodeRunnable_TaskRunnableDecodeMethods_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicommons_commons_image_PhotoDecodeRunnable_TaskRunnableDecodeMethods_, __args);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='PhotoDecodeRunnable']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

	}
}
