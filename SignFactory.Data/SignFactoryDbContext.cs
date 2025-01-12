using Microsoft.EntityFrameworkCore;
using SignFactory.Entities.Entity_Models;
using System.Diagnostics;
using System.Linq;

namespace SignFactory.Data
{
    public class SignFactoryDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<SignType> Types { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public SignFactoryDbContext(DbContextOptions<SignFactoryDbContext> cxt) : base(cxt)
        {

        }
        public SignFactoryDbContext()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
