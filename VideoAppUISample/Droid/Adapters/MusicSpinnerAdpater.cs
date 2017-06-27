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
    public class MusicSpinnerAdapter: BaseAdapter,ISpinnerAdapter
    {
		private Context context;
		private List<string> musicList;
        LayoutInflater inflater;
        int resourceLayout;

        public MusicSpinnerAdapter(Context context,int dropdownResourceId, List<string> musicItems)
		{
            resourceLayout = dropdownResourceId;
			this.context = context;
            this.musicList = musicItems;
            inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
		}

		/// <summary>
		/// Adds the new music into existing list.
		/// </summary>
		/// <param name="musicName">Music name.</param>
		public void AddNewMusic(string musicName)
		{
			musicList.Add(musicName);
			NotifyDataSetChanged();
		}

        public string GetSelectedMusicItem(int position)
        {
            return musicList[position];
        }

		public override View GetDropDownView(int position, View convertView, ViewGroup parent)
		{
			View row = inflater.Inflate(resourceLayout, parent, false);
			TextView musicTitle = (TextView)row.FindViewById(Resource.Id.music_title_text_view);
            musicTitle.Text = musicList[position];
			return row;
		}
		public override int Count => musicList.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            return musicList[position];
        }
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
			View row = inflater.Inflate(resourceLayout, parent, false);
			TextView musicTitle = (TextView)row.FindViewById(Resource.Id.music_title_text_view);
			musicTitle.Text = musicList[position];
			return row;
        }

    }
}
