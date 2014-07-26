﻿using System.Collections.Generic;

namespace InstaSharp.Models.Responses
{
    public class TagsMultiplePagesResponse : IResponse
    {
        public TagsMultiplePagesResponse()
        {
            Data = new List<Media>();
        }
        /// <summary>
        /// The most recent meta tag
        /// </summary>
        public Meta Meta { get; set; }
        public List<Media> Data { get; set; }
        /// <summary>
        /// The number of pages in total which were returned
        /// </summary>
        public uint PageCount { get; set; }
    }
}