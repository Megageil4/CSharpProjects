using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreDesignTimeDbContextFactory.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class CreateTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Formel1");

            migrationBuilder.CreateTable(
                name: "Team",
                schema: "Formel1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Formel1",
                table: "Team",
                columns: new[] { "Id", "Bezeichnung" },
                values: new object[,]
                {
                    { 1, "Red Bull" },
                    { 2, "Mercedes" },
                    { 3, "Ferrari" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team",
                schema: "Formel1");
        }
    }
}
