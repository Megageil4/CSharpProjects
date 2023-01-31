using dlekomze.BergInfo.Entity;
using dlekomze.BergInfo.SqlServer;

BergInfoDbContext context = new BergInfoDbContext();
IBergRepository bergRepository = new BergRepository(context);

Console.WriteLine("Auswahlmenü:");
Console.WriteLine();
Console.WriteLine("(1) Alle Berge ausgeben");
Console.WriteLine("(2) Berg anhand seiner ID auslesen");
Console.WriteLine("(3) Berg anhand seines Namens auslesen");
Console.WriteLine();
Console.WriteLine("(5) Ändern eines bestehenden Berges");
Console.WriteLine("(6) Löschen eines bestehenden Berges");
Console.WriteLine();
Console.WriteLine("(9) Programmende");
Console.WriteLine();
Console.Write("Ihre auswahl: ");

ConsoleKeyInfo consoleKey = Console.ReadKey();
switch (consoleKey.Key)
{
	case ConsoleKey.D1:
		AusgabeBerge();
		break;
	case ConsoleKey.D2:
		AusgabeBergID();
		break;
	case ConsoleKey.D3:
		AusgabeBergName();
		break;
	case ConsoleKey.D5:
		AendernBerg();
		break;
	case ConsoleKey.D6:
		DeleteBerg();
		break;
}

Console.WriteLine();
Console.WriteLine("Bitte drücken Sie eine beliebige Taste...");
Console.ReadKey();

void AusgabeBerge() {
	Console.Clear();
	AusgabeUeberschrift("Alle erfassten Berge");
	bergRepository.GetAll().ToList().ForEach(b =>
		Console.WriteLine($"{b.ID,3}: {b.Name,-30} ({b.Hoehe} m) Erstbesteigung: {b.Ersbesteigung}")
	);
}

void AusgabeBergID()
{
	Console.Clear();
	AusgabeUeberschrift("Berg anhand seiner ID ermitteln");
	int id = GetID();
	Console.WriteLine();

	Berg? berg = bergRepository.Get(id);
	if (berg is null)
	{
		Console.WriteLine($"Der Berg mit der ID {id} wurde nicht gefunden");
		return;
	}

	AusgebenBerg(berg);
}

void AusgabeBergName()
{
	Console.Clear();
	AusgabeUeberschrift("Berg anhand seines Namen ermitteln");
	Console.Write("Bitte geben Sie den Namen eines Berges ein: ");
	string name = Console.ReadLine()?? "";
	Console.WriteLine();

	Berg? berg = bergRepository.GetByName(name);
	if (berg is null)
	{
		Console.WriteLine($"Der Berg mit dem Namen {name} wurde nicht gefunden");
		return;
	}

	AusgebenBerg(berg);
}

void AendernBerg()
{
	Console.Clear();
	AusgabeUeberschrift("Bestehenden Berg ändern");
	int id = GetID();
	Berg? berg = bergRepository.Get(id);
	if (berg is null)
	{
		Console.WriteLine($"Der Berg mit der ID {id} wurde nicht gefunden und kann daher nicht geändert werden");
		return;
	}

	string name = GetNewProperty(() => $"Name [{berg.Name}]: ", i => true);
	berg.Name = name == "" ? berg.Name : name;
	string hoehe = GetNewProperty(() => $"Hoehe [{berg.Hoehe}]: ", i => int.TryParse(i,out _));
	berg.Hoehe = hoehe == "" ? berg.Hoehe : int.Parse(hoehe);
	string erst = GetNewProperty(() => $"Erstbesteigung [{berg.Ersbesteigung}]: ", i => DateTime.TryParse(i, out _));
	berg.Ersbesteigung = erst == "" ? berg.Ersbesteigung : DateTime.Parse(erst);

	context.SaveChanges();

	Console.WriteLine("Die Änderungen wurden erfolgreich gespeichert");
}

void DeleteBerg()
{
	Console.Clear();
	AusgabeUeberschrift("Bestehenden Berg löschen");
	int id = GetID();
	Berg? berg = bergRepository.Get(id);
	if (berg == null)
	{
		Console.WriteLine($"Der Berg mit der ID {id} wurde nicht gefunden und kann daher nicht gelöscht werden");
		return;
	}

	Console.WriteLine("Wollen Sie den Berg");
	Console.WriteLine($"{berg.ID,3}: {berg.Name,-30} ({berg.Hoehe} m) Erstbesteigung: {berg.Ersbesteigung}");
	Console.Write("wirklich löschen(J/ N)? ");
	if (Console.ReadLine() != "J")
	{
		Console.WriteLine();
		Console.WriteLine("Der Löschvorgang wurde abgebrochen.");
		return;
	}
	context.BergSet.Remove(berg);
	context.SaveChanges();
	Console.WriteLine();
	Console.WriteLine("Der Berg wurde gelöscht.");
}

string GetNewProperty(Func<string> output, Func<string,bool> isValidInput)
{
	bool valid = false;
	string input = "";
	while (!valid)
	{
		Console.Write(output());
		input = Console.ReadLine() ?? "";
		valid = isValidInput(input) || input == "";
	}

	return input;
}

void AusgebenBerg(Berg berg)
{
	Console.WriteLine($"ID: {berg.ID}");
	Console.WriteLine($"Name: {berg.Name}");
	Console.WriteLine($"Hoehe: {berg.Hoehe}");
	Console.WriteLine($"Erstbesteigung: {berg.Ersbesteigung}");
}

void AusgabeUeberschrift(string ueberschrift)
{
	Console.WriteLine(ueberschrift);
	Console.WriteLine(new String('=', ueberschrift.Length));
}

static int GetID()
{
	bool ok = false;
	int id = 0;
	while (!ok)
	{
		Console.Write("Bitte geben Sie die ID eines Berges ein: ");
		ok = int.TryParse(Console.ReadLine(), out id);
	}

	return id;
}