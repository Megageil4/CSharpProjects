using Devisenrechner.DataAccess;
using Devisenrechner.Entity;

DevisenCsvRepository devisenCsvRepository = new(@"D:\Daten\dlekomze\git\csharp\uebungen.git\Devisenrechner\Devisenrechner.TestUI\Kurse.dat");
devisenCsvRepository.Einlesen += ((sender, e) => Console.WriteLine("Einlesen gestarted"));
devisenCsvRepository.Eingelesen += ((sender, e) => Console.WriteLine($"{e.Anzahl} Elemente erflogreich Eingelesen"));
devisenCsvRepository.Lesefehler += ((sender, e) => Console.WriteLine($"Der Datensatz {e.Zeile} konnte nicht gelesen werden"));

Console.WriteLine(devisenCsvRepository.GetByKuerzel("CZK"));
Console.WriteLine();

foreach (var waerung in devisenCsvRepository.GetAll())
{
	Console.WriteLine(waerung);
}
Console.WriteLine();

Console.Write("Kürzel: ");
string kuerzel = Console.ReadLine()?? "";
Console.Write("Betrag: ");
decimal betrag = decimal.Parse(Console.ReadLine()?? "0");

Waehrung? waehrung = devisenCsvRepository.GetByKuerzel(kuerzel);
if (waehrung == null)
{
	throw new Exception("Kuerzel ungültig");
}
Console.WriteLine($"= {betrag * waehrung.AktuellerKurs} {waehrung.Bezeichnung}");

Console.ReadKey();