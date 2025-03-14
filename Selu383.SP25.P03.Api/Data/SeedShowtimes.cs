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
                context.Showtimes.AddRange(
                    new Showtime
                    {
                        Time = new TimeOnly(14, 30),
                        ShowDate = new DateOnly(2025, 3, 12),
                        TheaterId = 1,
                        Format = "2D",
                        Available = true,


                    },
                    new Showtime
                    {
                        Time = new TimeOnly(20, 00),
                        ShowDate = new DateOnly(2025, 3, 13),
                        TheaterId = 2,
                        Format = "IMAX",
                        Available = true
                    },
                    new Showtime
                    {
                        Time = new TimeOnly(13, 30),
                        ShowDate = new DateOnly(2025, 3, 12),
                        TheaterId = 3,
                        Format = "3D",
                        Available = false
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
