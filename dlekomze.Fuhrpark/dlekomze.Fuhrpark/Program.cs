using dlekomze.Fuhrpark;

Auto a1 = new("H1","T1",2019,50000, 100);

a1.Beschleunigen(16);
Console.WriteLine($"{a1.Reaktionsweg} + {a1.Bremsweg} = {a1.Anhalteweg}");
a1.Beschleunigen(100);
Console.WriteLine($"{a1.Reaktionsweg} + {a1.Bremsweg} = {a1.Anhalteweg}");
a1.Bremsen(2);
Console.WriteLine($"{a1.Reaktionsweg} + {a1.Bremsweg} = {a1.Anhalteweg}");
a1.Bremsen(200);
Console.WriteLine($"{a1.Reaktionsweg} + {a1.Bremsweg} = {a1.Anhalteweg}");

Console.WriteLine(a1.BerechneWert(2021));
Console.WriteLine(a1.BerechneWert(2020));
Console.WriteLine(a1.BerechneWert(2019));

Cabrio c1 = new Cabrio("H2", "T1", 2019, 50000, 100);
c1.Beschleunigen(10);
Console.WriteLine(c1.Bremsweg);
c1.Bremsen(2);
Console.WriteLine(c1.Bremsweg);




Fahrrad f1 = new("H1","T1",100,2022,"schwarz",7);
f1.Hochschalten();
f1.Hochschalten();
Console.WriteLine(f1.AnzahlGaenge);
Console.WriteLine(f1.AktuellerGang);
Console.WriteLine(f1.BerechneWert(2050));

EBike e1 = new("H1", "T2", 100, 2022, "schwarz", 7, 20);
Console.WriteLine(e1.IstMotorAn);
e1.Einschalten();
Console.WriteLine(e1.IstMotorAn);


Console.ReadKey();