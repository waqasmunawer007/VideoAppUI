
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace VideoAppUISample.Droid
{
	[Activity(Label = "LoginActivity")]
	public class LoginActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_login);

			// login facebook
			Button logFacebook = FindViewById<Button>(Resource.Id.anmeldenFacebook);
			logFacebook.Click += delegate
			{
				StartActivity(typeof(MainActivity));
			};

			// login google
			Button logGoogle = FindViewById<Button>(Resource.Id.anmeldenGoogle);
			logGoogle.Click += delegate
			{
                StartActivity(typeof(VideoWirdActivity));
			};

			// login mail
			Button logMail = FindViewById<Button>(Resource.Id.anmeldenEmail);
			logMail.Click += delegate
			{
				StartActivity(typeof(LoginMailActivity));
			};
		}
	}
}
