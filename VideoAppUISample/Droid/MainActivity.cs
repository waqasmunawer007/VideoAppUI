using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;
using SupportFragment = Android.Support.V4.App.Fragment;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;

namespace VideoAppUISample.Droid
{
	[Activity(Label = "VideoAppUISample", MainLauncher = false)]
	public class MainActivity : AppCompatActivity
	{
		ProjectFragment fragProject;
		PreviousProjectsFragment fragBisherige;
		SettingsFragment fragEinstenllungen;
		HelpFragment fragHilfe;

		private SupportFragment mCurrentFragment = new SupportFragment();
		private Stack<SupportFragment> mStackFragments;
		DrawerLayout drawerLayout;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// var drawer
			drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

			// Init toolbar
			var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.app_bar);
			SetSupportActionBar(toolbar);
			SupportActionBar.SetTitle(Resource.String.projectk);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			SupportActionBar.SetDisplayShowHomeEnabled(true);

			//Load Fragment
			fragProject = new ProjectFragment();
			fragBisherige = new PreviousProjectsFragment();
			fragEinstenllungen = new SettingsFragment();
			fragHilfe = new HelpFragment();


			//Fragment helper
			mStackFragments = new Stack<SupportFragment>();
			var navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
			navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;
			// Create ActionBarDrawerToggle button and add it to the toolbar
			var drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, Resource.String.open_drawer, Resource.String.close_drawer);
			drawerLayout.SetDrawerListener(drawerToggle);
			drawerToggle.SyncState();

			Android.Support.V4.App.FragmentTransaction tx = SupportFragmentManager.BeginTransaction();

			tx.Add(Resource.Id.HomeFrameLayout, fragProject);
			tx.Add(Resource.Id.HomeFrameLayout, fragBisherige);
			tx.Add(Resource.Id.HomeFrameLayout, fragEinstenllungen);
			tx.Add(Resource.Id.HomeFrameLayout, fragHilfe);
			tx.Hide(fragBisherige);
			tx.Hide(fragEinstenllungen);
			tx.Hide(fragHilfe);
			mCurrentFragment = fragProject;
			tx.Commit();
		}
		protected override void OnResume()
		{
			base.OnResume();
			SupportActionBar.SetTitle(Resource.String.projectk);
		}
		private void ShowFragment(SupportFragment fragment)
		{

			if (fragment.IsVisible)
			{
				return;
			}

			var trans = SupportFragmentManager.BeginTransaction();
			fragment.View.BringToFront();
			mCurrentFragment.View.BringToFront();
			trans.Hide(mCurrentFragment);
			trans.Show(fragment);
			trans.AddToBackStack(null);
			trans.Commit();

			mStackFragments.Push(mCurrentFragment);
			mCurrentFragment = fragment;

		}

		//define action for navigation menu selection
		void NavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
		{
			switch (e.MenuItem.ItemId)
			{
				case (Resource.Id.nav_project):

					SupportActionBar.SetTitle(Resource.String.projectk);
					ShowFragment(fragProject);
					break;
				case (Resource.Id.nav_bisherige):

					SupportActionBar.SetTitle(Resource.String.bisherige);
					ShowFragment(fragBisherige);
					break;
				case (Resource.Id.nav_einstellungen):
					SupportActionBar.SetTitle(Resource.String.einstellungen);
					ShowFragment(fragEinstenllungen);
					break;
				case (Resource.Id.nav_hilfe):
					SupportActionBar.SetTitle(Resource.String.hilfe);
					ShowFragment(fragHilfe);
					break;
			}
			// Close drawer
			drawerLayout.CloseDrawers();
		}

		//to avoid direct app exit on backpreesed and to show fragment from stack
		public override void OnBackPressed()
		{
			if (FragmentManager.BackStackEntryCount != 0)
			{
				FragmentManager.PopBackStack();// fragmentManager.popBackStack();
			}
			else
			{
				base.OnBackPressed();
			}
		}
	}
}
