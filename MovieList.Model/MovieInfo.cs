using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.Model
{
    public class MovieInfo
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
