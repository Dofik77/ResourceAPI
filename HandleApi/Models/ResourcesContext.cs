using Microsoft.EntityFrameworkCore;

namespace HandleApi.Models
{
    public class ResourcesContext : DbContext
    {
        public DbSet<ResourcesConsumersContext> ResourcesConsumers { get; set; }

        public ResourcesContext(DbContextOptions<ResourcesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
