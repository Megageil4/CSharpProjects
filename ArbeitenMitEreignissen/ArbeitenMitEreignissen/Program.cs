using ArbeitenMitEreignissen;

Console.WriteLine("Ich bin der Empfänger");
Rechner rechner = new();
rechner.BerechnungGestarted += BerechnungGestartetHandler;
rechner.BerechnungBeendet += (sender, e) => Console.WriteLine("Berechnung wurde Beendet");

long ergebnis = rechner.BerechnenSumme(1,30);
Console.WriteLine($"Das Ergebnis ist {ergebnis}");
Console.ReadKey();

void BerechnungGestartetHandler(Object? sender, EventArgs e)
{
	Console.WriteLine("Berechnung wurde gestartet");
}