
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
	[Activity(Label = "VideoWirdActivity")]
	public class VideoWirdActivity : AppCompatActivity
	{
        ImageButton mBackButton;
		ProgressDialog mProgressDialog;
		int progressStatus = 0;

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
			CreateProgressDialog();
		}

		/// <summary>
		/// Creates the  progress dialog.
		/// </summary>
		public void CreateProgressDialog()
		{
			mProgressDialog = new ProgressDialog(this);
			mProgressDialog.Indeterminate = false;
			mProgressDialog.SetMessage("WIRD GELADEN...");
			mProgressDialog.SetProgressStyle(ProgressDialogStyle.Horizontal);
			mProgressDialog.SetCancelable(true);
			mProgressDialog.Max = 100;
			mProgressDialog.Progress = 0;
			mProgressDialog.Show();

			UpdateProgress();//updates the progress
		}

		/// <summary>
		/// Updates the download progress value
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
							mProgressDialog.Hide();
							System.Threading.Thread.Sleep(1000);
							LoadShareActivity();
						}
					});
				}
			})).Start();
		}
		private void LoadShareActivity()
		{
			Intent intent = new Intent(this, typeof(ShareActivity));
			StartActivity(intent);
		}
	}
}
