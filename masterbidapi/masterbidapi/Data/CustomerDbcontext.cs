using masterbidapi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace masterbidapi.Data
{
    public class CustomerDbcontext : DbContext
    {
        public CustomerDbcontext(DbContextOptions<CustomerDbcontext> options) : base(options)
        {
        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
