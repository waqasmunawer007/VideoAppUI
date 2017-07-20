using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Daimajia.Swipe.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']"
	[Register ("com/daimajia/swipe/interfaces/SwipeItemMangerInterface", "", "Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker")]
	public partial interface ISwipeItemMangerInterface : IJavaObject {

		global::Com.Daimajia.Swipe.Util.Attributes.Mode Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()Lcom/daimajia/swipe/util/Attributes$Mode;", "GetGetModeHandler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.util.Attributes.Mode']]"
			[Register ("setMode", "(Lcom/daimajia/swipe/util/Attributes$Mode;)V", "GetSetMode_Lcom_daimajia_swipe_util_Attributes_Mode_Handler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")] set;
		}

		global::System.Collections.Generic.IList<global::Java.Lang.Integer> OpenItems {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='getOpenItems' and count(parameter)=0]"
			[Register ("getOpenItems", "()Ljava/util/List;", "GetGetOpenItemsHandler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Daimajia.Swipe.SwipeLayout> OpenLayouts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='getOpenLayouts' and count(parameter)=0]"
			[Register ("getOpenLayouts", "()Ljava/util/List;", "GetGetOpenLayoutsHandler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='closeAllExcept' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("closeAllExcept", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetCloseAllExcept_Lcom_daimajia_swipe_SwipeLayout_Handler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")]
		void CloseAllExcept (global::Com.Daimajia.Swipe.SwipeLayout p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='closeAllItems' and count(parameter)=0]"
		[Register ("closeAllItems", "()V", "GetCloseAllItemsHandler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")]
		void CloseAllItems ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='closeItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("closeItem", "(I)V", "GetCloseItem_IHandler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")]
		void CloseItem (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='isOpen' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isOpen", "(I)Z", "GetIsOpen_IHandler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")]
		bool IsOpen (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='openItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("openItem", "(I)V", "GetOpenItem_IHandler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")]
		void OpenItem (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeItemMangerInterface']/method[@name='removeShownLayouts' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
		[Register ("removeShownLayouts", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetRemoveShownLayouts_Lcom_daimajia_swipe_SwipeLayout_Handler:Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterfaceInvoker, SwipeBinding")]
		void RemoveShownLayouts (global::Com.Daimajia.Swipe.SwipeLayout p0);

	}

	[global::Android.Runtime.Register ("com/daimajia/swipe/interfaces/SwipeItemMangerInterface", DoNotGenerateAcw=true)]
	internal class ISwipeItemMangerInterfaceInvoker : global::Java.Lang.Object, ISwipeItemMangerInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/daimajia/swipe/interfaces/SwipeItemMangerInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISwipeItemMangerInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static ISwipeItemMangerInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISwipeItemMangerInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.daimajia.swipe.interfaces.SwipeItemMangerInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISwipeItemMangerInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.Util.Attributes.Mode p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Util.Attributes.Mode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Mode = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMode;
		IntPtr id_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_;
		public unsafe global::Com.Daimajia.Swipe.Util.Attributes.Mode Mode {
			get {
				if (id_getMode == IntPtr.Zero)
					id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()Lcom/daimajia/swipe/util/Attributes$Mode;");
				return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Util.Attributes.Mode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMode), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_ == IntPtr.Zero)
					id_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_ = JNIEnv.GetMethodID (class_ref, "setMode", "(Lcom/daimajia/swipe/util/Attributes$Mode;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_Lcom_daimajia_swipe_util_Attributes_Mode_, __args);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.OpenItems);
		}
#pragma warning restore 0169

		IntPtr id_getOpenItems;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> OpenItems {
			get {
				if (id_getOpenItems == IntPtr.Zero)
					id_getOpenItems = JNIEnv.GetMethodID (class_ref, "getOpenItems", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOpenItems), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout>.ToLocalJniHandle (__this.OpenLayouts);
		}
#pragma warning restore 0169

		IntPtr id_getOpenLayouts;
		public unsafe global::System.Collections.Generic.IList<global::Com.Daimajia.Swipe.SwipeLayout> OpenLayouts {
			get {
				if (id_getOpenLayouts == IntPtr.Zero)
					id_getOpenLayouts = JNIEnv.GetMethodID (class_ref, "getOpenLayouts", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOpenLayouts), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CloseAllExcept (p0);
		}
#pragma warning restore 0169

		IntPtr id_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_;
		public unsafe void CloseAllExcept (global::Com.Daimajia.Swipe.SwipeLayout p0)
		{
			if (id_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
				id_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "closeAllExcept", "(Lcom/daimajia/swipe/SwipeLayout;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeAllExcept_Lcom_daimajia_swipe_SwipeLayout_, __args);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseAllItems ();
		}
#pragma warning restore 0169

		IntPtr id_closeAllItems;
		public unsafe void CloseAllItems ()
		{
			if (id_closeAllItems == IntPtr.Zero)
				id_closeAllItems = JNIEnv.GetMethodID (class_ref, "closeAllItems", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeAllItems);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseItem (p0);
		}
#pragma warning restore 0169

		IntPtr id_closeItem_I;
		public unsafe void CloseItem (int p0)
		{
			if (id_closeItem_I == IntPtr.Zero)
				id_closeItem_I = JNIEnv.GetMethodID (class_ref, "closeItem", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeItem_I, __args);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen (p0);
		}
#pragma warning restore 0169

		IntPtr id_isOpen_I;
		public unsafe bool IsOpen (int p0)
		{
			if (id_isOpen_I == IntPtr.Zero)
				id_isOpen_I = JNIEnv.GetMethodID (class_ref, "isOpen", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpen_I, __args);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenItem (p0);
		}
#pragma warning restore 0169

		IntPtr id_openItem_I;
		public unsafe void OpenItem (int p0)
		{
			if (id_openItem_I == IntPtr.Zero)
				id_openItem_I = JNIEnv.GetMethodID (class_ref, "openItem", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openItem_I, __args);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeItemMangerInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveShownLayouts (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_;
		public unsafe void RemoveShownLayouts (global::Com.Daimajia.Swipe.SwipeLayout p0)
		{
			if (id_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
				id_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "removeShownLayouts", "(Lcom/daimajia/swipe/SwipeLayout;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeShownLayouts_Lcom_daimajia_swipe_SwipeLayout_, __args);
		}

	}

}
