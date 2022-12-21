using dlekomze.Zahlenraten.Logik;

Ratespiel ratespiel = new Ratespiel(0, 10, 5);
ratespiel.Gestartet += Ratespiel_Gestartet;
ratespiel.NichtAktiv += ((sender, e) => Console.WriteLine("Spiel ist nicht aktiv"));
ratespiel.Gewonnen += ((sender, e) => Console.WriteLine($"Du hast mit {e.Zahl} Versuchen gewonnen"));
ratespiel.Verloren += ((sender, e) => Console.WriteLine($"Du hast verloren, die Zahl wäre {e.Zahl}"));
ratespiel.Fehlversuch += ((sender, e) => Console.WriteLine($"Falsch, die Zahl ist {(e.Groesser? "größer" : "kleiner")}"));
ratespiel.Abgrebrochen += ((sender, e) => Console.WriteLine($"Abgebrochen, die Zahl war {e.Zahl}"));

ratespiel.Raten(1);
ratespiel.Starten();
while (ratespiel.IstAktiv)
{
	Console.Write("Zahl: ");
	ratespiel.Raten(int.Parse(Console.ReadLine()?? "0"));
}

Console.ReadKey();

void Ratespiel_Gestartet(object? sender, GestartetEventArgs e)
{
	Console.WriteLine($"Spiel wurde gestartet " +
		$"(Obergrenze: {e.Obergrenze}" +
		$" Untergrenze: {e.Untergrenze}" +
		$" Versuche: {e.MaxVersuche})");
}