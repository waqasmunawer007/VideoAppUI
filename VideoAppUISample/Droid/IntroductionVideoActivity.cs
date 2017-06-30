
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
    [Activity(Label = "ShareActivity",ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
	public class IntroductionVideoActivity : AppCompatActivity
	{
		ProgressBar mProgress;
		ImageButton mBackButton;
		ImageButton mNextButton;
		ImageButton mProjectPreviewButton;
		TextView mVideoTimeTextView;
		TextView mVideoDescTextView;


		int progressStatus = 0;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_introduction_video);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
			mNextButton = FindViewById<ImageButton>(Resource.Id.next_image_button);
			mProjectPreviewButton = FindViewById<ImageButton>(Resource.Id.project_view_menu_button);
			mProgress = FindViewById<ProgressBar>(Resource.Id.video_time_line_progressbar);
			mVideoTimeTextView = FindViewById<TextView>(Resource.Id.video_time_text_view);
			mVideoDescTextView = FindViewById<TextView>(Resource.Id.video_desc_text_view);

			SetUpToolbar();
			SetUpVideoProgressTimeBar();

			mNextButton.Click+=delegate {
				Intent intent = new Intent(this, typeof(PreCaptureVideoActivity));
				StartActivity(intent);
			};

			mProjectPreviewButton.Click += delegate {

			};

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
		/// <summary>
		/// Sets up video progress time bar.
		/// </summary>
		private void SetUpVideoProgressTimeBar()
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
						mVideoTimeTextView.Text = progressStatus + " Seconds";
					});
				}
			})).Start();
		}
	}
}




