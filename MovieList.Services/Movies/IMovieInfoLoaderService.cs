using System.Collections.Generic;
using System.Threading.Tasks;
using MovieList.Services.Model;

namespace MovieList.Services.Movies
{
    public interface IMovieInfoLoaderService
    {
        Task<IList<MovieBasicInfo>> GetMovieListAsync(string query = null, int page = 0);
        Task<MovieFullInfo> GetMovieDetailAsync(int movieId);
    }
}