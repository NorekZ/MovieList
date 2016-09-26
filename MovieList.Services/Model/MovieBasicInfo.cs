using System;
using Newtonsoft.Json;

namespace MovieList.Services.Model
{
    public class MovieBasicInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
