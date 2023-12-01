﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ShophubContext))]
    [Migration("20231201130908_make indexes and email unique 1")]
    partial class makeindexesandemailunique1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
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

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
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

                    b.HasIndex("FirstName", "LastName", "Email");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
