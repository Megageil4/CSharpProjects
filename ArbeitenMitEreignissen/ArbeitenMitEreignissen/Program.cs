using ArbeitenMitEreignissen;

Console.WriteLine("Ich bin der Empfänger");
Rechner rechner = new();
rechner.BerechnungGestarted += BerechnungGestartetHandler;
rechner.BerechnungBeendet += (sender, e) => Console.WriteLine("Berechnung wurde Beendet");
rechner.Zwischenergebnis += Rechner_Zwischenergebnis;

long ergebnis = rechner.BerechnenSumme(1,30);
Console.WriteLine($"Das Ergebnis ist {ergebnis}");
Console.ReadKey();

void BerechnungGestartetHandler(object? sender, EventArgs e)
{
	Console.WriteLine("Berechnung wurde gestartet");
}

void Rechner_Zwischenergebnis(object? sender, ErgebnisEventArgs e)
{
	Console.WriteLine($"  Zwischenergebnis: {e.Ergebnis} ({e.Zeitpunkt})");
}