
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
	[Activity(Label = "DownloadProjectActivity")]
	public class DownloadProjectActivity : AppCompatActivity
	{
		ProgressDialog mProgressDialog;
		ImageButton mBackButton;
		ImageButton mDownloadButton;
		TextView mProjectTitleTextView;
		TextView mProjectDescTextView;

		int progressStatus = 0;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_download_project);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
			mDownloadButton = FindViewById<ImageButton>(Resource.Id.download_image_button);
			mProjectTitleTextView = FindViewById<TextView>(Resource.Id.project_title_text_view);
			mProjectDescTextView = FindViewById<TextView>(Resource.Id.project_desc_text_view);
			SetUpToolbar();
			mDownloadButton.Click+=delegate {
				CreateDownloadProgressDialog(); 
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
		/// Creates the download progress dialog.
		/// </summary>
		public void CreateDownloadProgressDialog()
		{
			mProgressDialog = new ProgressDialog(this);
			mProgressDialog.Indeterminate = false;
			mProgressDialog.SetMessage("Downlaoding. Please wait...");
			mProgressDialog.SetProgressStyle(ProgressDialogStyle.Horizontal);
			mProgressDialog.SetCancelable(true);
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
							mProjectDescTextView.Visibility = ViewStates.Visible;
							mDownloadButton.SetBackgroundResource(Resource.Drawable.bt_done);
							mProgressDialog.Hide();
							//do some wait and then launch Rotate Phone screen
							System.Threading.Thread.Sleep(2000);
							LoadRotatePhoneActivity();

						}
					});
				}
			})).Start();
		}

		private void LoadRotatePhoneActivity()
		{
			Intent intent = new Intent(this, typeof(RotatePhoneActivity));
			StartActivity(intent);
		}
	}
}




