using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/image/ImageCache", DoNotGenerateAcw=true)]
	public partial class ImageCache : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache.RetainFragment']"
		[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/image/ImageCache$RetainFragment", DoNotGenerateAcw=true)]
		public partial class RetainFragment : global::Android.Support.V4.App.Fragment {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicommons/commons/image/ImageCache$RetainFragment", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RetainFragment); }
			}

			protected RetainFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache.RetainFragment']/constructor[@name='ImageCache.RetainFragment' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RetainFragment ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (RetainFragment)) {
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

			static Delegate cb_getObject;
#pragma warning disable 0169
			static Delegate GetGetObjectHandler ()
			{
				if (cb_getObject == null)
					cb_getObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObject);
				return cb_getObject;
			}

			static IntPtr n_GetObject (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Applozic.Mobicommons.Commons.Image.ImageCache.RetainFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.ImageCache.RetainFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Object);
			}
#pragma warning restore 0169

			static Delegate cb_setObject_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetSetObject_Ljava_lang_Object_Handler ()
			{
				if (cb_setObject_Ljava_lang_Object_ == null)
					cb_setObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetObject_Ljava_lang_Object_);
				return cb_setObject_Ljava_lang_Object_;
			}

			static void n_SetObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicommons.Commons.Image.ImageCache.RetainFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.ImageCache.RetainFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Object = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getObject;
			static IntPtr id_setObject_Ljava_lang_Object_;
			public virtual unsafe global::Java.Lang.Object Object {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache.RetainFragment']/method[@name='getObject' and count(parameter)=0]"
				[Register ("getObject", "()Ljava/lang/Object;", "GetGetObjectHandler")]
				get {
					if (id_getObject == IntPtr.Zero)
						id_getObject = JNIEnv.GetMethodID (class_ref, "getObject", "()Ljava/lang/Object;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getObject), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getObject", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache.RetainFragment']/method[@name='setObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
				[Register ("setObject", "(Ljava/lang/Object;)V", "GetSetObject_Ljava_lang_Object_Handler")]
				set {
					if (id_setObject_Ljava_lang_Object_ == IntPtr.Zero)
						id_setObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setObject", "(Ljava/lang/Object;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setObject_Ljava_lang_Object_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setObject", "(Ljava/lang/Object;)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/image/ImageCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageCache); }
		}

		protected ImageCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetAddBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ == null)
				cb_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_);
			return cb_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_;
		}

		static void n_AddBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicommons.Commons.Image.ImageCache __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.ImageCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddBitmapToCache (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache']/method[@name='addBitmapToCache' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("addBitmapToCache", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "GetAddBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void AddBitmapToCache (string p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "addBitmapToCache", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addBitmapToCache_Ljava_lang_String_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addBitmapToCache", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_calculateMemCacheSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache']/method[@name='calculateMemCacheSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("calculateMemCacheSize", "(F)I", "")]
		public static unsafe int CalculateMemCacheSize (float p0)
		{
			if (id_calculateMemCacheSize_F == IntPtr.Zero)
				id_calculateMemCacheSize_F = JNIEnv.GetStaticMethodID (class_ref, "calculateMemCacheSize", "(F)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_calculateMemCacheSize_F, __args);
			} finally {
			}
		}

		static IntPtr id_findOrCreateRetainFragment_Landroid_support_v4_app_FragmentManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache']/method[@name='findOrCreateRetainFragment' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.FragmentManager']]"
		[Register ("findOrCreateRetainFragment", "(Landroid/support/v4/app/FragmentManager;)Lcom/applozic/mobicommons/commons/image/ImageCache$RetainFragment;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.Commons.Image.ImageCache.RetainFragment FindOrCreateRetainFragment (global::Android.Support.V4.App.FragmentManager p0)
		{
			if (id_findOrCreateRetainFragment_Landroid_support_v4_app_FragmentManager_ == IntPtr.Zero)
				id_findOrCreateRetainFragment_Landroid_support_v4_app_FragmentManager_ = JNIEnv.GetStaticMethodID (class_ref, "findOrCreateRetainFragment", "(Landroid/support/v4/app/FragmentManager;)Lcom/applozic/mobicommons/commons/image/ImageCache$RetainFragment;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicommons.Commons.Image.ImageCache.RetainFragment __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.ImageCache.RetainFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_findOrCreateRetainFragment_Landroid_support_v4_app_FragmentManager_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getBitmapFromMemCache_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBitmapFromMemCache_Ljava_lang_String_Handler ()
		{
			if (cb_getBitmapFromMemCache_Ljava_lang_String_ == null)
				cb_getBitmapFromMemCache_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBitmapFromMemCache_Ljava_lang_String_);
			return cb_getBitmapFromMemCache_Ljava_lang_String_;
		}

		static IntPtr n_GetBitmapFromMemCache_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.Commons.Image.ImageCache __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.ImageCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBitmapFromMemCache (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBitmapFromMemCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache']/method[@name='getBitmapFromMemCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBitmapFromMemCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGetBitmapFromMemCache_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetBitmapFromMemCache (string p0)
		{
			if (id_getBitmapFromMemCache_Ljava_lang_String_ == IntPtr.Zero)
				id_getBitmapFromMemCache_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBitmapFromMemCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitmapFromMemCache_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmapFromMemCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getBitmapSize_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache']/method[@name='getBitmapSize' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getBitmapSize", "(Landroid/graphics/Bitmap;)I", "")]
		public static unsafe int GetBitmapSize (global::Android.Graphics.Bitmap p0)
		{
			if (id_getBitmapSize_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getBitmapSize_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "getBitmapSize", "(Landroid/graphics/Bitmap;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getBitmapSize_Landroid_graphics_Bitmap_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_support_v4_app_FragmentManager_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageCache']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='android.support.v4.app.FragmentManager'] and parameter[2][@type='float']]"
		[Register ("getInstance", "(Landroid/support/v4/app/FragmentManager;F)Lcom/applozic/mobicommons/commons/image/ImageCache;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.Commons.Image.ImageCache GetInstance (global::Android.Support.V4.App.FragmentManager p0, float p1)
		{
			if (id_getInstance_Landroid_support_v4_app_FragmentManager_F == IntPtr.Zero)
				id_getInstance_Landroid_support_v4_app_FragmentManager_F = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/support/v4/app/FragmentManager;F)Lcom/applozic/mobicommons/commons/image/ImageCache;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Applozic.Mobicommons.Commons.Image.ImageCache __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Image.ImageCache> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_support_v4_app_FragmentManager_F, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
