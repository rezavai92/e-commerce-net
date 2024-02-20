using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Coupons_CouponItemId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandItemId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "BrandItemId",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CouponItemId",
                table: "Orders",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Coupons_CouponItemId",
                table: "Orders",
                column: "CouponItemId",
                principalTable: "Coupons",
                principalColumn: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandItemId",
                table: "Products",
                column: "BrandItemId",
                principalTable: "Brands",
                principalColumn: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Coupons_CouponItemId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandItemId",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "BrandItemId",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CouponItemId",
                table: "Orders",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Coupons_CouponItemId",
                table: "Orders",
                column: "CouponItemId",
                principalTable: "Coupons",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandItemId",
                table: "Products",
                column: "BrandItemId",
                principalTable: "Brands",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
