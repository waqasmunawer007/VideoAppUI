
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
	[Activity(Label = "ShareActivity")]
	public class PostCaptureVideoSuccessActivity : AppCompatActivity
	{
		
		ImageButton mBackButton;
		ImageButton mOkButton;
        TextView mSuccessTextView;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_post_capture_video_success);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
			mOkButton = FindViewById<ImageButton>(Resource.Id.ok_image_button);
            mSuccessTextView = FindViewById<TextView>(Resource.Id.success_message_text_view);

			SetUpToolbar();

			mOkButton.Click+=delegate {
              //Todo launch project detail activity with the selected project containing latest created video  

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

	}
}




