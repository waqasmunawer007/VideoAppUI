
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
	[Activity(Label = "VideoWirdActivity", ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
	public class VideoWirdActivity : AppCompatActivity
	{
        ImageButton mBackButton;
        ProgressBar mProgress;
		//ProgressDialog mProgressDialog;
		int progressStatus = 0;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_video_wird);
            mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
            mProgress = FindViewById<ProgressBar>(Resource.Id.video_progressbar);
            SetUpProgressbar();

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
		private void LaunchShareActivity()
		{
			Intent intent = new Intent(this, typeof(ShareActivity));
			StartActivity(intent);
		}
        #region Progressbar
        private void SetUpProgressbar()
        {
            mProgress.Progress = 0;   // Main Progress
            mProgress.Indeterminate = false;
            mProgress.Max = 100; // Maximum Progress
            UpdateProgress();
        }

		/// <summary>
		/// Updates the video length timebar
		/// </summary>
	    public void UpdateProgress()
		{
			progressStatus = 0;
			new System.Threading.Thread(new ThreadStart(delegate
			{
				while (progressStatus < 100)
				{
					progressStatus += 1;
					try
					{
						System.Threading.Thread.Sleep(100);
                        if (progressStatus == 100)
                        {
							LaunchShareActivity();
                        }
					}
					catch (InterruptedException e)
					{
						e.PrintStackTrace();
					}
					RunOnUiThread(() =>
					{
						mProgress.Progress = progressStatus;
					});
				}
			})).Start();
		}
        #endregion
       

	}
}
