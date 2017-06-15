
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace VideoAppUISample.Droid
{
	public class PreviousProjectsFragment : Fragment
	{
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);
			View view = inflater.Inflate(Resource.Layout.fragment_bisherige, container, false);

			// clic on name project go activity detail project
			LinearLayout contentLayout = (LinearLayout)view.FindViewById(Resource.Id.cvVideo);

			contentLayout.Click += delegate

			{
				Intent intent = new Intent(this.Activity, typeof(DetailProjectActivity));
				StartActivity(intent);
				//Toast.MakeText(this.Activity, "OK", ToastLength.Long).Show();
			};

			// var floating action button
			var fab = view.FindViewById<FloatingActionButton>(Resource.Id.fab);
			fab.Click += delegate

			{
				Intent intent = new Intent(this.Activity, typeof(MainActivity));
				StartActivity(intent);
				//Toast.MakeText(this.Activity, "OK", ToastLength.Long).Show();
			};

			return view;
		}
	}
}
