using System;
using System.Collections.Generic;
using System.Linq;
using Selu383.SP25.P03.Api.Features.Movies;
namespace Selu383.SP25.P03.Api.Controllers
{


    public class MovieSelectionController
    {
        private List<Movie> movies;
        private Movie selectedMovie;

        public MovieSelectionController()
        {
            movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", Year = 2010, AgeRating = "PG-13" },
            new Movie { Id = 2, Title = "The Dark Knight", Genre = "Action", Year = 2008, AgeRating = "PG-13" },
            new Movie { Id = 3, Title = "Interstellar", Genre = "Sci-Fi", Year = 2014, AgeRating = "PG-13" },
            new Movie { Id = 4, Title = "Gladiator", Genre = "Historical Drama", Year = 2000, AgeRating = "R" },
            new Movie { Id = 5, Title = "The Matrix", Genre = "Sci-Fi", Year = 1999, AgeRating = "R" },
            new Movie { Id = 6, Title = "Avengers: Endgame", Genre = "Action", Year = 2019, AgeRating = "PG-13" },
            new Movie { Id = 7, Title = "Pulp Fiction", Genre = "Crime", Year = 1994, AgeRating = "R" },
            new Movie { Id = 8, Title = "The Godfather", Genre = "Crime", Year = 1972, AgeRating = "R" },
            new Movie { Id = 9, Title = "Forrest Gump", Genre = "Drama", Year = 1994, AgeRating = "PG-13" },
            new Movie { Id = 10, Title = "Fight Club", Genre = "Drama", Year = 1999, AgeRating = "R" },
            new Movie { Id = 11, Title = "The Shawshank Redemption", Genre = "Drama", Year = 1994, AgeRating = "R" },
            new Movie { Id = 12, Title = "The Lord of the Rings: The Fellowship of the Ring", Genre = "Fantasy", Year = 2001, AgeRating = "PG-13" },
            new Movie { Id = 13, Title = "The Lord of the Rings: The Two Towers", Genre = "Fantasy", Year = 2002, AgeRating = "PG-13" },
            new Movie { Id = 14, Title = "The Lord of the Rings: The Return of the King", Genre = "Fantasy", Year = 2003, AgeRating = "PG-13" },
            new Movie { Id = 15, Title = "The Lion King", Genre = "Animation", Year = 1994, AgeRating = "G" },
            new Movie { Id = 16, Title = "Spider-Man: No Way Home", Genre = "Action", Year = 2021, AgeRating = "PG-13" },
            new Movie { Id = 17, Title = "The Batman", Genre = "Action", Year = 2022, AgeRating = "PG-13" },
            new Movie { Id = 18, Title = "Dune", Genre = "Sci-Fi", Year = 2021, AgeRating = "PG-13" },
            new Movie { Id = 19, Title = "Avatar", Genre = "Sci-Fi", Year = 2009, AgeRating = "PG-13" },
            new Movie { Id = 20, Title = "Titanic", Genre = "Romance", Year = 1997, AgeRating = "PG-13" },
            new Movie { Id = 21, Title = "Joker", Genre = "Crime", Year = 2019, AgeRating = "R" },
            new Movie { Id = 22, Title = "Toy Story", Genre = "Animation", Year = 1995, AgeRating = "G" },
            new Movie { Id = 23, Title = "Finding Nemo", Genre = "Animation", Year = 2003, AgeRating = "G" },
            new Movie { Id = 24, Title = "Up", Genre = "Animation", Year = 2009, AgeRating = "PG" },
            new Movie { Id = 25, Title = "Shrek", Genre = "Animation", Year = 2001, AgeRating = "PG" },
            new Movie { Id = 26, Title = "The Incredibles", Genre = "Animation", Year = 2004, AgeRating = "PG" },
            new Movie { Id = 27, Title = "Frozen", Genre = "Animation", Year = 2013, AgeRating = "PG" },
            new Movie { Id = 28, Title = "WALL-E", Genre = "Animation", Year = 2008, AgeRating = "G" }
        };
        }

        public void DisplayMovies()
        {
            Console.WriteLine("Available Movies:");
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }

        public bool SelectMovie(int movieId)
        {
            var movie = movies.FirstOrDefault(m => m.Id == movieId);
            if (movie != null)
            {
                selectedMovie = movie;
                Console.WriteLine($"You selected: {selectedMovie.Title}");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid movie selection. Try again.");
                return false;
            }
        }

        public void ShowSelectedMovieDetails()
        {
            if (selectedMovie != null)
            {
                Console.WriteLine($"Selected Movie Details:\n{selectedMovie}");
            }
            else
            {
                Console.WriteLine("No movie selected yet.");
            }
        }
    }
}

