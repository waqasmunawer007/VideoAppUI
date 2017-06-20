
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Java.Lang;


namespace VideoAppUISample.Droid
{
	[Activity(Label = "DownloadProjectActivity", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize )]
	public class RotatePhoneActivity : AppCompatActivity
	{
		ImageButton mBackButton;

		SurfaceOrientation surfaceOrientation = 0;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_rotate_phone);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
			SetUpToolbar();

		}
		/// <summary>
		/// Sets up toolbar.
		/// </summary>
		private void SetUpToolbar()
		{
			mBackButton.Click += delegate
			{
				base.OnBackPressed();
			};
		}

		public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			Intent intent = new Intent(this, typeof(IntroductionVideoActivity));
			StartActivity(intent);
			
		}
	
	}
}




