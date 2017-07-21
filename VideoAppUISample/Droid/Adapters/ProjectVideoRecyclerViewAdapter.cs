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
        public static List<ProjectVideo> mItems;
        List<String> mMusicItems;
        List<String> mAnimationItems;
        public MusicSpinnerAdapter mMusicSpinnerAdapter;
        public AnimationDropDownAdpater mAnimationSpinnerAdapter;
        public event EventHandler<int> VorschauButtonClick;
        public event EventHandler<int> AddNewMusicButtonClick;
        public event EventHandler<int> HinzufugenButtonClick;
        public event EventHandler<int> MusicSpinnerClick;
		public event EventHandler<int> GreenCriclClick;
		public event EventHandler<int> BlueCircleClick;
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
        public ProjectVideo GetSelectedVideo(int position)
        {
            return mItems[position];
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
		void OnGreenCircleClick(int position)
		{
            if (GreenCriclClick != null)
				GreenCriclClick(this, position);
		}

		/// <summary>
		/// Ons the music spinner click.
		/// </summary>
		/// <param name="position">Position.</param>
		void OnBlueCircleClick(int position)
		{
            if (BlueCircleClick != null)
				BlueCircleClick(this, position);
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
                    vh.mCheckCircleLayout.Visibility = ViewStates.Visible;
                }
                else
                {
					vh.mCheckCircleLayout.Visibility = ViewStates.Gone;
					vh.mVideoCounterCircleTextView.Visibility = ViewStates.Visible;
                    vh.mVideoCounterCircleTextView.Text = projectVideo.Counter + "";
                    vh.mVideoThumbnailImageView.SetBackgroundResource(Resource.Drawable.video_rect_placeholder);
                   
                }
                #endregion

                #region Animations
                if (mAnimationSpinnerAdapter == null)
                {
                    mAnimationSpinnerAdapter = new AnimationDropDownAdpater(mContext, Resource.Layout.animation_spiner_item_layout, mAnimationItems);

                }
                vh.mAnimationSpiner.Adapter = mAnimationSpinnerAdapter;
                vh.mAnimationSpiner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(AnimationSpinner_ItemSelected);
				#endregion

				if (projectVideo.isDisbaled)
				{
				   vh.mDisabledLayout.Visibility = ViewStates.Visible;
                   vh.mDisbaledRowTextView.Visibility = ViewStates.Visible;
				}
				else
				{ 
					vh.mDisabledLayout.Visibility = ViewStates.Gone;
					vh.mDisbaledRowTextView.Visibility = ViewStates.Gone;
				}
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
                ProjectVideoViewHolder vh = new ProjectVideoViewHolder(itemView,OnGreenCircleClick,OnBlueCircleClick);
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
            public FrameLayout mCheckCircleLayout;
            public TextView mVideoDescTextView { get; private set; }
            public TextView mVideoLengthTextView { get; private set; }
			public TextView mVideoCounterCircleTextView { get; private set; }
            public Spinner mAnimationSpiner { get; set; }
            public ImageView mAnimationPickImageView { get; private set; }
			public Com.Daimajia.Swipe.SwipeLayout mSwipeLayout;
            public LinearLayout mDisabledLayout;
            public ImageButton mUnlockDisabledCellButton;
            public TextView mDisbaledRowTextView;

            public ProjectVideoViewHolder(View itemView,Action<int> greenCircleClick,Action<int> blueCircleClick) : base(itemView)
			{
				// Locate and cache view references:
				mAnimationPickImageView = itemView.FindViewById<ImageView>(Resource.Id.animation_pick_imageview);
				mAnimationSpiner = itemView.FindViewById<Spinner>(Resource.Id.animation_spinner);
				mVideoThumbnailImageView = itemView.FindViewById<ImageView>(Resource.Id.cover_video_image_view);
				mVideoDescTextView = itemView.FindViewById<TextView>(Resource.Id.video_desc_text_view);
				mVideoLengthTextView = itemView.FindViewById<TextView>(Resource.Id.video_length_text_view);
				mVideoCounterCircleTextView = itemView.FindViewById<TextView>(Resource.Id.video_counter);
				mVideoCompleteCircleButton = itemView.FindViewById<ImageView>(Resource.Id.video_complete_status_imagebutton);
				mCheckCircleLayout = itemView.FindViewById<FrameLayout>(Resource.Id.circle_check_button_layout);
				mSwipeLayout = itemView.FindViewById<Com.Daimajia.Swipe.SwipeLayout>(Resource.Id.swipe_layout);
				mDisabledLayout = itemView.FindViewById<LinearLayout>(Resource.Id.disabled_row_layout);
				mUnlockDisabledCellButton = itemView.FindViewById<ImageButton>(Resource.Id.unlock_disabled_row_imagebutton);
				mDisbaledRowTextView = itemView.FindViewById<TextView>(Resource.Id.disabled_row_textview);

				#pragma warning disable CS0618 // Type or member is obsolete
                mVideoCompleteCircleButton.Click += (sender, e) => greenCircleClick(base.Position);
                #pragma warning restore CS0618 // Type or member is obsolete
				
                #pragma warning disable CS0618 // Type or member is obsolete
                mVideoCounterCircleTextView.Click += (sender, e) => blueCircleClick(base.Position);
				#pragma warning restore CS0618 // Type or member is obsolete

				#region Right Swipe handlings
				mSwipeLayout.SetShowMode(Com.Daimajia.Swipe.SwipeLayout.ShowMode.PullOut);
				var bottomView = mSwipeLayout.FindViewById(Resource.Id.bottom_wrapper);
				mSwipeLayout.AddDrag(Com.Daimajia.Swipe.SwipeLayout.DragEdge.Right, bottomView);
				mSwipeLayout.LeftSwipeEnabled = false;
				mSwipeLayout.RightSwipeEnabled = true;
				mSwipeLayout.StartOpen += (sender, e) => { };
				mSwipeLayout.OpenEvent += (sender, e) =>
			   	{
				   ProjectVideo projectVideo = mItems[AdapterPosition];
				   if (!projectVideo.isDisbaled)
				   {
					   Android.Util.Log.Info("Open", "open event" + AdapterPosition);
					   projectVideo.isDisbaled = true;
					   mDisabledLayout.Visibility = ViewStates.Visible;
					   mDisbaledRowTextView.Visibility = ViewStates.Visible;
				   }
			   };
				mUnlockDisabledCellButton.Click += delegate
				{
					ProjectVideo projectVideo = mItems[AdapterPosition];
					projectVideo.isDisbaled = false;
					mDisabledLayout.Visibility = ViewStates.Gone;
					mDisbaledRowTextView.Visibility = ViewStates.Gone;
				};
				#endregion
			}
		}
       /// <summary>
       /// Animations the spinner item selected.
       /// </summary>
       /// <param name="sender">Sender.</param>
       /// <param name="e">E.</param>
		private void AnimationSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
            string selectedAnimation = (string)spinner.GetItemAtPosition(e.Position);	
		}
       
    }

}
