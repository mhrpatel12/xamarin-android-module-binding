using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='LocationInfo']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/core/utils/LocationInfo", DoNotGenerateAcw=true)]
	public partial class LocationInfo : global::Com.Applozic.Mobicommons.Json.JsonMarker {


		static IntPtr lat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='LocationInfo']/field[@name='lat']"
		[Register ("lat")]
		public double Lat {
			get {
				if (lat_jfieldId == IntPtr.Zero)
					lat_jfieldId = JNIEnv.GetFieldID (class_ref, "lat", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, lat_jfieldId);
			}
			set {
				if (lat_jfieldId == IntPtr.Zero)
					lat_jfieldId = JNIEnv.GetFieldID (class_ref, "lat", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lat_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='LocationInfo']/field[@name='lon']"
		[Register ("lon")]
		public double Lon {
			get {
				if (lon_jfieldId == IntPtr.Zero)
					lon_jfieldId = JNIEnv.GetFieldID (class_ref, "lon", "D");
				return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, lon_jfieldId);
			}
			set {
				if (lon_jfieldId == IntPtr.Zero)
					lon_jfieldId = JNIEnv.GetFieldID (class_ref, "lon", "D");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lon_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/core/utils/LocationInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationInfo); }
		}

		protected LocationInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='LocationInfo']/constructor[@name='LocationInfo' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public unsafe LocationInfo (double p0, double p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (LocationInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(DD)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(DD)V", __args);
					return;
				}

				if (id_ctor_DD == IntPtr.Zero)
					id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_DD, __args);
			} finally {
			}
		}

	}
}
