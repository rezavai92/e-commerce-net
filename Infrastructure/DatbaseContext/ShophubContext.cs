using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.DatabaseContext
{
    public class ShophubContext : DbContext
    {
        public ShophubContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ShippingInfo> ShippingInfos { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
      

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(ConfigureUser);
        }

        private static void ConfigureUser(EntityTypeBuilder<User> entity)
        {
          
            entity.HasIndex(u => new { u.FirstName, u.LastName, u.Email }).IsUnique(false);
          
            entity.HasIndex(u => u.CreatedOn);

            entity.HasIndex(u => u.Email).IsUnique();
        }

    }
}
