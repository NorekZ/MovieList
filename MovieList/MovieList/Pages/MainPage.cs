using FreshMvvm;
using MovieList.ViewModels;
using Xamarin.Forms;

namespace MovieList.Pages
{
    public class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            Master = FreshPageModelResolver.ResolvePageModel<MovieListPageModel>();
            var detailPage = FreshPageModelResolver.ResolvePageModel<MovieDetailPageModel>();
            var detailPageArea = new FreshNavigationContainer(detailPage);
            Detail = detailPageArea;
        }
    }
}
