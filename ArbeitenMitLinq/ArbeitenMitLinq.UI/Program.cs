using ArbeitenMitLinq.DataAccess;
using ArbeitenMitLinq.Model;

PersonService personService = new();
var personen = personService.Laden();

// Alle Personen, deren Vorname mit "J" beginnt
var query = from p in personen
			 where p.Vorname.StartsWith('J')
			 orderby p.Nachname, p.Vorname
			 select p;

var result = query.ToList();
Ausgeben(result);

var vornameBeginntMitJ = personen.Where(p => p.Vorname.StartsWith('J'))
						 .OrderBy(p => p.Nachname)
						 .ThenBy(p => p.Vorname)
						 .Select(p => p)
						 .ToList();
Ausgeben(vornameBeginntMitJ);

// Eine Person anhand der ID ermitteln 
int id;
do
{
	do
	{
		Console.Write("Bitte geben Sie die ID einer Person ein: ");
	} while (!int.TryParse(Console.ReadLine(), out id));

	// Person über die eindeutige abrufen
	var person = personen.SingleOrDefault(p => p.PersonID == id);
	if (person != null)
	{
		Console.WriteLine(person.ToString());
	}
	else
	{
		Console.WriteLine($"Es gibt keine Person mit PersonId={id}");
	}

	Console.WriteLine("Wollen Sie noch eine Person ermitteln? (J/N)");
} while (Console.ReadKey(true).Key == ConsoleKey.J);

// Gruppieren nach Lieblingsfarbe
var gruppiertNachLieblingsfarbe = personen.GroupBy(p => p.Lieblingsfarbe);

foreach (var farbe in gruppiertNachLieblingsfarbe.OrderByDescending(g => g.Count()))
{
	Console.WriteLine($"Lieblingsfarbe {farbe.Key} ({farbe.Count()})");
	foreach (var person in farbe.OrderBy(p => p.Geburtsdatum))
	{
		Console.WriteLine($"   {person.ToString()}");
	}
}

var zweitaeltestePerson = personen
							.OrderBy(p => p.Geburtsdatum)
							.Skip(1)
							.Take(1)
							.SingleOrDefault();

Console.WriteLine(Environment.NewLine + zweitaeltestePerson);

Console.ReadKey();

void Ausgeben(IEnumerable<Person> personen)
{
	foreach (var item in personen)
	{
		Console.WriteLine(item.ToString());
	}
	Console.WriteLine();
}
