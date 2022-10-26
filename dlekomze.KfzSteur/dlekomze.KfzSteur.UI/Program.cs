using dlekomze.KfzSteuer.Model;

PKW pkw1 = new("abc", DateTime.Now, 230, 69, 123,Schadstoffklasse.Euro1);
Motorrad motorad1 = new("def", new DateTime(2018,10,26), 230, 42);

Console.WriteLine(pkw1.BerechneSteuer());
Console.WriteLine(motorad1.BerechneSteuer());
Console.WriteLine(pkw1.NaechsteHauptuntersuchung());
Console.WriteLine(motorad1.NaechsteHauptuntersuchung());

Console.ReadKey();