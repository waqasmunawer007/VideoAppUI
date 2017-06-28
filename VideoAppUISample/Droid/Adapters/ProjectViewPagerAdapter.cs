using System;
using System.Collections.Generic;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;

namespace VideoAppUISample.Droid
{
	public class ProjectViewPagerAdapter : PagerAdapter
	{
		public event EventHandler<int> ItemClick;
		public List<Project> mItems;
		Context context;
		LayoutInflater mLayoutInflater;

		public ProjectViewPagerAdapter(Context context, List<Project> projectList)
		{
			mItems = projectList;
			this.context = context;
			mLayoutInflater = (LayoutInflater)this.context.GetSystemService(Context.LayoutInflaterService);
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

		/// <summary>
		/// Handles Item view click
		/// </summary>
		/// <param name="position">Position.</param>
		void OnItemClick(int position)
		{
			if (ItemClick != null)
				ItemClick(this, position);
		}

		public override int Count
		{
			get
			{
				return mItems.Count;
			}
		}
		public override bool IsViewFromObject(View view, Java.Lang.Object @object)
		{
			//return view == ((LinearLayout)object);
			return view == @object;
		}

		public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
		{
			Project project = mItems[position];
			View itemView = mLayoutInflater.Inflate(Resource.Layout.project_view_pager_item_layout, container, false);
			TextView projectTitleTextView = itemView.FindViewById<TextView>(Resource.Id.project_title_text_view);
			TextView projectDescTextView = itemView.FindViewById<TextView>(Resource.Id.project_desc_text_view);
            ImageView projectImageView = itemView.FindViewById<ImageView>(Resource.Id.project_imageview);
			projectTitleTextView.Text = project.Title;
			projectDescTextView.Text = project.Description;

            //TODO replace this logic with yours code
            if (position == 0)
            {
                projectImageView.SetBackgroundResource(Resource.Drawable.template);
            }
            else if (position == 1)
            {
                projectImageView.SetBackgroundResource(Resource.Drawable.login);
            }
            else
            {
                projectImageView.SetBackgroundResource(Resource.Drawable.template);
            }

			var viewPager = container.JavaCast<ViewPager>();
			viewPager.AddView(itemView);

			itemView.Click += (sender, e) => OnItemClick(position);
			return itemView;
		}

		public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object @object)
		{
			var viewPager = container.JavaCast<ViewPager>();
			viewPager.RemoveView(@object as View);
		}

	}
}