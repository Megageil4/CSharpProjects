using dlekomze.Ballonbauer.Model;

Ballon superflieger, lahmeEnte;
superflieger = new Ballon();
superflieger.Kammern.Add(new Quaderkammer(Gas.Helium, 1.5, 1.5, 1.5)); // Gas, Laenge, Breite, Hoehe
superflieger.Kammern.Add(new Zylinderkammer(Gas.Helium, 0.75, 1.25)); // Gas, Radius, Hoehe
superflieger.Kammern.Add(new Kugelkammer(Gas.Helium, 2.5)); // Gas, Radius
Console.WriteLine("SerienNr: {0}", superflieger.SerienNr);
Console.WriteLine("Anzahl Kammern: {0}", superflieger.Kammern.Count);
Console.WriteLine("Masse: {0}", superflieger.Masse);
Console.WriteLine("Volumen: {0}", superflieger.Volumen);
Console.WriteLine();
lahmeEnte = new Ballon();
lahmeEnte.Kammern.Add(new Kugelkammer(Gas.Helium, 1)); // Gas, Radius
Console.WriteLine(lahmeEnte.ToString());
Console.WriteLine();
Console.WriteLine("SerienNr Superflieger (erwartet: 111) --> {0}", superflieger.SerienNr);
Console.WriteLine();
Console.ReadKey();