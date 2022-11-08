using VerwendenVonIComparer.Comparer;
using VerwendenVonIComparer.DataAccess;
using VerwendenVonIComparer.Model;

FakeFilmRepository repository = new();
List<Film> filme = new(repository.GetAll());
filme.Sort(new EinspieleregebnissComparer(true));
foreach (var item in filme)
{
	Console.WriteLine(item);
}

Console.ReadKey();