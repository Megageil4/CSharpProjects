using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dlekomze.Zusatzstoffe.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ZusatzstoffeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "ENummern",
                table: "Bewertung",
                columns: new[] { "ID", "Bezeichnung" },
                values: new object[] { 1, "unbedenklich" });

            migrationBuilder.InsertData(
                schema: "ENummern",
                table: "Herkunft",
                columns: new[] { "ID", "Bezeichnung" },
                values: new object[,]
                {
                    { 1, "künstlich" },
                    { 2, "pflanzlich" },
                    { 3, "tierisch" }
                });

            migrationBuilder.InsertData(
                schema: "ENummern",
                table: "Verwendung",
                columns: new[] { "ID", "Beschreibung", "Bezeichnung" },
                values: new object[,]
                {
                    { 1, "Stoffe, die ein Lebensmittel ansäuern und/oder diesem einen sauren Geschmack verleihen", "Säurungsmittel" },
                    { 2, "verbinden Stoffe, die nicht miteinander mischbar sind, wie zum Beispiel Öl und Wasser", "Emulgator" },
                    { 3, "verhindern das Ranzigwerden von Fetten und sorgen für eine längere Haltbarkeit", "Antioxidationsmittel" },
                    { 4, "werden dazu verwendet, die Lebensmitteln zu stabilisieren, erhalten oder intensivieren", "Stabilisator" },
                    { 5, "???", "Mehlbehandlungsmittel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Bewertung",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Herkunft",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Herkunft",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Herkunft",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Verwendung",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Verwendung",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Verwendung",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Verwendung",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Verwendung",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
