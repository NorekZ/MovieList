using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MovieList.Services.Helpers;
using MovieList.Services.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MovieList.Services.Movies
{
    public class MovieInfoLoaderService : IMovieInfoLoaderService
    {
        private const string ApiKey = "f14320d4bbf682254a30a9775652c518";

        public async Task<IList<MovieBasicInfo>> GetMovieListAsync(string query = null, int page = 0)
        {
            using (var httpClient = new HttpClient())
            {
                var uri = new Uri($"http://api.themoviedb.org/3/discover/movie?api_key={ApiKey}&amp;page={page+1}");
                var response = await httpClient.GetAsync(uri);
                var responseData = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MovieDbResponse>(responseData, new JsonSerializerSettings
                {
                    ContractResolver = new SnakeCasePropertyNamesContractResolver()
                }).Results;
            }
            //return new List<MovieBasicInfo>
            //{
            //    new MovieBasicInfo { Title = "Film1", ReleaseDate = DateTime.Today.AddYears(-3) },
            //    new MovieBasicInfo { Title = "Film2", ReleaseDate = DateTime.Today.AddYears(-2) },
            //    new MovieBasicInfo { Title = "Film3", ReleaseDate = DateTime.Today.AddYears(-1) }
            //};
        }

        public async Task<MovieFullInfo> GetMovieDetailAsync(int movieId)
        {
            return new MovieFullInfo
            {
                Title = "Film1",
                ReleaseDate = DateTime.Today.AddYears(-3)
            };
        }

        private class MovieDbResponse
        {
            public IList<MovieBasicInfo> Results { get; set; }
        }
    }
}
