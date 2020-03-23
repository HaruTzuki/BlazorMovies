using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
        {
            new Movie(){Title = "Spider-Man: Far From Home", ReleaseDate = new DateTime(2019,7,2), Poster = "img/movies/spider_man_far_from_home.jpg"},
            new Movie(){Title = "Moana", ReleaseDate = new DateTime(2016,11,23), Poster = "img/movies/moana.jpg"},
            new Movie(){Title = "Inception", ReleaseDate = new DateTime(2010, 7, 16), Poster = "img/movies/inception.jpg"}
        };
        }
    }
}
