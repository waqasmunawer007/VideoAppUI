using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Daimajia.Swipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']"
	[global::Android.Runtime.Register ("com/daimajia/swipe/SimpleSwipeListener", DoNotGenerateAcw=true)]
	public partial class SimpleSwipeListener : global::Java.Lang.Object, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/daimajia/swipe/SimpleSwipeListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleSwipeListener); }
		}

		protected SimpleSwipeListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/constructor[@name='SimpleSwipeListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleSwipeListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SimpleSwipeListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static Delegate cb_onClose_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetOnClose_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_onClose_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_onClose_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClose_Lcom_daimajia_swipe_SwipeLayout_);
			return cb_onClose_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_OnClose_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SimpleSwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClose (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onClose_Lcom_daimajia_swipe_SwipeLayout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onClose' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("onClose", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnClose_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void OnClose (global::Com.Daimajia.Swipe.SwipeLayout p0)
		{
			if (id_onClose_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
				id_onClose_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "onClose", "(Lcom/daimajia/swipe/SwipeLayout;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClose_Lcom_daimajia_swipe_SwipeLayout_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClose", "(Lcom/daimajia/swipe/SwipeLayout;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF;
#pragma warning disable 0169
		static Delegate GetOnHandRelease_Lcom_daimajia_swipe_SwipeLayout_FFHandler ()
		{
			if (cb_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF == null)
				cb_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF);
			return cb_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF;
		}

		static void n_OnHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::Com.Daimajia.Swipe.SimpleSwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandRelease (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onHandRelease' and count(parameter)=3 and parameter[1][@type='com.daimajia.swipe.SwipeLayout'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("onHandRelease", "(Lcom/daimajia/swipe/SwipeLayout;FF)V", "GetOnHandRelease_Lcom_daimajia_swipe_SwipeLayout_FFHandler")]
		public virtual unsafe void OnHandRelease (global::Com.Daimajia.Swipe.SwipeLayout p0, float p1, float p2)
		{
			if (id_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF == IntPtr.Zero)
				id_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF = JNIEnv.GetMethodID (class_ref, "onHandRelease", "(Lcom/daimajia/swipe/SwipeLayout;FF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHandRelease", "(Lcom/daimajia/swipe/SwipeLayout;FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onOpen_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetOnOpen_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_onOpen_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_onOpen_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOpen_Lcom_daimajia_swipe_SwipeLayout_);
			return cb_onOpen_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_OnOpen_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SimpleSwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOpen (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onOpen_Lcom_daimajia_swipe_SwipeLayout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("onOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnOpen_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void OnOpen (global::Com.Daimajia.Swipe.SwipeLayout p0)
		{
			if (id_onOpen_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
				id_onOpen_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "onOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpen_Lcom_daimajia_swipe_SwipeLayout_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStartClose_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetOnStartClose_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_onStartClose_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_onStartClose_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStartClose_Lcom_daimajia_swipe_SwipeLayout_);
			return cb_onStartClose_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_OnStartClose_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SimpleSwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStartClose (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStartClose_Lcom_daimajia_swipe_SwipeLayout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onStartClose' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("onStartClose", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnStartClose_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void OnStartClose (global::Com.Daimajia.Swipe.SwipeLayout p0)
		{
			if (id_onStartClose_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
				id_onStartClose_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "onStartClose", "(Lcom/daimajia/swipe/SwipeLayout;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartClose_Lcom_daimajia_swipe_SwipeLayout_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStartClose", "(Lcom/daimajia/swipe/SwipeLayout;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetOnStartOpen_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStartOpen_Lcom_daimajia_swipe_SwipeLayout_);
			return cb_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_OnStartOpen_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SimpleSwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStartOpen (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onStartOpen' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("onStartOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnStartOpen_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void OnStartOpen (global::Com.Daimajia.Swipe.SwipeLayout p0)
		{
			if (id_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
				id_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "onStartOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStartOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II;
#pragma warning disable 0169
		static Delegate GetOnUpdate_Lcom_daimajia_swipe_SwipeLayout_IIHandler ()
		{
			if (cb_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II == null)
				cb_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnUpdate_Lcom_daimajia_swipe_SwipeLayout_II);
			return cb_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II;
		}

		static void n_OnUpdate_Lcom_daimajia_swipe_SwipeLayout_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Daimajia.Swipe.SimpleSwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SimpleSwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdate (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/method[@name='onUpdate' and count(parameter)=3 and parameter[1][@type='com.daimajia.swipe.SwipeLayout'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onUpdate", "(Lcom/daimajia/swipe/SwipeLayout;II)V", "GetOnUpdate_Lcom_daimajia_swipe_SwipeLayout_IIHandler")]
		public virtual unsafe void OnUpdate (global::Com.Daimajia.Swipe.SwipeLayout p0, int p1, int p2)
		{
			if (id_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II == IntPtr.Zero)
				id_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II = JNIEnv.GetMethodID (class_ref, "onUpdate", "(Lcom/daimajia/swipe/SwipeLayout;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUpdate", "(Lcom/daimajia/swipe/SwipeLayout;II)V"), __args);
			} finally {
			}
		}

	}
}
