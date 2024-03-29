﻿using Domain.Entities;
using Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
namespace Infrastructure.DatabaseContext
{
    public class ShophubContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ShophubContext(DbContextOptions options) : base(options)
        {
        }
      //  public DbSet<User> Users { get; set; }
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
        public DbSet<Location> Locations { get; set; }
        public DbSet<FeatureRoleMap> FeatureRoleMaps { get; set; }
        public DbSet<FeatureEndpointMap> FeatureEndpointMaps { get; set; }
        //public DbSet<Role> Roles { get; set; }


        T GetSeedDataFromJson<T>(string filePath)
        {
            var productJson = File.ReadAllText(filePath);
            var productData = JsonConvert.DeserializeObject<T>(productJson);

            return productData;
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        //    builder.Entity<User>(ConfigureUser);

            #region Product Table Relations

            builder.Entity<Product>().HasMany(e => e.Categories).WithMany(e => e.Products);

            #endregion

            #region Brand Table Relations

            builder.Entity<Brand>()
                .HasMany(e => e.Products)
                .WithOne(e => e.Brand)
                .HasForeignKey(fk => fk.BrandItemId)
                .IsRequired(false);

            #endregion

            #region User Table Relations

            builder.Entity<ApplicationUser>().HasOne(e => e.Customer).WithOne(e => e.ApplicationUser).HasForeignKey<Customer>(fk => fk.ApplicationUserId);
            

            #endregion

            #region Customer Table relations
            builder.Entity<Customer>()
                .HasOne(e => e.BillingLocation)
                .WithMany(e => e.BillingCustomers)
                .HasForeignKey(e => e.BillingLocationItemId);

            #endregion

            #region Order table relations

            builder.Entity<Order>().HasOne(e => e.Coupon).WithMany(e => e.Orders).HasForeignKey(e => e.CouponItemId).IsRequired(false);
            builder.Entity<Order>().HasOne(e => e.Customer).WithMany(e => e.Orders).HasForeignKey(e => e.CustomerItemId);
            builder.Entity<Order>().HasMany(e => e.Product).WithMany(e => e.CustomerOrders);
            builder.Entity<Invoice>().HasOne(e => e.Order).WithOne(e => e.Invoice).HasForeignKey<Invoice>(fk => fk.OrderItemId);

            #endregion

            #region Shopping Cart Relations

            builder.Entity<ShoppingCart>().HasMany(e => e.Products).WithMany(e => e.ShoppingCarts);
            builder.Entity<ShoppingCart>().HasOne(e => e.Customer).WithOne(e => e.ShoppingCart).HasForeignKey<ShoppingCart>(fk => fk.CustomerItemId);

            #endregion

            #region Shipping Info Relations

            builder.Entity<ShippingInfo>().HasMany(e => e.CustomerOrders).WithOne(e => e.ShippingInfo).HasForeignKey(e => e.ShippingInfoId);
            builder.Entity<ShippingInfo>().HasOne(e => e.BillingLocation).WithOne(e => e.ShippingInfo).HasForeignKey<ShippingInfo>(e => e.BillingLocationItemId);


            #endregion

            #region Payment Info Relations

            builder.Entity<PaymentInfo>().HasOne(e => e.Order).WithOne(e => e.PaymentInfo).HasForeignKey<PaymentInfo>(e => e.OrderItemId);

            #endregion


            #region Feature Role/endpoint map
            builder.Entity<FeatureRoleMap>().HasMany(e => e.FeatureEndpointMaps).WithMany(e => e.FeatureRoleMaps);
            #endregion

            /// add seed data on initial creation (it won't have any effect after first migraiton

            //var products = GetSeedDataFromJson<List<Product>>("seeds/Product.json");
            //var productCategories = GetSeedDataFromJson<List<ProductCategory>>("seeds/ProductCategory.json");
            //var customers = GetSeedDataFromJson<List<Customer>>("seeds/Customer.json");
            //var brands = GetSeedDataFromJson<List<Brand>>("seeds/Brand.json");
            //var users= GetSeedDataFromJson<List<User>>("seeds/User.json");

            //foreach(var product in products)
            //{
            //    builder.Entity<Product>().HasData(product);
            //}
            //foreach (var category in productCategories)
            //{
            //    builder.Entity<ProductCategory>().HasData(category);
            //}
            //foreach (var customer in customers)
            //{
            //    builder.Entity<Customer>().HasData(customer);
            //}
            //foreach (var brand in brands)
            //{
            //    builder.Entity<Brand>().HasData(brand);
            //}
            //foreach (var user in users)
            //{
            //    builder.Entity<User>().HasData(user);
            //}

        }

        //private static void ConfigureUser(EntityTypeBuilder<User> entity)
        //{

        //    entity.HasIndex(u => new { u.FirstName, u.LastName, u.Email }).IsUnique(false);

        //    entity.HasIndex(u => u.CreatedOn);

        //    entity.HasIndex(u => u.Email).IsUnique();
        //     }

    }
}
