﻿//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignFactory.Entities.Entity_Models;


namespace SignFactory.Data
{
    public class SignFactoryDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<SignProject> Projects { get; set; }

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

            modelBuilder.Entity<Order>()
                .HasMany(p => p.Project)
                .WithOne(o => o.Order)
                .HasForeignKey(o => o.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .Property(o => o.Deadline)
                .HasColumnType("DATE");

            modelBuilder.Entity<Order>()
                .Property(o => o.StartDate)
                .HasColumnType("DATE");


            base.OnModelCreating(modelBuilder);
        }
    }
    
}
