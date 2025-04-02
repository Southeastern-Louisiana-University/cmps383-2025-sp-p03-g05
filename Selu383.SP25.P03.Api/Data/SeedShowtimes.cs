using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Features.Showtimes;

namespace Selu383.SP25.P03.Api.Data
{
    public class SeedShowtimes
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if (context.Showtimes.Any())
                {
                    return;
                }
                    //context.Theaters.First(x => x.Name =="mytheatername").Id
                    //Instead of hard-coding theater ids, find the ids of the seeded theaters using the code above
                    //and placing them where 'TheaterId' is in the seeded showtimes
                context.Showtimes.AddRange(
                    new Showtime
                    {
                        Time = new TimeOnly(14, 15),
                        ShowDate = new DateOnly(2025, 4, 01),
                        TheaterId = context.Theaters.First(x => x.Name == "Grand Theater").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Two Towers").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        Time = new TimeOnly(10, 30),
                        ShowDate = new DateOnly(2025, 3, 27),
                        TheaterId = context.Theaters.First(x => x.Name == "Grand Theater").Id,
                        MovieId = context.Movies.First(x => x.Title == "Frozen").Id,
                        Format = "IMAX",
                        Available = true,

                    },
                    new Showtime
                    {
                        Time = new TimeOnly(21, 00),
                        ShowDate = new DateOnly(2025, 3, 28),
                        TheaterId = context.Theaters.First(x => x.Name == "Grand Theater").Id,
                        MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                        Format = "2D",
                        Available = true,

                    },
                    new Showtime
                    {
                        Time = new TimeOnly(15, 00),
                        ShowDate = new DateOnly(2025, 4, 02),
                        TheaterId = context.Theaters.First(x => x.Name == "Regal Cinema").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Return of the King").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        Time = new TimeOnly(13, 30),
                        ShowDate = new DateOnly(2025, 4, 03),
                        TheaterId = context.Theaters.First(x => x.Name == "Regal Cinema").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Matrix").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        Time = new TimeOnly(19, 30),
                        ShowDate = new DateOnly(2025, 4, 04),
                        TheaterId = context.Theaters.First(x => x.Name == "Regal Cinema").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        Time = new TimeOnly(13, 30),
                        ShowDate = new DateOnly(2025, 4, 01),
                        TheaterId = context.Theaters.First(x => x.Name == "Vintage Drive-In").Id,
                        MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                        Format = "3D",
                        Available = false
                    },
                    new Showtime
                    {
                        Time = new TimeOnly(20, 30),
                        ShowDate = new DateOnly(2025, 4, 01),
                        TheaterId = context.Theaters.First(x => x.Name == "Vintage Drive-In").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "3D",
                        Available = false
                    },
                    new Showtime
                    {
                        Time = new TimeOnly(09, 30),
                        ShowDate = new DateOnly(2025, 4, 02),
                        TheaterId = context.Theaters.First(x => x.Name == "Vintage Drive-In").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avengers: Endgame").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        Time = new TimeOnly(12, 30),
                        ShowDate = new DateOnly(2025, 4, 03),
                        TheaterId = context.Theaters.First(x => x.Name == "Vintage Drive-In").Id,
                        MovieId = context.Movies.First(x => x.Title == "Interstellar").Id,
                        Format = "2D",
                        Available = false
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
