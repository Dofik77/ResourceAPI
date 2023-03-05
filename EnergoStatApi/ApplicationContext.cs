using EnergoStatApi.Models.ApiModels;
using Microsoft.EntityFrameworkCore;

namespace EnergoStatApi.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ElectricConsumption> ElectroConsume => Set<ElectricConsumption>();
        public DbSet<WhaterConsumption> WhaterConsume => Set<WhaterConsumption>();

        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql
                ("Host=localhost;Port=5432;Database=ConsumeTest;Username=admin;Password=admin");
        }
    }
}
