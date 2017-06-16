
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace VideoAppUISample.Droid
{
	public class ProjectFragment : Fragment,ViewPager.IOnPageChangeListener
	{
		View mRootView;
		ImageButton mNextButton;
		ImageButton mPreviousButton;
		ViewPager mViewPager { get; set; }
		ProjectViewPagerAdapter mPagerAdapter;
		private int currentPage = 0;
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
			SetUpViewPager();
			return mRootView;
		}
		/// <summary>
		/// Sets up view pager.
		/// </summary>
		private void SetUpViewPager()
		{
			mViewPager = mRootView.FindViewById<ViewPager>(Resource.Id.project_viewpager);
			mPagerAdapter = new ProjectViewPagerAdapter(this.Activity, PrepareSampleProjects());
			mViewPager.Adapter = mPagerAdapter;
			mViewPager.AddOnPageChangeListener(this);
			mPreviousButton.Click += delegate {
				if (currentPage > 0)
				{
					currentPage--;
					mViewPager.CurrentItem = currentPage;
				}
			};
			mNextButton.Click+= delegate {
				if (currentPage <= sampleProjectList.Count-1)
				{
					currentPage++;
					mViewPager.CurrentItem = currentPage;
				}
			};
		}

		#region IOnPageChangeListener interface implementation
		public void OnPageScrollStateChanged(int state){}
		public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
		{
			currentPage = position;
		}
		public void OnPageSelected(int position){}

		#endregion

		//Todo Temp function
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
