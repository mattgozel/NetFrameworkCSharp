using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace IntroWebAPI
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
    }

    public class MovieRepository
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie
                { MovieId = 1, Title = "GhostBusters", Rating = "PG-13" },
            new Movie
                { MovieId = 2, Title = "Finding Nemo", Rating = "G" },
            new Movie
                { MovieId = 3, Title = "Rocky", Rating = "PG-13" }
        };

        public static List<Movie> GetAll()
        {
            return _movies;
        }

        public static Movie Get(int movieId)
        {
            return _movies.FirstOrDefault(m => m.MovieId == movieId);
        }


    }
}