using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.People {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicommons.people']/interface[@name='OnContactsInteractionListener']"
	[Register ("com/applozic/mobicommons/people/OnContactsInteractionListener", "", "Com.Applozic.Mobicommons.People.IOnContactsInteractionListenerInvoker")]
	public partial interface IOnContactsInteractionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people']/interface[@name='OnContactsInteractionListener']/method[@name='onContactSelected' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("onContactSelected", "(Landroid/net/Uri;)V", "GetOnContactSelected_Landroid_net_Uri_Handler:Com.Applozic.Mobicommons.People.IOnContactsInteractionListenerInvoker, AndroidMobicomBindingProject")]
		void OnContactSelected (global::Android.Net.Uri p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people']/interface[@name='OnContactsInteractionListener']/method[@name='onCustomContactSelected' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("onCustomContactSelected", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetOnCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_Handler:Com.Applozic.Mobicommons.People.IOnContactsInteractionListenerInvoker, AndroidMobicomBindingProject")]
		void OnCustomContactSelected (global::Com.Applozic.Mobicommons.People.Contact.Contact p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people']/interface[@name='OnContactsInteractionListener']/method[@name='onGroupSelected' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("onGroupSelected", "(Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetOnGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_Handler:Com.Applozic.Mobicommons.People.IOnContactsInteractionListenerInvoker, AndroidMobicomBindingProject")]
		void OnGroupSelected (global::Com.Applozic.Mobicommons.People.Channel.Channel p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people']/interface[@name='OnContactsInteractionListener']/method[@name='onSelectionCleared' and count(parameter)=0]"
		[Register ("onSelectionCleared", "()V", "GetOnSelectionClearedHandler:Com.Applozic.Mobicommons.People.IOnContactsInteractionListenerInvoker, AndroidMobicomBindingProject")]
		void OnSelectionCleared ();

	}

	[global::Android.Runtime.Register ("com/applozic/mobicommons/people/OnContactsInteractionListener", DoNotGenerateAcw=true)]
	internal class IOnContactsInteractionListenerInvoker : global::Java.Lang.Object, IOnContactsInteractionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicommons/people/OnContactsInteractionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnContactsInteractionListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnContactsInteractionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnContactsInteractionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicommons.people.OnContactsInteractionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnContactsInteractionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onContactSelected_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetOnContactSelected_Landroid_net_Uri_Handler ()
		{
			if (cb_onContactSelected_Landroid_net_Uri_ == null)
				cb_onContactSelected_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnContactSelected_Landroid_net_Uri_);
			return cb_onContactSelected_Landroid_net_Uri_;
		}

		static void n_OnContactSelected_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.IOnContactsInteractionListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.IOnContactsInteractionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnContactSelected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onContactSelected_Landroid_net_Uri_;
		public unsafe void OnContactSelected (global::Android.Net.Uri p0)
		{
			if (id_onContactSelected_Landroid_net_Uri_ == IntPtr.Zero)
				id_onContactSelected_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "onContactSelected", "(Landroid/net/Uri;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onContactSelected_Landroid_net_Uri_, __args);
		}

		static Delegate cb_onCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetOnCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_onCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_onCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_onCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_OnCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.IOnContactsInteractionListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.IOnContactsInteractionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCustomContactSelected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_;
		public unsafe void OnCustomContactSelected (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_onCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_onCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "onCustomContactSelected", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCustomContactSelected_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
		}

		static Delegate cb_onGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetOnGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_onGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_onGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_onGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_OnGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.IOnContactsInteractionListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.IOnContactsInteractionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGroupSelected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_;
		public unsafe void OnGroupSelected (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
		{
			if (id_onGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_onGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "onGroupSelected", "(Lcom/applozic/mobicommons/people/channel/Channel;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGroupSelected_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
		}

		static Delegate cb_onSelectionCleared;
#pragma warning disable 0169
		static Delegate GetOnSelectionClearedHandler ()
		{
			if (cb_onSelectionCleared == null)
				cb_onSelectionCleared = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSelectionCleared);
			return cb_onSelectionCleared;
		}

		static void n_OnSelectionCleared (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.IOnContactsInteractionListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.IOnContactsInteractionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSelectionCleared ();
		}
#pragma warning restore 0169

		IntPtr id_onSelectionCleared;
		public unsafe void OnSelectionCleared ()
		{
			if (id_onSelectionCleared == IntPtr.Zero)
				id_onSelectionCleared = JNIEnv.GetMethodID (class_ref, "onSelectionCleared", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSelectionCleared);
		}

	}

	public partial class ContactSelectedEventArgs : global::System.EventArgs {

		public ContactSelectedEventArgs (global::Android.Net.Uri p0)
		{
			this.p0 = p0;
		}

		global::Android.Net.Uri p0;
		public global::Android.Net.Uri P0 {
			get { return p0; }
		}
	}

	public partial class CustomContactSelectedEventArgs : global::System.EventArgs {

		public CustomContactSelectedEventArgs (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			this.p0 = p0;
		}

		global::Com.Applozic.Mobicommons.People.Contact.Contact p0;
		public global::Com.Applozic.Mobicommons.People.Contact.Contact P0 {
			get { return p0; }
		}
	}

	public partial class GroupSelectedEventArgs : global::System.EventArgs {

		public GroupSelectedEventArgs (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
		{
			this.p0 = p0;
		}

		global::Com.Applozic.Mobicommons.People.Channel.Channel p0;
		public global::Com.Applozic.Mobicommons.People.Channel.Channel P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/applozic/mobicommons/people/OnContactsInteractionListenerImplementor")]
	internal sealed partial class IOnContactsInteractionListenerImplementor : global::Java.Lang.Object, IOnContactsInteractionListener {

		object sender;

		public IOnContactsInteractionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applozic/mobicommons/people/OnContactsInteractionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ContactSelectedEventArgs> OnContactSelectedHandler;
#pragma warning restore 0649

		public void OnContactSelected (global::Android.Net.Uri p0)
		{
			var __h = OnContactSelectedHandler;
			if (__h != null)
				__h (sender, new ContactSelectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<CustomContactSelectedEventArgs> OnCustomContactSelectedHandler;
#pragma warning restore 0649

		public void OnCustomContactSelected (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			var __h = OnCustomContactSelectedHandler;
			if (__h != null)
				__h (sender, new CustomContactSelectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<GroupSelectedEventArgs> OnGroupSelectedHandler;
#pragma warning restore 0649

		public void OnGroupSelected (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
		{
			var __h = OnGroupSelectedHandler;
			if (__h != null)
				__h (sender, new GroupSelectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnSelectionClearedHandler;
#pragma warning restore 0649

		public void OnSelectionCleared ()
		{
			var __h = OnSelectionClearedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnContactsInteractionListenerImplementor value)
		{
			return value.OnContactSelectedHandler == null && value.OnCustomContactSelectedHandler == null && value.OnGroupSelectedHandler == null && value.OnSelectionClearedHandler == null;
		}
	}

}
