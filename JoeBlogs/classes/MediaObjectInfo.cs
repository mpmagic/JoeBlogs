﻿namespace JoeBlogs
{
    /// <summary>
    /// Represents media object info - The URL to the media object.
    /// </summary>
    public class MediaObjectInfo
    {
        /// <summary>
        /// The URL to the media object.
        /// </summary>
        public string URL { get; set; }
        public string ID { get; set; } // MP - we need id from Wordpress for Featured Image
    }
}