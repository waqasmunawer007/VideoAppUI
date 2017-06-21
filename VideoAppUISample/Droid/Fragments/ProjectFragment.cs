
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace VideoAppUISample.Droid
{
	public class ProjectFragment : Fragment, ViewPager.IOnPageChangeListener
	{
		View mRootView;
		ImageButton mNextButton;
		ImageButton mPreviousButton;
        Button mStartButton;
		ViewPager mViewPager { get; set; }
		ProjectViewPagerAdapter mPagerAdapter;
		private int currentPage = 0;
		public static Project selectedProject; //Todo temprary  declaration
		List<Project> sampleProjectList = new List<Project>(); //temparary list

		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			// Create your fragment here
		}
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			mRootView = inflater.Inflate(Resource.Layout.fragment_project, container, false);
			mPreviousButton = mRootView.FindViewById<ImageButton>(Resource.Id.previous_button);
			mNextButton = mRootView.FindViewById<ImageButton>(Resource.Id.next_button);
            mNextButton = mRootView.FindViewById<ImageButton>(Resource.Id.next_button);
            mStartButton = mRootView.FindViewById<Button>(Resource.Id.start_project_button);
			SetUpViewPager();

            mStartButton.Click += delegate {
               // LoadDownLoadProjectActivity();
            };
			return mRootView;
		}
		/// <summary>
		/// Sets up view pager.
		/// </summary>
		private void SetUpViewPager()
		{
			mViewPager = mRootView.FindViewById<ViewPager>(Resource.Id.project_viewpager);
			mPagerAdapter = new ProjectViewPagerAdapter(this.Activity, PrepareSampleProjects());
			mPagerAdapter.ItemClick += OnProjectItemClickHandler;
			mViewPager.Adapter = mPagerAdapter;
			mViewPager.AddOnPageChangeListener(this);
			mPreviousButton.Click += delegate
			{
				if (currentPage > 0)
				{
					currentPage--;
					mViewPager.CurrentItem = currentPage;
				}
			};
			mNextButton.Click += delegate
			{
				if (currentPage <= sampleProjectList.Count - 1)
				{
					currentPage++;
					mViewPager.CurrentItem = currentPage;
				}
			};
		}

		/// <summary>
		/// Ons the project/theme item click handler.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="position">Position.</param>
		private void OnProjectItemClickHandler(object sender, int position)
		{
			selectedProject = mPagerAdapter.GetSelectedProject(position);
			ShowConfirmationDialog();

		}

		#region IOnPageChangeListener interface implementation
		public void OnPageScrollStateChanged(int state){}
		public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
		{
			currentPage = position;
		}
		public void OnPageSelected(int position){}

		#endregion


		private void ShowConfirmationDialog()
		{ 
			var builder = new AlertDialog.Builder(this.Activity);
			builder.SetTitle("Alert");
			builder.SetMessage("Are you sure to downlaod? It will take mega bytes from your mobile storage space.");
			builder.SetPositiveButton("OK", (s, e) => { LoadDownLoadProjectActivity(); });
			builder.SetNegativeButton("Cancel", (s, e) => { /* do something on Cancel click */ });
			builder.Create().Show();
		}

		private void LoadDownLoadProjectActivity()
		{
			Intent intent = new Intent(this.Activity, typeof(DownloadProjectActivity));
			//Todo Pass Selected Project Item to DownloadProjectActivity screen here
			StartActivity(intent);

		}

		//Temp function
		private List<Project> PrepareSampleProjects()
		{
			Project project1 = new Project();
			project1.Title = "Personal Spot1";
			project1.Description = GetString(Resource.String.welcome_paragraph);
			sampleProjectList.Add(project1);

			Project project2 = new Project();
			project2.Title = "Personal Spot2";
			project2.Description = GetString(Resource.String.welcome_paragraph);
			sampleProjectList.Add(project2);

			Project project3 = new Project();
			project3.Title = "Personal Spot3";
			project3.Description = GetString(Resource.String.welcome_paragraph);
			sampleProjectList.Add(project3);

			return sampleProjectList;
		}
	}
}
