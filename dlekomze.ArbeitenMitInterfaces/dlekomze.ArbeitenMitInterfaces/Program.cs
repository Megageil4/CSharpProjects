using dlekomze.ArbeitenMitInterfaces;

INotenGenerator generator = new FlexiblerNotenGenerator(1,3);

AusgebenNotenListe(generator);
IPersonenService service = new FakePeronenService();
AusgabePersonen(service);

Console.ReadKey();

void AusgabePersonen(IPersonenService service)
{
    foreach (var item in service.Laden())
    {
		Console.WriteLine(item);
    }
}

void AusgebenNotenListe(INotenGenerator generator)
{
	IEnumerable<int> noten = generator.GenerierenNoten(24);
	foreach (var note in noten)
	{ 
		Console.WriteLine(note);
	}
}