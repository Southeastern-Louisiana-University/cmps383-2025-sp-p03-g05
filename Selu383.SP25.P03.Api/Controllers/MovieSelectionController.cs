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

