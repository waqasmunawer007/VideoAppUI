
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
        Button mClipHinzufugenButton;
        Button mAddNewMusicButton;
        Spinner mMusicPickerSpinner;

        public static Project SelectedProject;
		List<string> sampleMusicList = new List<string>();

 		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_detail_project);
            mMusicPickerSpinner = FindViewById<Spinner>(Resource.Id.music_picker_spinner);
            mPrjectRecyclerView = FindViewById<RecyclerView>(Resource.Id.project_video_recycler_view);
			mBackButton = FindViewById<ImageButton>(Resource.Id.back_image_button);
            mClipHinzufugenButton = FindViewById<Button>(Resource.Id.clip_hinzufugen_button);
			mAddNewMusicButton = FindViewById<Button>(Resource.Id.add_new_music_button);
            mToolbarTitleTextView = FindViewById<TextView>(Resource.Id.toolbar_title_text_view);
         
            SetUpToolbar();
            SetUpProjectVideoRecyclerView();
            SetupMusicPicker();

            mClipHinzufugenButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(VideoWirdActivity));
                StartActivity(intent);
            };
			mAddNewMusicButton.Click += delegate{};
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
            mViewAdapter = new ProjectVideoRecyclerViewAdapter(SelectedProject.ProjectVideos,this);
			mPrjectRecyclerView.SetAdapter(mViewAdapter);
		}
        /// <summary>
        /// Setups the music picker.
        /// </summary>
        private void SetupMusicPicker()
        {
            PrepareSampleMusic();
			mMusicPickerSpinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Music_ItemSelected);
            MusicSpinnerAdapter spinnerAdapter = new MusicSpinnerAdapter(this, Resource.Layout.music_spinner_item_layout, sampleMusicList);
			mMusicPickerSpinner.Adapter = spinnerAdapter;
           
        }
		private void Music_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
            string selectedMusic = (string)mMusicPickerSpinner.GetItemAtPosition(e.Position);
		}
		private void PrepareSampleMusic()
		{
			sampleMusicList.Add("Pick Music");
			sampleMusicList.Add("Music 1");
			sampleMusicList.Add("Music 2");
			sampleMusicList.Add("Music 3");
		}
	}
}
