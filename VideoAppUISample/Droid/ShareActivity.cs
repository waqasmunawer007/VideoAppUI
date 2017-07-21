
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
	[Activity(Label = "ShareActivity",ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
	public class ShareActivity : AppCompatActivity
	{
		ProgressBar mProgress;
		int progressStatus = 0;
		ImageButton mBackButton;
        ImageButton mPlayButton;
		Button mFBButton;
        TextView mToolbarTitleTextView;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_share);
            mToolbarTitleTextView = FindViewById<TextView>(Resource.Id.toolbar_title_text_view);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
            mPlayButton = FindViewById<ImageButton>(Resource.Id.video_play_imagebutton);
			mFBButton = FindViewById<Button>(Resource.Id.upload_video_facebook_button);
			mProgress = FindViewById<ProgressBar>(Resource.Id.video_time_line_progressbar);
			
            SetUpToolbar();
            mPlayButton.Click += delegate {
                SetupVideoProgressTimeBar();
            };
		}

		/// <summary>
		/// Sets up toolbar.
		/// </summary>
		private void SetUpToolbar()
		{
            mToolbarTitleTextView.Text = "Project-Name";
			mBackButton.Click += delegate
			{
				base.OnBackPressed();
			};
		}

        /// <summary>
        /// Setups the video progress time bar.
        /// </summary>
		private void SetupVideoProgressTimeBar()
		{ 
			mProgress.Progress = 0;   // Main Progress
			mProgress.Indeterminate = false;
			mProgress.Max = 100; // Maximum Progress
			UpdateTimeBarProgress();
		}
		/// <summary>
		/// Updates the video length timebar
		/// </summary>
		public void UpdateTimeBarProgress()
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
					}
					catch (InterruptedException e)
					{
						e.PrintStackTrace();
					}
					RunOnUiThread(() =>
					{
						mProgress.Progress = progressStatus;
						if (progressStatus == 100)
						{
							mProgress.Progress = 0;
						}
					});
				}
			})).Start();
		}

		public override void OnBackPressed()
		{
			base.OnBackPressed();
		}
		//private void LaunchProjectOverviewScreen()
		//{
		//	Intent intent = new Intent(this, typeof(MainActivity)); //with option Project overview screen
		//	intent.PutExtra("launch_project_overview", true);// will use to determine either launch Project Overview screen or not
		//	intent.AddFlags(ActivityFlags.ClearTask);  //clear previous activity stack
		//	intent.AddFlags(ActivityFlags.NewTask);
		//	StartActivity(intent);
		//	Finish();
		//}

	}
}




