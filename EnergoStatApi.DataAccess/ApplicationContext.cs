using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EnergoStatApi.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ElectricRate> ElectroRate { get; set; }
        public DbSet<WarmWhaterRate> WarmWhaterRate { get; set; }
        public DbSet<ColdWhaterRate> ColdWhaterRate { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AuthenticationUser> AuthUsers { get; set; }
        public DbSet<PaymentResource> PaymentData { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
    }
}