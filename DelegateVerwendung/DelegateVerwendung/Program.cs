using DelegateVerwendung.DataAccess;
using DelegateVerwendung.Model;
using System.Globalization;

AusgebenTabelleGerade();
AusgebenTabelleParabel();

// a
AusgebenWertetabelle(x => 2 * x - 1, -2, 2, 0.5M);
AusgebenWertetabelle(x => 18 * x - 0.5M * 5.4M * x * x, 0, 3, 0.1M);

// -----------------------
AusgebenPersonenliste();
// -----------------------

PersonRepository repository = new PersonRepository();
List<Person> personen = repository.Laden();
AusgebenPersonen("Liste aller Personen", personen, (item) => item.ToString());
Console.WriteLine();

AusgebenPersonen("Vorname beginnt mit S", VornameBeginntMitS(), person => $"{person.Nachname}, {person.Vorname}");

AusgebenPersonen("Alphabetische Namensliste", SortierteNamensliste(), person => $"{person.Nachname}, {person.Vorname} ({person.Geburtsdatum.Year})");
Console.WriteLine();

string month = DateTime.Now.ToString("MMMM", new CultureInfo("de-DE"));
AusgebenPersonen($"Geburtstagskinder im {month}", GeburtstagImAktuellenMonat(), person => $"{person.Geburtsdatum.Day,2:D2}. {person.Vorname} {person.Nachname}");

Console.ReadKey();

void AusgebenTabelleGerade()
{
	Console.WriteLine("Wertetabelle:");
	for (decimal x = -0.5M; x <= +0.5M; x += 0.1M)
	{
		Console.WriteLine($"{x,12:n4} -> {2 * x - 1,12:n4}");
	}
	Console.WriteLine();
}

void AusgebenTabelleParabel()
{
	Console.WriteLine("Wertetabelle:");
	for (decimal x = 0M; x <= 5M; x += 1M)
	{
		Console.WriteLine($"{x,12:n4} -> {x * x - 2 * x + 3,12:n4}");
	}
	Console.WriteLine();
}

void AusgebenWertetabelle(Func<decimal,decimal> function, decimal xmin, decimal xmax, decimal schritweite)
{
	Console.WriteLine("Wertetabelle:");
	for (decimal x = xmin; x <= xmax; x += schritweite)
	{
		Console.WriteLine($"{x,12:n4} -> {function(x),12:n4}");
	}
	Console.WriteLine();
}

void AusgebenPersonenliste()
{
	PersonRepository repository = new PersonRepository();
	List<Person> personen = repository.Laden();
	Console.WriteLine("Liste aller Personen");
	Console.WriteLine(new String('=', 30));
	foreach (var item in personen)
	{
		Console.WriteLine(item.ToString());
	}
	Console.WriteLine();
}

void AusgebenPersonen(string ueberschrift, List<Person> personen, Func<Person, string> output)
{
	Console.WriteLine(ueberschrift);
	Console.WriteLine(new String('=', 30));
	personen.ForEach(p => Console.WriteLine(output(p)));
}

List<Person> VornameBeginntMitS()
{
	PersonRepository repository = new PersonRepository();
	List<Person> personen = repository.Laden();
	return personen.FindAll(p => p.Vorname.StartsWith('S'));
}

List<Person> SortierteNamensliste()
{ 
	PersonRepository repository = new PersonRepository();
	List<Person> personen = repository.Laden();
	personen.Sort((person1, person2) => {
		int result = person1.Nachname.CompareTo(person2.Nachname);
		if (result == 0)
		{
			result = person1.Vorname.CompareTo(person2.Vorname);
		}
		return result;
	});
	return personen;
}

List<Person> GeburtstagImAktuellenMonat()
{
	PersonRepository repository = new PersonRepository();
	List<Person> personen = repository.Laden();
	personen = personen.FindAll(person => person.Geburtsdatum.Month == DateTime.Now.Month);
	personen.Sort((person1, person2) =>
	{
		int result = person1.Geburtsdatum.Day.CompareTo(person2.Geburtsdatum.Day);
		if (result == 0)
		{
			result = person1.Geburtsdatum.Year.CompareTo(person2.Geburtsdatum.Year);
		}
		return result;
	});
	return personen;
}