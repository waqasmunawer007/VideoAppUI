
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
	public class PostCaptureVideoActivity : AppCompatActivity
	{
		
		ImageButton mBackButton;
		ImageButton mTrimOkButton;
		ImageButton mResetButton;
		ImageButton mDottedMenuButton;
      

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_post_capture_video);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
			mDottedMenuButton = FindViewById<ImageButton>(Resource.Id.dotted_menu_image_button);
			mTrimOkButton = FindViewById<ImageButton>(Resource.Id.video_trim_ok_button);
			mResetButton = FindViewById<ImageButton>(Resource.Id.reset_image_button);

			SetUpToolbar();
			mTrimOkButton.Click+=delegate {
				Intent intent = new Intent(this, typeof(PostCaptureVideoSuccessActivity));
				StartActivity(intent);
			};

			mResetButton.Click += delegate {

			};

			mDottedMenuButton.Click += delegate {
				SetupPopMenu();
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




