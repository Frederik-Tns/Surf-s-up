using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class asdsa3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Surfboard_SurfboardId",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Surfboard",
                table: "Surfboard");

            migrationBuilder.RenameTable(
                name: "Surfboard",
                newName: "Surfboards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surfboards",
                table: "Surfboards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Surfboards_SurfboardId",
                table: "Bookings",
                column: "SurfboardId",
                principalTable: "Surfboards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Surfboards_SurfboardId",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Surfboards",
                table: "Surfboards");

            migrationBuilder.RenameTable(
                name: "Surfboards",
                newName: "Surfboard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surfboard",
                table: "Surfboard",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Surfboard_SurfboardId",
                table: "Bookings",
                column: "SurfboardId",
                principalTable: "Surfboard",
                principalColumn: "Id");
        }
    }
}
