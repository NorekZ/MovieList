using System.Collections.Generic;
using System.Threading.Tasks;
using MovieList.Model;

namespace MovieList.Services.Movies
{
    public interface IMovieInfoLoaderService
    {
        Task<IList<MovieInfo>> GetMovieListAsync(string query = null, int offset = 0, int count = 10);
        Task<MovieInfo> GetMovieDetailAsync(int movieId);
    }
}