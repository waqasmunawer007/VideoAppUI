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
        List<String> mMusicItems;
        List<String> mAnimationItems;
        public MusicSpinnerAdapter mMusicSpinnerAdapter;
        public AnimationDropDownAdpater mAnimationSpinnerAdapter;
        public event EventHandler<int> VorschauButtonClick;
        public event EventHandler<int> AddNewMusicButtonClick;
        public event EventHandler<int> HinzufugenButtonClick;
        public event EventHandler<int> MusicSpinnerClick;
        Context mContext;
		private const int Type_Item = 1;
        private  const int Type_Footer = 2;

        public ProjectVideoRecyclerViewAdapter(List<ProjectVideo> itemList,List<String>musicItems,List<string> animations,Context context)
        {
            mContext = context;
            mItems = itemList;
            mMusicItems = musicItems;
            mAnimationItems = animations;
        }

        public void AddNewVideo(ProjectVideo projectVideo)
        {
			mItems.Add(projectVideo);
			NotifyItemInserted(ItemCount - 1);
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
                if (video.isVideoCompleted)
				{
					selectedVideos.Add(video);
				}
			}
			return selectedVideos;
		}

        /// <summary>
        /// Ons the music spinner click.
        /// </summary>
        /// <param name="position">Position.</param>
		void OnMusicSpinnerClick(int position)
		{
			if (MusicSpinnerClick != null)
				MusicSpinnerClick(this, position);
		}
        /// <summary>
        /// Ons the vorschau button click.
        /// </summary>
        /// <param name="position">Position.</param>
		void OnVorschauButtonClick(int position)
		{
            if (VorschauButtonClick != null)
                VorschauButtonClick(this, position);
		}
        /// <summary>
        /// Ons the add new music button click.
        /// </summary>
        /// <param name="position">Position.</param>
		void OnAddNewMusicButtonClick(int position)
		{
			if (AddNewMusicButtonClick != null)
				AddNewMusicButtonClick(this, position);
		}
        /// <summary>
        /// Ons the hinzufugen button click.
        /// </summary>
        /// <param name="position">Position.</param>
		void OnHinzufugenButtonClick(int position)
		{
			if (HinzufugenButtonClick != null)
				HinzufugenButtonClick(this, position);
		}

        /// <summary>
        /// Is the position footer.
        /// </summary>
        /// <returns><c>true</c>, if position footer was found, <c>false</c> otherwise.</returns>
        /// <param name="position">Position.</param>
        private Boolean isPositionFooter(int position)
		{
            return position >= mItems.Count;
		}

		public override int GetItemViewType(int position)
		{
			if (isPositionFooter(position))
			{
                return Type_Footer;
			}
            else
            {
                return Type_Item;
            }
		}
        public override int ItemCount
        {
            get
            {
                return mItems.Count+1; //add 1 for footer layout
            }
        }
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is ProjectVideoViewHolder)
            {
                ProjectVideoViewHolder vh = holder as ProjectVideoViewHolder;
                ProjectVideo projectVideo = mItems[position];

                vh.mVideoDescTextView.Text = projectVideo.VideoDescription;
                vh.mVideoLengthTextView.Text = "Dauer " + projectVideo.VideoLength;
				
                #region numbers or check icon in Circle
                if (projectVideo.isVideoCompleted)
                {
                    vh.mVideoThumbnailImageView.SetBackgroundResource(Resource.Drawable.login);
                    vh.mVideoCounterCircleTextView.Visibility = ViewStates.Gone;
                    vh.mVideoCompleteCircleButton.Visibility = ViewStates.Visible;
                }
                else
                {
					vh.mVideoCompleteCircleButton.Visibility = ViewStates.Gone;
					vh.mVideoCounterCircleTextView.Visibility = ViewStates.Visible;
                    vh.mVideoCounterCircleTextView.Text = projectVideo.Counter + "";
                    vh.mVideoThumbnailImageView.SetBackgroundResource(Resource.Drawable.video_rect_placeholder);
                   
                }
                vh.mVideoCounterCircleTextView.Click += delegate
                {
                    Intent intent = new Intent(mContext, typeof(IntroductionVideoActivity));
                    mContext.StartActivity(intent);
                };
                vh.mVideoCompleteCircleButton.Click += delegate
                {
                    Intent intent = new Intent(mContext, typeof(PostCaptureVideoActivity));
                    mContext.StartActivity(intent);
                };
                #endregion

                #region Animations
                if (mAnimationSpinnerAdapter == null)
                {
                    mAnimationSpinnerAdapter = new AnimationDropDownAdpater(mContext, Resource.Layout.animation_spiner_item_layout, mAnimationItems);

                }
                vh.mAnimationSpiner.Adapter = mAnimationSpinnerAdapter;
                vh.mAnimationSpiner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);

                //vh.mAnimationPickCheckbox.Click += (o, e) =>
                //{
                //	if (vh.mAnimationPickCheckbox.Checked)
                //	{
                //		string selectedAnimation = (string)vh.mAnimationSpiner.SelectedItem;
                //	}
                //};
                #endregion

                #region Right Swipe settings
                vh.mSwipeLayout.SetShowMode(Com.Daimajia.Swipe.SwipeLayout.ShowMode.PullOut);
                var bottomView = vh.mSwipeLayout.FindViewById(Resource.Id.bottom_wrapper);
                vh.mSwipeLayout.AddDrag(Com.Daimajia.Swipe.SwipeLayout.DragEdge.Right, bottomView);
                vh.mSwipeLayout.LeftSwipeEnabled = false;
                vh.mSwipeLayout.RightSwipeEnabled = true;
                vh.mSwipeLayout.StartOpen += (sender, e) => { };
                vh.mSwipeLayout.OpenEvent += (sender, e) =>
               {
                   Android.Util.Log.Info("Open", "open event");
                   vh.mDisabledLayout.Visibility = ViewStates.Visible;
                   vh.mDisbaledRowTextView.Visibility = ViewStates.Visible;
               };
                // unlock disabled cell 
                vh.mUnlockDisabledCellButton.Click += delegate
                {
                    vh.mDisabledLayout.Visibility = ViewStates.Gone;
                    vh.mDisbaledRowTextView.Visibility = ViewStates.Gone;
                };
                #endregion

            }
            else
            {
				//footer layout binding
                FooterViewHolder footerViewHolder = holder as FooterViewHolder;
                mMusicSpinnerAdapter = new MusicSpinnerAdapter(mContext, Resource.Layout.music_spinner_item_layout, mMusicItems);
                footerViewHolder.mMusicPickerSpinner.Adapter = mMusicSpinnerAdapter;
			}
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            if (viewType == Type_Item)
            {
				View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.project_video_cell_item_layout, parent, false);
				ProjectVideoViewHolder vh = new ProjectVideoViewHolder(itemView);
				return vh; 
            }
            else
            {
                View footerView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.list_footer_layout, parent, false);
                FooterViewHolder vh = new FooterViewHolder(footerView,OnVorschauButtonClick,OnAddNewMusicButtonClick,OnHinzufugenButtonClick,OnMusicSpinnerClick);
				return vh;
			}
           
        }

		public class FooterViewHolder : RecyclerView.ViewHolder
		{
			public Button mClipHinzufugenButton;
			public Button mAddNewMusicButton;
            public Button mVorschauButton;
			public Spinner mMusicPickerSpinner;

			public FooterViewHolder(View footerView, Action<int> vorschauButtonClickListener, Action<int> newMusicButtonClickListener
										 , Action<int> hinzufugenButtonClickListener, Action<int> musicSpinnerClickListener) : base(footerView)
			{
				// Locate and cache view references:
				mMusicPickerSpinner = footerView.FindViewById<Spinner>(Resource.Id.music_picker_spinner);
				mClipHinzufugenButton = footerView.FindViewById<Button>(Resource.Id.clip_hinzufugen_button);
				mAddNewMusicButton = footerView.FindViewById<Button>(Resource.Id.add_new_music_button);
                mVorschauButton = footerView.FindViewById<Button>(Resource.Id.vorschau_button);

				#pragma warning disable CS0618 // Type or member is obsolete
				mVorschauButton.Click += (sender, e) => vorschauButtonClickListener(base.Position);
				#pragma warning restore CS0618 // Type or member is obsolete
				
                #pragma warning disable CS0618 // Type or member is obsolete
				mAddNewMusicButton.Click += (sender, e) => newMusicButtonClickListener(base.Position);
				#pragma warning restore CS0618 // Type or member is obsolete
				
                #pragma warning disable CS0618 // Type or member is obsolete
				mClipHinzufugenButton.Click += (sender, e) => hinzufugenButtonClickListener(base.Position);
				#pragma warning restore CS0618 // Type or member is obsolete

				#pragma warning disable CS0618 // Type or member is obsolete
				mMusicPickerSpinner.ItemSelected += (sender, e) => musicSpinnerClickListener(e.Position);
				#pragma warning restore CS0618 // Type or member is obsolete
			}
		}

        public class ProjectVideoViewHolder : RecyclerView.ViewHolder
        {
            public ImageView mVideoThumbnailImageView { get; private set; }
			public ImageView mVideoCompleteCircleButton { get; private set; }
            public TextView mVideoDescTextView { get; private set; }
            public TextView mVideoLengthTextView { get; private set; }
			public TextView mVideoCounterCircleTextView { get; private set; }
            public Spinner mAnimationSpiner { get; set; }
            public ImageView mAnimationPickImageView { get; private set; }
			public Com.Daimajia.Swipe.SwipeLayout mSwipeLayout;
            public LinearLayout mDisabledLayout;
            public ImageButton mUnlockDisabledCellButton;
            public TextView mDisbaledRowTextView;

            public ProjectVideoViewHolder(View itemView) : base(itemView)
            {
                // Locate and cache view references:
                mAnimationPickImageView = itemView.FindViewById<ImageView>(Resource.Id.animation_pick_imageview);
                mAnimationSpiner = itemView.FindViewById<Spinner>(Resource.Id.animation_spinner);
                mVideoThumbnailImageView = itemView.FindViewById<ImageView>(Resource.Id.cover_video_image_view);
                mVideoDescTextView = itemView.FindViewById<TextView>(Resource.Id.video_desc_text_view);
                mVideoLengthTextView = itemView.FindViewById<TextView>(Resource.Id.video_length_text_view);
				mVideoCounterCircleTextView = itemView.FindViewById<TextView>(Resource.Id.video_counter);
				mVideoCompleteCircleButton = itemView.FindViewById<ImageButton>(Resource.Id.video_complete_status_imagebutton);
				mSwipeLayout = itemView.FindViewById<Com.Daimajia.Swipe.SwipeLayout>(Resource.Id.swipe_layout);
                mDisabledLayout = itemView.FindViewById<LinearLayout>(Resource.Id.disabled_row_layout);
                mUnlockDisabledCellButton = itemView.FindViewById<ImageButton>(Resource.Id.unlock_disabled_row_imagebutton);
				mDisbaledRowTextView = itemView.FindViewById<TextView>(Resource.Id.disabled_row_textview);
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
       
    }

}
