using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using VideoAppUISample.Droid.Models;

namespace VideoAppUISample.Droid.Adapters
{
	public class ProjectVideoRecyclerViewAdapter : RecyclerView.Adapter
	{
        List<ProjectVideo> mItems;

		public ProjectVideoRecyclerViewAdapter(List<ProjectVideo> itemList)
		{
			mItems = itemList;
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
        }
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.cardview_detail, parent, false);
            ProjectVideoViewHolder vh = new ProjectVideoViewHolder(itemView);
			return vh;
		}

		public class ProjectVideoViewHolder : RecyclerView.ViewHolder
		{
			public ImageView mVideoThumbnailImageView { get; private set; }
            public TextView mVideoDescTextView { get; private set; }
            public TextView mVideoLengthTextView { get; private set; }
            public Spinner mAnimationSpiner { get; set; }
            public CheckBox mAnimationPickCheckbox { get; private set; }
			public ProjectVideoViewHolder(View itemView) : base(itemView)
			{
				// Locate and cache view references:
               //mAnimationPickCheckbox = itemView.FindViewById<CheckBox>(Resource.Id.animation_pick_checkbox);
               //mAnimationSpiner = itemView.FindViewById<Spinner>(Resource.Id.animations_spinner);
				mVideoThumbnailImageView = itemView.FindViewById<ImageView>(Resource.Id.cover_video_image_view);
				mVideoDescTextView = itemView.FindViewById<TextView>(Resource.Id.video_desc_text_view);
	            mVideoLengthTextView = itemView.FindViewById<TextView>(Resource.Id.video_length_text_view);
			}
		}

        private void SetupAnimationDropDown()
        {
            
        }

	}

}
