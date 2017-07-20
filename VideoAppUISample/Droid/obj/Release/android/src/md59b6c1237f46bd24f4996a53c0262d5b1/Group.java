package md59b6c1237f46bd24f4996a53c0262d5b1;


public class Group
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("VideoAppUISample.Droid.Models.Group, VideoAppUISample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Group.class, __md_methods);
	}


	public Group () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Group.class)
			mono.android.TypeManager.Activate ("VideoAppUISample.Droid.Models.Group, VideoAppUISample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
