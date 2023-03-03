using ArbeitenMitEFCore.Entity;
using ArbeitenMitEFCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;


//schueler.FehlzeitSet.Add(new Fehlzeit() { Von = new(2023, 1, 31) });

//context.FehlzeitSet.Add(new Fehlzeit() { Von = new(2023, 1, 17), SchuelerNavigation = schueler });

//context.FehlzeitSet.Add(new Fehlzeit() { Von = new(2023, 2, 2), SchuelerId = 4 });

//context.SaveChanges();

//Arbeitsgruppe schulhaus = new() { Bezeichnung = "Unser Schulhaus soll schöner werden" };
//schulhaus.SchuelerSet.Add(schueler);
//context.ArbeitsgruppeSet.Add(schulhaus);
//context.SaveChanges();


using SchuleDbContext context = CreateDbContext();
//var schueler = context.SchuelerSet.First();
//Console.WriteLine($"{schueler.ID}: {schueler.Nachname}");

var fehlzeiten = context.FehlzeitSet
	.Include((f) => f.SchuelerNavigation)
	.ToList();
foreach (var fehlzeit in fehlzeiten)
{
    Console.WriteLine($"{fehlzeit.Id} : {fehlzeit.Von} {fehlzeit.Grund} ({fehlzeit.SchuelerNavigation?.Nachname}, {fehlzeit.SchuelerNavigation?.Vorname})");
}

var alleSchuelerMitFehlzeiten = context.SchuelerSet
	.Include(s => s.FehlzeitSet)
	.ToList();

foreach (var schueler in alleSchuelerMitFehlzeiten)
{
    Console.WriteLine($"{schueler.Vorname} {schueler.Nachname} ({schueler.FehlzeitSet.Count} Fehlzeiten)");
    foreach (var fehlzeit in schueler.FehlzeitSet)
    {
        Console.WriteLine($"	{fehlzeit.Von} {fehlzeit.Grund}");
    }
}

var schuelerDetails = context.SchuelerSet
	.Include(s => s.FehlzeitSet)
	.Include(s => s.ArbeitsgruppeSet)
	.Include(s => s.AnmeldungSet)
		.ThenInclude(a => a.VortragNavigation)
	.ToList();

foreach (var schueler in schuelerDetails)
{
    Console.WriteLine($"{schueler.Vorname} ({schueler.FehlzeitSet.Count} F)");
    Console.WriteLine($"Arbeitsgruppen:");
    foreach (var ag in schueler.ArbeitsgruppeSet)
    {
		Console.WriteLine($"	{ag.Bezeichnung}");
    }
    Console.WriteLine("Anmeldungen:");
    foreach (var an in schueler.AnmeldungSet)
    {
        Console.WriteLine($"    {an.Anmeldezeitpunkt} - {an.VortragNavigation?.Bezeichnung}");
    }
}

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

SchuleDbContext CreateDbContext()
{
	var optionsBuilder = new DbContextOptionsBuilder<SchuleDbContext>();
	optionsBuilder.LogTo(m => Console.WriteLine(m),
		new[] { DbLoggerCategory.Database.Command.Name },
				Microsoft.Extensions.Logging.LogLevel.Information);

	return new SchuleDbContext(optionsBuilder.Options);
}