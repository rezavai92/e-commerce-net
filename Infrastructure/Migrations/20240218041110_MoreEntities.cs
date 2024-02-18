using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MoreEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByUserId",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryAddressItemId",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_Brands", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_Coupons", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    OrderId = table.Column<string>(type: "text", nullable: false),
                    PaymentId = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_Invoices", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    StreetName = table.Column<string>(type: "text", nullable: true),
                    StreetNumber = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    Lat = table.Column<double>(type: "double precision", nullable: true),
                    Long = table.Column<double>(type: "double precision", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_Location", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    PrductId = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<string>(type: "text", nullable: false),
                    OrderedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeliveredOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ApprovedByUserId = table.Column<string>(type: "text", nullable: false),
                    PaymentType = table.Column<string>(type: "text", nullable: false),
                    PaymentId = table.Column<string>(type: "text", nullable: false),
                    InvoiceId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Discount = table.Column<double>(type: "double precision", nullable: false),
                    CouponId = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_Orders", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentInfos",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    OrderId = table.Column<string>(type: "text", nullable: false),
                    PaidOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InvoiceId = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_PaymentInfos", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategorys",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_ProductCategorys", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ProductCode = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    PrimaryImageUrl = table.Column<string>(type: "text", nullable: false),
                    SecondaryImageUrls = table.Column<string[]>(type: "text[]", nullable: false),
                    RemainingQuantity = table.Column<long>(type: "bigint", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_Products", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "ShippingInfos",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    OrderId = table.Column<string>(type: "text", nullable: false),
                    BillingLocationId = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    TrackingNumber = table.Column<long>(type: "bigint", nullable: false),
                    Method = table.Column<long>(type: "bigint", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_ShippingInfos", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<string>(type: "text", nullable: false),
                    ProductIds = table.Column<string[]>(type: "text[]", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    BillingAddressItemId = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_Customers", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Customers_Location_BillingAddressItemId",
                        column: x => x.BillingAddressItemId,
                        principalTable: "Location",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_PrimaryAddressItemId",
                table: "Users",
                column: "PrimaryAddressItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BillingAddressItemId",
                table: "Customers",
                column: "BillingAddressItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Location_PrimaryAddressItemId",
                table: "Users",
                column: "PrimaryAddressItemId",
                principalTable: "Location",
                principalColumn: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Location_PrimaryAddressItemId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentInfos");

            migrationBuilder.DropTable(
                name: "ProductCategorys");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShippingInfos");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Users_PrimaryAddressItemId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PrimaryAddressItemId",
                table: "Users");
        }
    }
}
