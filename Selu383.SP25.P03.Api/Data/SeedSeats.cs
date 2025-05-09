﻿using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Features.Seats;

namespace Selu383.SP25.P03.Api.Data
{
    public class SeedSeats
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {

                if (context.Seats.Any())
                {
                    return; 
                }

                context.Seats.AddRange(
                    Enumerable.Range(0, 10).SelectMany(row =>
                        Enumerable.Range(1, 15).Select(col => new Seat
                        {
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New York").Id,
                            Row = ((char)('A' + row)).ToString(),
                            Col = col,
                            IsTaken = false
                        })
                    )
                );

                context.Seats.AddRange(
                    Enumerable.Range(0, 10).SelectMany(row =>
                        Enumerable.Range(1, 20).Select(col => new Seat
                        {
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - New Orleans").Id,
                            Row = ((char)('A' + row)).ToString(),
                            Col = col,
                            IsTaken = false
                        })
                    )
                );

                context.Seats.AddRange(
                    Enumerable.Range(0, 12).SelectMany(row =>
                        Enumerable.Range(1, 25).Select(col => new Seat
                        {
                            TheaterId = context.Theaters.First(x => x.Name == "Lion's Den Cinemas - Los Angeles").Id,
                            Row = ((char)('A' + row)).ToString(),
                            Col = col,
                            IsTaken = false
                        })
                    )
                );

                context.SaveChanges();
            }
        }
    }
}
