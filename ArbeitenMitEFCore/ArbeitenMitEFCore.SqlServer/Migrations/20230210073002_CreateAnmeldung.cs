using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArbeitenMitEFCore.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class CreateAnmeldung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vortrag",
                schema: "Schule",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vortrag", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Anmeldung",
                schema: "Schule",
                columns: table => new
                {
                    SchuelerId = table.Column<int>(type: "int", nullable: false),
                    VortragId = table.Column<int>(type: "int", nullable: false),
                    Anmeldezeitpunkt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anmeldung", x => new { x.SchuelerId, x.VortragId });
                    table.ForeignKey(
                        name: "FK_Anmeldung_Schueler_SchuelerId",
                        column: x => x.SchuelerId,
                        principalSchema: "Schule",
                        principalTable: "Schueler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Anmeldung_Vortrag_VortragId",
                        column: x => x.VortragId,
                        principalSchema: "Schule",
                        principalTable: "Vortrag",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anmeldung_VortragId",
                schema: "Schule",
                table: "Anmeldung",
                column: "VortragId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anmeldung",
                schema: "Schule");

            migrationBuilder.DropTable(
                name: "Vortrag",
                schema: "Schule");
        }
    }
}
