using Microsoft.EntityFrameworkCore;

namespace EnergoStatApi.Models
{
    public class ResourcesContext : DbContext
    { 
        public DbSet<ElectroConsume> ElectroConsume { get; set; }
        public DbSet<WhaterConsume> WhaterConsume { get; set; }

        public ResourcesContext(DbContextOptions<ResourcesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


    }
}
