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
                        StartTime = new DateTime(2025,4,1,14,15,0),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Two Towers").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 5, 14, 15, 0),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Two Towers").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,3,27,10,30,00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Frozen").Id,
                        Format = "IMAX",
                        Available = true,

                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,3,28,21,00,00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                        Format = "2D",
                        Available = true,

                    },
                     new Showtime
                     {
                         StartTime = new DateTime(2025, 3, 28, 09, 00, 00),
                         TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                         MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                         Format = "2D",
                         Available = true,

                     },
                      new Showtime
                      {
                          StartTime = new DateTime(2025, 3, 28, 12, 00, 00),
                          TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                          MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                          Format = "2D",
                          Available = true,

                      },
                       new Showtime
                       {
                           StartTime = new DateTime(2025, 4, 4, 14, 00, 00),
                           TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                           MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                           Format = "2D",
                           Available = true,

                       },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 4, 11, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                            Format = "2D",
                            Available = true,

                        },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,2,15,00,00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Return of the King").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 2, 12, 00, 00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Return of the King").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 2, 15, 00, 00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Return of the King").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,03,13,30,00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Matrix").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,4,19,30,00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,01,13,30,00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                        Format = "3D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,1,20,30,00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "3D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,2,9,30,00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avengers: Endgame").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,3,12,30,00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Interstellar").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 15, 30, 00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Interstellar").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 21, 30, 00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Interstellar").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 12, 30, 00),
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = false
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
