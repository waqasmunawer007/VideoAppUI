
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
	[Activity(Label = "AccountInfoActivity")]
	public class AccountInfoActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.account_info);

			// button more

			Button btMore = FindViewById<Button>(Resource.Id.btMore);
			btMore.Click += delegate
			{
				StartActivity(typeof(SelectUserGroupActivity));
			};
		}
	}
}
