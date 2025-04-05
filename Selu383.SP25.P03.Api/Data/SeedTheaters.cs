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
               
                if (context.Theaters.Any())
                {
                    return; 
                }

                context.Theaters.AddRange(
                    new Theater
                    {
                        Name = "AMC Palace 10",
                        Address = "123 Main St, Springfield",
                        SeatCount = 150
                    },
                    new Theater
                    {
                        Name = "Regal Cinema",
                        Address = "456 Elm St, Shelbyville",
                        SeatCount = 200
                    },
                    new Theater
                    {
                        Name = "Grand Theater",
                        Address = "789 Broadway Ave, Metropolis",
                        SeatCount = 300
                    },
                    new Theater
                    {
                        Name = "Vintage Drive-In",
                        Address = "101 Retro Rd, Smallville",
                        SeatCount = 75
                    },
                    new Theater
                    {
                        Name = "Baton Rouge Grand",
                        Address = "123 Main St, Baton Rouge, LA",
                        SeatCount = 250
                    },
                    new Theater
                    {
                        Name = "New Orleans Cineplex",
                        Address = "456 Canal St, New Orleans, LA",
                        SeatCount = 300
                    },
                    new Theater
                    {
                        Name = "Lafayette Movie House",
                        Address = "789 University Ave, Lafayette, LA",
                        SeatCount = 200
                    },
                    new Theater
                    {
                        Name = "Shreveport Cinemas",
                        Address = "101 Red River Rd, Shreveport, LA",
                        SeatCount = 275
                    },
                    new Theater
                    {
                        Name = "Lake Charles Theater",
                        Address = "222 Bayou Rd, Lake Charles, LA",
                        SeatCount = 180
                    },
                    new Theater
                    {
                        Name = "Monroe Film Center",
                        Address = "333 Cypress St, Monroe, LA",
                        SeatCount = 220
                    },
                    new Theater
                    {
                        Name = "Alexandria Premier",
                        Address = "444 Downtown Blvd, Alexandria, LA",
                        SeatCount = 240
                    },
                    new Theater
                    {
                        Name = "Houma Screenhouse",
                        Address = "555 Bayou Dr, Houma, LA",
                        SeatCount = 190
                    },
                    new Theater
                    {
                        Name = "Slidell Cineworld",
                        Address = "666 Lakeshore Dr, Slidell, LA",
                        SeatCount = 210
                    },
                    new Theater
                    {
                        Name = "Bossier City Multiplex",
                        Address = "777 Riverfront St, Bossier City, LA",
                        SeatCount = 260
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
