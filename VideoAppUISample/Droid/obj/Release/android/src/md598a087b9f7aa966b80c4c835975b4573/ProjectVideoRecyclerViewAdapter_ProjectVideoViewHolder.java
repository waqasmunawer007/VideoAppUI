package md598a087b9f7aa966b80c4c835975b4573;


public class ProjectVideoRecyclerViewAdapter_ProjectVideoViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("VideoAppUISample.Droid.Adapters.ProjectVideoRecyclerViewAdapter+ProjectVideoViewHolder, VideoAppUISample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ProjectVideoRecyclerViewAdapter_ProjectVideoViewHolder.class, __md_methods);
	}


	public ProjectVideoRecyclerViewAdapter_ProjectVideoViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ProjectVideoRecyclerViewAdapter_ProjectVideoViewHolder.class)
			mono.android.TypeManager.Activate ("VideoAppUISample.Droid.Adapters.ProjectVideoRecyclerViewAdapter+ProjectVideoViewHolder, VideoAppUISample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
