
using System;
using System.Collections.Generic;
using System.Drawing;
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
	public class PreCaptureVideoActivity : AppCompatActivity
	{
		ProgressBar mProgress;
		ImageButton mBackButton;
        ImageButton mRecordingButton;
        ImageButton mStopRecordingNormalButton;
        ImageButton mStopRecordingDangerButton;
		ImageButton mProjectPreviewButton;
		ImageButton mCameraSwitchButton;
		ImageButton mCameraFocusButton;
		ImageButton mDottedMenuButton;
        LinearLayout mVideoTimerLayout;
        TextView mVideoTimeTextView;

		int progressStatus = 0;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_pre_capture_video);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_button_imagebutton);
			mDottedMenuButton = FindViewById<ImageButton>(Resource.Id.dotted_menu_image_button);
            mRecordingButton = FindViewById<ImageButton>(Resource.Id.video_recording_imagebutton);
            mStopRecordingNormalButton = FindViewById<ImageButton>(Resource.Id.stop_recording_normal_imagebutton);
            mStopRecordingDangerButton = FindViewById<ImageButton>(Resource.Id.stop_recording_danger_imagebutton);

			mCameraSwitchButton = FindViewById<ImageButton>(Resource.Id.camera_switch_image_button);
			mCameraFocusButton = FindViewById<ImageButton>(Resource.Id.camera_focus_image_button);
			mProjectPreviewButton = FindViewById<ImageButton>(Resource.Id.project_preview_image_button);
			mProgress = FindViewById<ProgressBar>(Resource.Id.video_time_line_progressbar);
            mVideoTimerLayout = FindViewById<LinearLayout>(Resource.Id.video_timer_layout);
            mVideoTimeTextView = FindViewById<TextView>(Resource.Id.video_time_text_view);

			mBackButton.Click += delegate
			{
				LaunchProjectOverviewScreen();
			};

			mRecordingButton.Click+=delegate {
				mRecordingButton.Visibility = ViewStates.Gone;
				mStopRecordingNormalButton.Visibility = ViewStates.Visible;
				mVideoTimerLayout.Visibility = ViewStates.Visible;
				SetUpVideoProgressTimeBar();
				//if (!isVideoRecordingMode)
				//{
    //                isVideoRecordingMode = true;
    //                mRecordingButton.Visibility = ViewStates.Gone;
    //                mStopRecordingNormalButton.Visibility = ViewStates.Visible;
				//	mRecordingButton.SetBackgroundResource(Resource.Drawable.bt_download);//TOdo replace button with stop video buttton
					
				//	mVideoTimerLayout.Visibility = ViewStates.Visible;
				//	SetUpVideoProgressTimeBar();
				//}
				//else
				//{ 
				//	//launch Post Video Capture screen
				//	Intent intent = new Intent(this, typeof(PostCaptureVideoActivity));
				//	StartActivity(intent);
				//}
			};

            mStopRecordingNormalButton.Click +=delegate {
                //stop recording within the time range
            };
            mStopRecordingDangerButton.Click += delegate {
                //time threshold value crossed
            };

			mProjectPreviewButton.Click += delegate {
				Intent intent = new Intent(this, typeof(DetailProjectActivity));
				StartActivity(intent);
			};

			mCameraSwitchButton.Click += delegate
			{

			};

			mDottedMenuButton.Click += delegate {
				SetupPopMenu();
			};

		}
		/// <summary>
		/// Ons the device back pressed.
		/// </summary>
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
		/// <summary>
		/// Setups the pop menu.
		/// </summary>
		private void SetupPopMenu()
		{ 
			PopupMenu menu = new PopupMenu(this, mDottedMenuButton);
			menu.MenuInflater.Inflate(Resource.Menu.popup_menu, menu.Menu);
			menu.Show();
			menu.MenuItemClick += (s1, arg1) =>
			{
				string selectedItem = arg1.Item.TitleFormatted.ToString();
				Console.WriteLine("{0} selected", selectedItem);
			};
			menu.DismissEvent += (s2, arg2) =>
			{
				Console.WriteLine("menu dismissed");
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
                        mVideoTimeTextView.Text = progressStatus + " Seconds";
						if (progressStatus == 100)
						{
                            mVideoTimerLayout.Visibility = ViewStates.Invisible;
							mProgress.Progress = 0;
						}
                        if (progressStatus > 50)
                        {
                            mStopRecordingNormalButton.Visibility = ViewStates.Gone;
                            mStopRecordingDangerButton.Visibility = ViewStates.Visible;
                            mProgress.ProgressDrawable = Android.Support.V4.Content.ContextCompat.GetDrawable(this,Resource.Drawable.custom_progressbar_danger);
                        }
					});
				}
			})).Start();
		}
	}
}




