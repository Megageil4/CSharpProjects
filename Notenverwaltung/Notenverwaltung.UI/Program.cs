using Notenverwaltung.DataAccess;
using Notenverwaltung.Logik;
using Notenverwaltung.Model;

NotenManager notenManager = new NotenManager(new FakeZensurenRepository());
AusgebenAlleZensuren(notenManager);
Console.WriteLine("Durchschnitt im Fach Prog: " + notenManager.BerechneDurchschnitt("Prog"));

notenManager.HinzufuegenZensur(new Zensur("DB", DateTime.Now, 2, Leistungsart.KA));
notenManager.HinzufuegenZensur(new Zensur("DB", DateTime.Now, 3, Leistungsart.SA));
Console.WriteLine("Durchschnitt im Fach DB: " + notenManager.BerechneDurchschnitt("DB"));

notenManager.DurchschnittRechner = new GymDurchschnittRechner();
Console.WriteLine("Durchschnitt im Fach Prog: " + notenManager.BerechneDurchschnitt("Prog"));

Console.ReadKey();

static void AusgebenAlleZensuren(NotenManager nm)
{
	foreach (var note in nm.Zensuren)
	{
		Console.WriteLine($"{note.Fach}-{note.Art} am {note.Datum.ToShortDateString()}: Note {note.Note}");
	}
}