using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Daimajia.Swipe.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeAdapterInterface']"
	[Register ("com/daimajia/swipe/interfaces/SwipeAdapterInterface", "", "Com.Daimajia.Swipe.Interfaces.ISwipeAdapterInterfaceInvoker")]
	public partial interface ISwipeAdapterInterface : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.interfaces']/interface[@name='SwipeAdapterInterface']/method[@name='getSwipeLayoutResourceId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSwipeLayoutResourceId", "(I)I", "GetGetSwipeLayoutResourceId_IHandler:Com.Daimajia.Swipe.Interfaces.ISwipeAdapterInterfaceInvoker, SwipeBinding")]
		int GetSwipeLayoutResourceId (int p0);

	}

	[global::Android.Runtime.Register ("com/daimajia/swipe/interfaces/SwipeAdapterInterface", DoNotGenerateAcw=true)]
	internal class ISwipeAdapterInterfaceInvoker : global::Java.Lang.Object, ISwipeAdapterInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/daimajia/swipe/interfaces/SwipeAdapterInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISwipeAdapterInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static ISwipeAdapterInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISwipeAdapterInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.daimajia.swipe.interfaces.SwipeAdapterInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISwipeAdapterInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Daimajia.Swipe.Interfaces.ISwipeAdapterInterface __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Interfaces.ISwipeAdapterInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSwipeLayoutResourceId (p0);
		}
#pragma warning restore 0169

		IntPtr id_getSwipeLayoutResourceId_I;
		public unsafe int GetSwipeLayoutResourceId (int p0)
		{
			if (id_getSwipeLayoutResourceId_I == IntPtr.Zero)
				id_getSwipeLayoutResourceId_I = JNIEnv.GetMethodID (class_ref, "getSwipeLayoutResourceId", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSwipeLayoutResourceId_I, __args);
		}

	}

}
