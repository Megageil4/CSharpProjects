using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dlekomze.Zusatzstoffe.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ZusatzstoffeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ENummern");

            migrationBuilder.CreateTable(
                name: "Bewertung",
                schema: "ENummern",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bewertung", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Herkunft",
                schema: "ENummern",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herkunft", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Verwendung",
                schema: "ENummern",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Beschreibung = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verwendung", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stoff",
                schema: "ENummern",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Beschreibung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genetechnik = table.Column<bool>(type: "bit", nullable: false),
                    Nanotechnik = table.Column<bool>(type: "bit", nullable: false),
                    BewertungID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stoff_Bewertung_BewertungID",
                        column: x => x.BewertungID,
                        principalSchema: "ENummern",
                        principalTable: "Bewertung",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HerkunftStoff",
                schema: "ENummern",
                columns: table => new
                {
                    HerkunftSetID = table.Column<int>(type: "int", nullable: false),
                    StoffSetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HerkunftStoff", x => new { x.HerkunftSetID, x.StoffSetID });
                    table.ForeignKey(
                        name: "FK_HerkunftStoff_Herkunft_HerkunftSetID",
                        column: x => x.HerkunftSetID,
                        principalSchema: "ENummern",
                        principalTable: "Herkunft",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HerkunftStoff_Stoff_StoffSetID",
                        column: x => x.StoffSetID,
                        principalSchema: "ENummern",
                        principalTable: "Stoff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoffVerwendung",
                schema: "ENummern",
                columns: table => new
                {
                    StoffSetID = table.Column<int>(type: "int", nullable: false),
                    VerwendungSetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoffVerwendung", x => new { x.StoffSetID, x.VerwendungSetID });
                    table.ForeignKey(
                        name: "FK_StoffVerwendung_Stoff_StoffSetID",
                        column: x => x.StoffSetID,
                        principalSchema: "ENummern",
                        principalTable: "Stoff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoffVerwendung_Verwendung_VerwendungSetID",
                        column: x => x.VerwendungSetID,
                        principalSchema: "ENummern",
                        principalTable: "Verwendung",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HerkunftStoff_StoffSetID",
                schema: "ENummern",
                table: "HerkunftStoff",
                column: "StoffSetID");

            migrationBuilder.CreateIndex(
                name: "IX_Stoff_BewertungID",
                schema: "ENummern",
                table: "Stoff",
                column: "BewertungID");

            migrationBuilder.CreateIndex(
                name: "IX_StoffVerwendung_VerwendungSetID",
                schema: "ENummern",
                table: "StoffVerwendung",
                column: "VerwendungSetID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HerkunftStoff",
                schema: "ENummern");

            migrationBuilder.DropTable(
                name: "StoffVerwendung",
                schema: "ENummern");

            migrationBuilder.DropTable(
                name: "Herkunft",
                schema: "ENummern");

            migrationBuilder.DropTable(
                name: "Stoff",
                schema: "ENummern");

            migrationBuilder.DropTable(
                name: "Verwendung",
                schema: "ENummern");

            migrationBuilder.DropTable(
                name: "Bewertung",
                schema: "ENummern");
        }
    }
}
