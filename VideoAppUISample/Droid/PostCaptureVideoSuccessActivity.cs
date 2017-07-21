
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
	[Activity(Label = "PostCaptureVideoSuccessActivity",ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
	public class PostCaptureVideoSuccessActivity : AppCompatActivity
	{
        TextView mSuccessTextView;
        ImageView mCheckImageButton;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_post_capture_video_success);
            mSuccessTextView = FindViewById<TextView>(Resource.Id.success_message_text_view);
            mCheckImageButton = FindViewById<ImageView>(Resource.Id.check_imagebutton);

            mCheckImageButton.Click +=delegate {
                LaunchProjectDetailScreen();
                this.Finish();
            };
		}
       
		/// <summary>
        /// Launchs the project detail screen.
        /// </summary>
		private void LaunchProjectDetailScreen()
		{
			Intent intent = new Intent(this, typeof(DetailProjectActivity));
			//video_recording_flow flag will use to determine that the bank button option on DetailProjectActivity screen
			//should navigate the flow to Project listing screen.
            intent.PutExtra("video_recording_flow", true); 
			intent.AddFlags(ActivityFlags.ClearTask);  //clear previous activity stack
			intent.AddFlags(ActivityFlags.NewTask);
			StartActivity(intent);
		}

	}
}




