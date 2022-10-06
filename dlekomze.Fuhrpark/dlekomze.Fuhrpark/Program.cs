using dlekomze.Fuhrpark;

Auto a1 = new("H1","T1",2019,50000, 100);

a1.Beschleunigen(2);
Console.WriteLine($"{a1.Reaktionsweg} + {a1.Bremsweg} = {a1.Anhalteweg}");
a1.Beschleunigen(100);
Console.WriteLine($"{a1.Reaktionsweg} + {a1.Bremsweg} = {a1.Anhalteweg}");
a1.Bremsen(2);
Console.WriteLine($"{a1.Reaktionsweg} + {a1.Bremsweg} = {a1.Anhalteweg}");
a1.Bremsen(200);
Console.WriteLine($"{a1.Reaktionsweg} + {a1.Bremsweg} = {a1.Anhalteweg}");

Console.WriteLine(a1.BerechneWert(1));
Console.WriteLine(a1.BerechneWert(2));
Console.WriteLine(a1.BerechneWert(3));

Console.ReadKey();