using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;
using Domain.Entities;
namespace Infrastructure.DatabaseContext
{
    public class ShophubContext : DbContext
    {
        public ShophubContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<ProductCategory> ProductCategorys { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        //public DbSet<PaymentInfo> PaymentInfos { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<ShippingInfo> ShippingInfos { get; set; }
        //public DbSet<Seller> Sellers { get; set; }
    }
}
