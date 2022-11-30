using ArbeitenMitDelegates.DataAccess;
using ArbeitenMitDelegates.Model;

FahrzeugRepository repository = new();
List<Fahrzeug> fahrzeuge = repository.AlleFahrzeuge;
Ausgeben(fahrzeuge, "Alle Fahrzeuge");
// ----
Ausgeben(repository.FahrzeugeVonBMW(), "Fahrzeuge von BMW");
// ----
Ausgeben(repository.FahrzeugeVonAudi(), "Fahrzeuge von Audi");
// ----
Ausgeben(repository.FahrzeugeVonHersteller("BMW"), "Fahrzeuge von Herstller BMW");
// ----
Ausgeben(repository.FahrzeugeMitMaxKilometer(50000), "Fahrzeuge mit höchstens 50000km");
// ----
Ausgeben(repository.Filtern(IstBMW), "Filtern BMW");
// ----
Ausgeben(repository.Filtern(KilometerWenigerAls50000), "Filtern < 50000 km");

Ausgeben(repository.Filtern((f) => { return f.Hersteller == "Audi"; }), "Filtern");

Ausgeben(repository.Filtern(f => f.Hersteller == "BMW"), "BMW");

Console.ReadKey();

bool KilometerWenigerAls50000(Fahrzeug fahrzeug) 
{
	return fahrzeug.Kilometerstand < 50000;
}

bool IstBMW(Fahrzeug fahrzeug)
{
	return fahrzeug.Hersteller == "BMW";
}

void Ausgeben(IEnumerable<Fahrzeug> fahrzeuge, string ueberschrift)
{
	Console.WriteLine(ueberschrift);
	Console.WriteLine(new String('=', 44));
  foreach (var item in fahrzeuge)
  {
    Console.WriteLine(item.ToString());
  }
  Console.WriteLine();
}