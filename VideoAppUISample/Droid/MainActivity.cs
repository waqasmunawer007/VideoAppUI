using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;
using SupportFragment = Android.Support.V4.App.Fragment;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android.Graphics;
using Android.Content;

namespace VideoAppUISample.Droid
{
	[Activity(Label = "VideoAppUISample", MainLauncher = false, ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
	public class MainActivity : AppCompatActivity
	{
		ProjectFragment mFragmentProject;
		PreviousProjectsFragment mFragmentBisherige;
		SettingsFragment mFragmentEinstenllungen;
		HelpFragment mFragmentHilfe;
		DrawerLayout mDrawerLayout;
		public Android.Support.V7.Widget.Toolbar mToolbar;

		private SupportFragment mCurrentFragment = new SupportFragment();
		private Stack<SupportFragment> mStackFragments;
	
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
			mToolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.app_bar);
			SetupToolbar();
			SetupDrawer(); 
		}
		protected override void OnResume()
		{
			base.OnResume();
			SupportActionBar.SetTitle(Resource.String.projectk);
		}

		/// <summary>
		/// Setups the toolbar.
		/// </summary>
		private void SetupToolbar()
		{
            //mToolbar.Background.SetAlpha(0);
            //mToolbar.SetBackgroundResource(Resource.Color.transparent);
			SetSupportActionBar(mToolbar);
			SupportActionBar.SetTitle(Resource.String.projectk);
			SupportActionBar.SetDisplayHomeAsUpEnabled(true);
			SupportActionBar.SetDisplayShowHomeEnabled(true);
		}
		/// <summary>
		/// Setups and init the drawer menu.
		/// </summary>
		private void SetupDrawer()
		{ 
			//Load Fragment
			mFragmentProject = new ProjectFragment();
			mFragmentBisherige = new PreviousProjectsFragment();
			mFragmentEinstenllungen = new SettingsFragment();
			mFragmentHilfe = new HelpFragment();
			//Fragment helper
			mStackFragments = new Stack<SupportFragment>();
			var navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
			navigationView.NavigationItemSelected += NavigationView_NavigationItemSelected;
			// Create ActionBarDrawerToggle button and add it to the toolbar
			var drawerToggle = new ActionBarDrawerToggle(this, mDrawerLayout, mToolbar, Resource.String.open_drawer, Resource.String.close_drawer);
			mDrawerLayout.SetDrawerListener(drawerToggle);
			drawerToggle.SyncState();
			Android.Support.V4.App.FragmentTransaction tx = SupportFragmentManager.BeginTransaction();
			tx.Add(Resource.Id.home_frame_layout, mFragmentProject);
			tx.Add(Resource.Id.home_frame_layout, mFragmentBisherige);
			tx.Add(Resource.Id.home_frame_layout, mFragmentEinstenllungen);
			tx.Add(Resource.Id.home_frame_layout, mFragmentHilfe);
            Intent intent = Intent;
            if (intent != null)
            {
                bool projectViewLaunchMode = intent.GetBooleanExtra("launch_project_overview", false);
                if (projectViewLaunchMode)
                {
                    //show Project OverView screen and hide Project screen
					tx.Hide(mFragmentProject);	
                    mCurrentFragment = mFragmentBisherige;
                }
                else
                {
                    //hide Project Overview screen and show Project screen
					tx.Hide(mFragmentBisherige);
					mCurrentFragment = mFragmentProject;
                }
            }
            else
            {
				//hide Project Overview screen and show Project screen
				tx.Hide(mFragmentBisherige);
				mCurrentFragment = mFragmentProject;
            }
			tx.Hide(mFragmentEinstenllungen);
			tx.Hide(mFragmentHilfe);
			tx.Commit();
		}
		/// <summary>
		/// Shows the selected fragment.
		/// </summary>
		/// <param name="fragment">Fragment.</param>
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

		/// <summary>
		/// define action for navigation menu selection
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void NavigationView_NavigationItemSelected(object sender, NavigationView.NavigationItemSelectedEventArgs e)
		{
			switch (e.MenuItem.ItemId)
			{
				case (Resource.Id.nav_project):
					SupportActionBar.SetTitle(Resource.String.projectk);
					ShowFragment(mFragmentProject);
					break;
				case (Resource.Id.nav_bisherige):

					SupportActionBar.SetTitle(Resource.String.bisherige);
					ShowFragment(mFragmentBisherige);
					break;
				case (Resource.Id.nav_einstellungen):
					SupportActionBar.SetTitle(Resource.String.einstellungen);
					ShowFragment(mFragmentEinstenllungen);
					break;
				case (Resource.Id.nav_hilfe):
					SupportActionBar.SetTitle(Resource.String.hilfe);
					ShowFragment(mFragmentHilfe);
					break;
			}
			// Close drawer
			mDrawerLayout.CloseDrawers();
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
