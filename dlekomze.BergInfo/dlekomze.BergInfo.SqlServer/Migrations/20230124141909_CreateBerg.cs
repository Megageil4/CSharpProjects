using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dlekomze.BergInfo.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class CreateBerg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "BergInfo");

            migrationBuilder.CreateTable(
                name: "Berg",
                schema: "BergInfo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Hoehe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berg", x => x.ID);
                });

            migrationBuilder.InsertData(
                schema: "BergInfo",
                table: "Berg",
                columns: new[] { "ID", "Hoehe", "Name" },
                values: new object[,]
                {
                    { 1, 2962, "Zugspitze" },
                    { 2, 8672, "K2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Berg_Name",
                schema: "BergInfo",
                table: "Berg",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Berg",
                schema: "BergInfo");
        }
    }
}
