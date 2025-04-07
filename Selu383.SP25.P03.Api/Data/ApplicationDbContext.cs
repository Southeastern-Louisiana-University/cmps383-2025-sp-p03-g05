using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Features.Food;

namespace Selu383.SP25.P03.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
    }
}
