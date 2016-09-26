﻿using System;

namespace MovieList.Services.Model
{
    public class MovieFullInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string OriginalLanguage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Adult { get; set; }
        public string Overview { get; set; }
        public float Popularity { get; set; }
    }
}
