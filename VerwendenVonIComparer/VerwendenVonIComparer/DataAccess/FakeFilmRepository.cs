using VerwendenVonIComparer.Model;

namespace VerwendenVonIComparer.DataAccess
{
	public class FakeFilmRepository
	{
		public IEnumerable<Film> GetAll()
		{
			yield return new Film("Avatar - Aufbruch nach Pandora", 2009, 2923.8m, "20th Century Fox");
			yield return new Film("Titanic", 1997, 2201.6m, "Paramount Pictures");
			yield return new Film("Star Wars: Das Erwachen der Macht", 2015, 2069.5m, "Walt Disney Studios");
			yield return new Film("Der König der Löwen", 2019, 1663.3m, "Universal Studios");
			yield return new Film("Avengers: Endgame", 2019, 2797.5m, "Walt Disney Studios");
			yield return new Film("Jurassic World", 2015, 1671.5m, "Universal Studios");
		}
	}
}
