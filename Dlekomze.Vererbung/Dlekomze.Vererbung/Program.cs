using Dlekomze.Vererbung;

Spielfeld spielfeld = new() { Nr = 1, X = 10, Y = 10};
Aktionsfeld aktionsfeld = new() { Aktion = "Nochmal würfeln", Nr = 2, X = 40, Y = 40 };

Console.WriteLine(spielfeld.AusgebenSvg());
Console.WriteLine(aktionsfeld.AusgebenSvg());

List<Spielfeld> spielplan = new();
spielplan.Add(spielfeld);
spielplan.Add(aktionsfeld);

Console.ReadKey();