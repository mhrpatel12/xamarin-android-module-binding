using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Attachment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/attachment/FileClientService", DoNotGenerateAcw=true)]
	public partial class FileClientService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/field[@name='AL_UPLOAD_FILE_URL']"
		[Register ("AL_UPLOAD_FILE_URL")]
		public const string AlUploadFileUrl = (string) "/rest/ws/upload/file";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/field[@name='IMAGE_DIR']"
		[Register ("IMAGE_DIR")]
		public const string ImageDir = (string) "image";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/field[@name='MOBI_COM_CONTACT_FOLDER']"
		[Register ("MOBI_COM_CONTACT_FOLDER")]
		public const string MobiComContactFolder = (string) "/contact";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/field[@name='MOBI_COM_IMAGES_FOLDER']"
		[Register ("MOBI_COM_IMAGES_FOLDER")]
		public const string MobiComImagesFolder = (string) "/image";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/field[@name='MOBI_COM_OTHER_FILES_FOLDER']"
		[Register ("MOBI_COM_OTHER_FILES_FOLDER")]
		public const string MobiComOtherFilesFolder = (string) "/other";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/field[@name='MOBI_COM_THUMBNAIL_SUFIX']"
		[Register ("MOBI_COM_THUMBNAIL_SUFIX")]
		public const string MobiComThumbnailSufix = (string) "/.Thumbnail";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/field[@name='MOBI_COM_VIDEOS_FOLDER']"
		[Register ("MOBI_COM_VIDEOS_FOLDER")]
		public const string MobiComVideosFolder = (string) "/video";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/attachment/FileClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileClientService); }
		}

		protected FileClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/constructor[@name='FileClientService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe FileClientService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FileClientService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getFileUploadUrl;
#pragma warning disable 0169
		static Delegate GetGetFileUploadUrlHandler ()
		{
			if (cb_getFileUploadUrl == null)
				cb_getFileUploadUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileUploadUrl);
			return cb_getFileUploadUrl;
		}

		static IntPtr n_GetFileUploadUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileUploadUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getFileUploadUrl;
		public virtual unsafe string FileUploadUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='getFileUploadUrl' and count(parameter)=0]"
			[Register ("getFileUploadUrl", "()Ljava/lang/String;", "GetGetFileUploadUrlHandler")]
			get {
				if (id_getFileUploadUrl == IntPtr.Zero)
					id_getFileUploadUrl = JNIEnv.GetMethodID (class_ref, "getFileUploadUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileUploadUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileUploadUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUploadKey;
#pragma warning disable 0169
		static Delegate GetGetUploadKeyHandler ()
		{
			if (cb_getUploadKey == null)
				cb_getUploadKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUploadKey);
			return cb_getUploadKey;
		}

		static IntPtr n_GetUploadKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UploadKey);
		}
