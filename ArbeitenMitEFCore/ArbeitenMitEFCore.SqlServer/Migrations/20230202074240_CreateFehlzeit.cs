using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArbeitenMitEFCore.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class CreateFehlzeit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fehlzeit",
                schema: "Schule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Von = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bis = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Grund = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SchuelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fehlzeit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fehlzeit_Schueler_SchuelerId",
                        column: x => x.SchuelerId,
                        principalSchema: "Schule",
                        principalTable: "Schueler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fehlzeit_SchuelerId",
                schema: "Schule",
                table: "Fehlzeit",
                column: "SchuelerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fehlzeit",
                schema: "Schule");
        }
    }
}
