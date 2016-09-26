using FreshMvvm;
using MovieList.ViewModels;
using Xamarin.Forms;

namespace MovieList.Pages
{
    public partial class MovieListPage : FreshBaseContentPage
    {
        public MovieListPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listView = (sender as ListView);
            if (listView != null)
            {
                listView.SelectedItem = null;
            }
            var movie = e.SelectedItem as MovieBasicInfoViewModel;
            if (movie != null)
            {
                var movieId = movie.Id;
                var viewModel = (BindingContext as MovieListPageModel);
                viewModel?.ShowDetailCommand?.Execute(movieId);
            }
        }
    }
}
