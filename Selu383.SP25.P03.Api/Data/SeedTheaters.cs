using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Features.Theaters;

namespace Selu383.SP25.P03.Api.Data
{
    public static class SeedTheaters
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                // Look for any theaters.
                if (context.Theaters.Any())
                {
                    return;   // DB has been seeded
                }
                context.Theaters.AddRange(
                    new Theater
                    {
                        Id = 1,
                        Name = "AMC Palace 10",
                        Address = "123 Main St, Springfield",
                        City = "Springfield",
                        State = "IL",
                        SeatCount = 150,
                        HasIMAX = true,
                        Has3D = false,
                        HasReclinerSeats = true
                    },
                    new Theater
                    {
                        Id = 2,
                        Name = "Regal Cinema",
                        Address = "456 Elm St, Shelbyville",
                        City = "Shelbyville",
                        State = "TX",
                        SeatCount = 200,
                        HasIMAX = false,
                        Has3D = true,
                        HasReclinerSeats = false
                    },
                    new Theater
                    {
                        Id = 3,
                        Name = "Grand Theater",
                        Address = "789 Broadway Ave, Metropolis",
                        City = "Metropolis",
                        State = "NY",
                        SeatCount = 300,
                        HasIMAX = true,
                        Has3D = true,
                        HasReclinerSeats = true
                    },
                    new Theater
                    {
                        Id = 4,
                        Name = "Vintage Drive-In",
                        Address = "101 Retro Rd, Smallville",
                        City = "Smallville",
                        State = "KS",
                        SeatCount = 75,
                        HasIMAX = false,
                        Has3D = false,
                        HasReclinerSeats = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
