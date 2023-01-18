using ArbeitenMitEFCore.SqlServer;

SchuleDbContext context = new();
var alleSchueler = context.SchuelerSet.ToList();
alleSchueler.ForEach(s => Console.WriteLine(s.Nachname));
Console.ReadKey();