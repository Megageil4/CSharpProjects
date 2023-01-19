using ArbeitenMitEFCore.Entity;
using ArbeitenMitEFCore.SqlServer;

using SchuleDbContext context = new();
var alleSchueler = context.SchuelerSet.ToList();
alleSchueler.ForEach(s => Console.WriteLine(s.Nachname));


Console.Write("Bitte eine ID eingeben: ");
int id = int.Parse(Console.ReadLine() ?? String.Empty);
var schueler = context.SchuelerSet.Find(id);

AusgebenSchueler(schueler);

var schuelerAusDB = context.SchuelerSet.SingleOrDefault(s => s.ID == id);
AusgebenSchueler(schuelerAusDB);

Console.Write("Nachname: ");
string nachname = Console.ReadLine() ?? String.Empty;
Console.Write("Vorname: ");
string vorname = Console.ReadLine() ?? String.Empty;
string kennung = vorname[0] + nachname.Substring(1, 7);

var neuerSchueler = new Schueler() { Nachname = nachname, Vorname = vorname, Kennung = kennung };
context.SchuelerSet.Add(neuerSchueler);
context.SaveChanges();

Console.ReadKey();

static void AusgebenSchueler(Schueler? schueler)
{
	if (schueler != null)
	{
		Console.WriteLine($"Nachname: {schueler.Nachname}");
	}
	else
	{
		Console.WriteLine($"ID nicht gefunden");
	}
}