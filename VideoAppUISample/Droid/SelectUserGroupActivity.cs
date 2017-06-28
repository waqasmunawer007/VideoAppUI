
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
using VideoAppUISample.Droid.Adapters;
using VideoAppUISample.Droid.Models;

namespace VideoAppUISample.Droid
{
	[Activity(Label = "SelectUserGroupActivity",ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
	public class SelectUserGroupActivity : AppCompatActivity
	{
        private Spinner mGroupPickerSpinner;
        private GroupPickerSpinnerAdapter mAdapter;


		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_select_user_group);
			mGroupPickerSpinner = FindViewById<Spinner>(Resource.Id.group_picker_spinner);
            SetupGroupSpinner();
		}

        private void SetupGroupSpinner()
        {
			if (mAdapter == null)
			{
                mAdapter = new GroupPickerSpinnerAdapter(this, Resource.Layout.group_spinner_item_layout, PrepareSampleGroups());
			}
			mGroupPickerSpinner.Adapter = mAdapter;
			mGroupPickerSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(GroupSpinner_ItemSelected);

		}
		private void GroupSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
            Group selectedGroup = (Group)spinner.GetItemAtPosition(e.Position);
            if (selectedGroup.GroupId != 0)
            {
				System.Threading.Thread.Sleep(1000);
				Intent intent = new Intent(this, typeof(MainActivity));
                intent.AddFlags(ActivityFlags.ClearTask);  //clear previous activity stack
                intent.AddFlags(ActivityFlags.NewTask);
				StartActivity(intent);
				Finish();
            }
		}
        private List<Group> PrepareSampleGroups()
		{
            List<Group> groups = new List<Group>();
			Group g0 = new Group()
			{
				GroupName = "Deine User Gruppe",
				GroupId = 0
			};
            Group g1 = new Group()
            {
                GroupName = "Auswahl 1",
                GroupId = 1
            };
			Group g2 = new Group()
			{
				GroupName = "Auswahl 2",
				GroupId = 2
			};
			Group g3 = new Group()
			{
				GroupName = "Auswahl 3",
				GroupId = 3
			};
            groups.Add(g0);
			groups.Add(g1);
            groups.Add(g2);
            groups.Add(g3);
			
            return groups;
		}
	}
}
