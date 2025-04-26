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

                    //New York Showtimes
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,1,14,15,0), //2:15 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Two Towers").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 5, 14, 15, 0), //2:15 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Two Towers").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 15, 9, 00, 0), //9:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Two Towers").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 15, 13, 00, 0), //1:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Two Towers").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 17, 30, 00), //5:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 10, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 10, 19, 00, 00), //7:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,3,27,10,30,00), //10:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Frozen").Id,
                        Format = "IMAX",
                        Available = true,

                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 12, 11, 00, 00), //11:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Frozen").Id,
                        Format = "IMAX",
                        Available = true,

                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 15, 10, 30, 00), //10:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Frozen").Id,
                        Format = "IMAX",
                        Available = true,

                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 15, 18, 00, 00), //6:00 pm
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
                        StartTime = new DateTime(2025, 4, 16, 21, 00, 00), //9:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                        MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                        Format = "2D",
                        Available = true,

                    },
                     new Showtime
                     {
                         StartTime = new DateTime(2025, 4, 17, 09, 00, 00), //9:00 am
                         TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                         MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                         Format = "2D",
                         Available = true,

                     },
                      new Showtime
                      {
                          StartTime = new DateTime(2025, 4, 18, 12, 00, 00), //12:00 pm
                          TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                          MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                          Format = "2D",
                          Available = false,

                      },
                      new Showtime
                      {
                          StartTime = new DateTime(2025, 4, 18, 16, 00, 00), //4:00 pm
                          TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                          MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                          Format = "2D",
                          Available = true,

                      },
                       new Showtime
                       {
                           StartTime = new DateTime(2025, 4, 4, 14, 00, 00), //2:00 pm
                           TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                           MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                           Format = "2D",
                           Available = true,

                       },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 4, 11, 00, 00), //11:00 am
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                            Format = "2D",
                            Available = true,

                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 8, 18, 00, 00), //6:00 pm
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
                            StartTime = new DateTime(2025, 4, 12, 11, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 12, 15, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 13, 18, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                            Format = "2D",
                            Available = false
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 14, 09, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 14, 19, 30, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 15, 11, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 15, 11, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                            Format = "2D",
                            Available = false
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 16, 18, 30, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 15, 17, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 15, 11, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 15, 16, 30, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 13, 09, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 13, 09, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                            Format = "3D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 13, 12, 30, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                            Format = "3D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 16, 17, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 17, 12, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                            Format = "2D",
                            Available = true
                        },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 13, 10, 00, 00),
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                            Format = "IMAX",
                            Available = true
                        },
                         new Showtime
                         {
                             StartTime = new DateTime(2025, 4, 13, 14, 30, 00),
                             TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                             MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                             Format = "IMAX",
                             Available = false
                         },
                          new Showtime
                          {
                              StartTime = new DateTime(2025, 4, 16, 16, 00, 00),
                              TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                              MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                              Format = "IMAX",
                              Available = true
                          },
                           new Showtime
                           {
                               StartTime = new DateTime(2025, 4, 15, 19, 30, 00),
                               TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                               MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                               Format = "IMAX",
                               Available = true
                           },
                            new Showtime
                            {
                                StartTime = new DateTime(2025, 4, 15, 12, 00, 00),
                                TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                                Format = "IMAX",
                                Available = true
                            },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 15, 17, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 17, 17, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 17, 19, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 18, 11, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 18, 17, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 18, 14, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 20, 17, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                                 Format = "3D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 20, 11, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                                 Format = "3D",
                                 Available = false
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 19, 16, 30, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 21, 14, 30, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                                 Format = "3D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 18, 11, 30, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 18, 11, 30, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Gladiator").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 18, 15, 30, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Gladiator").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 19, 17, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Gladiator").Id,
                                 Format = "2D",
                                 Available = false
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 19, 21, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Gladiator").Id,
                                 Format = "2D",
                                 Available = true
                             },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 20, 12, 00, 00),
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Gladiator").Id,
                                 Format = "2D",
                                 Available = true
                             },


                    //New Orleans Showtimes
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 15, 00, 00), //3:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 8, 20, 30, 00), //8:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = false
                    },

                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,2,15,00,00), //2:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Return of the King").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 2, 12, 00, 00), //12:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Return of the King").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 2, 15, 00, 00), //2:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Return of the King").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,03,13,30,00), //1:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Matrix").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 13, 13, 30, 00), //1:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Matrix").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 03, 19, 00, 00), //7:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Matrix").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 03, 22, 30, 00), //10:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Matrix").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,4,19,30,00), //7:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 10, 19, 30, 00), //7:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 18, 10, 30, 00), //10:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "IMAX",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 19, 19, 30, 00), //7:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 20, 17, 30, 00), //5:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 17, 17, 30, 00), //5:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Forrest Gump").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 17, 10, 30, 00), //10:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Forrest Gump").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 17, 10, 00, 00), //10:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Forrest Gump").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 16, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Forrest Gump").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 17, 17, 30, 00), //5:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 12, 18, 00, 00), //6:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 13, 14, 00, 00), //2:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 13, 18, 00, 00), //6:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 21, 18, 00, 00), //6:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 22, 18, 00, 00), //6:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lion King").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 22, 11, 00, 00), //11:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lion King").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 21, 14, 00, 00), //11:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lion King").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 23, 15, 00, 00), //3:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lion King").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 19, 12, 00, 00), //12:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lion King").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 22, 22, 00, 00), //10:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Dune").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 22, 17, 00, 00), //5:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Dune").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 22, 22, 00, 00), //10:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Dune").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 23, 18, 00, 00), //6:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Dune").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 23, 13, 30, 00), //1:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Dune").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 20, 22, 00, 00), //10:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                        Format = "3D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 23, 21, 00, 00), //9:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 21, 18, 00, 00), //6:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 24, 19, 00, 00), //7:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 23, 21, 00, 00), //9:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avatar").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 19, 22, 00, 00), //7:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 19, 16, 00, 00), //4:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 25, 22, 00, 00), //10:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 24, 18, 00, 00), //6:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "Joker").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 19, 22, 00, 00), //7:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Incredibles").Id,
                        Format = "2D",
                        Available = true
                    },
                     new Showtime
                     {
                         StartTime = new DateTime(2025, 4, 19, 10, 00, 00), //10:00 am
                         TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                         MovieId = context.Movies.First(x => x.Title == "The Incredibles").Id,
                         Format = "2D",
                         Available = true
                     },
                      new Showtime
                      {
                          StartTime = new DateTime(2025, 4, 17, 20, 00, 00), //8:00 pm
                          TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                          MovieId = context.Movies.First(x => x.Title == "The Incredibles").Id,
                          Format = "2D",
                          Available = true
                      },
                       new Showtime
                       {
                           StartTime = new DateTime(2025, 4, 23, 13, 30, 00), //1:30 pm
                           TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                           MovieId = context.Movies.First(x => x.Title == "The Incredibles").Id,
                           Format = "2D",
                           Available = true
                       },
                        new Showtime
                        {
                            StartTime = new DateTime(2025, 4, 23, 16, 30, 00), //4:30 pm
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                            MovieId = context.Movies.First(x => x.Title == "The Incredibles").Id,
                            Format = "2D",
                            Available = true
                        },
                         new Showtime
                         {
                             StartTime = new DateTime(2025, 4, 23, 11, 00, 00), //11:00 am
                             TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                             MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                             Format = "3D",
                             Available = true
                         },
                         new Showtime
                         {
                             StartTime = new DateTime(2025, 4, 23, 20, 00, 00), //8:00 p,
                             TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                             MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                             Format = "3D",
                             Available = true
                         },
                         new Showtime
                         {
                             StartTime = new DateTime(2025, 4, 21, 15, 00, 00), //3:00 pm
                             TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                             MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                             Format = "3D",
                             Available = true
                         },
                         new Showtime
                         {
                             StartTime = new DateTime(2025, 4, 21, 21, 00, 00), //9:00 pm
                             TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                             MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                             Format = "3D",
                             Available = true
                         },
                         new Showtime
                         {
                             StartTime = new DateTime(2025, 4, 22, 11, 00, 00), //11:00 am
                             TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                             MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                             Format = "3D",
                             Available = true
                         },
                         new Showtime
                         {
                             StartTime = new DateTime(2025, 4, 18, 17, 00, 00), //5:00 pm
                             TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                             MovieId = context.Movies.First(x => x.Title == "Spider-Man: No Way Home").Id,
                             Format = "2D",
                             Available = true
                         },
                          new Showtime
                          {
                              StartTime = new DateTime(2025, 4, 20, 19, 00, 00), //7:00 am
                              TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                              MovieId = context.Movies.First(x => x.Title == "Spider-Man: No Way Home").Id,
                              Format = "2D",
                              Available = true
                          },
                           new Showtime
                           {
                               StartTime = new DateTime(2025, 4, 23, 21, 00, 00), //9:00 pm
                               TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                               MovieId = context.Movies.First(x => x.Title == "Spider-Man: No Way Home").Id,
                               Format = "2D",
                               Available = true
                           },
                            new Showtime
                            {
                                StartTime = new DateTime(2025, 4, 26, 11, 00, 00), //11:00 am
                                TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                                MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                                Format = "2D",
                                Available = true
                            },
                             new Showtime
                             {
                                 StartTime = new DateTime(2025, 4, 26, 20, 00, 00), //8:00 pm
                                 TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                                 MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                                 Format = "2D",
                                 Available = true
                             },
                              new Showtime
                              {
                                  StartTime = new DateTime(2025, 4, 25, 18, 00, 00), //6:00 pm
                                  TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                                  MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                                  Format = "2D",
                                  Available = false
                              },
                              new Showtime
                              {
                                  StartTime = new DateTime(2025, 4, 24, 18, 00, 00), //6:00 pm
                                  TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                                  MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                                  Format = "2D",
                                  Available = true
                              },
                              new Showtime
                              {
                                  StartTime = new DateTime(2025, 4, 25, 18, 00, 00), //6:00 pm
                                  TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                                  MovieId = context.Movies.First(x => x.Title == "Fight Club").Id,
                                  Format = "2D",
                                  Available = true
                              },
                              new Showtime
                              {
                                  StartTime = new DateTime(2025, 4, 20, 20, 00, 00), //8:00 pm
                                  TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                                  MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                                  Format = "2D",
                                  Available = true
                              },
                              new Showtime
                              {
                                  StartTime = new DateTime(2025, 4, 25, 18, 00, 00), //6:00 pm
                                  TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                                  MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                                  Format = "2D",
                                  Available = true
                              },
                              new Showtime
                              {
                                  StartTime = new DateTime(2025, 4, 23, 15, 00, 00), //3:00 pm
                                  TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                                  MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                                  Format = "2D",
                                  Available = true
                              },
                              new Showtime
                              {
                                  StartTime = new DateTime(2025, 4, 23, 20, 00, 00), //8:00 pm
                                  TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                                  MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                                  Format = "2D",
                                  Available = true
                              },


                    //Los Angeles Showtimes
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,01,13,30,00), //1:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                        Format = "3D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 01, 17, 30, 00), //5:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 07, 10, 30, 00), //10:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 09, 19, 00, 00), //1:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Shrek").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,1,20,30,00), //8:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 2, 20, 30, 00), //8:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 2, 16, 00, 00), //4:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 6, 12, 00, 00), //12:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 6, 18, 30, 00), //8:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Shawshank Redemption").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,2,9,30,00), //9:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avengers: Endgame").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 2, 18, 30, 00), //6:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avengers: Endgame").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 2, 22, 30, 00), //9:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avengers: Endgame").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Avengers: Endgame").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025,4,3,12,30,00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Interstellar").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 15, 30, 00), //3:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Interstellar").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 21, 30, 00), //9:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Interstellar").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 6, 21, 30, 00), //9:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Interstellar").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 6, 13, 30, 00), //1:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Interstellar").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 18, 30, 00), //6:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 4, 17, 00, 00), //5:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 4, 21, 00, 00), //9:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Inception").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 8, 20, 30, 00), //8:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Dark Knight").Id,
                        Format = "2D",
                        Available = false
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 10, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Dark Knight").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 9, 17, 00, 00), //5:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Dark Knight").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 9, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Dark Knight").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 10, 09, 30, 00), //9:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Dark Knight").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 12, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 12, 21, 00, 00), //09:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 11, 15, 00, 00), //3:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 12, 18, 30, 00), //06:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Godfather").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 3, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 4, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 4, 19, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 5, 16, 00, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 5, 22, 00, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lord of the Rings: The Fellowship of the Ring").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 10, 09, 30, 00), //09:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lion King").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 12, 17, 00, 00), //5:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lion King").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 13, 11, 30, 00), //11:30 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lion King").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 13, 12, 30, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "The Lion King").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 5, 1, 12, 00, 00), //12:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Up").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 29, 16, 00, 00), //4:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Up").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 29, 11, 00, 00), //12:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Up").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 30, 21, 30, 00), //9:30 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Up").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 25, 11, 00, 00), //11:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "WALL-E").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 26, 16, 00, 00), //4:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "WALL-E").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 26, 10, 00, 00), //10:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "WALL-E").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 27, 11, 00, 00), //11:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "WALL-E").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 27, 18, 00, 00), //6:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "WALL-E").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 25, 15, 00, 00), //3:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 26, 18, 00, 00), //6:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 27, 11, 00, 00), //11:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 28, 17, 00, 00), //5:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Titanic").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 5, 03, 17, 00, 00), //5:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Gladiator").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 5, 02, 16, 00, 00), //4:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Gladiator").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 5, 02, 09, 00, 00), //9:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Gladiator").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 5, 01, 17, 00, 00), //5:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Gladiator").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 28, 17, 00, 00), //5:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 29, 11, 00, 00), //11:00 am
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                        Format = "3D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 30, 13, 00, 00), //1:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                        Format = "2D",
                        Available = true
                    },
                    new Showtime
                    {
                        StartTime = new DateTime(2025, 4, 30, 22, 00, 00), //10:00 pm
                        TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                        MovieId = context.Movies.First(x => x.Title == "Finding Nemo").Id,
                        Format = "2D",
                        Available = true
                    },
                     new Showtime
                     {
                         StartTime = new DateTime(2025, 5, 3, 22, 00, 00), //10:00 pm
                         TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                         MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                         Format = "2D",
                         Available = true
                     },
                     new Showtime
                     {
                         StartTime = new DateTime(2025, 5, 3, 12, 00, 00), //12:00 pm
                         TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                         MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                         Format = "2D",
                         Available = true
                     },
                     new Showtime
                     {
                         StartTime = new DateTime(2025, 5, 2, 18, 00, 00), //6:00 pm
                         TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                         MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                         Format = "2D",
                         Available = true
                     },
                     new Showtime
                     {
                         StartTime = new DateTime(2025, 5, 2, 11, 00, 00), //11:00 am
                         TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                         MovieId = context.Movies.First(x => x.Title == "Pulp Fiction").Id,
                         Format = "2D",
                         Available = true
                     }
                    );
                context.SaveChanges();
            }
        }
    }
}
