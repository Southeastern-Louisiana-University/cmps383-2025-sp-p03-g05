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
                    new Movie { Title = "Inception", Genre = "Sci-Fi", Year = 2010, AgeRating = "PG-13", Poster = "https://www.aceshowbiz.com/images/still/inception_poster19.jpg" },
                    new Movie { Title = "The Dark Knight", Genre = "Action", Year = 2008, AgeRating = "PG-13", Poster = "https://m.media-amazon.com/images/M/MV5BMmZhMTdhYWUtZWZhYS00MjZmLWEwZTctMjk1MmY4M2IwYTZlXkEyXkFqcGdeQXVyMTQwODQwMzAy._V1_FMjpg_UX1000_.jpg" },
                    new Movie { Title = "Interstellar", Genre = "Sci-Fi", Year = 2014, AgeRating = "PG-13", Poster = "https://cdn.shopify.com/s/files/1/1416/8662/products/interstellar_2014_advance_original_film_art_682852f2-23f6-46de-a1db-4029d5b6f0b4_2000x.jpg?v=1574284010" },
                    new Movie { Title = "Gladiator", Genre = "Historical Drama", Year = 2000, AgeRating = "R" , Poster = "https://www.themoviedb.org/t/p/original/ixsPIb7dIiZlrqbV1QVdqA9XWxm.jpg" },
                    new Movie { Title = "The Matrix", Genre = "Sci-Fi", Year = 1999, AgeRating = "R", Poster = "https://picfiles.alphacoders.com/385/385304.jpg" },
                    new Movie { Title = "Avengers: Endgame", Genre = "Action", Year = 2019, AgeRating = "PG-13", Poster= "https://image.tmdb.org/t/p/original/gj0fKa4jjwxZLmVq7I8tv13V45.jpg" },
                    new Movie { Title = "Pulp Fiction", Genre = "Crime", Year = 1994, AgeRating = "R", Poster = "https://i.ebayimg.com/images/g/1uQAAOSw0wZjDeRh/s-l1600.jpg" },
                    new Movie { Title = "The Godfather", Genre = "Crime", Year = 1972, AgeRating = "R", Poster = "https://www.themoviedb.org/t/p/original/wWJbBo5yjw22AIjE8isBFoiBI3S.jpg" },
                    new Movie { Title = "Forrest Gump", Genre = "Drama", Year = 1994, AgeRating = "PG-13", Poster = "https://th.bing.com/th/id/OIP.4BQ14VKbOgT7NdoJ50ttUwHaK9?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "Fight Club", Genre = "Drama", Year = 1999, AgeRating = "R", Poster = "https://media.senscritique.com/media/000012256025/source_big/Fight_Club.jpg" },
                    new Movie { Title = "The Shawshank Redemption", Genre = "Drama", Year = 1994, AgeRating = "R", Poster = "https://th.bing.com/th/id/OIP.-4OO96SRH00tOP4F0HnKVgHaLG?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "The Lord of the Rings: The Fellowship of the Ring", Genre = "Fantasy", Year = 2001, AgeRating = "PG-13", Poster = "https://th.bing.com/th/id/OIP.jUeQkajMsvQ6nk8vTe04MgHaLH?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "The Lord of the Rings: The Two Towers", Genre = "Fantasy", Year = 2002, AgeRating = "PG-13", Poster = "https://www.themoviedb.org/t/p/original/arrWLKUCwS3uMZdRsKJOiai6VmR.jpg" },
                    new Movie { Title = "The Lord of the Rings: The Return of the King", Genre = "Fantasy", Year = 2003, AgeRating = "PG-13", Poster = "https://th.bing.com/th/id/OIP.mF8hZd3_gzktA2BZMTlcLAHaKr?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "The Lion King", Genre = "Animation", Year = 1994, AgeRating = "G", Poster = "https://th.bing.com/th/id/OIP.9yxvUHiTWP-sEgbvczFKYQAAAA?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "Spider-Man: No Way Home", Genre = "Action", Year = 2021, AgeRating = "PG-13", Poster = "https://th.bing.com/th/id/OIP.U5J4KwTUzAusa4ll1FXjlgHaK-?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "The Batman", Genre = "Action", Year = 2022, AgeRating = "PG-13", Poster = "https://th.bing.com/th/id/R.231c7bf8b7452c5050b4688fb295ed96?rik=DB9dLBt37G%2bQjg&pid=ImgRaw&r=0" },
                    new Movie { Title = "Dune", Genre = "Sci-Fi", Year = 2021, AgeRating = "PG-13", Poster = "https://www.themoviedb.org/t/p/original/AqjrlcNRSKx84CeNJyNueg6V1SR.jpg" },
                    new Movie { Title = "Avatar", Genre = "Sci-Fi", Year = 2009, AgeRating = "PG-13", Poster = "https://th.bing.com/th/id/OIP.MM4R_KeROPNDDy8wivGjmwHaK-?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "Titanic", Genre = "Romance", Year = 1997, AgeRating = "PG-13", Poster = "https://www.themoviedb.org/t/p/original/zraTDtulFw2wrpyuYf646k95MNq.jpg" },
                    new Movie { Title = "Joker", Genre = "Crime", Year = 2019, AgeRating = "R", Poster = "https://th.bing.com/th/id/OIP.4SzxxHd6AhrJIjmE39oKZwHaKe?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "Toy Story", Genre = "Animation", Year = 1995, AgeRating = "G", Poster = "https://th.bing.com/th/id/OIP.5RO2u7skPJ9Kl9bGZQFYGwHaLO?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "Finding Nemo", Genre = "Animation", Year = 2003, AgeRating = "G" , Poster = "https://th.bing.com/th/id/R.0645ee5c9dec542751c33fa9de1b36c1?rik=jd1H%2fhpTmAeqVg&pid=ImgRaw&r=0" },
                    new Movie { Title = "Up", Genre = "Animation", Year = 2009, AgeRating = "PG", Poster = "https://th.bing.com/th/id/OIP.0VZZUWFnagCf8f1ujhN1VQHaLG?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "Shrek", Genre = "Animation", Year = 2001, AgeRating = "PG" , Poster = "https://www.themoviedb.org/t/p/original/5Ch4NpEa6qmGyVxWNDiGYadadJw.jpg" },
                    new Movie { Title = "The Incredibles", Genre = "Animation", Year = 2004, AgeRating = "PG", Poster = "https://th.bing.com/th/id/OIP.n8c51-zOUJHK05B3NKoTNwHaLH?rs=1&pid=ImgDetMain" },
                    new Movie { Title = "Frozen", Genre = "Animation", Year = 2013, AgeRating = "PG" , Poster = "https://th.bing.com/th/id/OIP.QxZCCgdr5UuvsCZrqU3uLgHaKl?w=1024&h=1463&rs=1&pid=ImgDetMain" },
                    new Movie { Title = "WALL-E", Genre = "Animation", Year = 2008, AgeRating = "G" , Poster = "https://th.bing.com/th/id/OIP.3vDpfRv_EfgdMpWD4Rb6WAHaKj?rs=1&pid=ImgDetMain" }
                );

                context.SaveChanges();
            }
        }
    }
}
