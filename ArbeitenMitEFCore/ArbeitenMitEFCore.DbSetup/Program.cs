using ArbeitenMitEFCore.Entity;
using ArbeitenMitEFCore.SqlServer;


using SchuleDbContext context = new SchuleDbContext();
var schueler = context.SchuelerSet.First();
Console.WriteLine($"{schueler.ID}: {schueler.Nachname}");

//schueler.FehlzeitSet.Add(new Fehlzeit() { Von = new(2023, 1, 31) });

//context.FehlzeitSet.Add(new Fehlzeit() { Von = new(2023, 1, 17), SchuelerNavigation = schueler });

//context.FehlzeitSet.Add(new Fehlzeit() { Von = new(2023, 2, 2), SchuelerId = 4 });

//context.SaveChanges();

Arbeitsgruppe schulhaus = new() { Bezeichnung = "Unser Schulhaus soll schöner werden" };
schulhaus.SchuelerSet.Add(schueler);
context.ArbeitsgruppeSet.Add(schulhaus);
context.SaveChanges();


Console.ReadKey();

//using SchuleDbContext context = new();
//var alleSchueler = context.SchuelerSet.ToList();
//alleSchueler.ForEach(s => Console.WriteLine(s.Nachname));


//Console.Write("Bitte eine ID eingeben: ");
//int id = int.Parse(Console.ReadLine() ?? String.Empty);
//var schueler = context.SchuelerSet.Find(id);

//AusgebenSchueler(schueler);

//var schuelerAusDB = context.SchuelerSet.SingleOrDefault(s => s.ID == id);
//AusgebenSchueler(schuelerAusDB);

//Console.Write("Nachname: ");
//string nachname = Console.ReadLine() ?? String.Empty;
//Console.Write("Vorname: ");
//string vorname = Console.ReadLine() ?? String.Empty;
//string kennung = vorname[0] + nachname.Substring(1, 7);

//var neuerSchueler = new Schueler() { Nachname = nachname, Vorname = vorname, Kennung = kennung };
//context.SchuelerSet.Add(neuerSchueler);
//context.SaveChanges();


//Console.ReadKey();

//static void AusgebenSchueler(Schueler? schueler)
//{
//	if (schueler != null)
//	{
//		Console.WriteLine($"Nachname: {schueler.Nachname}");
//	}
//	else
//	{
//		Console.WriteLine($"ID nicht gefunden");
//	}
//}