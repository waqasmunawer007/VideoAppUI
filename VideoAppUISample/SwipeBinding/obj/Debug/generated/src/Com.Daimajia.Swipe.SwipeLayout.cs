using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Daimajia.Swipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']"
	[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout", DoNotGenerateAcw=true)]
	public partial class SwipeLayout : global::Android.Widget.FrameLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/field[@name='EMPTY_LAYOUT']"
		[Register ("EMPTY_LAYOUT")]
		[Obsolete ("deprecated")]
		public const int EmptyLayout = (int) -1;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.DoubleClickListener']"
		[Register ("com/daimajia/swipe/SwipeLayout$DoubleClickListener", "", "Com.Daimajia.Swipe.SwipeLayout/IDoubleClickListenerInvoker")]
		public partial interface IDoubleClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.DoubleClickListener']/method[@name='onDoubleClick' and count(parameter)=2 and parameter[1][@type='com.daimajia.swipe.SwipeLayout'] and parameter[2][@type='boolean']]"
			[Register ("onDoubleClick", "(Lcom/daimajia/swipe/SwipeLayout;Z)V", "GetOnDoubleClick_Lcom_daimajia_swipe_SwipeLayout_ZHandler:Com.Daimajia.Swipe.SwipeLayout/IDoubleClickListenerInvoker, SwipeBinding")]
			void OnDoubleClick (global::Com.Daimajia.Swipe.SwipeLayout p0, bool p1);

		}

		[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout$DoubleClickListener", DoNotGenerateAcw=true)]
		internal class IDoubleClickListenerInvoker : global::Java.Lang.Object, IDoubleClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/daimajia/swipe/SwipeLayout$DoubleClickListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IDoubleClickListenerInvoker); }
			}

			IntPtr class_ref;

			public static IDoubleClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDoubleClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.daimajia.swipe.SwipeLayout.DoubleClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDoubleClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z;
