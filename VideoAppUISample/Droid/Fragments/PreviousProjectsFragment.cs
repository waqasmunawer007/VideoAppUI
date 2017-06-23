
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
using Java.IO;
using VideoAppUISample.Droid.Adapters;
using VideoAppUISample.Droid.Models;

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
			//Todo correct way to pass the selected project through intent by implementing ISerializable or IParceable interface.
            DetailProjectActivity.SelectedProject = selectedProject; 
			Intent intent = new Intent(this.Activity, typeof(DetailProjectActivity));
			StartActivity(intent);
		}

		//Todo Temp function
		private List<Project> PrepareSampleProjects()
		{
            //project #1
			Project project1 = new Project();
			project1.Title = "Personal Spot1";
			project1.Description = GetString(Resource.String.welcome_paragraph);
            List<ProjectVideo> project1Videos = new List<ProjectVideo>();
            ProjectVideo video1 = new ProjectVideo()
            {
                VideoDescription = GetString(Resource.String.welcome_paragraph),
                VideoLength = "21:00",
				isVideoSelected = true,
                Counter = 1

            };
            project1Videos.Add(video1);
			ProjectVideo video2 = new ProjectVideo()
			{
				VideoDescription = GetString(Resource.String.welcome_paragraph),
				VideoLength = "22:00",
                isVideoSelected = false,
                Counter = 2   

			};
            project1Videos.Add(video2);
			ProjectVideo video3 = new ProjectVideo()
			{
				VideoDescription = GetString(Resource.String.welcome_paragraph),
				VideoLength = "23:00",
				isVideoSelected = true,
                Counter = 3

			};
            project1Videos.Add(video3);

			ProjectVideo video4 = new ProjectVideo()
			{
				VideoDescription = GetString(Resource.String.welcome_paragraph),
				VideoLength = "23:00",
				isVideoSelected = false,
                Counter = 4

			};
			project1Videos.Add(video4);

            project1.ProjectVideos = project1Videos;
			sampleProjectList.Add(project1);


            //project #2
			Project project2 = new Project();
			project2.Title = "Personal Spot2";
			project2.Description = GetString(Resource.String.welcome_paragraph);

			List<ProjectVideo> project2Videos = new List<ProjectVideo>();
			project2Videos.Add(video1);
			project2Videos.Add(video2);
			project2Videos.Add(video3);
            project2Videos.Add(video4);

			project2.ProjectVideos = project2Videos;
			sampleProjectList.Add(project2);

			//project #3
			Project project3 = new Project();
			project3.Title = "Personal Spot3";
			project3.Description = GetString(Resource.String.welcome_paragraph);

			List<ProjectVideo> project3Videos = new List<ProjectVideo>();
			project3Videos.Add(video1);
			project3Videos.Add(video2);
			project3Videos.Add(video3);
            project2Videos.Add(video4);

			project3.ProjectVideos = project3Videos;

			sampleProjectList.Add(project3);

            //project #4
			Project project4 = new Project();
			project4.Title = "Personal Spot4";
			project4.Description = GetString(Resource.String.welcome_paragraph);

			List<ProjectVideo> project4Videos = new List<ProjectVideo>();
			project4Videos.Add(video1);
			project4Videos.Add(video2);
			project4Videos.Add(video3);
            project2Videos.Add(video4);

			project4.ProjectVideos = project4Videos;

			sampleProjectList.Add(project4);


			return sampleProjectList;
		}
	}
}
