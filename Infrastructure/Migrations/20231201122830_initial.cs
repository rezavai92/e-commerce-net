using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Roles = table.Column<List<string>>(type: "text[]", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsMarkedToDelete = table.Column<bool>(type: "boolean", nullable: false),
                    RolesAllowedToRead = table.Column<string[]>(type: "text[]", nullable: false),
                    IdsAllowedToRead = table.Column<string[]>(type: "text[]", nullable: false),
                    RolesAllowedToWrite = table.Column<string[]>(type: "text[]", nullable: false),
                    IdsAllowedToWrite = table.Column<string[]>(type: "text[]", nullable: false),
                    RolesAllowedToUpdate = table.Column<string[]>(type: "text[]", nullable: false),
                    IdsAllowedToUpdate = table.Column<string[]>(type: "text[]", nullable: false),
                    RolesAllowedToDelete = table.Column<string[]>(type: "text[]", nullable: false),
                    IdsAllowedToDelete = table.Column<string[]>(type: "text[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ItemId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
