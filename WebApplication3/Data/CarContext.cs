using Car.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Principal;

namespace CarApi.Models
{
        public class CarContext : DbContext
        {
            public DbSet<CarItem> CarItems { get; set; }
            public DbSet<CarInfo> CarInfos { get; set; }
            public DbSet<Bill> Bills { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Employee> Employees { get; set; }

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
