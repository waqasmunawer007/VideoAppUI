
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;


namespace VideoAppUISample.Droid
{
	[Activity(Label = "DownloadProjectActivity",ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
	public class DownloadProjectActivity : AppCompatActivity
	{
		ProgressDialog mProgressDialog;
		ImageButton mBackButton;
        ImageView mProjectImageView;
        Button mJettztButton;
		ImageButton mDownloadButton;
		TextView mProjectTitleTextView;
		TextView mProjectDescTextView;
        LinearLayout mBottomLayout;
        bool ifDownloaded = false;
		int progressStatus = 0;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_download_project);
            mProjectImageView = FindViewById<ImageView>(Resource.Id.project_imageview);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_button_imagebutton);
            mJettztButton = FindViewById<Button>(Resource.Id.jettzt_button);
            mBottomLayout = FindViewById<LinearLayout>(Resource.Id.bottom_layout);
			mDownloadButton = FindViewById<ImageButton>(Resource.Id.download_image_button);
			mProjectTitleTextView = FindViewById<TextView>(Resource.Id.project_title_text_view);
			mProjectDescTextView = FindViewById<TextView>(Resource.Id.project_desc_text_view);
			
            mProjectImageView.SetBackgroundResource(Resource.Drawable.template);

			mDownloadButton.Click+=delegate {
                if (!ifDownloaded)
                {
                   CreateDownloadProgressDialog();
				}
				
			};

			mBackButton.Click += delegate
			{
				base.OnBackPressed();
			};
            mJettztButton.Click += delegate {
				LoadRotatePhoneActivity();
			};
		}
        /// <summary>
        /// Updates the user interface once the downloading completed.
        /// </summary>
        private void UpdateUI()
        {
			mProjectTitleTextView.Text = "Ausgezeichnet!";
			mProjectDescTextView.Visibility = ViewStates.Visible;
			mDownloadButton.SetBackgroundResource(Resource.Drawable.bt_done);
			mJettztButton.Visibility = ViewStates.Visible;
			mBottomLayout.Visibility = ViewStates.Gone;
			mProgressDialog.Hide(); 
        }
		/// <summary>
		/// Creates the download progress dialog.
		/// </summary>
		public void CreateDownloadProgressDialog()
		{
			mProgressDialog = new ProgressDialog(this);
			mProgressDialog.Indeterminate = false;
			mProgressDialog.SetMessage("Downlaoding. Please wait...");
			mProgressDialog.SetProgressStyle(ProgressDialogStyle.Horizontal);
            mProgressDialog.SetCancelable(false);
            mProgressDialog.SetCanceledOnTouchOutside(false);
			mProgressDialog.Max = 100;
			mProgressDialog.Progress = 0;
			mProgressDialog.Show();

			UpdateDownloadProgress();//updates the download progress
		}
		/// <summary>
		/// Updates the download progress value
		/// </summary>
		public void UpdateDownloadProgress()
		{
			progressStatus = 0;
			new System.Threading.Thread(new ThreadStart(delegate
			{
				while (progressStatus < 100)
				{
					progressStatus += 1;
					try
					{
						System.Threading.Thread.Sleep(100); //actual downloading work do here
					}
					catch (InterruptedException e)
					{
						e.PrintStackTrace();
					}            
					RunOnUiThread(() =>
					{
						mProgressDialog.Progress = progressStatus;
						if (progressStatus == 100)
						{
                            ifDownloaded = true;
                            UpdateUI();
						}
					});
				}
			})).Start();
		}

		private void LoadRotatePhoneActivity()
		{
            ScreenOrientation oreintation = GetScreenOrientation();
            if (oreintation == ScreenOrientation.Landscape) //If already in landscape, just skipe Rotate Phone screen
            {
				Intent intent = new Intent(this, typeof(IntroductionVideoActivity));
				StartActivity(intent);
            }
            else
            {
				Intent intent = new Intent(this, typeof(RotatePhoneActivity));
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




