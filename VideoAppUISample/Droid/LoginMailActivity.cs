
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
	[Activity(Label = "LoginMainActivity")]
	public class LoginMailActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.login_mail);

			// clic button login

			Button btLogin = FindViewById<Button>(Resource.Id.btLogin);
			btLogin.Click += delegate
			{
				StartActivity(typeof(MainActivity));
			};

			// create account

			TextView createAccount = FindViewById<TextView>(Resource.Id.registriereAccount);
			createAccount.Click += delegate
			{
				StartActivity(typeof(RegisterActivity));
			};
		}
	}
}
