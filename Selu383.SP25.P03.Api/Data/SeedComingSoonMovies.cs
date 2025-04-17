using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Features.ComingSoonMovies;

namespace Selu383.SP25.P03.Api.Data
{
    public class SeedComingSoonMovies
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if (context.ComingSoonMovies.Any())
                {
                    return; 
                }

                context.ComingSoonMovies.AddRange(
                    new ComingSoonMovies
                    {
                        Title = "The Boy and the Heron",
                        Genre = "Animation",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://m.media-amazon.com/images/M/MV5BMzA5Zjg3MTAtM2FhZS00NTNjLTg3NjEtNWQ4MTRhZjhiNzVmXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                        Description = "Hayao Miyazaki's newest fantasy about a boy's journey through grief and wonder."
                    },
                    new ComingSoonMovies
                    {
                        Title = "RRR 2",
                        Genre = "Action/Drama",
                        ReleaseYear = 2025,
                        AgeRating = "NR",
                        Poster = "https://i.ytimg.com/vi/r5wqzreQzbc/maxresdefault.jpg",
                        Description = "Sequel to the Indian epic action drama continuing the heroes’ rebellion."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Deadpool 3",
                        Genre = "Action/Comedy",
                        ReleaseYear = 2025,
                        AgeRating = "R",
                        Poster = "https://m.media-amazon.com/images/M/MV5BZTk5ODY0MmQtMzA3Ni00NGY1LThiYzItZThiNjFiNDM4MTM3XkEyXkFqcGc@._V1_.jpg",
                        Description = "Deadpool returns with unexpected allies."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Inside Out 2",
                        Genre = "Animation",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://pixflow.net/blog/wp-content/uploads/2025/02/Inside-Out-2-Colors.png",
                        Description = "Riley faces teenage emotions in a new journey."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Kung Fu Panda 4",
                        Genre = "Animation",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTOYIu1H-VoJgHf3S3c-c6JFdXAegiYPpAUaL8CxTk9MCcdQch2WR6tZXGFWuDf5p7y-EcF8w",
                        Description = "Po must train a new generation of warriors."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Wicked",
                        Genre = "Musical",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://comicbook.com/wp-content/uploads/sites/4/2025/01/2025-Golden-Globes-Wicked-movie-score-soundtrack.jpg",
                        Description = "The untold story of the witches of Oz."
                    },
                    new ComingSoonMovies
                    {
                        Title = "The Hunger Games: Sunrise on the Reaping",
                        Genre = "Drama/Sci-Fi",
                        ReleaseYear = 2025,
                        AgeRating = "PG-13",
                        Poster = "https://ew.com/thmb/xMKia_RonFZik5a7seefVm1v258=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/the-hunger-games-sunrise-on-the-reaping-040125-8962227e99a6434fad969244b29247ba.jpg",
                        Description = "A new rebellion brews in Panem."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Moana 2",
                        Genre = "Animation",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "hhttps://i.ebayimg.com/images/g/0HkAAOSwGUFnBCZK/s-l1200.jpg",
                        Description = "Moana sets sail on a new adventure."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Despicable Me 4",
                        Genre = "Animation",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ed/Despicable_Me_4_Theatrical_Release_Poster.jpeg/250px-Despicable_Me_4_Theatrical_Release_Poster.jpeg",
                        Description = "Gru and the minions return for another heist."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Zootopia 2",
                        Genre = "Animation",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://i.ytimg.com/vi/rO0HF82pqMg/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQj0AgKJD&rs=AOn4CLBtc_l7myqWFz7IAuNr2Q9TL2qK-w",
                        Description = "Judy Hopps and Nick Wilde take on a new case."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Toy Story 5",
                        Genre = "Animation",
                        ReleaseYear = 2025,
                        AgeRating = "G",
                        Poster = "https://i.ytimg.com/vi/Se7UMf8lND8/sddefault.jpg",
                        Description = "The toys face a new journey together."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Coco 2",
                        Genre = "Animation",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://9meters.com/wp-content/uploads/image_26fbdb681.jpeg",
                        Description = "Miguel returns to the Land of the Dead."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Leo",
                        Genre = "Action/Thriller",
                        ReleaseYear = 2025,
                        AgeRating = "NR",
                        Poster = "https://resizing.flixster.com/-BOvYVtW6LKWOdfbFz12hVdYzGk=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzL2RlNzVkZjM0LWRiZmEtNGE0YS1hYTUyLTU1YzlhYjQwMzViZi5qcGc=",
                        Description = "A Tamil-language thriller starring Vijay in a dual role."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Jurassic World: Rebirth",
                        Genre = "Action/Adventure",
                        ReleaseYear = 2025,
                        AgeRating = "NR",
                        Poster = "https://www.movieposters.com/cdn/shop/files/jurassic-world-rebirth_6gyim32q.jpg?v=1739552244",
                        Description = "Five years post-Jurassic World Dominion, an expedition braves isolated equatorial regions to extract DNA from three massive prehistoric creatures for a groundbreaking medical breakthrough."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Detective Chinatown 4",
                        Genre = "Comedy/Mystery",
                        ReleaseYear = 2025,
                        AgeRating = "PG-13",
                        Poster = "https://i.ytimg.com/vi/A0BOila1y8E/maxresdefault.jpg",
                        Description = "Chinese detectives solve crimes in yet another hilarious global case."
                    },
                    new ComingSoonMovies
                    {
                        Title = "BTS: Beyond the Stage",
                        Genre = "Music/Documentary",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://m.media-amazon.com/images/M/MV5BNDI1MGQwNWEtYmQ5Yi00MzU5LWEwNjUtNDk0MzM0N2JjMDU0XkEyXkFqcGc@._V1_.jpg",
                        Description = "An immersive behind-the-scenes look at BTS and their global impact."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Oppenheimer: Fallout",
                        Genre = "Drama/History",
                        ReleaseYear = 2025,
                        AgeRating = "R",
                        Poster = "https://m.media-amazon.com/images/M/MV5BN2JkMDc5MGQtZjg3YS00NmFiLWIyZmQtZTJmNTM5MjVmYTQ4XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
                        Description = "Sequel exploring the post-bomb legacy and ethical aftermath."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Wonka: The Chocolate War",
                        Genre = "Fantasy",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://ca-times.brightspotcdn.com/dims4/default/1cde905/2147483647/strip/true/crop/4341x1800+0+0/resize/1200x498!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2Fc7%2F9d%2F61b95d854a2995183d21c1feddfb%2Frev-1-won-cc-0005-high-res-jpeg.jpeg",
                        Description = "Willy Wonka protects his factory from industrial spies."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Spirited Away: The Return",
                        Genre = "Fantasy/Animation",
                        ReleaseYear = 2025,
                        AgeRating = "PG",
                        Poster = "https://theartsshelf.com/wp-content/uploads/2024/10/Spirited-Away-Quad-.jpg",
                        Description = "Studio Ghibli revisits the world beyond the bathhouse."
                    },
                    new ComingSoonMovies
                    {
                        Title = "The Railway Men",
                        Genre = "Drama",
                        ReleaseYear = 2025,
                        AgeRating = "NR",
                        Poster = "https://images.lifestyleasia.com/wp-content/uploads/sites/3/2023/11/22113528/the-railway-men-true-story-netflix.jpeg?tr=w-1200,h-900",
                        Description = "Inspired by real events in India during the Bhopal Gas Tragedy."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Mirzapur: The Movie",
                        Genre = "Action/Crime",
                        ReleaseYear = 2025,
                        AgeRating = "R",
                        Poster = "https://image.tmdb.org/t/p/w500/p0qM8hhlMF5DuxHBzl2EZR6TehX.jpg",
                        Description = "India’s gritty web series gets a cinematic conclusion."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Until Dawn",
                        Genre = "Horror",
                        ReleaseYear = 2025,
                        AgeRating = "R",
                        Poster = "https://www.impawards.com/2025/posters/until_dawn.jpg",
                        Description = "A group of friends trapped in a time loop, where mysterious foes are chasing and killing them in gruesome ways, must survive until dawn to escape it."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Bugonia",
                        Genre = "Sci-Fi Comedy",
                        ReleaseYear = 2025,
                        AgeRating = "PG-13",
                        Poster = "https://www.impawards.com/2025/posters/bugonia.jpg",
                        Description = "Two conspiracy-obsessed young men kidnap the high-powered CEO of a major company, convinced that she is an alien intent on destroying planet Earth."
                    },
                    new ComingSoonMovies
                    {
                        Title = "A Big Bold Beautiful Journey",
                        Genre = "Romantic Fantasy",
                        ReleaseYear = 2025,
                        AgeRating = "PG-13",
                        Poster = "https://www.themoviedb.org/t/p/original/your_poster_path_here.jpg",
                        Description = "An extraordinary emotional journey connects two strangers."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Animal Friends",
                        Genre = "Live-Action/Animation",
                        ReleaseYear = 2025,
                        AgeRating = "R",
                        Poster = "https://www.impawards.com/2025/posters/animal_friends.jpg",
                        Description = "An R-rated road trip adventure combining live-action and animated characters."
                    },
                    new ComingSoonMovies
                    {
                        Title = "The Wedding Banquet",
                        Genre = "Romantic Comedy",
                        ReleaseYear = 2025,
                        AgeRating = "PG-13",
                        Poster = "https://www.impawards.com/2025/posters/wedding_banquet.jpg",
                        Description = "A gay man makes a deal with his lesbian friend: a green-card marriage for him, in exchange for in vitro fertilization treatments for her."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Eddington",
                        Genre = "Thriller",
                        ReleaseYear = 2025,
                        AgeRating = "R",
                        Poster = "https://www.impawards.com/2025/posters/eddington.jpg",
                        Description = "In May of 2020, a standoff between a small-town sheriff and mayor sparks a powder keg as neighbor is pitted against neighbor in Eddington, New Mexico."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Sinners",
                        Genre = "Vampire Thriller",
                        ReleaseYear = 2025,
                        AgeRating = "R",
                        Poster = "https://www.impawards.com/2025/posters/sinners.jpg",
                        Description = "A vampire thriller set in 1930s Mississippi, directed by Ryan Coogler and starring Michael B. Jordan."
                    },
                    new ComingSoonMovies
                    {
                        Title = "The Fantastic Four: First Steps",
                        Genre = "Superhero",
                        ReleaseYear = 2025,
                        AgeRating = "PG-13",
                        Poster = "https://www.impawards.com/2025/posters/fantastic_four.jpg",
                        Description = "Marvel's reboot of the Fantastic Four, introducing the superhero team into the MCU."
                    },
                    new ComingSoonMovies
                    {
                        Title = "Thunderbolts*",
                        Genre = "Superhero",
                        ReleaseYear = 2025,
                        AgeRating = "PG-13",
                        Poster = "https://www.impawards.com/2025/posters/thunderbolts.jpg",
                        Description = "An unconventional team of antiheroes must embark on a dangerous mission that will force them to confront the darkest corners of their pasts."
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
