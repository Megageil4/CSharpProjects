using dlekomze.ArbeitenMitInterfaces;

INotenGenerator generator = new FlexiblerNotenGenerator(1,3);

AusgebenNotenListe(generator);

Console.ReadKey();

void AusgebenNotenListe(INotenGenerator generator)
{
	IEnumerable<int> noten = generator.GenerierenNoten(24);
	foreach (var note in noten)
	{
		Console.WriteLine(note);
	}
}