using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class invoiceadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingInfo_ShippingInfoId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInfo_Orders_OrderItemId",
                table: "PaymentInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductShoppingCart_ShoppingCart_ShoppingCartsItemId",
                table: "ProductShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingInfo_Locations_BillingLocationItemId",
                table: "ShippingInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Customers_CustomerItemId",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingInfo",
                table: "ShippingInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentInfo",
                table: "PaymentInfo");

            migrationBuilder.RenameTable(
                name: "ShoppingCart",
                newName: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ShippingInfo",
                newName: "ShippingInfos");

            migrationBuilder.RenameTable(
                name: "PaymentInfo",
                newName: "PaymentInfos");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCart_CustomerItemId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_CustomerItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingInfo_BillingLocationItemId",
                table: "ShippingInfos",
                newName: "IX_ShippingInfos_BillingLocationItemId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentInfo_OrderItemId",
                table: "PaymentInfos",
                newName: "IX_PaymentInfos_OrderItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingInfos",
                table: "ShippingInfos",
                column: "ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentInfos",
                table: "PaymentInfos",
                column: "ItemId");

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    OrderItemId = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_Invoices", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Invoices_Orders_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "Orders",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_OrderItemId",
                table: "Invoices",
                column: "OrderItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingInfos_ShippingInfoId",
                table: "Orders",
                column: "ShippingInfoId",
                principalTable: "ShippingInfos",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInfos_Orders_OrderItemId",
                table: "PaymentInfos",
                column: "OrderItemId",
                principalTable: "Orders",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductShoppingCart_ShoppingCarts_ShoppingCartsItemId",
                table: "ProductShoppingCart",
                column: "ShoppingCartsItemId",
                principalTable: "ShoppingCarts",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingInfos_Locations_BillingLocationItemId",
                table: "ShippingInfos",
                column: "BillingLocationItemId",
                principalTable: "Locations",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Customers_CustomerItemId",
                table: "ShoppingCarts",
                column: "CustomerItemId",
                principalTable: "Customers",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ShippingInfos_ShippingInfoId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentInfos_Orders_OrderItemId",
                table: "PaymentInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductShoppingCart_ShoppingCarts_ShoppingCartsItemId",
                table: "ProductShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingInfos_Locations_BillingLocationItemId",
                table: "ShippingInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Customers_CustomerItemId",
                table: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingInfos",
                table: "ShippingInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentInfos",
                table: "PaymentInfos");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "ShoppingCart");

            migrationBuilder.RenameTable(
                name: "ShippingInfos",
                newName: "ShippingInfo");

            migrationBuilder.RenameTable(
                name: "PaymentInfos",
                newName: "PaymentInfo");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_CustomerItemId",
                table: "ShoppingCart",
                newName: "IX_ShoppingCart_CustomerItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingInfos_BillingLocationItemId",
                table: "ShippingInfo",
                newName: "IX_ShippingInfo_BillingLocationItemId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentInfos_OrderItemId",
                table: "PaymentInfo",
                newName: "IX_PaymentInfo_OrderItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart",
                column: "ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingInfo",
                table: "ShippingInfo",
                column: "ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentInfo",
                table: "PaymentInfo",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ShippingInfo_ShippingInfoId",
                table: "Orders",
                column: "ShippingInfoId",
                principalTable: "ShippingInfo",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentInfo_Orders_OrderItemId",
                table: "PaymentInfo",
                column: "OrderItemId",
                principalTable: "Orders",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductShoppingCart_ShoppingCart_ShoppingCartsItemId",
                table: "ProductShoppingCart",
                column: "ShoppingCartsItemId",
                principalTable: "ShoppingCart",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingInfo_Locations_BillingLocationItemId",
                table: "ShippingInfo",
                column: "BillingLocationItemId",
                principalTable: "Locations",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Customers_CustomerItemId",
                table: "ShoppingCart",
                column: "CustomerItemId",
                principalTable: "Customers",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
