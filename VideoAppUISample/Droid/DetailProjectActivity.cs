
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
	[Activity(Label = "DetailProjectActivity" ,ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
	public class DetailProjectActivity : Activity
	{
		RecyclerView mPrjectRecyclerView;
		LinearLayoutManager mLayoutManager;
		ProjectVideoRecyclerViewAdapter mViewAdapter { get; set; }
        TextView mToolbarTitleTextView;
        ImageButton mBackButton;
        bool VideoCompletionFlow = false;
 		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_detail_project);
            mPrjectRecyclerView = FindViewById<RecyclerView>(Resource.Id.project_video_recycler_view);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
            mToolbarTitleTextView = FindViewById<TextView>(Resource.Id.toolbar_title_text_view);
            SetUpToolbar();
            SetUpProjectVideoRecyclerView();

			Intent intent = Intent;
			if (intent != null)
			{
                //if DetailActivity launches through Video Player
                VideoCompletionFlow = intent.GetBooleanExtra("video_recording_flow", false);//todo temparay code, need to revisit it
				
			}


		}
        /// <summary>
        /// Sets up toolbar.
        /// </summary>
        private void SetUpToolbar()
        {
			mToolbarTitleTextView.Text = "Projekt-Name # 1";
			mBackButton.Click += delegate
            {
				//todo temparay code, need to revisit it
				if (VideoCompletionFlow)
                {
                    Intent intent = new Intent(this, typeof(MainActivity));
                    intent.PutExtra("launch_project_overview", true);
					StartActivity(intent);
                    Finish();
                }
                else
                {
                    base.OnBackPressed();
                }
				
			};
        }
        #region Project Video RecyclerView Setup
        /// <summary>
        /// Sets up project videos recycler view.
        /// </summary>
        private void SetUpProjectVideoRecyclerView()
		{
			mLayoutManager = new LinearLayoutManager(mPrjectRecyclerView.Context);
			mPrjectRecyclerView.SetLayoutManager(mLayoutManager);
			mPrjectRecyclerView.HasFixedSize = true;
            mViewAdapter = new ProjectVideoRecyclerViewAdapter(PrepareSampleProjectVideo(),PrepareSampleMusic(),PrepareSampleAnimations(),this);
            mViewAdapter.VorschauButtonClick += VorschauButtonClickHandler;
            mViewAdapter.AddNewMusicButtonClick += AddNewMusicButtonClickHandler;
            mViewAdapter.HinzufugenButtonClick += HinzufugenButtonClickHandler;
            mViewAdapter.MusicSpinnerClick += Music_ItemSelected;
			mPrjectRecyclerView.SetAdapter(mViewAdapter);
		}
		void AddNewMusicButtonClickHandler(object sender, int position)
		{
            //add new music item into the existing music list
            mViewAdapter.mMusicSpinnerAdapter.AddNewMusic("new song");
            //Toast.MakeText(this, "new song added", ToastLength.Short).Show();
		}
		void VorschauButtonClickHandler(object sender, int position)
		{
			Intent intent = new Intent(this, typeof(VideoWirdActivity));
            StartActivity(intent);
		}
		void HinzufugenButtonClickHandler(object sender, int position)
		{
            //add new video into existing project videos list
            int videoCount = mViewAdapter.ItemCount - 1; //minus 1 to exclude Footer Layout 
			ProjectVideo dummyVieo = new ProjectVideo()
            {
                VideoDescription = "Dummy new video",
                VideoLength = "10:00",
                isVideoCompleted = false,
				Counter = videoCount+1

			};
            mViewAdapter.AddNewVideo(dummyVieo);
		}
		void Music_ItemSelected(object sender, int position)
		{
            string selectedMusic = (string)mViewAdapter.mMusicSpinnerAdapter.GetSelectedMusicItem(position);
            //Toast.MakeText(this, "Selected Music "+ selectedMusic, ToastLength.Short).Show();
		}

		private List<String> PrepareSampleMusic()
		{
			List<string> sampleMusicList = new List<string>();
			sampleMusicList.Add("Pick Music");
			sampleMusicList.Add("Music 1");
			sampleMusicList.Add("Music 2");
			sampleMusicList.Add("Music 3");
			return sampleMusicList;
		}
		private List<String> PrepareSampleAnimations()
		{
            List<string> animations = new List<string>();
			animations.Add("StandardAnimation");
			animations.Add("Animation1");
			animations.Add("Animation2");
			animations.Add("Animation3");
            return animations;
		}
		//Todo Temp function
		private List<ProjectVideo> PrepareSampleProjectVideo()
		{
			List<ProjectVideo> projectVideos = new List<ProjectVideo>();
			ProjectVideo video1 = new ProjectVideo()
			{
				VideoDescription = GetString(Resource.String.welcome_paragraph),
				VideoLength = "21:00",
				isVideoCompleted = true,
				Counter = 1

			};
			projectVideos.Add(video1);

			ProjectVideo video2 = new ProjectVideo()
			{
				VideoDescription = GetString(Resource.String.welcome_paragraph),
				VideoLength = "22:00",
				isVideoCompleted = false,
				Counter = 2

			};
			projectVideos.Add(video2);

			ProjectVideo video3 = new ProjectVideo()
			{
				VideoDescription = GetString(Resource.String.welcome_paragraph),
				VideoLength = "23:00",
				isVideoCompleted = true,
				Counter = 3

			};
			projectVideos.Add(video3);

			ProjectVideo video4 = new ProjectVideo()
			{
				VideoDescription = GetString(Resource.String.welcome_paragraph),
				VideoLength = "23:00",
				isVideoCompleted = false,
				Counter = 4

			};
			projectVideos.Add(video4);
			return projectVideos;
		}
    #endregion

		
	}
}
