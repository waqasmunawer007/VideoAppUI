﻿using System;
using System.Collections.Generic;
using Android.Content;
using Android.Database;
using Android.Views;
using Android.Widget;
using Java.Lang;
using VideoAppUISample.Droid.Models;

namespace VideoAppUISample.Droid.Adapters
{
    public class AnimationDropDownAdpater: BaseAdapter,ISpinnerAdapter
    {
		private Context context;
		private List<string> animations;
        LayoutInflater inflater;
        int resourceLayout;

        public AnimationDropDownAdpater(Context context,int dropdownResourceId, List<string> animations)
		{
            resourceLayout = dropdownResourceId;
			this.context = context;
            this.animations = animations;
            inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
		}
		public override View GetDropDownView(int position, View convertView, ViewGroup parent)
		{
			View row = inflater.Inflate(resourceLayout, parent, false);
			TextView animationText = (TextView)row.FindViewById(Resource.Id.animation_title_text_view);
            animationText.Text = animations[position];
			return row;
		}
      
		public override int Count => animations.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            return animations[position];
        }
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
			View row = inflater.Inflate(resourceLayout, parent, false);
			TextView make = (TextView)row.FindViewById(Resource.Id.animation_title_text_view);
			make.Text = animations[position];
			return row;
        }

    }
}
