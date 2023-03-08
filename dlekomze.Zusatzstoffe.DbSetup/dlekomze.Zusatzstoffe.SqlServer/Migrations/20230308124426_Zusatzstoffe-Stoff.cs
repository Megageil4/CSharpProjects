using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dlekomze.Zusatzstoffe.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ZusatzstoffeStoff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "ENummern",
                table: "Stoff",
                columns: new[] { "ID", "Beschreibung", "BewertungID", "Bezeichnung", "Genetechnik", "Nanotechnik" },
                values: new object[,]
                {
                    { 1, "Säurungsmittel auf pflanzlicher Basis. Natürliche Substanz im menschlichen Stoffwechsel. Wird mit Hilfe von Schimmelpilzen aus zuckerhaltigen Substanzen gewonnen. Kann auch gentechnisch hergestellt werden. Der zunehmende Einsatz in Getränken und \"sauren\" Süßigkeiten führt immer häufiger zu Zahnschäden bei Kindern und Erwachsenen, weil der Zahnschmelz von der Säure angegriffen wird, zum Beispiel durch Eistee in Nuckelflaschen für Kleinkinder. Auch für Bio-Lebensmittel zugelassen. Vom Verzehr in größeren Mengen ist abzuraten.", 1, "Citronensäure", false, true },
                    { 2, "Lecithin verbessert die Knet- und Formeigenschaften von Teigen und verlangsamt das Altbackenwerden von Gebäck. In Margarine sorgt Lecithin dafür, dass sie in der Pfanne nicht spritzt.", 1, "Lecithin", true, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Stoff",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "ENummern",
                table: "Stoff",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
