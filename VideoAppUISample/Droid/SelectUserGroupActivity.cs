
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
	[Activity(Label = "SelectUserGroupActivity")]
	public class SelectUserGroupActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_select_user_group);
			// Create your application here
		}
	}
}
