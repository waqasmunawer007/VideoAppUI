using System;
using System.Collections.Generic;
using Android.Content;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using VideoAppUISample.Droid.Models;


namespace VideoAppUISample.Droid.Adapters
{
    public class ProjectVideoRecyclerViewAdapter : RecyclerView.Adapter 
    {
        List<ProjectVideo> mItems;
        Context mContext;
        List<string> animations = new List<string>();
        public ProjectVideoRecyclerViewAdapter(List<ProjectVideo> itemList,Context context)
        {
            mContext = context;
            mItems = itemList;
            PrepareSampleAnimations();
        }

		/// <summary>
		/// Returns all selected project video.
		/// </summary>
		/// <returns>The all selected project video.</returns>
		public List<ProjectVideo> GetAllSelectedProjectVideo()
		{
			List<ProjectVideo> selectedVideos = new List<ProjectVideo>();
			foreach (ProjectVideo video in mItems)
			{
				if (video.isVideoSelected)
				{
					selectedVideos.Add(video);
				}
			}
			return selectedVideos;
		}

        public override int ItemCount
        {
            get
            {
                return mItems.Count;
            }
        }
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ProjectVideoViewHolder vh = holder as ProjectVideoViewHolder;
            ProjectVideo projectVideo = mItems[position];
            vh.mVideoDescTextView.Text = projectVideo.VideoDescription;
            vh.mVideoLengthTextView.Text = "Dauer " + projectVideo.VideoLength;
			vh.mVideoCounterTextView.Text = ++position + "";

            AnimationDropDownAdpater spinnerAdapter = new AnimationDropDownAdpater(mContext, Resource.Layout.animation_spiner_item_layout, animations);
            vh.mAnimationSpiner.Adapter = spinnerAdapter;
            vh.mAnimationSpiner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            vh.mAnimationPickCheckbox.Click += (o, e) =>
			{
                if (vh.mAnimationPickCheckbox.Checked)
                {
                  string selectedAnimation = (string)vh.mAnimationSpiner.SelectedItem;  
                }
			};
			vh.mVideoCounterTextView.Click += delegate {
				projectVideo.isVideoSelected = true;
				vh.mVideoCounterTextView.Visibility = ViewStates.Gone;
				vh.mVideoOKButton.Visibility = ViewStates.Visible;
			};

			if (projectVideo.isVideoSelected)
			{
				vh.mVideoCounterTextView.Visibility = ViewStates.Gone;
				vh.mVideoOKButton.Visibility = ViewStates.Visible;
			}
			else
			{ 
				vh.mVideoCounterTextView.Visibility = ViewStates.Visible;
			}

			vh.mSwipeLayout.SetShowMode(Com.Daimajia.Swipe.SwipeLayout.ShowMode.LayDown);
			var bottomView = vh.mSwipeLayout.FindViewById(Resource.Id.bottom_wrapper);
			//vh.mSwipeLayout.FindViewById<LinearLayout>(Resource.Id.bottom_wrapper)
			
			vh.mSwipeLayout.AddDrag(Com.Daimajia.Swipe.SwipeLayout.DragEdge.Left,bottomView);

			vh.mSwipeLayout.LeftSwipeEnabled = false;
			vh.mSwipeLayout.RightSwipeEnabled = true;



        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.project_video_cell_item_layout, parent, false);
            ProjectVideoViewHolder vh = new ProjectVideoViewHolder(itemView);
            return vh;
        }

        public class ProjectVideoViewHolder : RecyclerView.ViewHolder
        {
            public ImageView mVideoThumbnailImageView { get; private set; }
			public ImageView mVideoOKButton { get; private set; }
            public TextView mVideoDescTextView { get; private set; }
            public TextView mVideoLengthTextView { get; private set; }
			public TextView mVideoCounterTextView { get; private set; }
            public Spinner mAnimationSpiner { get; set; }
            public CheckBox mAnimationPickCheckbox { get; private set; }
			public Com.Daimajia.Swipe.SwipeLayout mSwipeLayout;
            public ProjectVideoViewHolder(View itemView) : base(itemView)
            {
                // Locate and cache view references:
                mAnimationPickCheckbox = itemView.FindViewById<CheckBox>(Resource.Id.animation_pick_checkbox);
                mAnimationSpiner = itemView.FindViewById<Spinner>(Resource.Id.animation_spinner);
                mVideoThumbnailImageView = itemView.FindViewById<ImageView>(Resource.Id.cover_video_image_view);
                mVideoDescTextView = itemView.FindViewById<TextView>(Resource.Id.video_desc_text_view);
                mVideoLengthTextView = itemView.FindViewById<TextView>(Resource.Id.video_length_text_view);
				mVideoCounterTextView = itemView.FindViewById<TextView>(Resource.Id.video_counter);
				mVideoOKButton = itemView.FindViewById<ImageButton>(Resource.Id.video_selected_button_imagebutton);
				mSwipeLayout = itemView.FindViewById<Com.Daimajia.Swipe.SwipeLayout>(Resource.Id.swipe_layout);
            }
        }


        /// <summary>
        /// click listener for spinner the item selected.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
		private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
            string selectedAnimation = (string)spinner.GetItemAtPosition(e.Position);	
		}
        private void PrepareSampleAnimations()
        {
            animations.Add("StandardAnimation");
			animations.Add("Animation1");
			animations.Add("Animation2");
			animations.Add("Animation3");
        }

    }

}
