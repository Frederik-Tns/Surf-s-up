using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class asdsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SurfboardId = table.Column<int>(type: "INTEGER", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_Surfboard_SurfboardId",
                        column: x => x.SurfboardId,
                        principalTable: "Surfboard",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SurfboardId",
                table: "Bookings",
                column: "SurfboardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

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
        }
    }
}
