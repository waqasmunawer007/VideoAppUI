using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Daimajia.Swipe.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']"
	[global::Android.Runtime.Register ("com/daimajia/swipe/adapters/ArraySwipeAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class ArraySwipeAdapter : global::Android.Widget.ArrayAdapter, global::Com.Daimajia.Swipe.Interfaces.ISwipeAdapterInterface, global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/daimajia/swipe/adapters/ArraySwipeAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArraySwipeAdapter); }
		}

		protected ArraySwipeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_IILjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/constructor[@name='ArraySwipeAdapter' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.util.List&lt;T&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;IILjava/util/List;)V", "")]
		public unsafe ArraySwipeAdapter (global::Android.Content.Context p0, int p1, int p2, global::System.Collections.IList p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = global::Android.Runtime.JavaList.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (ArraySwipeAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;IILjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;IILjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_IILjava_util_List_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_IILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;IILjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_IILjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_IILjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_ILjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/constructor[@name='ArraySwipeAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;T&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;ILjava/util/List;)V", "")]
		public unsafe ArraySwipeAdapter (global::Android.Content.Context p0, int p1, global::System.Collections.IList p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (ArraySwipeAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ILjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;ILjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ILjava_util_List_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_ILjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_IIarrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/constructor[@name='ArraySwipeAdapter' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='T[]']]"
		[Register (".ctor", "(Landroid/content/Context;II[Ljava/lang/Object;)V", "")]
		public unsafe ArraySwipeAdapter (global::Android.Content.Context p0, int p1, int p2, global::Java.Lang.Object[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (ArraySwipeAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;II[Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;II[Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_IIarrayLjava_lang_Object_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_IIarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;II[Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_IIarrayLjava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_IIarrayLjava_lang_Object_, __args);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/constructor[@name='ArraySwipeAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe ArraySwipeAdapter (global::Android.Content.Context p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ArraySwipeAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/constructor[@name='ArraySwipeAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;II)V", "")]
		public unsafe ArraySwipeAdapter (global::Android.Content.Context p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ArraySwipeAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_IarrayLjava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/constructor[@name='ArraySwipeAdapter' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='T[]']]"
		[Register (".ctor", "(Landroid/content/Context;I[Ljava/lang/Object;)V", "")]
		public unsafe ArraySwipeAdapter (global::Android.Content.Context p0, int p1, global::Java.Lang.Object[] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (ArraySwipeAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I[Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;I[Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_IarrayLjava_lang_Object_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_IarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I[Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_IarrayLjava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_IarrayLjava_lang_Object_, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMode);
			return cb_getMode;
		}

		static IntPtr n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Mode);
		}
#pragma warning restore 0169

		static Delegate cb_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lcom_daimajia_swipe_util_Attributes_Mode_Handler ()
		{
			if (cb_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_ == null)
				cb_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMode_Lcom_daimajia_swipe_util_Attributes_Mode_);
			return cb_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_;
		}

		static void n_SetMode_Lcom_daimajia_swipe_util_Attributes_Mode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.Util.Attributes.Mode p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Util.Attributes.Mode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Mode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMode;
		static IntPtr id_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_;
		public virtual unsafe global::Com.Daimajia.Swipe.Util.Attributes.Mode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lcom/daimajia/swipe/util/Attributes$Mode;", "GetGetModeHandler")]
			get {
				if (id_getMode == IntPtr.Zero)
					id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()Lcom/daimajia/swipe/util/Attributes$Mode;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Util.Attributes.Mode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Util.Attributes.Mode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMode", "()Lcom/daimajia/swipe/util/Attributes$Mode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.util.Attributes.Mode']]"
			[Register ("setMode", "(Lcom/daimajia/swipe/util/Attributes$Mode;)V", "GetSetMode_Lcom_daimajia_swipe_util_Attributes_Mode_Handler")]
			set {
				if (id_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_ == IntPtr.Zero)
					id_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_ = JNIEnv.GetMethodID (class_ref, "setMode", "(Lcom/daimajia/swipe/util/Attributes$Mode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(Lcom/daimajia/swipe/util/Attributes$Mode;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOpenItems;
#pragma warning disable 0169
		static Delegate GetGetOpenItemsHandler ()
		{
			if (cb_getOpenItems == null)
				cb_getOpenItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpenItems);
			return cb_getOpenItems;
		}

		static IntPtr n_GetOpenItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.OpenItems);
		}
#pragma warning restore 0169

		static IntPtr id_getOpenItems;
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> OpenItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='getOpenItems' and count(parameter)=0]"
			[Register ("getOpenItems", "()Ljava/util/List;", "GetGetOpenItemsHandler")]
			get {
				if (id_getOpenItems == IntPtr.Zero)
					id_getOpenItems = JNIEnv.GetMethodID (class_ref, "getOpenItems", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOpenItems), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpenItems", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOpenLayouts;
#pragma warning disable 0169
		static Delegate GetGetOpenLayoutsHandler ()
		{
			if (cb_getOpenLayouts == null)
				cb_getOpenLayouts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpenLayouts);
			return cb_getOpenLayouts;
		}

		static IntPtr n_GetOpenLayouts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout>.ToLocalJniHandle (__this.OpenLayouts);
		}
#pragma warning restore 0169

		static IntPtr id_getOpenLayouts;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Daimajia.Swipe.SwipeLayout> OpenLayouts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='getOpenLayouts' and count(parameter)=0]"
			[Register ("getOpenLayouts", "()Ljava/util/List;", "GetGetOpenLayoutsHandler")]
			get {
				if (id_getOpenLayouts == IntPtr.Zero)
					id_getOpenLayouts = JNIEnv.GetMethodID (class_ref, "getOpenLayouts", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOpenLayouts), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpenLayouts", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetCloseAllExcept_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CloseAllExcept_Lcom_daimajia_swipe_SwipeLayout_);
			return cb_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_CloseAllExcept_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CloseAllExcept (p0);
		}
#pragma warning restore 0169

		static IntPtr id_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='closeAllExcept' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("closeAllExcept", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetCloseAllExcept_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void CloseAllExcept (global::Com.Daimajia.Swipe.SwipeLayout p0)
		{
			if (id_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
				id_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "closeAllExcept", "(Lcom/daimajia/swipe/SwipeLayout;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeAllExcept", "(Lcom/daimajia/swipe/SwipeLayout;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_closeAllItems;
#pragma warning disable 0169
		static Delegate GetCloseAllItemsHandler ()
		{
			if (cb_closeAllItems == null)
				cb_closeAllItems = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseAllItems);
			return cb_closeAllItems;
		}

		static void n_CloseAllItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseAllItems ();
		}
#pragma warning restore 0169

		static IntPtr id_closeAllItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='closeAllItems' and count(parameter)=0]"
		[Register ("closeAllItems", "()V", "GetCloseAllItemsHandler")]
		public virtual unsafe void CloseAllItems ()
		{
			if (id_closeAllItems == IntPtr.Zero)
				id_closeAllItems = JNIEnv.GetMethodID (class_ref, "closeAllItems", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeAllItems);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeAllItems", "()V"));
			} finally {
			}
		}

		static Delegate cb_closeItem_I;
#pragma warning disable 0169
		static Delegate GetCloseItem_IHandler ()
		{
			if (cb_closeItem_I == null)
				cb_closeItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_CloseItem_I);
			return cb_closeItem_I;
		}

		static void n_CloseItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_closeItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='closeItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("closeItem", "(I)V", "GetCloseItem_IHandler")]
		public virtual unsafe void CloseItem (int p0)
		{
			if (id_closeItem_I == IntPtr.Zero)
				id_closeItem_I = JNIEnv.GetMethodID (class_ref, "closeItem", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeItem", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_isOpen_I;
#pragma warning disable 0169
		static Delegate GetIsOpen_IHandler ()
		{
			if (cb_isOpen_I == null)
				cb_isOpen_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsOpen_I);
			return cb_isOpen_I;
		}

		static bool n_IsOpen_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isOpen_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='isOpen' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isOpen", "(I)Z", "GetIsOpen_IHandler")]
		public virtual unsafe bool IsOpen (int p0)
		{
			if (id_isOpen_I == IntPtr.Zero)
				id_isOpen_I = JNIEnv.GetMethodID (class_ref, "isOpen", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpen", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_openItem_I;
#pragma warning disable 0169
		static Delegate GetOpenItem_IHandler ()
		{
			if (cb_openItem_I == null)
				cb_openItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OpenItem_I);
			return cb_openItem_I;
		}

		static void n_OpenItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenItem (p0);
		}
#pragma warning restore 0169

		static IntPtr id_openItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='openItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("openItem", "(I)V", "GetOpenItem_IHandler")]
		public virtual unsafe void OpenItem (int p0)
		{
			if (id_openItem_I == IntPtr.Zero)
				id_openItem_I = JNIEnv.GetMethodID (class_ref, "openItem", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openItem_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openItem", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
		static Delegate GetRemoveShownLayouts_Lcom_daimajia_swipe_SwipeLayout_Handler ()
		{
			if (cb_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_ == null)
				cb_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveShownLayouts_Lcom_daimajia_swipe_SwipeLayout_);
			return cb_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_;
		}

		static void n_RemoveShownLayouts_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveShownLayouts (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.adapters']/class[@name='ArraySwipeAdapter']/method[@name='removeShownLayouts' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("removeShownLayouts", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetRemoveShownLayouts_Lcom_daimajia_swipe_SwipeLayout_Handler")]
		public virtual unsafe void RemoveShownLayouts (global::Com.Daimajia.Swipe.SwipeLayout p0)
		{
			if (id_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
				id_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "removeShownLayouts", "(Lcom/daimajia/swipe/SwipeLayout;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeShownLayouts", "(Lcom/daimajia/swipe/SwipeLayout;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getSwipeLayoutResourceId_I;
#pragma warning disable 0169
		static Delegate GetGetSwipeLayoutResourceId_IHandler ()
		{
			if (cb_getSwipeLayoutResourceId_I == null)
				cb_getSwipeLayoutResourceId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetSwipeLayoutResourceId_I);
			return cb_getSwipeLayoutResourceId_I;
		}

		static int n_GetSwipeLayoutResourceId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Adapters.ArraySwipeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSwipeLayoutResourceId (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeAdapterInterface']/method[@name='getSwipeLayoutResourceId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSwipeLayoutResourceId", "(I)I", "GetGetSwipeLayoutResourceId_IHandler")]
		public abstract int GetSwipeLayoutResourceId (int p0);

	}

	[global::Android.Runtime.Register ("com/daimajia/swipe/adapters/ArraySwipeAdapter", DoNotGenerateAcw=true)]
	internal partial class ArraySwipeAdapterInvoker : ArraySwipeAdapter {

		public ArraySwipeAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArraySwipeAdapterInvoker); }
		}

		static IntPtr id_getSwipeLayoutResourceId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeAdapterInterface']/method[@name='getSwipeLayoutResourceId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSwipeLayoutResourceId", "(I)I", "GetGetSwipeLayoutResourceId_IHandler")]
		public override unsafe int GetSwipeLayoutResourceId (int p0)
		{
			if (id_getSwipeLayoutResourceId_I == IntPtr.Zero)
				id_getSwipeLayoutResourceId_I = JNIEnv.GetMethodID (class_ref, "getSwipeLayoutResourceId", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSwipeLayoutResourceId_I, __args);
			} finally {
			}
		}

	}

}
