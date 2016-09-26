using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using FreshMvvm;
using MovieList.Services.Movies;
using PropertyChanged;
using Xamarin.Forms;

namespace MovieList.ViewModels
{
    [ImplementPropertyChanged]
    public class MovieListPageModel : FreshBasePageModel
    {
        private readonly IMovieInfoLoaderService _movieInfoLoaderService;

        public ObservableCollection<MovieBasicInfoViewModel> Movies { get; set; } = new ObservableCollection<MovieBasicInfoViewModel>();

        public ICommand ShowDetailCommand;

        public MovieListPageModel(IMovieInfoLoaderService movieInfoLoaderService)
        {
            _movieInfoLoaderService = movieInfoLoaderService;
        }

        private void InitializeCommands()
        {
            ShowDetailCommand = new Command(async movieId =>
            {
                await CoreMethods.PopToRoot(false);
                await CoreMethods.PushPageModel<MovieDetailPageModel>(movieId);
            });
        }

        public override async void Init(object initData)
        {
            base.Init(initData);

            InitializeCommands();

            await LoadMovies();
        }

        private async Task LoadMovies()
        {
            var movies = await _movieInfoLoaderService.GetMovieListAsync();
            foreach (var movie in movies)
            {
                Movies.Add(new MovieBasicInfoViewModel
                {
                    Id = movie.Id,
                    Name = movie.Title,
                    Year = movie.ReleaseDate.Year
                });
            }
        }
    }
}
