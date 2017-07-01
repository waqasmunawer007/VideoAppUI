using System;
namespace VideoAppUISample.Droid.Models
{
    /// <summary>
    /// Video statuses either video recording stop normally (within time range)
    /// or exceed the threshhold value 
    /// </summary>
    public class VideoStatus
    {
        public static int NORMAL_RECORDING = 0;
        public static int DANGER_RECORDING = 1;

    }
}
