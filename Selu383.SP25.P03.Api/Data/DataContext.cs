using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Features.Users;
using Selu383.SP25.P03.Api.Features.Theaters;
using Selu383.SP25.P03.Api.Features.Seats;
using Selu383.SP25.P03.Api.Features.Tickets;
using Selu383.SP25.P03.Api.Features.Showtimes;
using Selu383.SP25.P03.Api.Features.Food;
using Selu383.SP25.P03.Api.Features.ComingSoonMovies;

using Selu383.SP25.P03.Api.Features.Movies;

namespace Selu383.SP25.P03.Api.Data
{
    public class DataContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Seat> Seats { get; set; }           
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<Food> Foods { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<ComingSoonMovie> ComingSoonMovies { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var allSeats = new List<Seats>();
            allSeats.AddRange(CreateSeatsForTheater(5, 150)); 
            allSeats.AddRange(CreateSeatsForTheater(6, 200)); 
            allSeats.AddRange(CreateSeatsForTheater(7, 300)); 

            builder.Entity<Seats>().HasData(allSeats);


            builder.Entity<UserRole>().HasKey(x => new { x.UserId, x.RoleId });

            builder.Entity<User>()
                .HasMany(e => e.UserRoles)
                .WithOne(x => x.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Role>()
                .HasMany(e => e.UserRoles)
                .WithOne(x => x.Role)
                .HasForeignKey(e => e.RoleId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

           
            builder.Entity<Seat>()
                .Property(s => s.Row)
                .IsRequired();


            builder.Entity<Food>()
                .Property(f => f.Price)
                .HasColumnType("decimal(10,2)");
        }

        
        private static List<Seats> CreateSeatsForTheater(int theaterId, int totalSeats)
        {
            var seats = new List<Seats>();
            int numRows = 10;
            int seatsPerRow = totalSeats / numRows;
            int aisleCol = seatsPerRow / 2;

            int seatId = theaterId * 1000;

            for (int row = 0; row < numRows; row++)
            {
                char rowChar = (char)('A' + row);
                int colNumber = 1;

                for (int col = 0; col < seatsPerRow; col++)
                {
                    if (col == aisleCol)
                        continue; 

                    seats.Add(new Seats
                    {
                        Id = seatId++,
                        TheaterId = theaterId,
                        Row = rowChar.ToString(),
                        Col = col,
                        Number = colNumber++,
                        IsTaken = false
                    });
                }
            }

            return seats;
        }
    }
}
