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
                name: "Brands",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                name: "Locations",
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
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_Locations", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategorys",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Alias = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                name: "Users",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Roles = table.Column<List<string>>(type: "text[]", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ProductCode = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    PrimaryImageUrl = table.Column<string>(type: "text", nullable: false),
                    SecondaryImageUrls = table.Column<string[]>(type: "text[]", nullable: false),
                    RemainingQuantity = table.Column<long>(type: "bigint", nullable: false),
                    BrandItemId = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandItemId",
                        column: x => x.BrandItemId,
                        principalTable: "Brands",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingInfo",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    BillingLocationItemId = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    TrackingNumber = table.Column<string>(type: "text", nullable: false),
                    ShippingMethod = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_ShippingInfo", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_ShippingInfo_Locations_BillingLocationItemId",
                        column: x => x.BillingLocationItemId,
                        principalTable: "Locations",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    UserItemId = table.Column<string>(type: "text", nullable: false),
                    BillingLocationItemId = table.Column<string>(type: "text", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                        name: "FK_Customers_Locations_BillingLocationItemId",
                        column: x => x.BillingLocationItemId,
                        principalTable: "Locations",
                        principalColumn: "ItemId");
                    table.ForeignKey(
                        name: "FK_Customers_Users_UserItemId",
                        column: x => x.UserItemId,
                        principalTable: "Users",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProductCategory",
                columns: table => new
                {
                    CategoriesItemId = table.Column<string>(type: "text", nullable: false),
                    ProductsItemId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductCategory", x => new { x.CategoriesItemId, x.ProductsItemId });
                    table.ForeignKey(
                        name: "FK_ProductProductCategory_ProductCategorys_CategoriesItemId",
                        column: x => x.CategoriesItemId,
                        principalTable: "ProductCategorys",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductCategory_Products_ProductsItemId",
                        column: x => x.ProductsItemId,
                        principalTable: "Products",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    OrderedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DeliveredOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Discount = table.Column<double>(type: "double precision", nullable: false),
                    CouponItemId = table.Column<string>(type: "text", nullable: false),
                    CustomerItemId = table.Column<string>(type: "text", nullable: false),
                    ShippingInfoId = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Orders_Coupons_CouponItemId",
                        column: x => x.CouponItemId,
                        principalTable: "Coupons",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerItemId",
                        column: x => x.CustomerItemId,
                        principalTable: "Customers",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_ShippingInfo_ShippingInfoId",
                        column: x => x.ShippingInfoId,
                        principalTable: "ShippingInfo",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    CustomerItemId = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_ShoppingCart", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCart_Customers_CustomerItemId",
                        column: x => x.CustomerItemId,
                        principalTable: "Customers",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    CustomerOrdersItemId = table.Column<string>(type: "text", nullable: false),
                    ProductItemId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.CustomerOrdersItemId, x.ProductItemId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_CustomerOrdersItemId",
                        column: x => x.CustomerOrdersItemId,
                        principalTable: "Orders",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "Products",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentInfo",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    OrderItemId = table.Column<string>(type: "text", nullable: false),
                    PaidOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PaymentType = table.Column<string>(type: "text", nullable: false),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: true),
                    LastUpdatedByUserId = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_PaymentInfo", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_PaymentInfo_Orders_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "Orders",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductShoppingCart",
                columns: table => new
                {
                    ProductsItemId = table.Column<string>(type: "text", nullable: false),
                    ShoppingCartsItemId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShoppingCart", x => new { x.ProductsItemId, x.ShoppingCartsItemId });
                    table.ForeignKey(
                        name: "FK_ProductShoppingCart_Products_ProductsItemId",
                        column: x => x.ProductsItemId,
                        principalTable: "Products",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductShoppingCart_ShoppingCart_ShoppingCartsItemId",
                        column: x => x.ShoppingCartsItemId,
                        principalTable: "ShoppingCart",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BillingLocationItemId",
                table: "Customers",
                column: "BillingLocationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserItemId",
                table: "Customers",
                column: "UserItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductItemId",
                table: "OrderProduct",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CouponItemId",
                table: "Orders",
                column: "CouponItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerItemId",
                table: "Orders",
                column: "CustomerItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingInfoId",
                table: "Orders",
                column: "ShippingInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfo_OrderItemId",
                table: "PaymentInfo",
                column: "OrderItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductCategory_ProductsItemId",
                table: "ProductProductCategory",
                column: "ProductsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShoppingCart_ShoppingCartsItemId",
                table: "ProductShoppingCart",
                column: "ShoppingCartsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandItemId",
                table: "Products",
                column: "BrandItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShippingInfo_BillingLocationItemId",
                table: "ShippingInfo",
                column: "BillingLocationItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_CustomerItemId",
                table: "ShoppingCart",
                column: "CustomerItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedOn",
                table: "Users",
                column: "CreatedOn");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_FirstName_LastName_Email",
                table: "Users",
                columns: new[] { "FirstName", "LastName", "Email" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "PaymentInfo");

            migrationBuilder.DropTable(
                name: "ProductProductCategory");

            migrationBuilder.DropTable(
                name: "ProductShoppingCart");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductCategorys");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "ShippingInfo");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
