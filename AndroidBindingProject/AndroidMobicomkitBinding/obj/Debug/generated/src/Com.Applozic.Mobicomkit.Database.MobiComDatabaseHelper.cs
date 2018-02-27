using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/database/MobiComDatabaseHelper", DoNotGenerateAcw=true)]
	public partial class MobiComDatabaseHelper : global::Android.Database.Sqlite.SQLiteOpenHelper {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='ADMIN_ID']"
		[Register ("ADMIN_ID")]
		public const string AdminId = (string) "adminId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='APPLICATION_ID']"
		[Register ("APPLICATION_ID")]
		public const string ApplicationId = (string) "applicationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='BLOCKED']"
		[Register ("BLOCKED")]
		public const string Blocked = (string) "blocked";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='BLOCKED_BY']"
		[Register ("BLOCKED_BY")]
		public const string BlockedBy = (string) "blockedBy";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CHANNEL']"
		[Register ("CHANNEL")]
		public const string Channel = (string) "channel";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CHANNEL_DISPLAY_NAME']"
		[Register ("CHANNEL_DISPLAY_NAME")]
		public const string ChannelDisplayName = (string) "channelName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CHANNEL_IMAGE_LOCAL_URI']"
		[Register ("CHANNEL_IMAGE_LOCAL_URI")]
		public const string ChannelImageLocalUri = (string) "channelImageLocalURI";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CHANNEL_IMAGE_URL']"
		[Register ("CHANNEL_IMAGE_URL")]
		public const string ChannelImageUrl = (string) "channelImageURL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CHANNEL_KEY']"
		[Register ("CHANNEL_KEY")]
		public const string ChannelKey = (string) "channelKey";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CHANNEL_META_DATA']"
		[Register ("CHANNEL_META_DATA")]
		public const string ChannelMetaData = (string) "channelMetadata";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CHANNEL_USER_X']"
		[Register ("CHANNEL_USER_X")]
		public const string ChannelUserX = (string) "channel_User_X";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CLIENT_GROUP_ID']"
		[Register ("CLIENT_GROUP_ID")]
		public const string ClientGroupId = (string) "clientGroupId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CONNECTED']"
		[Register ("CONNECTED")]
		public const string Connected = (string) "connected";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CONTACTID']"
		[Register ("CONTACTID")]
		public const string Contactid = (string) "contactId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CONTACT_IMAGE_LOCAL_URI']"
		[Register ("CONTACT_IMAGE_LOCAL_URI")]
		public const string ContactImageLocalUri = (string) "contactImageLocalURI";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CONTACT_IMAGE_URL']"
		[Register ("CONTACT_IMAGE_URL")]
		public const string ContactImageUrl = (string) "contactImageURL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CONTACT_NO']"
		[Register ("CONTACT_NO")]
		public const string ContactNo = (string) "contactNO";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CONTACT_TABLE_NAME']"
		[Register ("CONTACT_TABLE_NAME")]
		public const string ContactTableName = (string) "contact";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CONTACT_TYPE']"
		[Register ("CONTACT_TYPE")]
		public const string ContactType = (string) "contactType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CONVERSATION']"
		[Register ("CONVERSATION")]
		public const string Conversation = (string) "conversation";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CONVERSATION_ID']"
		[Register ("CONVERSATION_ID")]
		public const string ConversationId = (string) "conversationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CREATED']"
		[Register ("CREATED")]
		public const string Created = (string) "created";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CREATE_SCHEDULE_SMS_TABLE']"
		[Register ("CREATE_SCHEDULE_SMS_TABLE")]
		public const string CreateScheduleSmsTable = (string) "create table ScheduleSMS( _id integer primary key autoincrement  ,sms text not null, timeStamp INTEGER ,toField varchar(20) not null, SMSType varchar(20) not null ,contactId varchar(20) , smsKeyString varChar(50), storeOnDevice INTEGER DEFAULT 1, source INTEGER, timeToLive integer) ;";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='CREATE_SMS_TABLE']"
		[Register ("CREATE_SMS_TABLE")]
		public const string CreateSmsTable = (string) "create table sms ( id integer primary key autoincrement, keyString var(100), toNumbers varchar(1000), contactNumbers varchar(2000), message text not null, type integer, read integer default 0, delivered integer default 0, storeOnDevice integer default 1, sentToServer integer default 1, createdAt integer, scheduledAt integer, source integer, timeToLive integer, fileMetaKeyStrings varchar(2000), filePaths varchar(2000), metadata varchar(2000), thumbnailUrl varchar(2000), size integer, name varchar(2000), contentType varchar(200), metaFileKeyString varchar(2000), blobKeyString varchar(2000), canceled integer default 0, deleted integer default 0,applicationId varchar(2000) null,messageContentType integer default 0,conversationId integer default 0,topicId varchar(300) null,channelKey integer default 0,status varchar(200) default 0,clientGroupId varchar(1000) default null,hidden integer default 0,replyMessage INTEGER default 0,url varchar(2000),UNIQUE (keyString,contactNumbers,channelKey))";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='DB_VERSION']"
		[Register ("DB_VERSION")]
		public const int DbVersion = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='DELETED_AT']"
		[Register ("DELETED_AT")]
		public const string DeletedAt = (string) "deletedAtTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='DISPLAY_NAME']"
		[Register ("DISPLAY_NAME")]
		public const string DisplayName = (string) "displayName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='EMAIL']"
		[Register ("EMAIL")]
		public const string Email = (string) "email";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='FULL_NAME']"
		[Register ("FULL_NAME")]
		public const string FullName = (string) "fullName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='HIDDEN']"
		[Register ("HIDDEN")]
		public const string Hidden = (string) "hidden";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='INSERT_INTO_SMS_FROM_SMS_BACKUP_QUERY']"
		[Register ("INSERT_INTO_SMS_FROM_SMS_BACKUP_QUERY")]
		public const string InsertIntoSmsFromSmsBackupQuery = (string) "INSERT INTO sms (id,keyString,toNumbers,contactNumbers,message,type,read,delivered,storeOnDevice,sentToServer,createdAt,scheduledAt,source,timeToLive,fileMetaKeyStrings,filePaths,metadata,thumbnailUrl,size,name,contentType,metaFileKeyString,blobKeyString,canceled,deleted,applicationId,messageContentType,conversationId,topicId,channelKey,status,hidden,replyMessage,url) SELECT id,keyString,toNumbers,contactNumbers,message,type,read,delivered,storeOnDevice,sentToServer,createdAt,scheduledAt,source,timeToLive,fileMetaKeyStrings,filePaths,metadata,thumbnailUrl,size,name,contentType,metaFileKeyString,blobKeyString,canceled,deleted,applicationId,messageContentType,conversationId,topicId,channelKey,status,hidden,replyMessage,url FROM sms_backup";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='KEY']"
		[Register ("KEY")]
		public const string Key = (string) "key";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='LAST_MESSAGED_AT']"
		[Register ("LAST_MESSAGED_AT")]
		public const string LastMessagedAt = (string) "lastMessagedAt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='LAST_SEEN_AT_TIME']"
		[Register ("LAST_SEEN_AT_TIME")]
		public const string LastSeenAtTime = (string) "lastSeenAt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='MESSAGE_CONTENT_TYPE']"
		[Register ("MESSAGE_CONTENT_TYPE")]
		public const string MessageContentType = (string) "messageContentType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='MESSAGE_METADATA']"
		[Register ("MESSAGE_METADATA")]
		public const string MessageMetadata = (string) "metadata";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='NOTIFICATION_AFTER_TIME']"
		[Register ("NOTIFICATION_AFTER_TIME")]
		public const string NotificationAfterTime = (string) "notificationAfterTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='REPLY_MESSAGE']"
		[Register ("REPLY_MESSAGE")]
		public const string ReplyMessage = (string) "replyMessage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='ROLE']"
		[Register ("ROLE")]
		public const string Role = (string) "role";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='SCHEDULE_SMS_TABLE_NAME']"
		[Register ("SCHEDULE_SMS_TABLE_NAME")]
		public const string ScheduleSmsTableName = (string) "ScheduleSMS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='SENDER_USER_NAME']"
		[Register ("SENDER_USER_NAME")]
		public const string SenderUserName = (string) "senderUserName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='SMS']"
		[Register ("SMS")]
		public const string Sms = (string) "sms";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='SMS_KEY_STRING']"
		[Register ("SMS_KEY_STRING")]
		public const string SmsKeyString = (string) "smsKeyString";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='SMS_TABLE_NAME']"
		[Register ("SMS_TABLE_NAME")]
		public const string SmsTableName = (string) "sms";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='SMS_TYPE']"
		[Register ("SMS_TYPE")]
		public const string SmsType = (string) "SMSType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='STATUS']"
		[Register ("STATUS")]
		public const string Status = (string) "status";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='STORE_ON_DEVICE_COLUMN']"
		[Register ("STORE_ON_DEVICE_COLUMN")]
		public const string StoreOnDeviceColumn = (string) "storeOnDevice";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='TIMESTAMP']"
		[Register ("TIMESTAMP")]
		public const string Timestamp = (string) "timeStamp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='TIME_TO_LIVE']"
		[Register ("TIME_TO_LIVE")]
		public const string TimeToLive = (string) "timeToLive";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='TOPIC_DETAIL']"
		[Register ("TOPIC_DETAIL")]
		public const string TopicDetail = (string) "topicDetail";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='TOPIC_ID']"
		[Register ("TOPIC_ID")]
		public const string TopicId = (string) "topicId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='TOPIC_LOCAL_IMAGE_URL']"
		[Register ("TOPIC_LOCAL_IMAGE_URL")]
		public const string TopicLocalImageUrl = (string) "topicLocalImageUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='TO_FIELD']"
		[Register ("TO_FIELD")]
		public const string ToField = (string) "toField";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='TYPE']"
		[Register ("TYPE")]
		public const string Type = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='UNREAD_COUNT']"
		[Register ("UNREAD_COUNT")]
		public const string UnreadCount = (string) "unreadCount";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='URL']"
		[Register ("URL")]
		public const string Url = (string) "url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='USERID']"
		[Register ("USERID")]
		public const string Userid = (string) "userId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='USER_COUNT']"
		[Register ("USER_COUNT")]
		public const string UserCount = (string) "userCount";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='USER_METADATA']"
		[Register ("USER_METADATA")]
		public const string UserMetadata = (string) "userMetadata";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='USER_ROLE_TYPE']"
		[Register ("USER_ROLE_TYPE")]
		public const string UserRoleType = (string) "userRoleType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='USER_TYPE_ID']"
		[Register ("USER_TYPE_ID")]
		public const string UserTypeId = (string) "userTypeId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/field[@name='_ID']"
		[Register ("_ID")]
		public const string Id = (string) "_id";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/database/MobiComDatabaseHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobiComDatabaseHelper); }
		}

		protected MobiComDatabaseHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_database_sqlite_SQLiteDatabase_CursorFactory_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/constructor[@name='MobiComDatabaseHelper' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.database.sqlite.SQLiteDatabase.CursorFactory'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)V", "")]
		public unsafe MobiComDatabaseHelper (global::Android.Content.Context p0, string p1, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (MobiComDatabaseHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_database_sqlite_SQLiteDatabase_CursorFactory_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_database_sqlite_SQLiteDatabase_CursorFactory_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_database_sqlite_SQLiteDatabase_CursorFactory_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Landroid_database_sqlite_SQLiteDatabase_CursorFactory_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_delDatabase;
#pragma warning disable 0169
		static Delegate GetDelDatabaseHandler ()
		{
			if (cb_delDatabase == null)
				cb_delDatabase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DelDatabase);
			return cb_delDatabase;
		}

		static int n_DelDatabase (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Database.MobiComDatabaseHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Database.MobiComDatabaseHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DelDatabase ();
		}
#pragma warning restore 0169

		static IntPtr id_delDatabase;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/method[@name='delDatabase' and count(parameter)=0]"
		[Register ("delDatabase", "()I", "GetDelDatabaseHandler")]
		public virtual unsafe int DelDatabase ()
		{
			if (id_delDatabase == IntPtr.Zero)
				id_delDatabase = JNIEnv.GetMethodID (class_ref, "delDatabase", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_delDatabase);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delDatabase", "()I"));
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/database/MobiComDatabaseHelper;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Database.MobiComDatabaseHelper GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/database/MobiComDatabaseHelper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Database.MobiComDatabaseHelper __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Database.MobiComDatabaseHelper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler ()
		{
			if (cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == null)
				cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_);
			return cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
		}

		static void n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Database.MobiComDatabaseHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Database.MobiComDatabaseHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
		[Register ("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", "GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler")]
		public override unsafe void OnCreate (global::Android.Database.Sqlite.SQLiteDatabase p0)
		{
			if (id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
				id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_database_sqlite_SQLiteDatabase_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
#pragma warning disable 0169
		static Delegate GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler ()
		{
			if (cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == null)
				cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II);
			return cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		}

		static void n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Applozic.Mobicomkit.Database.MobiComDatabaseHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Database.MobiComDatabaseHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpgrade (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.database']/class[@name='MobiComDatabaseHelper']/method[@name='onUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler")]
		public override unsafe void OnUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
		{
			if (id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
				id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V"), __args);
			} finally {
			}
		}

	}
}
