using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dlekomze.TankenApp.DBSetup.Migrations
{
    /// <inheritdoc />
    public partial class CreateTankbeleg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Tank");

            migrationBuilder.CreateTable(
                name: "Tankbeleg",
                schema: "Tank",
                columns: table => new
                {
                    TankbelegID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    Kilometerstand = table.Column<double>(type: "float", nullable: false),
                    GefahreneKilometer = table.Column<double>(type: "float", nullable: false),
                    Preis = table.Column<double>(type: "float", nullable: false),
                    Liter = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tankbeleg", x => x.TankbelegID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tankbeleg",
                schema: "Tank");
        }
    }
}
