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
                    new Movie { 
                        Title = "Inception", 
                        Genre = "Sci-Fi", 
                        Year = 2010, 
                        AgeRating = "PG-13", 
                        Poster = "https://www.aceshowbiz.com/images/still/inception_poster19.jpg", 
                        Description= "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster." 
                    },
                    new Movie { 
                        Title = "The Dark Knight", 
                        Genre = "Action", 
                        Year = 2008, 
                        AgeRating = "PG-13", 
                        Poster = "https://m.media-amazon.com/images/M/MV5BMmZhMTdhYWUtZWZhYS00MjZmLWEwZTctMjk1MmY4M2IwYTZlXkEyXkFqcGdeQXVyMTQwODQwMzAy._V1_FMjpg_UX1000_.jpg", 
                        Description= "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness." 
                    },
                    new Movie { 
                        Title = "Interstellar", 
                        Genre = "Sci-Fi", 
                        Year = 2014, 
                        AgeRating = "PG-13", 
                        Poster = "https://cdn.shopify.com/s/files/1/1416/8662/products/interstellar_2014_advance_original_film_art_682852f2-23f6-46de-a1db-4029d5b6f0b4_2000x.jpg?v=1574284010", 
                        Description= "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, to find a new planet for humans." 
                    },
                    new Movie { 
                        Title = "Gladiator", 
                        Genre = "Historical Drama", 
                        Year = 2000, 
                        AgeRating = "R" , 
                        Poster = "https://www.themoviedb.org/t/p/original/ixsPIb7dIiZlrqbV1QVdqA9XWxm.jpg", 
                        Description= "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery." 
                    },
                    new Movie { 
                        Title = "The Matrix", 
                        Genre = "Sci-Fi", 
                        Year = 1999, 
                        AgeRating = "R", 
                        Poster = "https://picfiles.alphacoders.com/385/385304.jpg",
                        Description= "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence."
                    },
                    new Movie { 
                        Title = "Avengers: Endgame", 
                        Genre = "Action", 
                        Year = 2019, 
                        AgeRating = "PG-13", 
                        Poster= "https://image.tmdb.org/t/p/original/gj0fKa4jjwxZLmVq7I8tv13V45.jpg",
                        Description= "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins due to the efforts of the Mad Titan, Thanos. With the help of remaining allies, the Avengers must assemble once more in order to undo Thanos's actions and undo the chaos to the universe, no matter what consequences may be in store, and no matter who they face..."
                    },
                    new Movie { 
                        Title = "Pulp Fiction", 
                        Genre = "Crime", 
                        Year = 1994, 
                        AgeRating = "R", 
                        Poster = "https://i.ebayimg.com/images/g/1uQAAOSw0wZjDeRh/s-l1600.jpg",
                        Description= "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption."
                    },
                    new Movie { 
                        Title = "The Godfather", 
                        Genre = "Crime", 
                        Year = 1972, 
                        AgeRating = "R", 
                        Poster = "https://www.themoviedb.org/t/p/original/wWJbBo5yjw22AIjE8isBFoiBI3S.jpg",
                        Description= "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
                    },
                    new Movie { 
                        Title = "Forrest Gump", 
                        Genre = "Drama", 
                        Year = 1994, 
                        AgeRating = "PG-13", 
                        Poster = "https://th.bing.com/th/id/OIP.4BQ14VKbOgT7NdoJ50ttUwHaK9?rs=1&pid=ImgDetMain",
                        Description= "The history of the United States from the 1950s to the '70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart."
                    },
                    new Movie { 
                        Title = "Fight Club", 
                        Genre = "Drama", 
                        Year = 1999, 
                        AgeRating = "R", 
                        Poster = "https://media.senscritique.com/media/000012256025/source_big/Fight_Club.jpg",
                        Description= "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more."
                    },
                    new Movie { 
                        Title = "The Shawshank Redemption", 
                        Genre = "Drama", 
                        Year = 1994, 
                        AgeRating = "R", 
                        Poster = "https://th.bing.com/th/id/OIP.-4OO96SRH00tOP4F0HnKVgHaLG?rs=1&pid=ImgDetMain",
                        Description= "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."
                    },
                    new Movie { 
                        Title = "The Lord of the Rings: The Fellowship of the Ring", 
                        Genre = "Fantasy", 
                        Year = 2001, 
                        AgeRating = "PG-13", 
                        Poster = "https://th.bing.com/th/id/OIP.jUeQkajMsvQ6nk8vTe04MgHaLH?rs=1&pid=ImgDetMain",
                        Description= "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron."
                    },
                    new Movie { 
                        Title = "The Lord of the Rings: The Two Towers", 
                        Genre = "Fantasy", 
                        Year = 2002, 
                        AgeRating = "PG-13", 
                        Poster = "https://www.themoviedb.org/t/p/original/arrWLKUCwS3uMZdRsKJOiai6VmR.jpg",
                        Description= "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard."
                    },
                    new Movie { 
                        Title = "The Lord of the Rings: The Return of the King", 
                        Genre = "Fantasy", 
                        Year = 2003, 
                        AgeRating = "PG-13", 
                        Poster = "https://th.bing.com/th/id/OIP.mF8hZd3_gzktA2BZMTlcLAHaKr?rs=1&pid=ImgDetMain",
                        Description= "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."
                    },
                    new Movie { 
                        Title = "The Lion King", 
                        Genre = "Animation", 
                        Year = 1994, 
                        AgeRating = "G", 
                        Poster = "https://th.bing.com/th/id/OIP.9yxvUHiTWP-sEgbvczFKYQAAAA?rs=1&pid=ImgDetMain",
                        Description= "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself."
                    },
                    new Movie { 
                        Title = "Spider-Man: No Way Home", 
                        Genre = "Action", 
                        Year = 2021, 
                        AgeRating = "PG-13", 
                        Poster = "https://th.bing.com/th/id/OIP.U5J4KwTUzAusa4ll1FXjlgHaK-?rs=1&pid=ImgDetMain",
                        Description= "Peter Parker's secret identity is revealed to the entire world. Desperate for help, Peter turns to Doctor Strange to make the world forget that he is Spider-Man. The spell goes horribly wrong and shatters the multiverse, bringing in monstrous villains that could destroy the world."
                    },
                    new Movie { 
                        Title = "The Batman", 
                        Genre = "Action", 
                        Year = 2022, 
                        AgeRating = "PG-13", 
                        Poster = "https://th.bing.com/th/id/R.231c7bf8b7452c5050b4688fb295ed96?rik=DB9dLBt37G%2bQjg&pid=ImgRaw&r=0",
                        Description= "When a sadistic serial killer begins murdering key political figures in Gotham, the Batman is forced to investigate the city's hidden corruption and question his family's involvement."
                    },
                    new Movie { 
                        Title = "Dune", 
                        Genre = "Sci-Fi", 
                        Year = 2021, 
                        AgeRating = "PG-13", 
                        Poster = "https://www.themoviedb.org/t/p/original/AqjrlcNRSKx84CeNJyNueg6V1SR.jpg",
                        Description= "Paul Atreides arrives on Arrakis after his father accepts the stewardship of the dangerous planet. However, chaos ensues after a betrayal as forces clash to control melange, a precious resource."
                    },
                    new Movie { 
                        Title = "Avatar", 
                        Genre = "Sci-Fi", 
                        Year = 2009, 
                        AgeRating = "PG-13", 
                        Poster = "https://th.bing.com/th/id/OIP.MM4R_KeROPNDDy8wivGjmwHaK-?rs=1&pid=ImgDetMain",
                        Description= "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home."
                    },
                    new Movie { 
                        Title = "Titanic", 
                        Genre = "Romance", 
                        Year = 1997, 
                        AgeRating = "PG-13", 
                        Poster = "https://www.themoviedb.org/t/p/original/zraTDtulFw2wrpyuYf646k95MNq.jpg",
                        Description= "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic."
                    },
                    new Movie { 
                        Title = "Joker", 
                        Genre = "Crime", 
                        Year = 2019, 
                        AgeRating = "R", 
                        Poster = "https://th.bing.com/th/id/OIP.4SzxxHd6AhrJIjmE39oKZwHaKe?rs=1&pid=ImgDetMain",
                        Description= "Arthur Fleck, a party clown and a failed stand-up comedian, leads an impoverished life with his ailing mother. However, when society shuns him and brands him as a freak, he decides to embrace the life of chaos in Gotham City."
                    },
                    new Movie { 
                        Title = "Toy Story", 
                        Genre = "Animation", 
                        Year = 1995, 
                        AgeRating = "G", 
                        Poster = "https://th.bing.com/th/id/OIP.5RO2u7skPJ9Kl9bGZQFYGwHaLO?rs=1&pid=ImgDetMain",
                        Description= "A cowboy doll is profoundly threatened and jealous when a new spaceman action figure supplants him as top toy in a boy's bedroom."
                    },
                    new Movie { 
                        Title = "Finding Nemo", 
                        Genre = "Animation", 
                        Year = 2003, 
                        AgeRating = "G" , 
                        Poster = "https://th.bing.com/th/id/R.0645ee5c9dec542751c33fa9de1b36c1?rik=jd1H%2fhpTmAeqVg&pid=ImgRaw&r=0",
                        Description= "After his son is captured in the Great Barrier Reef and taken to Sydney, a timid clownfish sets out on a journey to bring him home."
                    },
                    new Movie { 
                        Title = "Up", 
                        Genre = "Animation", 
                        Year = 2009, 
                        AgeRating = "PG", 
                        Poster = "https://th.bing.com/th/id/OIP.0VZZUWFnagCf8f1ujhN1VQHaLG?rs=1&pid=ImgDetMain",
                        Description= "78-year-old Carl Fredricksen travels to South America in his house equipped with balloons, inadvertently taking a young stowaway."
                    },
                    new Movie { 
                        Title = "Shrek", 
                        Genre = "Animation", 
                        Year = 2001, 
                        AgeRating = "PG" , 
                        Poster = "https://www.themoviedb.org/t/p/original/5Ch4NpEa6qmGyVxWNDiGYadadJw.jpg",
                        Description= "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back."
                    },
                    new Movie { 
                        Title = "The Incredibles", 
                        Genre = "Animation", 
                        Year = 2004, 
                        AgeRating = "PG", 
                        Poster = "https://th.bing.com/th/id/OIP.n8c51-zOUJHK05B3NKoTNwHaLH?rs=1&pid=ImgDetMain",
                        Description= "While trying to lead a quiet suburban life, a family of undercover superheroes are forced into action to save the world."
                    },
                    new Movie { 
                        Title = "Frozen", 
                        Genre = "Animation", 
                        Year = 2013, 
                        AgeRating = "PG" , 
                        Poster = "https://th.bing.com/th/id/OIP.QxZCCgdr5UuvsCZrqU3uLgHaKl?w=1024&h=1463&rs=1&pid=ImgDetMain",
                        Description= "Fearless optimist Anna teams up with rugged mountain man Kristoff and his loyal reindeer Sven in an epic journey to find Anna's sister Elsa, whose icy powers have trapped the kingdom of Arendelle in eternal winter."
                    },
                    new Movie { 
                        Title = "WALL-E", 
                        Genre = "Animation", 
                        Year = 2008, 
                        AgeRating = "G" , 
                        Poster = "https://th.bing.com/th/id/OIP.3vDpfRv_EfgdMpWD4Rb6WAHaKj?rs=1&pid=ImgDetMain",
                        Description= "A robot who is responsible for cleaning a waste-covered Earth meets another robot and falls in love with her. Together, they set out on a journey that will alter the fate of mankind."
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
