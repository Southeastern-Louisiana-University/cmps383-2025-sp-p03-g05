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
                        Time = new TimeOnly(14, 30),
                        ShowDate = new DateOnly(2025, 3, 12),
                        TheaterId = context.Theaters.First(x => x.Name == "Grand Theater").Id,
                        Format = "2D",
                        Available = true,



                    },
                    new Showtime
                    {
                        Time = new TimeOnly(09, 30),
                        ShowDate = new DateOnly(2025, 3, 27),
                        TheaterId = context.Theaters.First(x => x.Name == "Grand Theater").Id,
                        Format = "",
                        Available = true,

                    },
                    new Showtime
                    {
                        Time = new TimeOnly(20, 00),
                        ShowDate = new DateOnly(2025, 3, 13),
                        TheaterId = context.Theaters.First(x => x.Name == "Regal Cinema").Id,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        Time = new TimeOnly(13, 30),
                        ShowDate = new DateOnly(2025, 3, 12),
                        TheaterId = context.Theaters.First(x => x.Name == "Vintage Drive-In").Id,
                        Format = "3D",
                        Available = false
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
