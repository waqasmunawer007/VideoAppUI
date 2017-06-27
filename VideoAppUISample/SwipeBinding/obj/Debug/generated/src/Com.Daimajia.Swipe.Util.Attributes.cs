using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Daimajia.Swipe.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe.util']/class[@name='Attributes']"
	[global::Android.Runtime.Register ("com/daimajia/swipe/util/Attributes", DoNotGenerateAcw=true)]
	public partial class Attributes : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe.util']/class[@name='Attributes.Mode']"
		[global::Android.Runtime.Register ("com/daimajia/swipe/util/Attributes$Mode", DoNotGenerateAcw=true)]
		public sealed partial class Mode : global::Java.Lang.Enum {


			static IntPtr Multiple_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe.util']/class[@name='Attributes.Mode']/field[@name='Multiple']"
			[Register ("Multiple")]
			public static global::Com.Daimajia.Swipe.Util.Attributes.Mode Multiple {
				get {
					if (Multiple_jfieldId == IntPtr.Zero)
						Multiple_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Multiple", "Lcom/daimajia/swipe/util/Attributes$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Multiple_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Util.Attributes.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Single_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.daimajia.swipe.util']/class[@name='Attributes.Mode']/field[@name='Single']"
			[Register ("Single")]
			public static global::Com.Daimajia.Swipe.Util.Attributes.Mode Single {
				get {
					if (Single_jfieldId == IntPtr.Zero)
						Single_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Single", "Lcom/daimajia/swipe/util/Attributes$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Single_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Util.Attributes.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/daimajia/swipe/util/Attributes$Mode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Mode); }
			}

			internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.util']/class[@name='Attributes.Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/daimajia/swipe/util/Attributes$Mode;", "")]
			public static unsafe global::Com.Daimajia.Swipe.Util.Attributes.Mode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/daimajia/swipe/util/Attributes$Mode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Daimajia.Swipe.Util.Attributes.Mode __ret = global::Java.Lang.Object.GetObject<global::Com.Daimajia.Swipe.Util.Attributes.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.daimajia.swipe.util']/class[@name='Attributes.Mode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/daimajia/swipe/util/Attributes$Mode;", "")]
			public static unsafe global::Com.Daimajia.Swipe.Util.Attributes.Mode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/daimajia/swipe/util/Attributes$Mode;");
				try {
					return (global::Com.Daimajia.Swipe.Util.Attributes.Mode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Daimajia.Swipe.Util.Attributes.Mode));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/daimajia/swipe/util/Attributes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Attributes); }
		}

		protected Attributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe.util']/class[@name='Attributes']/constructor[@name='Attributes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Attributes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Attributes)) {
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

	}
}
