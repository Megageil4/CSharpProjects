using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArbeitenMitEFCore.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ErstellenSchueler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Schule");

            migrationBuilder.CreateTable(
                name: "Schueler",
                schema: "Schule",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nachname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Vorname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Geburtsdatum = table.Column<DateTime>(type: "date", nullable: true),
                    Kennung = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schueler", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schueler_Kennung",
                schema: "Schule",
                table: "Schueler",
                column: "Kennung",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schueler",
                schema: "Schule");
        }
    }
}
