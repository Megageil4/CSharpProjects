using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uebung.TankenApp.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Tankvorgang",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Kilometerstand = table.Column<double>(type: "float", nullable: false),
                    GefahreneKilometer = table.Column<double>(type: "float", nullable: false),
                    Preis = table.Column<decimal>(type: "money", nullable: false),
                    GetankteLiter = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tankvorgang", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tankvorgang",
                schema: "dbo");
        }
    }
}
