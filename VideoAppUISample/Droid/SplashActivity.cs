
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace VideoAppUISample.Droid
{
	[Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
	public class SplashActivity : Activity
	{
		static readonly string TAG = "X:" + typeof(SplashActivity).Name;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
           // SetContentView(Resource.Layout.activity_splash);

           Task startupWork = new Task(() =>
		   {
			   Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
			   Task.Delay(3000); // Simulate a bit of startup work.
				Log.Debug(TAG, "Working in the background - important stuff.");
		   });

			startupWork.ContinueWith(t =>
			{
				Log.Debug(TAG, "Work is finished - start Activity1.");
				StartActivity(new Intent(Application.Context, typeof(LoginActivity)));
			}, TaskScheduler.FromCurrentSynchronizationContext());

			startupWork.Start();
		}
	}
}
