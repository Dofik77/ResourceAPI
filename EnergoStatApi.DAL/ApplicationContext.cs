using EnergoStatApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace EnergoStatApi.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }


        public DbSet<ElectricConsumptionModel> ElectroConsume { get; set; }
        public DbSet<WhaterConsumptionModel> WhaterConsume { get; set; }
    }
}