
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using VideoAppUISample.Droid.Adapters;

namespace VideoAppUISample.Droid
{
	public class PreviousProjectsFragment : Fragment
	{
        View mRootView;
        RecyclerView mPrjectRecyclerView;
        LinearLayoutManager mLayoutManager;
		ProjectRecyclerViewAdapter mViewAdapter { get; set; }
		
        List<Project> sampleProjectList = new List<Project>(); //temparary list

		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            mRootView = inflater.Inflate(Resource.Layout.fragment_bisherige, container, false);
            SetUpProjectRecyclerView();

			// var floating action button
            var fab = mRootView.FindViewById<FloatingActionButton>(Resource.Id.fab);
			fab.Click += delegate
			{
				Intent intent = new Intent(this.Activity, typeof(MainActivity));
				StartActivity(intent);
				//Toast.MakeText(this.Activity, "OK", ToastLength.Long).Show();
			};
            return mRootView;
		}
        /// <summary>
        /// Sets up project recycler view.
        /// </summary>
        private void SetUpProjectRecyclerView()
        {
            mPrjectRecyclerView = mRootView.FindViewById<RecyclerView>(Resource.Id.projects_recycler_view);
            mLayoutManager = new LinearLayoutManager(mPrjectRecyclerView.Context);
            mPrjectRecyclerView.SetLayoutManager(mLayoutManager);
            mPrjectRecyclerView.HasFixedSize = true;

            mViewAdapter = new ProjectRecyclerViewAdapter(PrepareSampleProjects());
            mViewAdapter.VideoThumbnailClick += OnVideoItemClick;
            mPrjectRecyclerView.SetAdapter(mViewAdapter);

        }
        /// <summary>
        /// Ons the video item click.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="position">Position.</param>
        void OnVideoItemClick(object sender, int position)
        {
            Project selectedProject = mViewAdapter.GetSelectedProject(position);
			Intent intent = new Intent(this.Activity, typeof(DetailProjectActivity));
			StartActivity(intent);
		}

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
