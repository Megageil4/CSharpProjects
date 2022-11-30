using DelegateVerwendung.DataAccess;
using DelegateVerwendung.Model;

AusgebenTabelleGerade();
AusgebenTabelleParabel();

// a
AusgebenWertetabelle(x => 2 * x - 1, -2, 2, 0.5M);
AusgebenWertetabelle(x => 18 * x - 0.5M * 5.4M * x * x, 0, 3, 0.1M);

// -----------------------
AusgebenPersonenliste();
// -----------------------

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