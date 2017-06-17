using System;
using System.Collections.Generic;
using Java.IO;
using VideoAppUISample.Droid.Models;

namespace VideoAppUISample.Droid
{
    public class Project 
    {
        public string Title { get; set; }
        public string Description { get; set; }
		public List<ProjectVideo> ProjectVideos;

    }
}
