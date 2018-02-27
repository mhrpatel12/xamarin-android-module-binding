using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/MobicomLocationActivity", DoNotGenerateAcw=true)]
	public partial class MobicomLocationActivity : global::Android.Support.V7.App.AppCompatActivity, global::Android.Support.V4.App.ActivityCompat.IOnRequestPermissionsResultCallback, global::Android.Gms.Common.Apis.GoogleApiClient.IConnectionCallbacks, global::Android.Gms.Common.Apis.GoogleApiClient.IOnConnectionFailedListener, global::Android.Gms.Location.ILocationListener, global::Android.Gms.Maps.IOnMapReadyCallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/field[@name='FASTEST_INTERVAL']"
		[Register ("FASTEST_INTERVAL")]
		protected const long FastestInterval = (long) 1L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/field[@name='LOCATION_SERVICE_ENABLE']"
		[Register ("LOCATION_SERVICE_ENABLE")]
		public const int LocationServiceEnable = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/field[@name='UPDATE_INTERVAL']"
		[Register ("UPDATE_INTERVAL")]
		protected const long UpdateInterval = (long) 5L;

		static IntPtr googleApiClient_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/field[@name='googleApiClient']"
		[Register ("googleApiClient")]
		protected global::Android.Gms.Common.Apis.GoogleApiClient GoogleApiClient {
			get {
				if (googleApiClient_jfieldId == IntPtr.Zero)
					googleApiClient_jfieldId = JNIEnv.GetFieldID (class_ref, "googleApiClient", "Lcom/google/android/gms/common/api/GoogleApiClient;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, googleApiClient_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Gms.Common.Apis.GoogleApiClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (googleApiClient_jfieldId == IntPtr.Zero)
					googleApiClient_jfieldId = JNIEnv.GetFieldID (class_ref, "googleApiClient", "Lcom/google/android/gms/common/api/GoogleApiClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, googleApiClient_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr snackbar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/field[@name='snackbar']"
		[Register ("snackbar")]
		public global::Android.Support.Design.Widget.Snackbar Snackbar {
			get {
				if (snackbar_jfieldId == IntPtr.Zero)
					snackbar_jfieldId = JNIEnv.GetFieldID (class_ref, "snackbar", "Landroid/support/design/widget/Snackbar;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, snackbar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.Design.Widget.Snackbar> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (snackbar_jfieldId == IntPtr.Zero)
					snackbar_jfieldId = JNIEnv.GetFieldID (class_ref, "snackbar", "Landroid/support/design/widget/Snackbar;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, snackbar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/MobicomLocationActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobicomLocationActivity); }
		}

		protected MobicomLocationActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/constructor[@name='MobicomLocationActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobicomLocationActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MobicomLocationActivity)) {
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

		static Delegate cb_onConnected_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Landroid_os_Bundle_Handler ()
		{
			if (cb_onConnected_Landroid_os_Bundle_ == null)
				cb_onConnected_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnected_Landroid_os_Bundle_);
			return cb_onConnected_Landroid_os_Bundle_;
		}

		static void n_OnConnected_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnected_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onConnected", "(Landroid/os/Bundle;)V", "GetOnConnected_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnConnected (global::Android.OS.Bundle p0)
		{
			if (id_onConnected_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onConnected_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnected", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
#pragma warning disable 0169
		static Delegate GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler ()
		{
			if (cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == null)
				cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_);
			return cb_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
		}

		static void n_OnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Common.ConnectionResult p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Common.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/method[@name='onConnectionFailed' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.common.ConnectionResult']]"
		[Register ("onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V", "GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler")]
		public virtual unsafe void OnConnectionFailed (global::Android.Gms.Common.ConnectionResult p0)
		{
			if (id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ == IntPtr.Zero)
				id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_ = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionFailed", "(Lcom/google/android/gms/common/ConnectionResult;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionSuspended_I;
#pragma warning disable 0169
		static Delegate GetOnConnectionSuspended_IHandler ()
		{
			if (cb_onConnectionSuspended_I == null)
				cb_onConnectionSuspended_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnConnectionSuspended_I);
			return cb_onConnectionSuspended_I;
		}

		static void n_OnConnectionSuspended_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionSuspended (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionSuspended_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/method[@name='onConnectionSuspended' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onConnectionSuspended", "(I)V", "GetOnConnectionSuspended_IHandler")]
		public virtual unsafe void OnConnectionSuspended (int p0)
		{
			if (id_onConnectionSuspended_I == IntPtr.Zero)
				id_onConnectionSuspended_I = JNIEnv.GetMethodID (class_ref, "onConnectionSuspended", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionSuspended_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionSuspended", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location p0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationChanged_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler")]
		public virtual unsafe void OnLocationChanged (global::Android.Locations.Location p0)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLocationChanged_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationChanged", "(Landroid/location/Location;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMapReady_Lcom_google_android_gms_maps_GoogleMap_;
#pragma warning disable 0169
		static Delegate GetOnMapReady_Lcom_google_android_gms_maps_GoogleMap_Handler ()
		{
			if (cb_onMapReady_Lcom_google_android_gms_maps_GoogleMap_ == null)
				cb_onMapReady_Lcom_google_android_gms_maps_GoogleMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapReady_Lcom_google_android_gms_maps_GoogleMap_);
			return cb_onMapReady_Lcom_google_android_gms_maps_GoogleMap_;
		}

		static void n_OnMapReady_Lcom_google_android_gms_maps_GoogleMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Gms.Maps.GoogleMap p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.GoogleMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMapReady (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onMapReady_Lcom_google_android_gms_maps_GoogleMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/method[@name='onMapReady' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.GoogleMap']]"
		[Register ("onMapReady", "(Lcom/google/android/gms/maps/GoogleMap;)V", "GetOnMapReady_Lcom_google_android_gms_maps_GoogleMap_Handler")]
		public virtual unsafe void OnMapReady (global::Android.Gms.Maps.GoogleMap p0)
		{
			if (id_onMapReady_Lcom_google_android_gms_maps_GoogleMap_ == IntPtr.Zero)
				id_onMapReady_Lcom_google_android_gms_maps_GoogleMap_ = JNIEnv.GetMethodID (class_ref, "onMapReady", "(Lcom/google/android/gms/maps/GoogleMap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapReady_Lcom_google_android_gms_maps_GoogleMap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMapReady", "(Lcom/google/android/gms/maps/GoogleMap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processLocation;
#pragma warning disable 0169
		static Delegate GetProcessLocationHandler ()
		{
			if (cb_processLocation == null)
				cb_processLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessLocation);
			return cb_processLocation;
		}

		static void n_ProcessLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_processLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/method[@name='processLocation' and count(parameter)=0]"
		[Register ("processLocation", "()V", "GetProcessLocationHandler")]
		public virtual unsafe void ProcessLocation ()
		{
			if (id_processLocation == IntPtr.Zero)
				id_processLocation = JNIEnv.GetMethodID (class_ref, "processLocation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processLocation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processLocation", "()V"));
			} finally {
			}
		}

		static Delegate cb_processingLocation;
#pragma warning disable 0169
		static Delegate GetProcessingLocationHandler ()
		{
			if (cb_processingLocation == null)
				cb_processingLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessingLocation);
			return cb_processingLocation;
		}

		static void n_ProcessingLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessingLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_processingLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/method[@name='processingLocation' and count(parameter)=0]"
		[Register ("processingLocation", "()V", "GetProcessingLocationHandler")]
		public virtual unsafe void ProcessingLocation ()
		{
			if (id_processingLocation == IntPtr.Zero)
				id_processingLocation = JNIEnv.GetMethodID (class_ref, "processingLocation", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processingLocation);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processingLocation", "()V"));
			} finally {
			}
		}

		static Delegate cb_showSnackBar_I;
#pragma warning disable 0169
		static Delegate GetShowSnackBar_IHandler ()
		{
			if (cb_showSnackBar_I == null)
				cb_showSnackBar_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ShowSnackBar_I);
			return cb_showSnackBar_I;
		}

		static void n_ShowSnackBar_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.MobicomLocationActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSnackBar (p0);
		}
#pragma warning restore 0169

		static IntPtr id_showSnackBar_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='MobicomLocationActivity']/method[@name='showSnackBar' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("showSnackBar", "(I)V", "GetShowSnackBar_IHandler")]
		public virtual unsafe void ShowSnackBar (int p0)
		{
			if (id_showSnackBar_I == IntPtr.Zero)
				id_showSnackBar_I = JNIEnv.GetMethodID (class_ref, "showSnackBar", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showSnackBar_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showSnackBar", "(I)V"), __args);
			} finally {
			}
		}

	}
}
