using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArbeitenMitEFCore.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class AddArbeitsgruppe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbeitsgruppe",
                schema: "Schule",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbeitsgruppe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArbeitsgruppeSchueler",
                schema: "Schule",
                columns: table => new
                {
                    ArbeitsgruppeSetID = table.Column<int>(type: "int", nullable: false),
                    SchuelerSetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbeitsgruppeSchueler", x => new { x.ArbeitsgruppeSetID, x.SchuelerSetID });
                    table.ForeignKey(
                        name: "FK_ArbeitsgruppeSchueler_Arbeitsgruppe_ArbeitsgruppeSetID",
                        column: x => x.ArbeitsgruppeSetID,
                        principalSchema: "Schule",
                        principalTable: "Arbeitsgruppe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArbeitsgruppeSchueler_Schueler_SchuelerSetID",
                        column: x => x.SchuelerSetID,
                        principalSchema: "Schule",
                        principalTable: "Schueler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArbeitsgruppeSchueler_SchuelerSetID",
                schema: "Schule",
                table: "ArbeitsgruppeSchueler",
                column: "SchuelerSetID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArbeitsgruppeSchueler",
                schema: "Schule");

            migrationBuilder.DropTable(
                name: "Arbeitsgruppe",
                schema: "Schule");
        }
    }
}
