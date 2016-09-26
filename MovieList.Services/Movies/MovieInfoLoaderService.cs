using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieList.Model;

namespace MovieList.Services.Movies
{
    public class MovieInfoLoaderService : IMovieInfoLoaderService
    {
        public async Task<IList<MovieInfo>> GetMovieListAsync(string query = null, int offset = 0, int count = 10)
        {
            return new List<MovieInfo>
            {
                new MovieInfo { Title = "Film1", ReleaseDate = DateTime.Today.AddYears(-3) },
                new MovieInfo { Title = "Film2", ReleaseDate = DateTime.Today.AddYears(-2) },
                new MovieInfo { Title = "Film3", ReleaseDate = DateTime.Today.AddYears(-1) }
            };
        }

        public async Task<MovieInfo> GetMovieDetailAsync(int movieId)
        {
            return new MovieInfo
            {
                Title = "Film1",
                ReleaseDate = DateTime.Today.AddYears(-3)
            };
        }
    }
}
