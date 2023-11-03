using Microsoft.EntityFrameworkCore;
using TpiProg3.Data.Entities;

namespace TpiProg3.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Order> Orders {  get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>()
            .HasMany(o => o.Products)
            .WithMany(p => p.Orders)
            .UsingEntity(j => j.ToTable("OrderProduct"));

        }
    }
}
