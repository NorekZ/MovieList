using FreshMvvm;
using MovieList.Configuration;
using MovieList.Pages;
using MovieList.ViewModels;
using Xamarin.Forms;

namespace MovieList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            IocConfig.RegisterDependencies();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
