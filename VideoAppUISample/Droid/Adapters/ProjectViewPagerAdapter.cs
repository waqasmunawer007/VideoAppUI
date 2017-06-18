using System;
using System.Collections.Generic;
using Android.Content;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;

namespace VideoAppUISample.Droid
{
	public class ProjectViewPagerAdapter: PagerAdapter
	{
		public List<Project> mItems;
		Context context;
		LayoutInflater mLayoutInflater;
		public ProjectViewPagerAdapter(Context context, List<Project> projectList)
		{
			mItems = projectList;
			this.context = context;
			mLayoutInflater = (LayoutInflater)this.context.GetSystemService(Context.LayoutInflaterService);
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
			projectTitleTextView.Text = project.Title;
			projectDescTextView.Text = project.Description;
			var viewPager = container.JavaCast<ViewPager>();
			viewPager.AddView(itemView);

			return itemView;
		}

		public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object @object)
		{
			var viewPager = container.JavaCast<ViewPager>();
			viewPager.RemoveView(@object as View);
		}

	}
}