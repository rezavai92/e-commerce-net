using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class getApps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeatureEndpointMaps",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    Action = table.Column<string>(type: "text", nullable: false),
                    Controller = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_FeatureEndpointMaps", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "FeatureRoleMaps",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    FeatureId = table.Column<string>(type: "text", nullable: false),
                    FeatureName = table.Column<string>(type: "text", nullable: false),
                    AppName = table.Column<string>(type: "text", nullable: false),
                    RoleName = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("PK_FeatureRoleMaps", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "FeatureEndpointMapFeatureRoleMap",
                columns: table => new
                {
                    FeatureEndpointMapsItemId = table.Column<string>(type: "text", nullable: false),
                    FeatureRoleMapsItemId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureEndpointMapFeatureRoleMap", x => new { x.FeatureEndpointMapsItemId, x.FeatureRoleMapsItemId });
                    table.ForeignKey(
                        name: "FK_FeatureEndpointMapFeatureRoleMap_FeatureEndpointMaps_Featur~",
                        column: x => x.FeatureEndpointMapsItemId,
                        principalTable: "FeatureEndpointMaps",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeatureEndpointMapFeatureRoleMap_FeatureRoleMaps_FeatureRol~",
                        column: x => x.FeatureRoleMapsItemId,
                        principalTable: "FeatureRoleMaps",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeatureEndpointMapFeatureRoleMap_FeatureRoleMapsItemId",
                table: "FeatureEndpointMapFeatureRoleMap",
                column: "FeatureRoleMapsItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureEndpointMapFeatureRoleMap");

            migrationBuilder.DropTable(
                name: "FeatureEndpointMaps");

            migrationBuilder.DropTable(
                name: "FeatureRoleMaps");
        }
    }
}
