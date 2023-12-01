using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class makeindexesandemailunique1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_FirstName_LastName_CreatedOn",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedOn",
                table: "Users",
                column: "CreatedOn");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FirstName_LastName_Email",
                table: "Users",
                columns: new[] { "FirstName", "LastName", "Email" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_CreatedOn",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_FirstName_LastName_Email",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_FirstName_LastName_CreatedOn",
                table: "Users",
                columns: new[] { "FirstName", "LastName", "CreatedOn" });
        }
    }
}
