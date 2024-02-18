﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ShophubContext))]
    partial class ShophubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Brand", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Domain.Entities.Coupon", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("BillingAddressItemId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ItemId");

                    b.HasIndex("BillingAddressItemId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Domain.Entities.Invoice", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Domain.Entities.Location", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("Lat")
                        .HasColumnType("double precision");

                    b.Property<double?>("Long")
                        .HasColumnType("double precision");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("StreetName")
                        .HasColumnType("text");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<string>("ApprovedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CouponId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DeliveredOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Discount")
                        .HasColumnType("double precision");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PrductId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.Entities.PaymentInfo", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("PaidOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("PaymentInfos");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("PrimaryImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("RemainingQuantity")
                        .HasColumnType("bigint");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("SecondaryImageUrls")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Entities.ProductCategory", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("ProductCategorys");
                });

            modelBuilder.Entity("Domain.Entities.ShippingInfo", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("BillingLocationId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Method")
                        .HasColumnType("bigint");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("TrackingNumber")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("ShippingInfos");
                });

            modelBuilder.Entity("Domain.Entities.ShoppingCart", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("ProductIds")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string[]>("IdsAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("IdsAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<bool>("IsMarkedToDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("LastUpdatedByUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("PrimaryAddressItemId")
                        .HasColumnType("text");

                    b.Property<List<string>>("Roles")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToDelete")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToRead")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToUpdate")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string[]>("RolesAllowedToWrite")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ItemId");

                    b.HasIndex("CreatedOn");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PrimaryAddressItemId");

                    b.HasIndex("FirstName", "LastName", "Email");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.HasOne("Domain.Entities.Location", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillingAddress");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.Location", "PrimaryAddress")
                        .WithMany()
                        .HasForeignKey("PrimaryAddressItemId");

                    b.Navigation("PrimaryAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
