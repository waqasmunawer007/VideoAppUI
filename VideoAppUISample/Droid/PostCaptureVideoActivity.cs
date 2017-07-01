
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
using VideoAppUISample.Droid.Models;

namespace VideoAppUISample.Droid
{
	[Activity(Label = "PostCaptureVideoActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
	public class PostCaptureVideoActivity : AppCompatActivity
	{
		
		ImageButton mBackButton;
		ImageView mTrimOptionImageView;
		ImageButton mRefreshImageButton;
		ImageButton mDottedMenuButton;
        ProgressBar mProgress;
        ImageView mLeftArrowImageView;
        ImageView mRightArrowImageView;
        ImageView mFingerTouchImageView;
        TextView mTimerTextView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_post_capture_video);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_button_imagebutton);
			mDottedMenuButton = FindViewById<ImageButton>(Resource.Id.dotted_menu_image_button);
			mTrimOptionImageView = FindViewById<ImageView>(Resource.Id.trim_option_imageview);
			mRefreshImageButton = FindViewById<ImageButton>(Resource.Id.refresh_imagebutton);
            mTimerTextView = FindViewById<TextView>(Resource.Id.video_time_text_view);
            mProgress = FindViewById<ProgressBar>(Resource.Id.video_time_line_progressbar);
			mLeftArrowImageView = FindViewById<ImageView>(Resource.Id.left_arrow_imageview);
            mRightArrowImageView = FindViewById<ImageView>(Resource.Id.right_arrow_imageview);
            mFingerTouchImageView = FindViewById<ImageView>(Resource.Id.finger_touch_imageview);

            Intent intent = Intent;
            if (intent != null)
            {
                int videoRecordingStatus = intent.GetIntExtra("video_recording_status", VideoStatus.NORMAL_RECORDING);
                if (videoRecordingStatus == VideoStatus.DANGER_RECORDING)
                {
                    //gray
                    mTrimOptionImageView.SetColorFilter(new Android.Graphics.Color(158, 158, 158));
                    mTrimOptionImageView.Enabled = false;
                }
                else
                {
                    //green
                    mTrimOptionImageView.SetColorFilter(new Android.Graphics.Color(0, 230, 118));
                    mTrimOptionImageView.Enabled = true;
                    mProgress.Progress = 100;
					mProgress.ProgressDrawable = Android.Support.V4.Content.ContextCompat.GetDrawable(this, Resource.Drawable.custom_progressbar_green);
                }
            }

			mBackButton.Click += delegate
			{
				LaunchProjectOverviewScreen();
			};

			mTrimOptionImageView.Click+=delegate {
                Intent i = new Intent(this, typeof(PostCaptureVideoSuccessActivity));
                StartActivity(i);
			};

			mRefreshImageButton.Click += delegate {

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


	}
}




