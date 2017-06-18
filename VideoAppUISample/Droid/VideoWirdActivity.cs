
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace VideoAppUISample.Droid
{
	[Activity(Label = "VideoWirdActivity")]
	public class VideoWirdActivity : AppCompatActivity
	{
        ImageButton mBackButton;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_video_wird);
            mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
			mBackButton.Click += delegate
			{
				base.OnBackPressed();
			};
			
		}
	}
}
