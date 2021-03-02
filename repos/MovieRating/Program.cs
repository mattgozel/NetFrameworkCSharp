using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MovieRating> movies = new List<MovieRating>();
            movies.Add(new MovieRating { Title = "Her", Rating = 8 });
            movies.Add(new MovieRating { Title = "Fletch", Rating = 5 });
            movies.Add(new MovieRating { Title = "Superbabies: Baby Geniuses 2", Rating = 9 });
            movies.Add(new MovieRating { Title = "Howl's Moving Castle", Rating = 10 });
            movies.Sort();

            foreach (var movie in movies)
            {
                Console.Write(movie.Title + " ");
                Console.WriteLine(movie.Rating);

            }
        }
    }

    public class MovieRating : IComparable<MovieRating>
    {
        public string Title { get; set; }
        public int Rating { get; set; }

        public int CompareTo(MovieRating other)
        {
            if (other == null)
            {
                return 1;
            }

            return this.Rating.CompareTo(other.Rating);
        }
    }
}