#pragma warning disable 0169
			static Delegate GetOnDoubleClick_Lcom_daimajia_swipe_SwipeLayout_ZHandler ()
			{
				if (cb_onDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z == null)
					cb_onDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z);
				return cb_onDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z;
			}

			static void n_OnDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
			{
				global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDoubleClick (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z;
			public unsafe void OnDoubleClick (global::Com.Daimajia.Swipe.SwipeLayout p0, bool p1)
			{
				if (id_onDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z == IntPtr.Zero)
					id_onDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z = JNIEnv.GetMethodID (class_ref, "onDoubleClick", "(Lcom/daimajia/swipe/SwipeLayout;Z)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDoubleClick_Lcom_daimajia_swipe_SwipeLayout_Z, __args);
			}

		}

		public partial class DoubleClickEventArgs : global::System.EventArgs {

			public DoubleClickEventArgs (global::Com.Daimajia.Swipe.SwipeLayout p0, bool p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Daimajia.Swipe.SwipeLayout p0;
			public global::Com.Daimajia.Swipe.SwipeLayout P0 {
				get { return p0; }
			}

			bool p1;
			public bool P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/daimajia/swipe/SwipeLayout_DoubleClickListenerImplementor")]
		internal sealed partial class IDoubleClickListenerImplementor : global::Java.Lang.Object, IDoubleClickListener {

			object sender;

			public IDoubleClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/daimajia/swipe/SwipeLayout_DoubleClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<DoubleClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnDoubleClick (global::Com.Daimajia.Swipe.SwipeLayout p0, bool p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new DoubleClickEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IDoubleClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.DragEdge']"
		[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout$DragEdge", DoNotGenerateAcw=true)]
		public sealed partial class DragEdge : global::Java.Lang.Enum {


			static IntPtr Bottom_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.DragEdge']/field[@name='Bottom']"
			[Register ("Bottom")]
			public static global::Com.Daimajia.Swipe.SwipeLayout.DragEdge Bottom {
				get {
					if (Bottom_jfieldId == IntPtr.Zero)
						Bottom_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Bottom", "Lcom/daimajia/swipe/SwipeLayout$DragEdge;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Bottom_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Left_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.DragEdge']/field[@name='Left']"
			[Register ("Left")]
			public static global::Com.Daimajia.Swipe.SwipeLayout.DragEdge Left {
				get {
					if (Left_jfieldId == IntPtr.Zero)
						Left_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Left", "Lcom/daimajia/swipe/SwipeLayout$DragEdge;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Left_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Right_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.DragEdge']/field[@name='Right']"
			[Register ("Right")]
			public static global::Com.Daimajia.Swipe.SwipeLayout.DragEdge Right {
				get {
					if (Right_jfieldId == IntPtr.Zero)
						Right_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Right", "Lcom/daimajia/swipe/SwipeLayout$DragEdge;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Right_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Top_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.DragEdge']/field[@name='Top']"
			[Register ("Top")]
			public static global::Com.Daimajia.Swipe.SwipeLayout.DragEdge Top {
				get {
					if (Top_jfieldId == IntPtr.Zero)
						Top_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Top", "Lcom/daimajia/swipe/SwipeLayout$DragEdge;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Top_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/daimajia/swipe/SwipeLayout$DragEdge", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DragEdge); }
			}

			internal DragEdge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.DragEdge']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/daimajia/swipe/SwipeLayout$DragEdge;", "")]
			public static unsafe global::Com.Daimajia.Swipe.SwipeLayout.DragEdge ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/daimajia/swipe/SwipeLayout$DragEdge;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Daimajia.Swipe.SwipeLayout.DragEdge __ret = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.DragEdge']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/daimajia/swipe/SwipeLayout$DragEdge;", "")]
			public static unsafe global::Com.Daimajia.Swipe.SwipeLayout.DragEdge[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/daimajia/swipe/SwipeLayout$DragEdge;");
				try {
					return (global::Com.Daimajia.Swipe.SwipeLayout.DragEdge[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Daimajia.Swipe.SwipeLayout.DragEdge));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.OnLayout']"
		[Register ("com/daimajia/swipe/SwipeLayout$OnLayout", "", "Com.Daimajia.Swipe.SwipeLayout/IOnLayoutInvoker")]
		public partial interface IOnLayout : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.OnLayout']/method[@name='onLayout' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
			[Register ("onLayout", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnLayout_Lcom_daimajia_swipe_SwipeLayout_Handler:Com.Daimajia.Swipe.SwipeLayout/IOnLayoutInvoker, SwipeBinding")]
			void OnLayout (global::Com.Daimajia.Swipe.SwipeLayout p0);

		}

		[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout$OnLayout", DoNotGenerateAcw=true)]
		internal class IOnLayoutInvoker : global::Java.Lang.Object, IOnLayout {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/daimajia/swipe/SwipeLayout$OnLayout");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnLayoutInvoker); }
			}

			IntPtr class_ref;

			public static IOnLayout GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnLayout> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.daimajia.swipe.SwipeLayout.OnLayout"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnLayoutInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onLayout_Lcom_daimajia_swipe_SwipeLayout_;
#pragma warning disable 0169
			static Delegate GetOnLayout_Lcom_daimajia_swipe_SwipeLayout_Handler ()
			{
				if (cb_onLayout_Lcom_daimajia_swipe_SwipeLayout_ == null)
					cb_onLayout_Lcom_daimajia_swipe_SwipeLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLayout_Lcom_daimajia_swipe_SwipeLayout_);
				return cb_onLayout_Lcom_daimajia_swipe_SwipeLayout_;
			}

			static void n_OnLayout_Lcom_daimajia_swipe_SwipeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLayout (p0);
			}
#pragma warning restore 0169

			IntPtr id_onLayout_Lcom_daimajia_swipe_SwipeLayout_;
			public unsafe void OnLayout (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				if (id_onLayout_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
					id_onLayout_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "onLayout", "(Lcom/daimajia/swipe/SwipeLayout;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayout_Lcom_daimajia_swipe_SwipeLayout_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.OnRevealListener']"
		[Register ("com/daimajia/swipe/SwipeLayout$OnRevealListener", "", "Com.Daimajia.Swipe.SwipeLayout/IOnRevealListenerInvoker")]
		public partial interface IOnRevealListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.OnRevealListener']/method[@name='onReveal' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.daimajia.swipe.SwipeLayout.DragEdge'] and parameter[3][@type='float'] and parameter[4][@type='int']]"
			[Register ("onReveal", "(Landroid/view/View;Lcom/daimajia/swipe/SwipeLayout$DragEdge;FI)V", "GetOnReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FIHandler:Com.Daimajia.Swipe.SwipeLayout/IOnRevealListenerInvoker, SwipeBinding")]
			void OnReveal (global::Android.Views.View p0, global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p1, float p2, int p3);

		}

		[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout$OnRevealListener", DoNotGenerateAcw=true)]
		internal class IOnRevealListenerInvoker : global::Java.Lang.Object, IOnRevealListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/daimajia/swipe/SwipeLayout$OnRevealListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnRevealListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnRevealListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnRevealListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.daimajia.swipe.SwipeLayout.OnRevealListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnRevealListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI;
#pragma warning disable 0169
			static Delegate GetOnReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FIHandler ()
			{
				if (cb_onReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI == null)
					cb_onReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, int>) n_OnReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI);
				return cb_onReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI;
			}

			static void n_OnReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, int p3)
			{
				global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p1 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReveal (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI;
			public unsafe void OnReveal (global::Android.Views.View p0, global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p1, float p2, int p3)
			{
				if (id_onReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI == IntPtr.Zero)
					id_onReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI = JNIEnv.GetMethodID (class_ref, "onReveal", "(Landroid/view/View;Lcom/daimajia/swipe/SwipeLayout$DragEdge;FI)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReveal_Landroid_view_View_Lcom_daimajia_swipe_SwipeLayout_DragEdge_FI, __args);
			}

		}

		public partial class RevealEventArgs : global::System.EventArgs {

			public RevealEventArgs (global::Android.Views.View p0, global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p1, float p2, int p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p1;
			public global::Com.Daimajia.Swipe.SwipeLayout.DragEdge P1 {
				get { return p1; }
			}

			float p2;
			public float P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/daimajia/swipe/SwipeLayout_OnRevealListenerImplementor")]
		internal sealed partial class IOnRevealListenerImplementor : global::Java.Lang.Object, IOnRevealListener {

			object sender;

			public IOnRevealListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/daimajia/swipe/SwipeLayout_OnRevealListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<RevealEventArgs> Handler;
#pragma warning restore 0649

			public void OnReveal (global::Android.Views.View p0, global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p1, float p2, int p3)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new RevealEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IOnRevealListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.ShowMode']"
		[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout$ShowMode", DoNotGenerateAcw=true)]
		public sealed partial class ShowMode : global::Java.Lang.Enum {


			static IntPtr LayDown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.ShowMode']/field[@name='LayDown']"
			[Register ("LayDown")]
			public static global::Com.Daimajia.Swipe.SwipeLayout.ShowMode LayDown {
				get {
					if (LayDown_jfieldId == IntPtr.Zero)
						LayDown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LayDown", "Lcom/daimajia/swipe/SwipeLayout$ShowMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LayDown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ShowMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PullOut_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.ShowMode']/field[@name='PullOut']"
			[Register ("PullOut")]
			public static global::Com.Daimajia.Swipe.SwipeLayout.ShowMode PullOut {
				get {
					if (PullOut_jfieldId == IntPtr.Zero)
						PullOut_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PullOut", "Lcom/daimajia/swipe/SwipeLayout$ShowMode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PullOut_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ShowMode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/daimajia/swipe/SwipeLayout$ShowMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ShowMode); }
			}

			internal ShowMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.ShowMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/daimajia/swipe/SwipeLayout$ShowMode;", "")]
			public static unsafe global::Com.Daimajia.Swipe.SwipeLayout.ShowMode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/daimajia/swipe/SwipeLayout$ShowMode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Daimajia.Swipe.SwipeLayout.ShowMode __ret = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ShowMode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.ShowMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/daimajia/swipe/SwipeLayout$ShowMode;", "")]
			public static unsafe global::Com.Daimajia.Swipe.SwipeLayout.ShowMode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/daimajia/swipe/SwipeLayout$ShowMode;");
				try {
					return (global::Com.Daimajia.Swipe.SwipeLayout.ShowMode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Daimajia.Swipe.SwipeLayout.ShowMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.Status']"
		[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout$Status", DoNotGenerateAcw=true)]
		public sealed partial class Status : global::Java.Lang.Enum {


			static IntPtr Close_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.Status']/field[@name='Close']"
			[Register ("Close")]
			public static global::Com.Daimajia.Swipe.SwipeLayout.Status Close {
				get {
					if (Close_jfieldId == IntPtr.Zero)
						Close_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Close", "Lcom/daimajia/swipe/SwipeLayout$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Close_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Middle_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.Status']/field[@name='Middle']"
			[Register ("Middle")]
			public static global::Com.Daimajia.Swipe.SwipeLayout.Status Middle {
				get {
					if (Middle_jfieldId == IntPtr.Zero)
						Middle_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Middle", "Lcom/daimajia/swipe/SwipeLayout$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Middle_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Open_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.Status']/field[@name='Open']"
			[Register ("Open")]
			public static global::Com.Daimajia.Swipe.SwipeLayout.Status Open {
				get {
					if (Open_jfieldId == IntPtr.Zero)
						Open_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Open", "Lcom/daimajia/swipe/SwipeLayout$Status;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Open_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.Status> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/daimajia/swipe/SwipeLayout$Status", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Status); }
			}

			internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/daimajia/swipe/SwipeLayout$Status;", "")]
			public static unsafe global::Com.Daimajia.Swipe.SwipeLayout.Status ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/daimajia/swipe/SwipeLayout$Status;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Daimajia.Swipe.SwipeLayout.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.Status']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/daimajia/swipe/SwipeLayout$Status;", "")]
			public static unsafe global::Com.Daimajia.Swipe.SwipeLayout.Status[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/daimajia/swipe/SwipeLayout$Status;");
				try {
					return (global::Com.Daimajia.Swipe.SwipeLayout.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Daimajia.Swipe.SwipeLayout.Status));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.SwipeDenier']"
		[Register ("com/daimajia/swipe/SwipeLayout$SwipeDenier", "", "Com.Daimajia.Swipe.SwipeLayout/ISwipeDenierInvoker")]
		public partial interface ISwipeDenier : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.SwipeDenier']/method[@name='shouldDenySwipe' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("shouldDenySwipe", "(Landroid/view/MotionEvent;)Z", "GetShouldDenySwipe_Landroid_view_MotionEvent_Handler:Com.Daimajia.Swipe.SwipeLayout/ISwipeDenierInvoker, SwipeBinding")]
			bool ShouldDenySwipe (global::Android.Views.MotionEvent p0);

		}

		[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout$SwipeDenier", DoNotGenerateAcw=true)]
		internal class ISwipeDenierInvoker : global::Java.Lang.Object, ISwipeDenier {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/daimajia/swipe/SwipeLayout$SwipeDenier");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISwipeDenierInvoker); }
			}

			IntPtr class_ref;

			public static ISwipeDenier GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISwipeDenier> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.daimajia.swipe.SwipeLayout.SwipeDenier"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISwipeDenierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_shouldDenySwipe_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetShouldDenySwipe_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_shouldDenySwipe_Landroid_view_MotionEvent_ == null)
					cb_shouldDenySwipe_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldDenySwipe_Landroid_view_MotionEvent_);
				return cb_shouldDenySwipe_Landroid_view_MotionEvent_;
			}

			static bool n_ShouldDenySwipe_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.ShouldDenySwipe (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_shouldDenySwipe_Landroid_view_MotionEvent_;
			public unsafe bool ShouldDenySwipe (global::Android.Views.MotionEvent p0)
			{
				if (id_shouldDenySwipe_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_shouldDenySwipe_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "shouldDenySwipe", "(Landroid/view/MotionEvent;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldDenySwipe_Landroid_view_MotionEvent_, __args);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout.SwipeDetector']"
		[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout$SwipeDetector", DoNotGenerateAcw=true)]
		public partial class SwipeDetector : global::Android.Views.GestureDetector.SimpleOnGestureListener {

			protected SwipeDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.SwipeListener']"
		[Register ("com/daimajia/swipe/SwipeLayout$SwipeListener", "", "Com.Daimajia.Swipe.SwipeLayout/ISwipeListenerInvoker")]
		public partial interface ISwipeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.SwipeListener']/method[@name='onClose' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
			[Register ("onClose", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnClose_Lcom_daimajia_swipe_SwipeLayout_Handler:Com.Daimajia.Swipe.SwipeLayout/ISwipeListenerInvoker, SwipeBinding")]
			void OnClose (global::Com.Daimajia.Swipe.SwipeLayout p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.SwipeListener']/method[@name='onHandRelease' and count(parameter)=3 and parameter[1][@type='com.daimajia.swipe.SwipeLayout'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
			[Register ("onHandRelease", "(Lcom/daimajia/swipe/SwipeLayout;FF)V", "GetOnHandRelease_Lcom_daimajia_swipe_SwipeLayout_FFHandler:Com.Daimajia.Swipe.SwipeLayout/ISwipeListenerInvoker, SwipeBinding")]
			void OnHandRelease (global::Com.Daimajia.Swipe.SwipeLayout p0, float p1, float p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.SwipeListener']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
			[Register ("onOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnOpen_Lcom_daimajia_swipe_SwipeLayout_Handler:Com.Daimajia.Swipe.SwipeLayout/ISwipeListenerInvoker, SwipeBinding")]
			void OnOpen (global::Com.Daimajia.Swipe.SwipeLayout p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.SwipeListener']/method[@name='onStartClose' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
			[Register ("onStartClose", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnStartClose_Lcom_daimajia_swipe_SwipeLayout_Handler:Com.Daimajia.Swipe.SwipeLayout/ISwipeListenerInvoker, SwipeBinding")]
			void OnStartClose (global::Com.Daimajia.Swipe.SwipeLayout p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.SwipeListener']/method[@name='onStartOpen' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout']]"
			[Register ("onStartOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V", "GetOnStartOpen_Lcom_daimajia_swipe_SwipeLayout_Handler:Com.Daimajia.Swipe.SwipeLayout/ISwipeListenerInvoker, SwipeBinding")]
			void OnStartOpen (global::Com.Daimajia.Swipe.SwipeLayout p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/interface[@name='SwipeLayout.SwipeListener']/method[@name='onUpdate' and count(parameter)=3 and parameter[1][@type='com.daimajia.swipe.SwipeLayout'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onUpdate", "(Lcom/daimajia/swipe/SwipeLayout;II)V", "GetOnUpdate_Lcom_daimajia_swipe_SwipeLayout_IIHandler:Com.Daimajia.Swipe.SwipeLayout/ISwipeListenerInvoker, SwipeBinding")]
			void OnUpdate (global::Com.Daimajia.Swipe.SwipeLayout p0, int p1, int p2);

		}

		[global::Android.Runtime.Register ("com/daimajia/swipe/SwipeLayout$SwipeListener", DoNotGenerateAcw=true)]
		internal class ISwipeListenerInvoker : global::Java.Lang.Object, ISwipeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/daimajia/swipe/SwipeLayout$SwipeListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISwipeListenerInvoker); }
			}

			IntPtr class_ref;

			public static ISwipeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISwipeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.daimajia.swipe.SwipeLayout.SwipeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISwipeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnClose (p0);
			}
#pragma warning restore 0169

			IntPtr id_onClose_Lcom_daimajia_swipe_SwipeLayout_;
			public unsafe void OnClose (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				if (id_onClose_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
					id_onClose_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "onClose", "(Lcom/daimajia/swipe/SwipeLayout;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClose_Lcom_daimajia_swipe_SwipeLayout_, __args);
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
				global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnHandRelease (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF;
			public unsafe void OnHandRelease (global::Com.Daimajia.Swipe.SwipeLayout p0, float p1, float p2)
			{
				if (id_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF == IntPtr.Zero)
					id_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF = JNIEnv.GetMethodID (class_ref, "onHandRelease", "(Lcom/daimajia/swipe/SwipeLayout;FF)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHandRelease_Lcom_daimajia_swipe_SwipeLayout_FF, __args);
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
				global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnOpen (p0);
			}
#pragma warning restore 0169

			IntPtr id_onOpen_Lcom_daimajia_swipe_SwipeLayout_;
			public unsafe void OnOpen (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				if (id_onOpen_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
					id_onOpen_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "onOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpen_Lcom_daimajia_swipe_SwipeLayout_, __args);
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
				global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStartClose (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStartClose_Lcom_daimajia_swipe_SwipeLayout_;
			public unsafe void OnStartClose (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				if (id_onStartClose_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
					id_onStartClose_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "onStartClose", "(Lcom/daimajia/swipe/SwipeLayout;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartClose_Lcom_daimajia_swipe_SwipeLayout_, __args);
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
				global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStartOpen (p0);
			}
#pragma warning restore 0169

			IntPtr id_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_;
			public unsafe void OnStartOpen (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				if (id_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_ == IntPtr.Zero)
					id_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_ = JNIEnv.GetMethodID (class_ref, "onStartOpen", "(Lcom/daimajia/swipe/SwipeLayout;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartOpen_Lcom_daimajia_swipe_SwipeLayout_, __args);
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
				global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Daimajia.Swipe.SwipeLayout p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdate (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II;
			public unsafe void OnUpdate (global::Com.Daimajia.Swipe.SwipeLayout p0, int p1, int p2)
			{
				if (id_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II == IntPtr.Zero)
					id_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II = JNIEnv.GetMethodID (class_ref, "onUpdate", "(Lcom/daimajia/swipe/SwipeLayout;II)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdate_Lcom_daimajia_swipe_SwipeLayout_II, __args);
			}

		}

		public partial class CloseEventArgs : global::System.EventArgs {

			public CloseEventArgs (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				this.p0 = p0;
			}

			global::Com.Daimajia.Swipe.SwipeLayout p0;
			public global::Com.Daimajia.Swipe.SwipeLayout P0 {
				get { return p0; }
			}
		}

		public partial class HandReleaseEventArgs : global::System.EventArgs {

			public HandReleaseEventArgs (global::Com.Daimajia.Swipe.SwipeLayout p0, float p1, float p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Daimajia.Swipe.SwipeLayout p0;
			public global::Com.Daimajia.Swipe.SwipeLayout P0 {
				get { return p0; }
			}

			float p1;
			public float P1 {
				get { return p1; }
			}

			float p2;
			public float P2 {
				get { return p2; }
			}
		}

		public partial class OpenEventArgs : global::System.EventArgs {

			public OpenEventArgs (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				this.p0 = p0;
			}

			global::Com.Daimajia.Swipe.SwipeLayout p0;
			public global::Com.Daimajia.Swipe.SwipeLayout P0 {
				get { return p0; }
			}
		}

		public partial class StartCloseEventArgs : global::System.EventArgs {

			public StartCloseEventArgs (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				this.p0 = p0;
			}

			global::Com.Daimajia.Swipe.SwipeLayout p0;
			public global::Com.Daimajia.Swipe.SwipeLayout P0 {
				get { return p0; }
			}
		}

		public partial class StartOpenEventArgs : global::System.EventArgs {

			public StartOpenEventArgs (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				this.p0 = p0;
			}

			global::Com.Daimajia.Swipe.SwipeLayout p0;
			public global::Com.Daimajia.Swipe.SwipeLayout P0 {
				get { return p0; }
			}
		}

		public partial class UpdateEventArgs : global::System.EventArgs {

			public UpdateEventArgs (global::Com.Daimajia.Swipe.SwipeLayout p0, int p1, int p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			global::Com.Daimajia.Swipe.SwipeLayout p0;
			public global::Com.Daimajia.Swipe.SwipeLayout P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/daimajia/swipe/SwipeLayout_SwipeListenerImplementor")]
		internal sealed partial class ISwipeListenerImplementor : global::Java.Lang.Object, ISwipeListener {

			object sender;

			public ISwipeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/daimajia/swipe/SwipeLayout_SwipeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<CloseEventArgs> OnCloseHandler;
#pragma warning restore 0649

			public void OnClose (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				var __h = OnCloseHandler;
				if (__h != null)
					__h (sender, new CloseEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<HandReleaseEventArgs> OnHandReleaseHandler;
#pragma warning restore 0649

			public void OnHandRelease (global::Com.Daimajia.Swipe.SwipeLayout p0, float p1, float p2)
			{
				var __h = OnHandReleaseHandler;
				if (__h != null)
					__h (sender, new HandReleaseEventArgs (p0, p1, p2));
			}
#pragma warning disable 0649
			public EventHandler<OpenEventArgs> OnOpenHandler;
#pragma warning restore 0649

			public void OnOpen (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				var __h = OnOpenHandler;
				if (__h != null)
					__h (sender, new OpenEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<StartCloseEventArgs> OnStartCloseHandler;
#pragma warning restore 0649

			public void OnStartClose (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				var __h = OnStartCloseHandler;
				if (__h != null)
					__h (sender, new StartCloseEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<StartOpenEventArgs> OnStartOpenHandler;
#pragma warning restore 0649

			public void OnStartOpen (global::Com.Daimajia.Swipe.SwipeLayout p0)
			{
				var __h = OnStartOpenHandler;
				if (__h != null)
					__h (sender, new StartOpenEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<UpdateEventArgs> OnUpdateHandler;
#pragma warning restore 0649

			public void OnUpdate (global::Com.Daimajia.Swipe.SwipeLayout p0, int p1, int p2)
			{
				var __h = OnUpdateHandler;
				if (__h != null)
					__h (sender, new UpdateEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (ISwipeListenerImplementor value)
			{
				return value.OnCloseHandler == null && value.OnHandReleaseHandler == null && value.OnOpenHandler == null && value.OnStartCloseHandler == null && value.OnStartOpenHandler == null && value.OnUpdateHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/daimajia/swipe/SwipeLayout", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SwipeLayout); }
		}

		protected SwipeLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/constructor[@name='SwipeLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe SwipeLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (SwipeLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/constructor[@name='SwipeLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe SwipeLayout (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (SwipeLayout)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/constructor[@name='SwipeLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe SwipeLayout (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SwipeLayout)) {
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

		static Delegate cb_isBottomSwipeEnabled;
#pragma warning disable 0169
		static Delegate GetIsBottomSwipeEnabledHandler ()
		{
			if (cb_isBottomSwipeEnabled == null)
				cb_isBottomSwipeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBottomSwipeEnabled);
			return cb_isBottomSwipeEnabled;
		}

		static bool n_IsBottomSwipeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BottomSwipeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setBottomSwipeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetBottomSwipeEnabled_ZHandler ()
		{
			if (cb_setBottomSwipeEnabled_Z == null)
				cb_setBottomSwipeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBottomSwipeEnabled_Z);
			return cb_setBottomSwipeEnabled_Z;
		}

		static void n_SetBottomSwipeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BottomSwipeEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isBottomSwipeEnabled;
		static IntPtr id_setBottomSwipeEnabled_Z;
		public virtual unsafe bool BottomSwipeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='isBottomSwipeEnabled' and count(parameter)=0]"
			[Register ("isBottomSwipeEnabled", "()Z", "GetIsBottomSwipeEnabledHandler")]
			get {
				if (id_isBottomSwipeEnabled == IntPtr.Zero)
					id_isBottomSwipeEnabled = JNIEnv.GetMethodID (class_ref, "isBottomSwipeEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBottomSwipeEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBottomSwipeEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setBottomSwipeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBottomSwipeEnabled", "(Z)V", "GetSetBottomSwipeEnabled_ZHandler")]
			set {
				if (id_setBottomSwipeEnabled_Z == IntPtr.Zero)
					id_setBottomSwipeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setBottomSwipeEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBottomSwipeEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBottomSwipeEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBottomViews;
#pragma warning disable 0169
		static Delegate GetGetBottomViewsHandler ()
		{
			if (cb_getBottomViews == null)
				cb_getBottomViews = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBottomViews);
			return cb_getBottomViews;
		}

		static IntPtr n_GetBottomViews (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Views.View>.ToLocalJniHandle (__this.BottomViews);
		}
#pragma warning restore 0169

		static IntPtr id_getBottomViews;
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Views.View> BottomViews {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getBottomViews' and count(parameter)=0]"
			[Register ("getBottomViews", "()Ljava/util/List;", "GetGetBottomViewsHandler")]
			get {
				if (id_getBottomViews == IntPtr.Zero)
					id_getBottomViews = JNIEnv.GetMethodID (class_ref, "getBottomViews", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBottomViews), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Android.Views.View>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBottomViews", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isClickToClose;
#pragma warning disable 0169
		static Delegate GetIsClickToCloseHandler ()
		{
			if (cb_isClickToClose == null)
				cb_isClickToClose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClickToClose);
			return cb_isClickToClose;
		}

		static bool n_IsClickToClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClickToClose;
		}
#pragma warning restore 0169

		static Delegate cb_setClickToClose_Z;
#pragma warning disable 0169
		static Delegate GetSetClickToClose_ZHandler ()
		{
			if (cb_setClickToClose_Z == null)
				cb_setClickToClose_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetClickToClose_Z);
			return cb_setClickToClose_Z;
		}

		static void n_SetClickToClose_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClickToClose = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isClickToClose;
		static IntPtr id_setClickToClose_Z;
		public virtual unsafe bool ClickToClose {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='isClickToClose' and count(parameter)=0]"
			[Register ("isClickToClose", "()Z", "GetIsClickToCloseHandler")]
			get {
				if (id_isClickToClose == IntPtr.Zero)
					id_isClickToClose = JNIEnv.GetMethodID (class_ref, "isClickToClose", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClickToClose);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClickToClose", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setClickToClose' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setClickToClose", "(Z)V", "GetSetClickToClose_ZHandler")]
			set {
				if (id_setClickToClose_Z == IntPtr.Zero)
					id_setClickToClose_Z = JNIEnv.GetMethodID (class_ref, "setClickToClose", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClickToClose_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClickToClose", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentBottomView;
#pragma warning disable 0169
		static Delegate GetGetCurrentBottomViewHandler ()
		{
			if (cb_getCurrentBottomView == null)
				cb_getCurrentBottomView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentBottomView);
			return cb_getCurrentBottomView;
		}

		static IntPtr n_GetCurrentBottomView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentBottomView);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentBottomView;
		public virtual unsafe global::Android.Views.View CurrentBottomView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getCurrentBottomView' and count(parameter)=0]"
			[Register ("getCurrentBottomView", "()Landroid/view/View;", "GetGetCurrentBottomViewHandler")]
			get {
				if (id_getCurrentBottomView == IntPtr.Zero)
					id_getCurrentBottomView = JNIEnv.GetMethodID (class_ref, "getCurrentBottomView", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentBottomView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentBottomView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDragDistance;
#pragma warning disable 0169
		static Delegate GetGetDragDistanceHandler ()
		{
			if (cb_getDragDistance == null)
				cb_getDragDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDragDistance);
			return cb_getDragDistance;
		}

		static int n_GetDragDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DragDistance;
		}
#pragma warning restore 0169

		static Delegate cb_setDragDistance_I;
#pragma warning disable 0169
		static Delegate GetSetDragDistance_IHandler ()
		{
			if (cb_setDragDistance_I == null)
				cb_setDragDistance_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDragDistance_I);
			return cb_setDragDistance_I;
		}

		static void n_SetDragDistance_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DragDistance = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDragDistance;
		static IntPtr id_setDragDistance_I;
		public virtual unsafe int DragDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getDragDistance' and count(parameter)=0]"
			[Register ("getDragDistance", "()I", "GetGetDragDistanceHandler")]
			get {
				if (id_getDragDistance == IntPtr.Zero)
					id_getDragDistance = JNIEnv.GetMethodID (class_ref, "getDragDistance", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDragDistance);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDragDistance", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setDragDistance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDragDistance", "(I)V", "GetSetDragDistance_IHandler")]
			set {
				if (id_setDragDistance_I == IntPtr.Zero)
					id_setDragDistance_I = JNIEnv.GetMethodID (class_ref, "setDragDistance", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDragDistance_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDragDistance", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDragEdgeMap;
#pragma warning disable 0169
		static Delegate GetGetDragEdgeMapHandler ()
		{
			if (cb_getDragEdgeMap == null)
				cb_getDragEdgeMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDragEdgeMap);
			return cb_getDragEdgeMap;
		}

		static IntPtr n_GetDragEdgeMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge, global::Android.Views.View>.ToLocalJniHandle (__this.DragEdgeMap);
		}
#pragma warning restore 0169

		static IntPtr id_getDragEdgeMap;
		public virtual unsafe global::System.Collections.Generic.IDictionary<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge, global::Android.Views.View> DragEdgeMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getDragEdgeMap' and count(parameter)=0]"
			[Register ("getDragEdgeMap", "()Ljava/util/Map;", "GetGetDragEdgeMapHandler")]
			get {
				if (id_getDragEdgeMap == IntPtr.Zero)
					id_getDragEdgeMap = JNIEnv.GetMethodID (class_ref, "getDragEdgeMap", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge, global::Android.Views.View>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDragEdgeMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge, global::Android.Views.View>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDragEdgeMap", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDragEdges;
#pragma warning disable 0169
		static Delegate GetGetDragEdgesHandler ()
		{
			if (cb_getDragEdges == null)
				cb_getDragEdges = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDragEdges);
			return cb_getDragEdges;
		}

		static IntPtr n_GetDragEdges (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge>.ToLocalJniHandle (__this.DragEdges);
		}
#pragma warning restore 0169

		static Delegate cb_setDragEdges_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDragEdges_Ljava_util_List_Handler ()
		{
			if (cb_setDragEdges_Ljava_util_List_ == null)
				cb_setDragEdges_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDragEdges_Ljava_util_List_);
			return cb_setDragEdges_Ljava_util_List_;
		}

		static void n_SetDragEdges_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DragEdges = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDragEdges;
		static IntPtr id_setDragEdges_Ljava_util_List_;
		[Obsolete (@"deprecated")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> DragEdges {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getDragEdges' and count(parameter)=0]"
			[Register ("getDragEdges", "()Ljava/util/List;", "GetGetDragEdgesHandler")]
			get {
				if (id_getDragEdges == IntPtr.Zero)
					id_getDragEdges = JNIEnv.GetMethodID (class_ref, "getDragEdges", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDragEdges), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDragEdges", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setDragEdges' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.daimajia.swipe.SwipeLayout.DragEdge&gt;']]"
			[Register ("setDragEdges", "(Ljava/util/List;)V", "GetSetDragEdges_Ljava_util_List_Handler")]
			set {
				if (id_setDragEdges_Ljava_util_List_ == IntPtr.Zero)
					id_setDragEdges_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setDragEdges", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDragEdges_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDragEdges", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isLeftSwipeEnabled;
#pragma warning disable 0169
		static Delegate GetIsLeftSwipeEnabledHandler ()
		{
			if (cb_isLeftSwipeEnabled == null)
				cb_isLeftSwipeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLeftSwipeEnabled);
			return cb_isLeftSwipeEnabled;
		}

		static bool n_IsLeftSwipeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LeftSwipeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setLeftSwipeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetLeftSwipeEnabled_ZHandler ()
		{
			if (cb_setLeftSwipeEnabled_Z == null)
				cb_setLeftSwipeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLeftSwipeEnabled_Z);
			return cb_setLeftSwipeEnabled_Z;
		}

		static void n_SetLeftSwipeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LeftSwipeEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isLeftSwipeEnabled;
		static IntPtr id_setLeftSwipeEnabled_Z;
		public virtual unsafe bool LeftSwipeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='isLeftSwipeEnabled' and count(parameter)=0]"
			[Register ("isLeftSwipeEnabled", "()Z", "GetIsLeftSwipeEnabledHandler")]
			get {
				if (id_isLeftSwipeEnabled == IntPtr.Zero)
					id_isLeftSwipeEnabled = JNIEnv.GetMethodID (class_ref, "isLeftSwipeEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLeftSwipeEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLeftSwipeEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setLeftSwipeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLeftSwipeEnabled", "(Z)V", "GetSetLeftSwipeEnabled_ZHandler")]
			set {
				if (id_setLeftSwipeEnabled_Z == IntPtr.Zero)
					id_setLeftSwipeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setLeftSwipeEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLeftSwipeEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLeftSwipeEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOpenStatus;
#pragma warning disable 0169
		static Delegate GetGetOpenStatusHandler ()
		{
			if (cb_getOpenStatus == null)
				cb_getOpenStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpenStatus);
			return cb_getOpenStatus;
		}

		static IntPtr n_GetOpenStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OpenStatus);
		}
#pragma warning restore 0169

		static IntPtr id_getOpenStatus;
		public virtual unsafe global::Com.Daimajia.Swipe.SwipeLayout.Status OpenStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getOpenStatus' and count(parameter)=0]"
			[Register ("getOpenStatus", "()Lcom/daimajia/swipe/SwipeLayout$Status;", "GetGetOpenStatusHandler")]
			get {
				if (id_getOpenStatus == IntPtr.Zero)
					id_getOpenStatus = JNIEnv.GetMethodID (class_ref, "getOpenStatus", "()Lcom/daimajia/swipe/SwipeLayout$Status;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.Status> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOpenStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.Status> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpenStatus", "()Lcom/daimajia/swipe/SwipeLayout$Status;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRightSwipeEnabled;
#pragma warning disable 0169
		static Delegate GetIsRightSwipeEnabledHandler ()
		{
			if (cb_isRightSwipeEnabled == null)
				cb_isRightSwipeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRightSwipeEnabled);
			return cb_isRightSwipeEnabled;
		}

		static bool n_IsRightSwipeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RightSwipeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setRightSwipeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetRightSwipeEnabled_ZHandler ()
		{
			if (cb_setRightSwipeEnabled_Z == null)
				cb_setRightSwipeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRightSwipeEnabled_Z);
			return cb_setRightSwipeEnabled_Z;
		}

		static void n_SetRightSwipeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RightSwipeEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isRightSwipeEnabled;
		static IntPtr id_setRightSwipeEnabled_Z;
		public virtual unsafe bool RightSwipeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='isRightSwipeEnabled' and count(parameter)=0]"
			[Register ("isRightSwipeEnabled", "()Z", "GetIsRightSwipeEnabledHandler")]
			get {
				if (id_isRightSwipeEnabled == IntPtr.Zero)
					id_isRightSwipeEnabled = JNIEnv.GetMethodID (class_ref, "isRightSwipeEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRightSwipeEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRightSwipeEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setRightSwipeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRightSwipeEnabled", "(Z)V", "GetSetRightSwipeEnabled_ZHandler")]
			set {
				if (id_setRightSwipeEnabled_Z == IntPtr.Zero)
					id_setRightSwipeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setRightSwipeEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRightSwipeEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRightSwipeEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSurfaceView;
#pragma warning disable 0169
		static Delegate GetGetSurfaceViewHandler ()
		{
			if (cb_getSurfaceView == null)
				cb_getSurfaceView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurfaceView);
			return cb_getSurfaceView;
		}

		static IntPtr n_GetSurfaceView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceView);
		}
#pragma warning restore 0169

		static IntPtr id_getSurfaceView;
		public virtual unsafe global::Android.Views.View SurfaceView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getSurfaceView' and count(parameter)=0]"
			[Register ("getSurfaceView", "()Landroid/view/View;", "GetGetSurfaceViewHandler")]
			get {
				if (id_getSurfaceView == IntPtr.Zero)
					id_getSurfaceView = JNIEnv.GetMethodID (class_ref, "getSurfaceView", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurfaceView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSurfaceView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isSwipeEnabled;
#pragma warning disable 0169
		static Delegate GetIsSwipeEnabledHandler ()
		{
			if (cb_isSwipeEnabled == null)
				cb_isSwipeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSwipeEnabled);
			return cb_isSwipeEnabled;
		}

		static bool n_IsSwipeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SwipeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setSwipeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetSwipeEnabled_ZHandler ()
		{
			if (cb_setSwipeEnabled_Z == null)
				cb_setSwipeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSwipeEnabled_Z);
			return cb_setSwipeEnabled_Z;
		}

		static void n_SetSwipeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwipeEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSwipeEnabled;
		static IntPtr id_setSwipeEnabled_Z;
		public virtual unsafe bool SwipeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='isSwipeEnabled' and count(parameter)=0]"
			[Register ("isSwipeEnabled", "()Z", "GetIsSwipeEnabledHandler")]
			get {
				if (id_isSwipeEnabled == IntPtr.Zero)
					id_isSwipeEnabled = JNIEnv.GetMethodID (class_ref, "isSwipeEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSwipeEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSwipeEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setSwipeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSwipeEnabled", "(Z)V", "GetSetSwipeEnabled_ZHandler")]
			set {
				if (id_setSwipeEnabled_Z == IntPtr.Zero)
					id_setSwipeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setSwipeEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSwipeEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSwipeEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTopSwipeEnabled;
#pragma warning disable 0169
		static Delegate GetIsTopSwipeEnabledHandler ()
		{
			if (cb_isTopSwipeEnabled == null)
				cb_isTopSwipeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTopSwipeEnabled);
			return cb_isTopSwipeEnabled;
		}

		static bool n_IsTopSwipeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TopSwipeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setTopSwipeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetTopSwipeEnabled_ZHandler ()
		{
			if (cb_setTopSwipeEnabled_Z == null)
				cb_setTopSwipeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTopSwipeEnabled_Z);
			return cb_setTopSwipeEnabled_Z;
		}

		static void n_SetTopSwipeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TopSwipeEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isTopSwipeEnabled;
		static IntPtr id_setTopSwipeEnabled_Z;
		public virtual unsafe bool TopSwipeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='isTopSwipeEnabled' and count(parameter)=0]"
			[Register ("isTopSwipeEnabled", "()Z", "GetIsTopSwipeEnabledHandler")]
			get {
				if (id_isTopSwipeEnabled == IntPtr.Zero)
					id_isTopSwipeEnabled = JNIEnv.GetMethodID (class_ref, "isTopSwipeEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTopSwipeEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTopSwipeEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setTopSwipeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTopSwipeEnabled", "(Z)V", "GetSetTopSwipeEnabled_ZHandler")]
			set {
				if (id_setTopSwipeEnabled_Z == IntPtr.Zero)
					id_setTopSwipeEnabled_Z = JNIEnv.GetMethodID (class_ref, "setTopSwipeEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTopSwipeEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopSwipeEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetAddDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Handler ()
		{
			if (cb_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_ == null)
				cb_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_);
			return cb_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_;
		}

		static void n_AddDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddDrag (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='addDrag' and count(parameter)=2 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.DragEdge'] and parameter[2][@type='android.view.View']]"
		[Register ("addDrag", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;Landroid/view/View;)V", "GetAddDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Handler")]
		public virtual unsafe void AddDrag (global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p0, global::Android.Views.View p1)
		{
			if (id_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_ == IntPtr.Zero)
				id_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "addDrag", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDrag", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetAddDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler ()
		{
			if (cb_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
				cb_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_);
			return cb_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		static void n_AddDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ViewGroup.LayoutParams p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup.LayoutParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddDrag (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='addDrag' and count(parameter)=3 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.DragEdge'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup.LayoutParams']]"
		[Register ("addDrag", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", "GetAddDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler")]
		public virtual unsafe void AddDrag (global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p0, global::Android.Views.View p1, global::Android.Views.ViewGroup.LayoutParams p2)
		{
			if (id_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
				id_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "addDrag", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addDrag_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addDrag", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_;
#pragma warning disable 0169
		static Delegate GetAddOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_Handler ()
		{
			if (cb_addOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ == null)
				cb_addOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_);
			return cb_addOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_;
		}

		static void n_AddOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout p0 = (global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOnLayoutListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='addOnLayoutListener' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.OnLayout']]"
		[Register ("addOnLayoutListener", "(Lcom/daimajia/swipe/SwipeLayout$OnLayout;)V", "GetAddOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_Handler")]
		public virtual unsafe void AddOnLayoutListener (global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout p0)
		{
			if (id_addOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ == IntPtr.Zero)
				id_addOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ = JNIEnv.GetMethodID (class_ref, "addOnLayoutListener", "(Lcom/daimajia/swipe/SwipeLayout$OnLayout;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnLayoutListener", "(Lcom/daimajia/swipe/SwipeLayout$OnLayout;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_;
#pragma warning disable 0169
		static Delegate GetAddRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_Handler ()
		{
			if (cb_addRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ == null)
				cb_addRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_);
			return cb_addRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_;
		}

		static void n_AddRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener p1 = (global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddRevealListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='addRevealListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.daimajia.swipe.SwipeLayout.OnRevealListener']]"
		[Register ("addRevealListener", "(ILcom/daimajia/swipe/SwipeLayout$OnRevealListener;)V", "GetAddRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_Handler")]
		public virtual unsafe void AddRevealListener (int p0, global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener p1)
		{
			if (id_addRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ == IntPtr.Zero)
				id_addRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ = JNIEnv.GetMethodID (class_ref, "addRevealListener", "(ILcom/daimajia/swipe/SwipeLayout$OnRevealListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRevealListener", "(ILcom/daimajia/swipe/SwipeLayout$OnRevealListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_;
#pragma warning disable 0169
		static Delegate GetAddRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_Handler ()
		{
			if (cb_addRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ == null)
				cb_addRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_);
			return cb_addRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_;
		}

		static void n_AddRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener p1 = (global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddRevealListener (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_addRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='addRevealListener' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='com.daimajia.swipe.SwipeLayout.OnRevealListener']]"
		[Register ("addRevealListener", "([ILcom/daimajia/swipe/SwipeLayout$OnRevealListener;)V", "GetAddRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_Handler")]
		public virtual unsafe void AddRevealListener (int[] p0, global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener p1)
		{
			if (id_addRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ == IntPtr.Zero)
				id_addRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ = JNIEnv.GetMethodID (class_ref, "addRevealListener", "([ILcom/daimajia/swipe/SwipeLayout$OnRevealListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addRevealListener_arrayILcom_daimajia_swipe_SwipeLayout_OnRevealListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRevealListener", "([ILcom/daimajia/swipe/SwipeLayout$OnRevealListener;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_;
#pragma warning disable 0169
		static Delegate GetAddSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_Handler ()
		{
			if (cb_addSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ == null)
				cb_addSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_);
			return cb_addSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_;
		}

		static void n_AddSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier p0 = (global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddSwipeDenier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='addSwipeDenier' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.SwipeDenier']]"
		[Register ("addSwipeDenier", "(Lcom/daimajia/swipe/SwipeLayout$SwipeDenier;)V", "GetAddSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_Handler")]
		public virtual unsafe void AddSwipeDenier (global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier p0)
		{
			if (id_addSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ == IntPtr.Zero)
				id_addSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ = JNIEnv.GetMethodID (class_ref, "addSwipeDenier", "(Lcom/daimajia/swipe/SwipeLayout$SwipeDenier;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSwipeDenier", "(Lcom/daimajia/swipe/SwipeLayout$SwipeDenier;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_;
#pragma warning disable 0169
		static Delegate GetAddSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_Handler ()
		{
			if (cb_addSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ == null)
				cb_addSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_);
			return cb_addSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_;
		}

		static void n_AddSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener p0 = (global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddSwipeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='addSwipeListener' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.SwipeListener']]"
		[Register ("addSwipeListener", "(Lcom/daimajia/swipe/SwipeLayout$SwipeListener;)V", "GetAddSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_Handler")]
		public virtual unsafe void AddSwipeListener (global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener p0)
		{
			if (id_addSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ == IntPtr.Zero)
				id_addSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ = JNIEnv.GetMethodID (class_ref, "addSwipeListener", "(Lcom/daimajia/swipe/SwipeLayout$SwipeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSwipeListener", "(Lcom/daimajia/swipe/SwipeLayout$SwipeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_close_Z;
#pragma warning disable 0169
		static Delegate GetClose_ZHandler ()
		{
			if (cb_close_Z == null)
				cb_close_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Close_Z);
			return cb_close_Z;
		}

		static void n_Close_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0);
		}
#pragma warning restore 0169

		static IntPtr id_close_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='close' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("close", "(Z)V", "GetClose_ZHandler")]
		public virtual unsafe void Close (bool p0)
		{
			if (id_close_Z == IntPtr.Zero)
				id_close_Z = JNIEnv.GetMethodID (class_ref, "close", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_close_ZZ;
#pragma warning disable 0169
		static Delegate GetClose_ZZHandler ()
		{
			if (cb_close_ZZ == null)
				cb_close_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_Close_ZZ);
			return cb_close_ZZ;
		}

		static void n_Close_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_close_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='close' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("close", "(ZZ)V", "GetClose_ZZHandler")]
		public virtual unsafe void Close (bool p0, bool p1)
		{
			if (id_close_ZZ == IntPtr.Zero)
				id_close_ZZ = JNIEnv.GetMethodID (class_ref, "close", "(ZZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "(ZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_dispatchRevealEvent_IIII;
#pragma warning disable 0169
		static Delegate GetDispatchRevealEvent_IIIIHandler ()
		{
			if (cb_dispatchRevealEvent_IIII == null)
				cb_dispatchRevealEvent_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_DispatchRevealEvent_IIII);
			return cb_dispatchRevealEvent_IIII;
		}

		static void n_DispatchRevealEvent_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchRevealEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchRevealEvent_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='dispatchRevealEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("dispatchRevealEvent", "(IIII)V", "GetDispatchRevealEvent_IIIIHandler")]
		protected virtual unsafe void DispatchRevealEvent (int p0, int p1, int p2, int p3)
		{
			if (id_dispatchRevealEvent_IIII == IntPtr.Zero)
				id_dispatchRevealEvent_IIII = JNIEnv.GetMethodID (class_ref, "dispatchRevealEvent", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispatchRevealEvent_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchRevealEvent", "(IIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_dispatchSwipeEvent_IIZ;
#pragma warning disable 0169
		static Delegate GetDispatchSwipeEvent_IIZHandler ()
		{
			if (cb_dispatchSwipeEvent_IIZ == null)
				cb_dispatchSwipeEvent_IIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, bool>) n_DispatchSwipeEvent_IIZ);
			return cb_dispatchSwipeEvent_IIZ;
		}

		static void n_DispatchSwipeEvent_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSwipeEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchSwipeEvent_IIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='dispatchSwipeEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("dispatchSwipeEvent", "(IIZ)V", "GetDispatchSwipeEvent_IIZHandler")]
		protected virtual unsafe void DispatchSwipeEvent (int p0, int p1, bool p2)
		{
			if (id_dispatchSwipeEvent_IIZ == IntPtr.Zero)
				id_dispatchSwipeEvent_IIZ = JNIEnv.GetMethodID (class_ref, "dispatchSwipeEvent", "(IIZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispatchSwipeEvent_IIZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchSwipeEvent", "(IIZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_dispatchSwipeEvent_IIII;
#pragma warning disable 0169
		static Delegate GetDispatchSwipeEvent_IIIIHandler ()
		{
			if (cb_dispatchSwipeEvent_IIII == null)
				cb_dispatchSwipeEvent_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_DispatchSwipeEvent_IIII);
			return cb_dispatchSwipeEvent_IIII;
		}

		static void n_DispatchSwipeEvent_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchSwipeEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_dispatchSwipeEvent_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='dispatchSwipeEvent' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("dispatchSwipeEvent", "(IIII)V", "GetDispatchSwipeEvent_IIIIHandler")]
		protected virtual unsafe void DispatchSwipeEvent (int p0, int p1, int p2, int p3)
		{
			if (id_dispatchSwipeEvent_IIII == IntPtr.Zero)
				id_dispatchSwipeEvent_IIII = JNIEnv.GetMethodID (class_ref, "dispatchSwipeEvent", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispatchSwipeEvent_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchSwipeEvent", "(IIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getDragEdge;
#pragma warning disable 0169
		static Delegate GetGetDragEdgeHandler ()
		{
			if (cb_getDragEdge == null)
				cb_getDragEdge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDragEdge);
			return cb_getDragEdge;
		}

		static IntPtr n_GetDragEdge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDragEdge ());
		}
#pragma warning restore 0169

		static IntPtr id_getDragEdge;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getDragEdge' and count(parameter)=0]"
		[Register ("getDragEdge", "()Lcom/daimajia/swipe/SwipeLayout$DragEdge;", "GetGetDragEdgeHandler")]
		public virtual unsafe global::Com.Daimajia.Swipe.SwipeLayout.DragEdge GetDragEdge ()
		{
			if (id_getDragEdge == IntPtr.Zero)
				id_getDragEdge = JNIEnv.GetMethodID (class_ref, "getDragEdge", "()Lcom/daimajia/swipe/SwipeLayout$DragEdge;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDragEdge), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDragEdge", "()Lcom/daimajia/swipe/SwipeLayout$DragEdge;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRelativePosition_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetGetRelativePosition_Landroid_view_View_Handler ()
		{
			if (cb_getRelativePosition_Landroid_view_View_ == null)
				cb_getRelativePosition_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRelativePosition_Landroid_view_View_);
			return cb_getRelativePosition_Landroid_view_View_;
		}

		static IntPtr n_GetRelativePosition_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRelativePosition (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRelativePosition_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getRelativePosition' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getRelativePosition", "(Landroid/view/View;)Landroid/graphics/Rect;", "GetGetRelativePosition_Landroid_view_View_Handler")]
		protected virtual unsafe global::Android.Graphics.Rect GetRelativePosition (global::Android.Views.View p0)
		{
			if (id_getRelativePosition_Landroid_view_View_ == IntPtr.Zero)
				id_getRelativePosition_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "getRelativePosition", "(Landroid/view/View;)Landroid/graphics/Rect;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Graphics.Rect __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRelativePosition_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelativePosition", "(Landroid/view/View;)Landroid/graphics/Rect;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getShowMode;
#pragma warning disable 0169
		static Delegate GetGetShowModeHandler ()
		{
			if (cb_getShowMode == null)
				cb_getShowMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShowMode);
			return cb_getShowMode;
		}

		static IntPtr n_GetShowMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetShowMode ());
		}
#pragma warning restore 0169

		static IntPtr id_getShowMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='getShowMode' and count(parameter)=0]"
		[Register ("getShowMode", "()Lcom/daimajia/swipe/SwipeLayout$ShowMode;", "GetGetShowModeHandler")]
		public virtual unsafe global::Com.Daimajia.Swipe.SwipeLayout.ShowMode GetShowMode ()
		{
			if (id_getShowMode == IntPtr.Zero)
				id_getShowMode = JNIEnv.GetMethodID (class_ref, "getShowMode", "()Lcom/daimajia/swipe/SwipeLayout$ShowMode;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ShowMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShowMode), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ShowMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShowMode", "()Lcom/daimajia/swipe/SwipeLayout$ShowMode;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII;
#pragma warning disable 0169
		static Delegate GetIsViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIIIHandler ()
		{
			if (cb_isViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII == null)
				cb_isViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, bool>) n_IsViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII);
			return cb_isViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII;
		}

		static bool n_IsViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, int p5, int p6)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p2 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsViewShowing (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='isViewShowing' and count(parameter)=7 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='com.daimajia.swipe.SwipeLayout.DragEdge'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("isViewShowing", "(Landroid/view/View;Landroid/graphics/Rect;Lcom/daimajia/swipe/SwipeLayout$DragEdge;IIII)Z", "GetIsViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIIIHandler")]
		protected virtual unsafe bool IsViewShowing (global::Android.Views.View p0, global::Android.Graphics.Rect p1, global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p2, int p3, int p4, int p5, int p6)
		{
			if (id_isViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII == IntPtr.Zero)
				id_isViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII = JNIEnv.GetMethodID (class_ref, "isViewShowing", "(Landroid/view/View;Landroid/graphics/Rect;Lcom/daimajia/swipe/SwipeLayout$DragEdge;IIII)Z");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isViewShowing_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isViewShowing", "(Landroid/view/View;Landroid/graphics/Rect;Lcom/daimajia/swipe/SwipeLayout$DragEdge;IIII)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII;
#pragma warning disable 0169
		static Delegate GetIsViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIIIHandler ()
		{
			if (cb_isViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII == null)
				cb_isViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int, bool>) n_IsViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII);
			return cb_isViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII;
		}

		static bool n_IsViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, int p5, int p6)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p2 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsViewTotallyFirstShowed (p0, p1, p2, p3, p4, p5, p6);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='isViewTotallyFirstShowed' and count(parameter)=7 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.Rect'] and parameter[3][@type='com.daimajia.swipe.SwipeLayout.DragEdge'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("isViewTotallyFirstShowed", "(Landroid/view/View;Landroid/graphics/Rect;Lcom/daimajia/swipe/SwipeLayout$DragEdge;IIII)Z", "GetIsViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIIIHandler")]
		protected virtual unsafe bool IsViewTotallyFirstShowed (global::Android.Views.View p0, global::Android.Graphics.Rect p1, global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p2, int p3, int p4, int p5, int p6)
		{
			if (id_isViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII == IntPtr.Zero)
				id_isViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII = JNIEnv.GetMethodID (class_ref, "isViewTotallyFirstShowed", "(Landroid/view/View;Landroid/graphics/Rect;Lcom/daimajia/swipe/SwipeLayout$DragEdge;IIII)Z");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isViewTotallyFirstShowed_Landroid_view_View_Landroid_graphics_Rect_Lcom_daimajia_swipe_SwipeLayout_DragEdge_IIII, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isViewTotallyFirstShowed", "(Landroid/view/View;Landroid/graphics/Rect;Lcom/daimajia/swipe/SwipeLayout$DragEdge;IIII)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onViewRemoved_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnViewRemoved_Landroid_view_View_Handler ()
		{
			if (cb_onViewRemoved_Landroid_view_View_ == null)
				cb_onViewRemoved_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnViewRemoved_Landroid_view_View_);
			return cb_onViewRemoved_Landroid_view_View_;
		}

		static void n_OnViewRemoved_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnViewRemoved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onViewRemoved_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='onViewRemoved' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onViewRemoved", "(Landroid/view/View;)V", "GetOnViewRemoved_Landroid_view_View_Handler")]
		protected virtual unsafe void OnViewRemoved (global::Android.Views.View p0)
		{
			if (id_onViewRemoved_Landroid_view_View_ == IntPtr.Zero)
				id_onViewRemoved_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "onViewRemoved", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onViewRemoved_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onViewRemoved", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public virtual unsafe void Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "()V"));
			} finally {
			}
		}

		static Delegate cb_open_Z;
#pragma warning disable 0169
		static Delegate GetOpen_ZHandler ()
		{
			if (cb_open_Z == null)
				cb_open_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Open_Z);
			return cb_open_Z;
		}

		static void n_Open_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0);
		}
#pragma warning restore 0169

		static IntPtr id_open_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='open' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("open", "(Z)V", "GetOpen_ZHandler")]
		public virtual unsafe void Open (bool p0)
		{
			if (id_open_Z == IntPtr.Zero)
				id_open_Z = JNIEnv.GetMethodID (class_ref, "open", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_open_ZZ;
#pragma warning disable 0169
		static Delegate GetOpen_ZZHandler ()
		{
			if (cb_open_ZZ == null)
				cb_open_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_Open_ZZ);
			return cb_open_ZZ;
		}

		static void n_Open_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_open_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='open' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("open", "(ZZ)V", "GetOpen_ZZHandler")]
		public virtual unsafe void Open (bool p0, bool p1)
		{
			if (id_open_ZZ == IntPtr.Zero)
				id_open_ZZ = JNIEnv.GetMethodID (class_ref, "open", "(ZZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(ZZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_;
#pragma warning disable 0169
		static Delegate GetOpen_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_Handler ()
		{
			if (cb_open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_ == null)
				cb_open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool, IntPtr>) n_Open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_);
			return cb_open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_;
		}

		static void n_Open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, IntPtr native_p2)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p2 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='open' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='com.daimajia.swipe.SwipeLayout.DragEdge']]"
		[Register ("open", "(ZZLcom/daimajia/swipe/SwipeLayout$DragEdge;)V", "GetOpen_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_Handler")]
		public virtual unsafe void Open (bool p0, bool p1, global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p2)
		{
			if (id_open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_ == IntPtr.Zero)
				id_open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNIEnv.GetMethodID (class_ref, "open", "(ZZLcom/daimajia/swipe/SwipeLayout$DragEdge;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open_ZZLcom_daimajia_swipe_SwipeLayout_DragEdge_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(ZZLcom/daimajia/swipe/SwipeLayout$DragEdge;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_;
#pragma warning disable 0169
		static Delegate GetOpen_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_Handler ()
		{
			if (cb_open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_ == null)
				cb_open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_Open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_);
			return cb_open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_;
		}

		static void n_Open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p1 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='open' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.daimajia.swipe.SwipeLayout.DragEdge']]"
		[Register ("open", "(ZLcom/daimajia/swipe/SwipeLayout$DragEdge;)V", "GetOpen_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_Handler")]
		public virtual unsafe void Open (bool p0, global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p1)
		{
			if (id_open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_ == IntPtr.Zero)
				id_open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNIEnv.GetMethodID (class_ref, "open", "(ZLcom/daimajia/swipe/SwipeLayout$DragEdge;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open_ZLcom_daimajia_swipe_SwipeLayout_DragEdge_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(ZLcom/daimajia/swipe/SwipeLayout$DragEdge;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_;
#pragma warning disable 0169
		static Delegate GetOpen_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Handler ()
		{
			if (cb_open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ == null)
				cb_open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_);
			return cb_open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_;
		}

		static void n_Open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0);
		}
#pragma warning restore 0169

		static IntPtr id_open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.DragEdge']]"
		[Register ("open", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;)V", "GetOpen_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Handler")]
		public virtual unsafe void Open (global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p0)
		{
			if (id_open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ == IntPtr.Zero)
				id_open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNIEnv.GetMethodID (class_ref, "open", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open_Lcom_daimajia_swipe_SwipeLayout_DragEdge_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processHandRelease_FFZ;
#pragma warning disable 0169
		static Delegate GetProcessHandRelease_FFZHandler ()
		{
			if (cb_processHandRelease_FFZ == null)
				cb_processHandRelease_FFZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, bool>) n_ProcessHandRelease_FFZ);
			return cb_processHandRelease_FFZ;
		}

		static void n_ProcessHandRelease_FFZ (IntPtr jnienv, IntPtr native__this, float p0, float p1, bool p2)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessHandRelease (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_processHandRelease_FFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='processHandRelease' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("processHandRelease", "(FFZ)V", "GetProcessHandRelease_FFZHandler")]
		protected virtual unsafe void ProcessHandRelease (float p0, float p1, bool p2)
		{
			if (id_processHandRelease_FFZ == IntPtr.Zero)
				id_processHandRelease_FFZ = JNIEnv.GetMethodID (class_ref, "processHandRelease", "(FFZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processHandRelease_FFZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processHandRelease", "(FFZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeAllRevealListeners_I;
#pragma warning disable 0169
		static Delegate GetRemoveAllRevealListeners_IHandler ()
		{
			if (cb_removeAllRevealListeners_I == null)
				cb_removeAllRevealListeners_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveAllRevealListeners_I);
			return cb_removeAllRevealListeners_I;
		}

		static void n_RemoveAllRevealListeners_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllRevealListeners (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeAllRevealListeners_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='removeAllRevealListeners' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeAllRevealListeners", "(I)V", "GetRemoveAllRevealListeners_IHandler")]
		public virtual unsafe void RemoveAllRevealListeners (int p0)
		{
			if (id_removeAllRevealListeners_I == IntPtr.Zero)
				id_removeAllRevealListeners_I = JNIEnv.GetMethodID (class_ref, "removeAllRevealListeners", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllRevealListeners_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllRevealListeners", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeAllSwipeDeniers;
#pragma warning disable 0169
		static Delegate GetRemoveAllSwipeDeniersHandler ()
		{
			if (cb_removeAllSwipeDeniers == null)
				cb_removeAllSwipeDeniers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllSwipeDeniers);
			return cb_removeAllSwipeDeniers;
		}

		static void n_RemoveAllSwipeDeniers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllSwipeDeniers ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllSwipeDeniers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='removeAllSwipeDeniers' and count(parameter)=0]"
		[Register ("removeAllSwipeDeniers", "()V", "GetRemoveAllSwipeDeniersHandler")]
		public virtual unsafe void RemoveAllSwipeDeniers ()
		{
			if (id_removeAllSwipeDeniers == IntPtr.Zero)
				id_removeAllSwipeDeniers = JNIEnv.GetMethodID (class_ref, "removeAllSwipeDeniers", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllSwipeDeniers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllSwipeDeniers", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_;
#pragma warning disable 0169
		static Delegate GetRemoveOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_Handler ()
		{
			if (cb_removeOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ == null)
				cb_removeOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_);
			return cb_removeOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_;
		}

		static void n_RemoveOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout p0 = (global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnLayoutListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='removeOnLayoutListener' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.OnLayout']]"
		[Register ("removeOnLayoutListener", "(Lcom/daimajia/swipe/SwipeLayout$OnLayout;)V", "GetRemoveOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_Handler")]
		public virtual unsafe void RemoveOnLayoutListener (global::Com.Daimajia.Swipe.SwipeLayout.IOnLayout p0)
		{
			if (id_removeOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ == IntPtr.Zero)
				id_removeOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_ = JNIEnv.GetMethodID (class_ref, "removeOnLayoutListener", "(Lcom/daimajia/swipe/SwipeLayout$OnLayout;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeOnLayoutListener_Lcom_daimajia_swipe_SwipeLayout_OnLayout_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOnLayoutListener", "(Lcom/daimajia/swipe/SwipeLayout$OnLayout;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_;
#pragma warning disable 0169
		static Delegate GetRemoveRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_Handler ()
		{
			if (cb_removeRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ == null)
				cb_removeRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RemoveRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_);
			return cb_removeRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_;
		}

		static void n_RemoveRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener p1 = (global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRevealListener (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_removeRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='removeRevealListener' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.daimajia.swipe.SwipeLayout.OnRevealListener']]"
		[Register ("removeRevealListener", "(ILcom/daimajia/swipe/SwipeLayout$OnRevealListener;)V", "GetRemoveRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_Handler")]
		public virtual unsafe void RemoveRevealListener (int p0, global::Com.Daimajia.Swipe.SwipeLayout.IOnRevealListener p1)
		{
			if (id_removeRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ == IntPtr.Zero)
				id_removeRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_ = JNIEnv.GetMethodID (class_ref, "removeRevealListener", "(ILcom/daimajia/swipe/SwipeLayout$OnRevealListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeRevealListener_ILcom_daimajia_swipe_SwipeLayout_OnRevealListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeRevealListener", "(ILcom/daimajia/swipe/SwipeLayout$OnRevealListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_;
#pragma warning disable 0169
		static Delegate GetRemoveSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_Handler ()
		{
			if (cb_removeSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ == null)
				cb_removeSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_);
			return cb_removeSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_;
		}

		static void n_RemoveSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier p0 = (global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSwipeDenier (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='removeSwipeDenier' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.SwipeDenier']]"
		[Register ("removeSwipeDenier", "(Lcom/daimajia/swipe/SwipeLayout$SwipeDenier;)V", "GetRemoveSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_Handler")]
		public virtual unsafe void RemoveSwipeDenier (global::Com.Daimajia.Swipe.SwipeLayout.ISwipeDenier p0)
		{
			if (id_removeSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ == IntPtr.Zero)
				id_removeSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_ = JNIEnv.GetMethodID (class_ref, "removeSwipeDenier", "(Lcom/daimajia/swipe/SwipeLayout$SwipeDenier;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSwipeDenier_Lcom_daimajia_swipe_SwipeLayout_SwipeDenier_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSwipeDenier", "(Lcom/daimajia/swipe/SwipeLayout$SwipeDenier;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_;
#pragma warning disable 0169
		static Delegate GetRemoveSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_Handler ()
		{
			if (cb_removeSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ == null)
				cb_removeSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_);
			return cb_removeSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_;
		}

		static void n_RemoveSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener p0 = (global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSwipeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='removeSwipeListener' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.SwipeListener']]"
		[Register ("removeSwipeListener", "(Lcom/daimajia/swipe/SwipeLayout$SwipeListener;)V", "GetRemoveSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_Handler")]
		public virtual unsafe void RemoveSwipeListener (global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener p0)
		{
			if (id_removeSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ == IntPtr.Zero)
				id_removeSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_ = JNIEnv.GetMethodID (class_ref, "removeSwipeListener", "(Lcom/daimajia/swipe/SwipeLayout$SwipeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSwipeListener_Lcom_daimajia_swipe_SwipeLayout_SwipeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeSwipeListener", "(Lcom/daimajia/swipe/SwipeLayout$SwipeListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBottomViewIds_IIII;
#pragma warning disable 0169
		static Delegate GetSetBottomViewIds_IIIIHandler ()
		{
			if (cb_setBottomViewIds_IIII == null)
				cb_setBottomViewIds_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_SetBottomViewIds_IIII);
			return cb_setBottomViewIds_IIII;
		}

		static void n_SetBottomViewIds_IIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBottomViewIds (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setBottomViewIds_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setBottomViewIds' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setBottomViewIds", "(IIII)V", "GetSetBottomViewIds_IIIIHandler")]
		public virtual unsafe void SetBottomViewIds (int p0, int p1, int p2, int p3)
		{
			if (id_setBottomViewIds_IIII == IntPtr.Zero)
				id_setBottomViewIds_IIII = JNIEnv.GetMethodID (class_ref, "setBottomViewIds", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBottomViewIds_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBottomViewIds", "(IIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_;
#pragma warning disable 0169
		static Delegate GetSetDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Handler ()
		{
			if (cb_setDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ == null)
				cb_setDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_);
			return cb_setDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_;
		}

		static void n_SetDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.DragEdge> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDragEdge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setDragEdge' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.DragEdge']]"
		[Obsolete (@"deprecated")]
		[Register ("setDragEdge", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;)V", "GetSetDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_Handler")]
		public virtual unsafe void SetDragEdge (global::Com.Daimajia.Swipe.SwipeLayout.DragEdge p0)
		{
			if (id_setDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ == IntPtr.Zero)
				id_setDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNIEnv.GetMethodID (class_ref, "setDragEdge", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDragEdge_Lcom_daimajia_swipe_SwipeLayout_DragEdge_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDragEdge", "(Lcom/daimajia/swipe/SwipeLayout$DragEdge;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_;
#pragma warning disable 0169
		static Delegate GetSetDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_Handler ()
		{
			if (cb_setDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_ == null)
				cb_setDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_);
			return cb_setDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_;
		}

		static void n_SetDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.DragEdge[] p0 = (global::Com.Daimajia.Swipe.SwipeLayout.DragEdge[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Daimajia.Swipe.SwipeLayout.DragEdge));
			__this.SetDragEdges (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setDragEdges' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.DragEdge...']]"
		[Obsolete (@"deprecated")]
		[Register ("setDragEdges", "([Lcom/daimajia/swipe/SwipeLayout$DragEdge;)V", "GetSetDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_Handler")]
		public virtual unsafe void SetDragEdges (params global:: Com.Daimajia.Swipe.SwipeLayout.DragEdge[] p0)
		{
			if (id_setDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_ == IntPtr.Zero)
				id_setDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_ = JNIEnv.GetMethodID (class_ref, "setDragEdges", "([Lcom/daimajia/swipe/SwipeLayout$DragEdge;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDragEdges_arrayLcom_daimajia_swipe_SwipeLayout_DragEdge_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDragEdges", "([Lcom/daimajia/swipe/SwipeLayout$DragEdge;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_Handler ()
		{
			if (cb_setOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_ == null)
				cb_setOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_);
			return cb_setOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_;
		}

		static void n_SetOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListener p0 = (global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListener)global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDoubleClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setOnDoubleClickListener' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.DoubleClickListener']]"
		[Register ("setOnDoubleClickListener", "(Lcom/daimajia/swipe/SwipeLayout$DoubleClickListener;)V", "GetSetOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_Handler")]
		public virtual unsafe void SetOnDoubleClickListener (global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListener p0)
		{
			if (id_setOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_ == IntPtr.Zero)
				id_setOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnDoubleClickListener", "(Lcom/daimajia/swipe/SwipeLayout$DoubleClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDoubleClickListener_Lcom_daimajia_swipe_SwipeLayout_DoubleClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDoubleClickListener", "(Lcom/daimajia/swipe/SwipeLayout$DoubleClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_;
#pragma warning disable 0169
		static Delegate GetSetShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_Handler ()
		{
			if (cb_setShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_ == null)
				cb_setShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_);
			return cb_setShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_;
		}

		static void n_SetShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Daimajia.Swipe.SwipeLayout.ShowMode p0 = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout.ShowMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShowMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='setShowMode' and count(parameter)=1 and parameter[1][@type='com.daimajia.swipe.SwipeLayout.ShowMode']]"
		[Register ("setShowMode", "(Lcom/daimajia/swipe/SwipeLayout$ShowMode;)V", "GetSetShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_Handler")]
		public virtual unsafe void SetShowMode (global::Com.Daimajia.Swipe.SwipeLayout.ShowMode p0)
		{
			if (id_setShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_ == IntPtr.Zero)
				id_setShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_ = JNIEnv.GetMethodID (class_ref, "setShowMode", "(Lcom/daimajia/swipe/SwipeLayout$ShowMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShowMode_Lcom_daimajia_swipe_SwipeLayout_ShowMode_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowMode", "(Lcom/daimajia/swipe/SwipeLayout$ShowMode;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toggle;
#pragma warning disable 0169
		static Delegate GetToggleHandler ()
		{
			if (cb_toggle == null)
				cb_toggle = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Toggle);
			return cb_toggle;
		}

		static void n_Toggle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Toggle ();
		}
#pragma warning restore 0169

		static IntPtr id_toggle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='toggle' and count(parameter)=0]"
		[Register ("toggle", "()V", "GetToggleHandler")]
		public virtual unsafe void Toggle ()
		{
			if (id_toggle == IntPtr.Zero)
				id_toggle = JNIEnv.GetMethodID (class_ref, "toggle", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toggle);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggle", "()V"));
			} finally {
			}
		}

		static Delegate cb_toggle_Z;
#pragma warning disable 0169
		static Delegate GetToggle_ZHandler ()
		{
			if (cb_toggle_Z == null)
				cb_toggle_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Toggle_Z);
			return cb_toggle_Z;
		}

		static void n_Toggle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Daimajia.Swipe.SwipeLayout __this = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.SwipeLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Toggle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_toggle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SwipeLayout']/method[@name='toggle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("toggle", "(Z)V", "GetToggle_ZHandler")]
		public virtual unsafe void Toggle (bool p0)
		{
			if (id_toggle_Z == IntPtr.Zero)
				id_toggle_Z = JNIEnv.GetMethodID (class_ref, "toggle", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toggle_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggle", "(Z)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Daimajia.Swipe.SwipeLayout.ISwipeListener"
		public event EventHandler<global::Com.Daimajia.Swipe.SwipeLayout.CloseEventArgs> CloseEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						__CreateISwipeListenerImplementor,
						AddSwipeListener,
						__h => __h.OnCloseHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor.__IsEmpty,
						__v => RemoveSwipeListener (__v),
						__h => __h.OnCloseHandler -= value);
			}
		}

		public event EventHandler<global::Com.Daimajia.Swipe.SwipeLayout.HandReleaseEventArgs> HandRelease {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						__CreateISwipeListenerImplementor,
						AddSwipeListener,
						__h => __h.OnHandReleaseHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor.__IsEmpty,
						__v => RemoveSwipeListener (__v),
						__h => __h.OnHandReleaseHandler -= value);
			}
		}

		public event EventHandler<global::Com.Daimajia.Swipe.SwipeLayout.OpenEventArgs> OpenEvent {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						__CreateISwipeListenerImplementor,
						AddSwipeListener,
						__h => __h.OnOpenHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor.__IsEmpty,
						__v => RemoveSwipeListener (__v),
						__h => __h.OnOpenHandler -= value);
			}
		}

		public event EventHandler<global::Com.Daimajia.Swipe.SwipeLayout.StartCloseEventArgs> StartClose {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						__CreateISwipeListenerImplementor,
						AddSwipeListener,
						__h => __h.OnStartCloseHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor.__IsEmpty,
						__v => RemoveSwipeListener (__v),
						__h => __h.OnStartCloseHandler -= value);
			}
		}

		public event EventHandler<global::Com.Daimajia.Swipe.SwipeLayout.StartOpenEventArgs> StartOpen {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						__CreateISwipeListenerImplementor,
						AddSwipeListener,
						__h => __h.OnStartOpenHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor.__IsEmpty,
						__v => RemoveSwipeListener (__v),
						__h => __h.OnStartOpenHandler -= value);
			}
		}

		public event EventHandler<global::Com.Daimajia.Swipe.SwipeLayout.UpdateEventArgs> Update {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						__CreateISwipeListenerImplementor,
						AddSwipeListener,
						__h => __h.OnUpdateHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListener, global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor>(
						ref weak_implementor_AddSwipeListener,
						global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor.__IsEmpty,
						__v => RemoveSwipeListener (__v),
						__h => __h.OnUpdateHandler -= value);
			}
		}

		WeakReference weak_implementor_AddSwipeListener;

		global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor __CreateISwipeListenerImplementor ()
		{
			return new global::Com.Daimajia.Swipe.SwipeLayout.ISwipeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListener"
		public event EventHandler<global::Com.Daimajia.Swipe.SwipeLayout.DoubleClickEventArgs> DoubleClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListener, global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListenerImplementor>(
						ref weak_implementor_SetOnDoubleClickListener,
						__CreateIDoubleClickListenerImplementor,
						SetOnDoubleClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListener, global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListenerImplementor>(
						ref weak_implementor_SetOnDoubleClickListener,
						global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListenerImplementor.__IsEmpty,
						__v => SetOnDoubleClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnDoubleClickListener;

		global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListenerImplementor __CreateIDoubleClickListenerImplementor ()
		{
			return new global::Com.Daimajia.Swipe.SwipeLayout.IDoubleClickListenerImplementor (this);
		}
#endregion
	}
}
