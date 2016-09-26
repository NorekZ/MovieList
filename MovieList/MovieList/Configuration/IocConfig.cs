using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;
using MovieList.Services.Movies;

namespace MovieList.Configuration
{
    public static class IocConfig
    {
        public static void RegisterDependencies()
        {
            FreshIOC.Container.Register<IMovieInfoLoaderService, MovieInfoLoaderService>();
        }
    }
}
