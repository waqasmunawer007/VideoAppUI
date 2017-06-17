
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using VideoAppUISample.Droid.Adapters;
using VideoAppUISample.Droid.Models;

namespace VideoAppUISample.Droid
{
	[Activity(Label = "DetailProjectActivity")]
	public class DetailProjectActivity : Activity
	{

		RecyclerView mPrjectRecyclerView;
		LinearLayoutManager mLayoutManager;
		ProjectVideoRecyclerViewAdapter mViewAdapter { get; set; }
        TextView mToolbarTitleTextView;
        ImageButton mBackButton;
        public static Project SelectedProject;
 		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_detail_project);
            mPrjectRecyclerView = FindViewById<RecyclerView>(Resource.Id.project_video_recycler_view);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
            mToolbarTitleTextView = FindViewById<TextView>(Resource.Id.toolbar_title_text_view);
            SetUpToolbar();
            SetUpProjectVideoRecyclerView();
			
		}

        /// <summary>
        /// Sets up toolbar.
        /// </summary>
        private void SetUpToolbar()
        {
            mToolbarTitleTextView.Text = SelectedProject.Title;
			mBackButton.Click += delegate
			{
				base.OnBackPressed();
			};
        }
		/// <summary>
		/// Sets up project videos recycler view.
		/// </summary>
		private void SetUpProjectVideoRecyclerView()
		{
			mLayoutManager = new LinearLayoutManager(mPrjectRecyclerView.Context);
			mPrjectRecyclerView.SetLayoutManager(mLayoutManager);
			mPrjectRecyclerView.HasFixedSize = true;
            mViewAdapter = new ProjectVideoRecyclerViewAdapter(SelectedProject.ProjectVideos);
			mPrjectRecyclerView.SetAdapter(mViewAdapter);
		}
	}
}
