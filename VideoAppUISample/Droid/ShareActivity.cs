
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
	[Activity(Label = "AccountInfoActivity")]
	public class ShareActivity : AppCompatActivity
	{
		ProgressDialog mProgressDialog;
		ProgressBar mProgress;
		int status = 0;
		Button mFBButton;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_share);
			mFBButton = FindViewById<Button>(Resource.Id.upload_video_facebook_button);
			mProgress = FindViewById<ProgressBar>(Resource.Id.video_time_line_progressbar);
			mFBButton.Click += delegate
			{
				createVideoProgressBar();
				//CreateProgressDialog();
				ShowProgressDialog();
			};

		}

		private void createVideoProgressBar()
		{ 
			mProgress.Progress = 0;   // Main Progress
			mProgress.Indeterminate = false;
			mProgress.Max = 100; // Maximum Progress
		}
		public void CreateProgressDialog()
		{
			mProgressDialog = new ProgressDialog(this);
			mProgressDialog.Indeterminate = false;
			mProgressDialog.SetMessage("Downlaoding. Please wait...");
			mProgressDialog.SetProgressStyle(ProgressDialogStyle.Horizontal);
			mProgressDialog.SetCancelable(true);
			mProgressDialog.Max = 100;
			mProgressDialog.Progress = 0;
			mProgressDialog.Show();
		}
		public void ShowProgressDialog()
		{
			status = 0;
			new System.Threading.Thread(new ThreadStart(delegate
			{
				while (status < 100)
				{
					status += 1;
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

						//Todo for timeline progressbar
						mProgress.Progress = status;
						if (status == 100)
						{
							mProgress.Progress = 0;
						}
						//Todo for ProgressDialog code
						//mProgressDialog.Progress = status;
						//if (status == 100)
						//{
						//	mProgressDialog.Hide();
						//}
					});
				}
			})).Start();

		}
	}

}




