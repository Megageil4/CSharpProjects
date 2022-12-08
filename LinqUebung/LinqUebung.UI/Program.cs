using LinqUebung.DataAccess;
using LinqUebung.Model;

StadionService service = new();
var stadien = service.Laden();
Ausgeben("Alle Stadien", stadien);

// Geben Sie für jede der folgenden Teilaufgaben eine geeignete LINQ-Query an.
// Zeigen Sie die Ergebnismenge an (Häufig können Sie dazu die Methode Ausgeben verwenden).
// -----------------------------------------------------------------------------------------
// Geben Sie alle Stadien in Deutschland (Land hat den Wert DEU) aus. 
// Das Stadion mit der größten Kapazität soll an erster Stelle der Liste erscheinen.
var deutscheStadien = stadien
					.Where(s => s.Land == "DEU")
					.OrderByDescending(s => s.Kapazitaet);
Ausgeben("Deutsche Stadien", deutscheStadien);


// Welche Stadien haben eine Bezeichnung, die auf "Arena" (unabhängig von Groß-/Kleinschreibung) endet? 
// Sortieren Sie die Liste nach `Bezeichnung`
var areanaStadien = stadien
					.Where(s => s.Bezeichnung.EndsWith("Arena", true, null))
					.OrderBy(s => s.Bezeichnung);
Ausgeben("Stadien die auf \"Arena\" enden", areanaStadien);

// Welche Stadien in Italien (ITA) haben eine Kapazität von mindestens 60000 und weniger als 80000 Zuschauer?
var stadienIta = stadien
					.Where(s => s.Kapazitaet >= 60000
					&& s.Kapazitaet <= 80000);
Ausgeben("Italienische Stadien mit einer Kapazität von mindestens 60000 und weniger als 80000 Zuschauer", stadienIta);

// Welche Stadien, die nicht in Deutschland sind und mehr als 70000 Zuschauer Kapazität haben 
// wurden 2006, 2007 oder 2008 eröffnet?
// Verwenden Sie in Ihrer Abfrage die Methode .Year **nicht**
var stadienYear = stadien
					.Where(s => s.Land != "DEU"
					&& s.Kapazitaet > 70000
					&& s.Eroeffnung.HasValue
					&& s.Eroeffnung.Value >= new DateTime(2006, 1, 1)
					&& s.Eroeffnung.Value < new DateTime(2009, 1, 1));
Ausgeben("Stadin zwischen 2006 und 2008", stadienYear);

// Es sollen alle Stadien in Deutschland und England, deren Zuschauerkapazität nicht zwischen 
// 30000 und 70000 liegt, sortiert nach Zuschauerkapazität ausgegeben werden.
var stadienDeuEng = stadien
					.Where(s => (s.Land == "DEU"
					|| s.Land == "GBR")
					&& (s.Kapazitaet < 30000
					|| s.Kapazitaet > 70000))
					.OrderBy(s => s.Kapazitaet);
Ausgeben("Deutsche und Englishe Stadien", stadienDeuEng);

// Wie viele Zuschauer fassen die Stadien in Deutschland insgesamt? 
var zuschauer = stadien
					.Where(s => s.Land == "DEU")
					.Sum(s => s.Kapazitaet);
Console.WriteLine(zuschauer ?? 0);
Console.ReadKey();
Console.Clear();

// Erstellen Sie eine nach Land gruppierte Liste aller Stadien. 
// Es sollen nur Länder mit mindestens 2 Stadien aufgelistet werden.
// Die nach Land sortierte Ausgabe soll ungefähr so aussehen
// Land: CHN (2 Stadien)
//   Durchschnittskapazität 71.069,50
//   Höchste Kapazität 91000
// ----------------------------------
// 	 1, Nationalstadion Peking, 91000, Peking, CHN, 18.04.2008
//   29, Hangzhou - Dragon - Stadion, 51139, Hangzhou, CHN,
//
// Land: DEU
//   Durchschnittskapazität 49.833,73
// ...

var stadienByLand = stadien
					 .GroupBy(s => s.Land)
					 .Where(s => s.Count() >= 2);
foreach (var land in stadienByLand)
{
	Console.WriteLine($"Land: {land.Key} ({land.Count()})");
	Console.WriteLine($"  Durschnittskapazität {land.Average(s => s.Kapazitaet)}");
	Console.WriteLine($"  Höchste Kapazität {land.Max(s => s.Kapazitaet)}");
	Console.WriteLine("----------------------------------");
	foreach (var stadion in land)
	{
		Console.WriteLine($"  {stadion}");
	}
	Console.WriteLine();
}
Console.ReadKey();
Console.Clear();
// Lassen Sie den Anwender eine ganzzahlige ID eingeben und ermitteln Sie das zugehörige Stadion-Objekt
int id = int.Parse(Console.ReadLine()?? "-1");
var stadionByID = stadien
				.Where(s => s.ID == id);
Ausgeben($"Stadion {id}",stadionByID);

// Welches ist das Stadion mit der höchsten Kapazität? Sollten mehrere Stadien die gleiche höchste Kapazität haben, 
// verwenden Sie das erste gefundene Stadion.

// Ermitteln Sie die 10 zuletzt eröffneten Stadien. 

Console.ReadKey();



void Ausgeben(string ueberschrift, IEnumerable<Stadion> stadien)
{
	Console.WriteLine(ueberschrift);
	Console.WriteLine(new String('=', ueberschrift.Length));
	foreach (var item in stadien)
	{
		Console.WriteLine(item.ToString());
	}
	Console.WriteLine();
	Console.WriteLine("Bitte eine Taste drücken...");
	Console.ReadKey(true);
	Console.Clear();
}
