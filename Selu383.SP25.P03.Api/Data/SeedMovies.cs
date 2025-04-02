using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Features.Movies;

namespace Selu383.SP25.P03.Api.Data
{
    public class SeedMovies
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                // Look for any Movies.
               if (context.Movies.Any())
                {
                  return;   // DB has been seeded
                }

                context.Movies.AddRange(
                    new Movie { Title = "Inception", Genre = "Sci-Fi", Year = 2010, AgeRating = "PG-13" },
                    new Movie { Title = "The Dark Knight", Genre = "Action", Year = 2008, AgeRating = "PG-13" },
                    new Movie { Title = "Interstellar", Genre = "Sci-Fi", Year = 2014, AgeRating = "PG-13" },
                    new Movie { Title = "Gladiator", Genre = "Historical Drama", Year = 2000, AgeRating = "R" },
                    new Movie { Title = "The Matrix", Genre = "Sci-Fi", Year = 1999, AgeRating = "R" },
                    new Movie { Title = "Avengers: Endgame", Genre = "Action", Year = 2019, AgeRating = "PG-13" },
                    new Movie { Title = "Pulp Fiction", Genre = "Crime", Year = 1994, AgeRating = "R" },
                    new Movie { Title = "The Godfather", Genre = "Crime", Year = 1972, AgeRating = "R" },
                    new Movie { Title = "Forrest Gump", Genre = "Drama", Year = 1994, AgeRating = "PG-13" },
                    new Movie { Title = "Fight Club", Genre = "Drama", Year = 1999, AgeRating = "R" },
                    new Movie { Title = "The Shawshank Redemption", Genre = "Drama", Year = 1994, AgeRating = "R" },
                    new Movie { Title = "The Lord of the Rings: The Fellowship of the Ring", Genre = "Fantasy", Year = 2001, AgeRating = "PG-13" },
                    new Movie { Title = "The Lord of the Rings: The Two Towers", Genre = "Fantasy", Year = 2002, AgeRating = "PG-13" },
                    new Movie { Title = "The Lord of the Rings: The Return of the King", Genre = "Fantasy", Year = 2003, AgeRating = "PG-13" },
                    new Movie { Title = "The Lion King", Genre = "Animation", Year = 1994, AgeRating = "G" },
                    new Movie { Title = "Spider-Man: No Way Home", Genre = "Action", Year = 2021, AgeRating = "PG-13" },
                    new Movie { Title = "The Batman", Genre = "Action", Year = 2022, AgeRating = "PG-13" },
                    new Movie { Title = "Dune", Genre = "Sci-Fi", Year = 2021, AgeRating = "PG-13" },
                    new Movie { Title = "Avatar", Genre = "Sci-Fi", Year = 2009, AgeRating = "PG-13" },
                    new Movie { Title = "Titanic", Genre = "Romance", Year = 1997, AgeRating = "PG-13" },
                    new Movie { Title = "Joker", Genre = "Crime", Year = 2019, AgeRating = "R" },
                    new Movie { Title = "Toy Story", Genre = "Animation", Year = 1995, AgeRating = "G" },
                    new Movie { Title = "Finding Nemo", Genre = "Animation", Year = 2003, AgeRating = "G" },
                    new Movie { Title = "Up", Genre = "Animation", Year = 2009, AgeRating = "PG" },
                    new Movie { Title = "Shrek", Genre = "Animation", Year = 2001, AgeRating = "PG" },
                    new Movie { Title = "The Incredibles", Genre = "Animation", Year = 2004, AgeRating = "PG" },
                    new Movie { Title = "Frozen", Genre = "Animation", Year = 2013, AgeRating = "PG" },
                    new Movie { Title = "WALL-E", Genre = "Animation", Year = 2008, AgeRating = "G" }
                );

                context.SaveChanges();
            }
        }
    }
}
