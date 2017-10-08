using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Json {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='JsonParcelableMarker']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/json/JsonParcelableMarker", DoNotGenerateAcw=true)]
	public abstract partial class JsonParcelableMarker : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/json/JsonParcelableMarker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonParcelableMarker); }
		}

		protected JsonParcelableMarker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='JsonParcelableMarker']/constructor[@name='JsonParcelableMarker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonParcelableMarker ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JsonParcelableMarker)) {
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
			global::Com.Applozic.Mobicommons.Json.JsonParcelableMarker __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Json.JsonParcelableMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public abstract global::System.Int32 DescribeContents ();

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Applozic.Mobicommons.Json.JsonParcelableMarker __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Json.JsonParcelableMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public abstract void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicommons/json/JsonParcelableMarker", DoNotGenerateAcw=true)]
	internal partial class JsonParcelableMarkerInvoker : JsonParcelableMarker {

		public JsonParcelableMarkerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonParcelableMarkerInvoker); }
		}

		static IntPtr id_describeContents;
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public override unsafe global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public override unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}

}
