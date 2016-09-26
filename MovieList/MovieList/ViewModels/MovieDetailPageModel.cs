using System;
using FreshMvvm;
using MovieList.Model;
using MovieList.Services.Movies;
using PropertyChanged;

namespace MovieList.ViewModels
{
    [ImplementPropertyChanged]
    public class MovieDetailPageModel : FreshBasePageModel
    {
        private readonly IMovieInfoLoaderService _movieInfoLoaderService;

        public int Id { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string OriginalLanguage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Adult { get; set; }
        public string Overview { get; set; }
        public float Popularity { get; set; }

        public MovieDetailPageModel(IMovieInfoLoaderService movieInfoLoaderService)
        {
            _movieInfoLoaderService = movieInfoLoaderService;
        }

        public override async void Init(object initData)
        {
            base.Init(initData);

            if (initData is int)
            {
                var movie = await _movieInfoLoaderService.GetMovieDetailAsync((int) initData);

                ShowMovie(movie);
            }
        }

        private void ShowMovie(MovieInfo movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            OriginalTitle = movie.OriginalTitle;
            OriginalLanguage = movie.OriginalLanguage;
            ReleaseDate = movie.ReleaseDate;
            Adult = movie.Adult;
            Overview = movie.Overview;
            Popularity = movie.Popularity;
        }
    }
}
