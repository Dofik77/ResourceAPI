using EnergoStatApi.Models.ApiModels;
using Microsoft.EntityFrameworkCore;

namespace EnergoStatApi.Models
{
    public class ApplicationContext : DbContext
    { 
        public DbSet<ElectricConsumption> ElectroConsume { get; set; }
        public DbSet<WhaterConsumption> WhaterConsume { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


    }
}
