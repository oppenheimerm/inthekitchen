using ITK.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ITK.DataStore.EFCore
{
    public class ITKDbContext : IdentityDbContext
    {
        public ITKDbContext(DbContextOptions<ITKDbContext> options)
            : base(options)
        { }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderEntry> OrderEntries { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  Error Fix: The entity type ‘IdentityUserLogin‘ requires a primary
            //  key to be defined. If you intended to use a keyless entity
            //  type call ‘HasNoKey()’.
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .Property(p => p.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderEntry>().ToTable("OrderEntry");
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
