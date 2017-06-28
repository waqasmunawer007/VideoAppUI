
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using VideoAppUISample.Droid.Adapters;
using VideoAppUISample.Droid.Models;

namespace VideoAppUISample.Droid
{
	public class SettingsFragment : Fragment
	{
		View mRootView;
		private Spinner mGroupPickerSpinner;
		private GroupPickerSpinnerAdapter mAdapter;

		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);
			mRootView = inflater.Inflate(Resource.Layout.fragment_einstenllungen, container, false);
			mGroupPickerSpinner = mRootView.FindViewById<Spinner>(Resource.Id.group_picker_spinner);
			SetupGroupSpinner();

			return mRootView;
		}


        /// <summary>
        /// Setups the group spinner.
        /// </summary>
		private void SetupGroupSpinner()
		{
			if (mAdapter == null)
			{
                mAdapter = new GroupPickerSpinnerAdapter(this.Activity, Resource.Layout.group_spinner_item_layout, PrepareSampleGroups());
			}
			mGroupPickerSpinner.Adapter = mAdapter;
			mGroupPickerSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(GroupSpinner_ItemSelected);
		}
		private void GroupSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
			Group selectedGroup = (Group)spinner.GetItemAtPosition(e.Position);
			if (selectedGroup.GroupId != 0)
			{}
		}
		private List<Group> PrepareSampleGroups()
		{
			List<Group> groups = new List<Group>();
			Group g0 = new Group() //Todo somehow 'prompt' property to set title for spinner not working, so adding extra group to set title
			{
				GroupName = "User Gruppe andern",
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