#pragma warning restore 0169

		static IntPtr id_getUploadKey;
		public virtual unsafe string UploadKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='getUploadKey' and count(parameter)=0]"
			[Register ("getUploadKey", "()Ljava/lang/String;", "GetGetUploadKeyHandler")]
			get {
				if (id_getUploadKey == IntPtr.Zero)
					id_getUploadKey = JNIEnv.GetMethodID (class_ref, "getUploadKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUploadKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUploadKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createAndSaveVideoThumbnail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateAndSaveVideoThumbnail_Ljava_lang_String_Handler ()
		{
			if (cb_createAndSaveVideoThumbnail_Ljava_lang_String_ == null)
				cb_createAndSaveVideoThumbnail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAndSaveVideoThumbnail_Ljava_lang_String_);
			return cb_createAndSaveVideoThumbnail_Ljava_lang_String_;
		}

		static IntPtr n_CreateAndSaveVideoThumbnail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAndSaveVideoThumbnail (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAndSaveVideoThumbnail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='createAndSaveVideoThumbnail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createAndSaveVideoThumbnail", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetCreateAndSaveVideoThumbnail_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap CreateAndSaveVideoThumbnail (string p0)
		{
			if (id_createAndSaveVideoThumbnail_Ljava_lang_String_ == IntPtr.Zero)
				id_createAndSaveVideoThumbnail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createAndSaveVideoThumbnail", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAndSaveVideoThumbnail_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAndSaveVideoThumbnail", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_downloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetDownloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_downloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_downloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_downloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static IntPtr n_DownloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DownloadBitmap (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_downloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='downloadBitmap' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("downloadBitmap", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)Landroid/graphics/Bitmap;", "GetDownloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap DownloadBitmap (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1)
		{
			if (id_downloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_downloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "downloadBitmap", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_downloadBitmap_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadBitmap", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_downloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_;
#pragma warning disable 0169
		static Delegate GetDownloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_Handler ()
		{
			if (cb_downloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_ == null)
				cb_downloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_);
			return cb_downloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_;
		}

		static IntPtr n_DownloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DownloadProductImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_downloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='downloadProductImage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation']]"
		[Register ("downloadProductImage", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Landroid/graphics/Bitmap;", "GetDownloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap DownloadProductImage (global::Com.Applozic.Mobicommons.People.Channel.Conversation p0)
		{
			if (id_downloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_ == IntPtr.Zero)
				id_downloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNIEnv.GetMethodID (class_ref, "downloadProductImage", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_downloadProductImage_Lcom_applozic_mobicommons_people_channel_Conversation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadProductImage", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFilePath_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='getFilePath' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String']]"
		[Register ("getFilePath", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetFilePath (string p0, global::Android.Content.Context p1, string p2)
		{
			if (id_getFilePath_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getFilePath_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFilePath", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFilePath_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getFilePath_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='getFilePath' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("getFilePath", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;Z)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetFilePath (string p0, global::Android.Content.Context p1, string p2, bool p3)
		{
			if (id_getFilePath_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_getFilePath_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getFilePath", "(Ljava/lang/String;Landroid/content/Context;Ljava/lang/String;Z)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFilePath_Ljava_lang_String_Landroid_content_Context_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_loadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetLoadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_loadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_loadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_loadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_LoadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadContactsvCard (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='loadContactsvCard' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("loadContactsvCard", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetLoadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void LoadContactsvCard (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_loadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_loadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "loadContactsvCard", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadContactsvCard_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadContactsvCard", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_loadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_;
#pragma warning disable 0169
		static Delegate GetLoadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_Handler ()
		{
			if (cb_loadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_ == null)
				cb_loadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_);
			return cb_loadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_;
		}

		static IntPtr n_LoadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadMessageImage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='loadMessageImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Conversation']]"
		[Register ("loadMessageImage", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Conversation;)Landroid/graphics/Bitmap;", "GetLoadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap LoadMessageImage (global::Android.Content.Context p0, global::Com.Applozic.Mobicommons.People.Channel.Conversation p1)
		{
			if (id_loadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_ == IntPtr.Zero)
				id_loadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNIEnv.GetMethodID (class_ref, "loadMessageImage", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Conversation;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadMessageImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Conversation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadMessageImage", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Conversation;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_loadMessageImage_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadMessageImage_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_loadMessageImage_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_loadMessageImage_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadMessageImage_Landroid_content_Context_Ljava_lang_String_);
			return cb_loadMessageImage_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_LoadMessageImage_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadMessageImage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadMessageImage_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='loadMessageImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("loadMessageImage", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetLoadMessageImage_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap LoadMessageImage (global::Android.Content.Context p0, string p1)
		{
			if (id_loadMessageImage_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_loadMessageImage_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadMessageImage", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadMessageImage_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadMessageImage", "(Landroid/content/Context;Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_loadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II;
#pragma warning disable 0169
		static Delegate GetLoadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_IIHandler ()
		{
			if (cb_loadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II == null)
				cb_loadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_LoadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II);
			return cb_loadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II;
		}

		static IntPtr n_LoadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadThumbnailImage (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='loadThumbnailImage' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("loadThumbnailImage", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/Message;II)Landroid/graphics/Bitmap;", "GetLoadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_IIHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap LoadThumbnailImage (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1, int p2, int p3)
		{
			if (id_loadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II == IntPtr.Zero)
				id_loadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II = JNIEnv.GetMethodID (class_ref, "loadThumbnailImage", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/Message;II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadThumbnailImage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadThumbnailImage", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/Message;II)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_profileImageUploadURL;
#pragma warning disable 0169
		static Delegate GetProfileImageUploadURLHandler ()
		{
			if (cb_profileImageUploadURL == null)
				cb_profileImageUploadURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ProfileImageUploadURL);
			return cb_profileImageUploadURL;
		}

		static IntPtr n_ProfileImageUploadURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfileImageUploadURL ());
		}
#pragma warning restore 0169

		static IntPtr id_profileImageUploadURL;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='profileImageUploadURL' and count(parameter)=0]"
		[Register ("profileImageUploadURL", "()Ljava/lang/String;", "GetProfileImageUploadURLHandler")]
		public virtual unsafe string ProfileImageUploadURL ()
		{
			if (id_profileImageUploadURL == IntPtr.Zero)
				id_profileImageUploadURL = JNIEnv.GetMethodID (class_ref, "profileImageUploadURL", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_profileImageUploadURL), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "profileImageUploadURL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_uploadBlobImage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUploadBlobImage_Ljava_lang_String_Handler ()
		{
			if (cb_uploadBlobImage_Ljava_lang_String_ == null)
				cb_uploadBlobImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadBlobImage_Ljava_lang_String_);
			return cb_uploadBlobImage_Ljava_lang_String_;
		}

		static IntPtr n_UploadBlobImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UploadBlobImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_uploadBlobImage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='uploadBlobImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uploadBlobImage", "(Ljava/lang/String;)Ljava/lang/String;", "GetUploadBlobImage_Ljava_lang_String_Handler")]
		public virtual unsafe string UploadBlobImage (string p0)
		{
			if (id_uploadBlobImage_Ljava_lang_String_ == IntPtr.Zero)
				id_uploadBlobImage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "uploadBlobImage", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uploadBlobImage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uploadBlobImage", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_uploadProfileImage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUploadProfileImage_Ljava_lang_String_Handler ()
		{
			if (cb_uploadProfileImage_Ljava_lang_String_ == null)
				cb_uploadProfileImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UploadProfileImage_Ljava_lang_String_);
			return cb_uploadProfileImage_Ljava_lang_String_;
		}

		static IntPtr n_UploadProfileImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UploadProfileImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_uploadProfileImage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='uploadProfileImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("uploadProfileImage", "(Ljava/lang/String;)Ljava/lang/String;", "GetUploadProfileImage_Ljava_lang_String_Handler")]
		public virtual unsafe string UploadProfileImage (string p0)
		{
			if (id_uploadProfileImage_Ljava_lang_String_ == IntPtr.Zero)
				id_uploadProfileImage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "uploadProfileImage", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uploadProfileImage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uploadProfileImage", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_writeFile_Landroid_net_Uri_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetWriteFile_Landroid_net_Uri_Ljava_io_File_Handler ()
		{
			if (cb_writeFile_Landroid_net_Uri_Ljava_io_File_ == null)
				cb_writeFile_Landroid_net_Uri_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteFile_Landroid_net_Uri_Ljava_io_File_);
			return cb_writeFile_Landroid_net_Uri_Ljava_io_File_;
		}

		static void n_WriteFile_Landroid_net_Uri_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WriteFile (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeFile_Landroid_net_Uri_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='FileClientService']/method[@name='writeFile' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.io.File']]"
		[Register ("writeFile", "(Landroid/net/Uri;Ljava/io/File;)V", "GetWriteFile_Landroid_net_Uri_Ljava_io_File_Handler")]
		public virtual unsafe void WriteFile (global::Android.Net.Uri p0, global::Java.IO.File p1)
		{
			if (id_writeFile_Landroid_net_Uri_Ljava_io_File_ == IntPtr.Zero)
				id_writeFile_Landroid_net_Uri_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "writeFile", "(Landroid/net/Uri;Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeFile_Landroid_net_Uri_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeFile", "(Landroid/net/Uri;Ljava/io/File;)V"), __args);
			} finally {
			}
		}

	}
}
