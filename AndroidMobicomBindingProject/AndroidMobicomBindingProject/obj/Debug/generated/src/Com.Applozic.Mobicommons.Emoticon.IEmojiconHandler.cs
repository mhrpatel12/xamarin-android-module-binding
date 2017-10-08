using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Emoticon {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicommons.emoticon']/interface[@name='EmojiconHandler']"
	[Register ("com/applozic/mobicommons/emoticon/EmojiconHandler", "", "Com.Applozic.Mobicommons.Emoticon.IEmojiconHandlerInvoker")]
	public partial interface IEmojiconHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.emoticon']/interface[@name='EmojiconHandler']/method[@name='addEmojis' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.text.Spannable'] and parameter[3][@type='int']]"
		[Register ("addEmojis", "(Landroid/content/Context;Landroid/text/Spannable;I)V", "GetAddEmojis_Landroid_content_Context_Landroid_text_Spannable_IHandler:Com.Applozic.Mobicommons.Emoticon.IEmojiconHandlerInvoker, AndroidMobicomBindingProject")]
		void AddEmojis (global::Android.Content.Context p0, global::Android.Text.ISpannable p1, int p2);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicommons/emoticon/EmojiconHandler", DoNotGenerateAcw=true)]
	internal class IEmojiconHandlerInvoker : global::Java.Lang.Object, IEmojiconHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicommons/emoticon/EmojiconHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEmojiconHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IEmojiconHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEmojiconHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicommons.emoticon.EmojiconHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEmojiconHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addEmojis_Landroid_content_Context_Landroid_text_Spannable_I;
#pragma warning disable 0169
		static Delegate GetAddEmojis_Landroid_content_Context_Landroid_text_Spannable_IHandler ()
		{
			if (cb_addEmojis_Landroid_content_Context_Landroid_text_Spannable_I == null)
				cb_addEmojis_Landroid_content_Context_Landroid_text_Spannable_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_AddEmojis_Landroid_content_Context_Landroid_text_Spannable_I);
			return cb_addEmojis_Landroid_content_Context_Landroid_text_Spannable_I;
		}

		static void n_AddEmojis_Landroid_content_Context_Landroid_text_Spannable_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Com.Applozic.Mobicommons.Emoticon.IEmojiconHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Emoticon.IEmojiconHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Text.ISpannable p1 = (global::Android.Text.ISpannable)global::Java.Lang.Object.GetObject<global::Android.Text.ISpannable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddEmojis (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_addEmojis_Landroid_content_Context_Landroid_text_Spannable_I;
		public unsafe void AddEmojis (global::Android.Content.Context p0, global::Android.Text.ISpannable p1, int p2)
		{
			if (id_addEmojis_Landroid_content_Context_Landroid_text_Spannable_I == IntPtr.Zero)
				id_addEmojis_Landroid_content_Context_Landroid_text_Spannable_I = JNIEnv.GetMethodID (class_ref, "addEmojis", "(Landroid/content/Context;Landroid/text/Spannable;I)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addEmojis_Landroid_content_Context_Landroid_text_Spannable_I, __args);
		}

	}

}
