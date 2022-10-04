using Dlekomze.Vererbung;

Spielfeld spielfeld = new() { Nr = 1, PosX = 10, PosY = 10};
Aktionsfeld aktionsfeld = new() { Aktion = "Nochmal würfeln", Nr = 2, PosX = 40, PosY = 40 };

//Console.WriteLine(spielfeld.AusgebenSvg());
//Console.WriteLine(aktionsfeld.AusgebenSvg());

List<Spielfeld> spielplan = new();
spielplan.Add(spielfeld);
spielplan.Add(aktionsfeld);

Spielfeld feld1 = new();
Spielfeld feld2 = new Aktionsfeld();
Aktionsfeld feld3 = new();

Console.WriteLine(feld1.AusgebenSvg());
Console.WriteLine(feld2.AusgebenSvg());
Console.WriteLine(feld3.AusgebenSvg());

Console.ReadKey();