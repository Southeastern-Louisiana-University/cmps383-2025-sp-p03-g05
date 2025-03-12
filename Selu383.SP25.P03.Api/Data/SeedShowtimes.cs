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
                        Time = new TimeOnly(14,30),
                        ShowDate = new DateOnly(2025, 3, 12),
                        TheaterId = 1,
                        Format = "2D",
                        Available = true,


                    }
                    );
            }
        }
    }
}
