using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace VideoAppUISample.Droid.Adapters
{
	public class ProjectRecyclerViewAdapter : RecyclerView.Adapter
	{
		public event EventHandler<int> VideoThumbnailClick;
        List<Project> mItems;


		/// <summary>
        /// Adds the new project.
        /// </summary>
        /// <param name="project">Project.</param>
        public void AddNewProject(Project project)
		{
            mItems.Add(project);
			NotifyItemInserted(ItemCount - 1);
		}

        /// <summary>
        /// Gets the selected project item.
        /// </summary>
        /// <returns>The selected project.</returns>
        /// <param name="position">Position.</param>
        public Project GetSelectedProject(int position)
        {
            return mItems[position];
        }
		public ProjectRecyclerViewAdapter(List<Project> itemList)
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
        /// <summary>
        /// Ons the project video thumbnail click.
        /// </summary>
        /// <param name="position">Position.</param>
		void OnVideoThumbnailClick(int position)
		{
			if (VideoThumbnailClick != null)
				VideoThumbnailClick(this, position);
		}
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ProjectViewHolder vh = holder as ProjectViewHolder;
            Project project = mItems[position];
            vh.mProjectTitleTextView.Text = project.Title;

        }
		public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.cardview_video, parent, false);
            ProjectViewHolder vh = new ProjectViewHolder(itemView, OnVideoThumbnailClick);
			return vh;
		}

		public class ProjectViewHolder : RecyclerView.ViewHolder
		{
			public ImageView mVideoThumbnailImageView { get; private set; }
            public TextView mProjectTitleTextView { get; private set; }
            public TextView mProjectEditTextView { get; private set; }

			public ProjectViewHolder(View itemView, Action<int> videoItemClickListener) : base(itemView)
			{
				// Locate and cache view references:
				mVideoThumbnailImageView = itemView.FindViewById<ImageView>(Resource.Id.video_thumbnail_image_view);
				mProjectTitleTextView = itemView.FindViewById<TextView>(Resource.Id.project_name);
                mProjectEditTextView = itemView.FindViewById<TextView>(Resource.Id.edit_project_text_view);
				#pragma warning disable CS0618 // Type or member is obsolete
				mVideoThumbnailImageView.Click += (sender, e) => videoItemClickListener(base.Position);
				#pragma warning restore CS0618 // Type or member is obsolete
			}
		}

	}

}
