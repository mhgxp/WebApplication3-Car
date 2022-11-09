using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CarApi.Models
{
        public class CarContext : DbContext
        {
            public DbSet<CarItem> CarItems { get; set; }

            public CarContext()
            {

            }

            public CarContext(DbContextOptions<CarContext> dbContextOptions)
                : base(dbContextOptions)
            {

            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder DataContext)
        {
            
        }
    }
}
