
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;


namespace VideoAppUISample.Droid
{
	[Activity(Label = "DownloadProjectActivity", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize )]
	public class RotatePhoneActivity : AppCompatActivity
	{
		ImageButton mBackButton;
        ImageButton mBurgerMenuImageButton;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_rotate_phone);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_button_imagebutton);
            mBurgerMenuImageButton = FindViewById<ImageButton>(Resource.Id.burger_menu_imagebutton);
			SetUpToolbar();

            mBurgerMenuImageButton.Click += delegate {
				Intent intent = new Intent(this, typeof(DetailProjectActivity));
				StartActivity(intent);
            };

		}
		/// <summary>
		/// Sets up toolbar.
		/// </summary>
		private void SetUpToolbar()
		{
			mBackButton.Click += delegate
			{
                LaunchProjectOverviewScreen();
			};
		}
		public override void OnBackPressed()
		{
			base.OnBackPressed();
			LaunchProjectOverviewScreen();
		}
		private void LaunchProjectOverviewScreen()
		{
			Intent intent = new Intent(this, typeof(MainActivity)); //with option Project overview screen
			intent.PutExtra("launch_project_overview", true);// will use to determine either launch Project Overview screen or not
			intent.AddFlags(ActivityFlags.ClearTask);  //clear previous activity stack
			intent.AddFlags(ActivityFlags.NewTask);
			StartActivity(intent);
			Finish();
		}

		public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
		{
			base.OnConfigurationChanged(newConfig);
			ScreenOrientation oreintation = GetScreenOrientation();
			if (oreintation == ScreenOrientation.Landscape) //If already in landscape, just skipe Rotate Phone screen
			{
				Intent intent = new Intent(this, typeof(IntroductionVideoActivity));
				StartActivity(intent);
			}
		}
        /// <summary>
        /// Gets the screen orientation.
        /// </summary>
        /// <returns>The screen orientation.</returns>
		private ScreenOrientation GetScreenOrientation()
		{
			ScreenOrientation orientation;
			SurfaceOrientation rotation = WindowManager.DefaultDisplay.Rotation;

			DisplayMetrics dm = new DisplayMetrics();
			WindowManager.DefaultDisplay.GetMetrics(dm);

			if ((rotation == SurfaceOrientation.Rotation0 || rotation == SurfaceOrientation.Rotation180) && dm.HeightPixels > dm.WidthPixels
				|| (rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270) && dm.WidthPixels > dm.HeightPixels)
			{
				// The device's natural orientation is portrait
				switch (rotation)
				{
					case SurfaceOrientation.Rotation0:
						orientation = ScreenOrientation.Portrait;
						break;
					case SurfaceOrientation.Rotation90:
						orientation = ScreenOrientation.Landscape;
						break;
					case SurfaceOrientation.Rotation180:
						orientation = ScreenOrientation.ReversePortrait;
						break;
					case SurfaceOrientation.Rotation270:
						orientation = ScreenOrientation.ReverseLandscape;
						break;
					default:
						orientation = ScreenOrientation.Portrait;
						break;
				}
			}
			else
			{
				// The device's natural orientation is landscape or if the device is square
				switch (rotation)
				{
					case SurfaceOrientation.Rotation0:
						orientation = ScreenOrientation.Landscape;
						break;
					case SurfaceOrientation.Rotation90:
						orientation = ScreenOrientation.Portrait;
						break;
					case SurfaceOrientation.Rotation180:
						orientation = ScreenOrientation.ReverseLandscape;
						break;
					case SurfaceOrientation.Rotation270:
						orientation = ScreenOrientation.ReversePortrait;
						break;
					default:
						orientation = ScreenOrientation.Landscape;
						break;
				}
			}

			return orientation;
		}
	
	}
}




