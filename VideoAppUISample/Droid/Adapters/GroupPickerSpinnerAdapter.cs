using System;
using System.Collections.Generic;
using Android.Content;
using Android.Database;
using Android.Views;
using Android.Widget;
using Java.Lang;
using VideoAppUISample.Droid.Models;

namespace VideoAppUISample.Droid.Adapters
{
    public class GroupPickerSpinnerAdapter: BaseAdapter,ISpinnerAdapter
    {
		private Context context;
        private List<Group> mItems;
        LayoutInflater inflater;
        int resourceLayout;

        public GroupPickerSpinnerAdapter(Context context,int dropdownResourceId, List<Group> groups)
		{
            resourceLayout = dropdownResourceId;
			this.context = context;
            this.mItems = groups;
            inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
		}
		public override View GetDropDownView(int position, View convertView, ViewGroup parent)
		{
			View row = inflater.Inflate(resourceLayout, parent, false);
			TextView groupTitleTextView = (TextView)row.FindViewById(Resource.Id.group_title_textview);
            groupTitleTextView.Text = mItems[position].GroupName;
			ImageView groupIcon = (ImageView)row.FindViewById(Resource.Id.group_icon_imageview);

			//set icon for each animation
			if (position == 0)
            {
                groupIcon.Visibility = ViewStates.Gone;
            }
			else if (position == 1)
			{
                groupIcon.SetBackgroundResource(Resource.Drawable.ic_landscape);
			}
			else if (position == 2)
			{
                groupIcon.SetBackgroundResource(Resource.Drawable.ic_send);
			}
            else if (position == 3)
			{
                groupIcon.SetBackgroundResource(Resource.Drawable.ic_thumb_up);
			}
			return row;
		}
      
		public override int Count => mItems.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            return mItems[position];
        }
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
			View row = inflater.Inflate(resourceLayout, parent, false);
			TextView groupTitleTextView = (TextView)row.FindViewById(Resource.Id.group_title_textview);
			groupTitleTextView.Text = mItems[position].GroupName;
			ImageView groupIcon = (ImageView)row.FindViewById(Resource.Id.group_icon_imageview);

			//set icon for each animation
			if (position == 0)
			{
				groupIcon.Visibility = ViewStates.Gone; //for Group title, hide icon visibility
			}
			else if (position == 1)
			{
				groupIcon.SetBackgroundResource(Resource.Drawable.ic_landscape);
			}
			else if (position == 2)
			{
				groupIcon.SetBackgroundResource(Resource.Drawable.ic_send);
			}
			else if (position == 3)
			{
				groupIcon.SetBackgroundResource(Resource.Drawable.ic_thumb_up);
			}
           
			return row;
        }

    }
}
