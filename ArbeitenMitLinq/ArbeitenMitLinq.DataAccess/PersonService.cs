using ArbeitenMitLinq.Model;

namespace ArbeitenMitLinq.DataAccess
{
	public class PersonService
	{
    public IEnumerable<Person> Laden()
    {
      yield return new Person(1, "König", "Diana", new DateTime(1989, 11, 20), "rot");
      yield return new Person(2, "Schulze", "Kevin", new DateTime(1977, 5, 31), "blau");
      yield return new Person(3, "Schäfer", "Verena", new DateTime(1953, 6, 10), "grün");
      yield return new Person(4, "Schultheiss", "Sabrina", new DateTime(1991, 7, 17), "gelb");
      yield return new Person(5, "Herzog", "Sven", new DateTime(1944, 5, 31), "blau");
      yield return new Person(6, "Mayer", "Sebastian", new DateTime(1983, 1, 25), "grau");
      yield return new Person(7, "Trommler", "Angelika", new DateTime(1989, 7, 17), "weiß");
      yield return new Person(8, "Hoffmann", "Sandra", new DateTime(1977, 4, 25), "grün");
      yield return new Person(9, "Frey", "Stephan", new DateTime(1959, 6, 12), "blau");
      yield return new Person(10, "Mayer", "Klaus", new DateTime(1984, 4, 27), "rot");
      yield return new Person(11, "Lang", "Sandro", new DateTime(1997, 10, 28), "lila");
      yield return new Person(12, "Wagner", "Ulrich", new DateTime(1993, 12, 10), "grün");
      yield return new Person(13, "Weber", "Karolin", new DateTime(1974, 11, 20), "schwarz");
      yield return new Person(14, "Kuhn", "Dagmar", new DateTime(1980, 3, 13), "weiß");
      yield return new Person(15, "Herzog", "Janina", new DateTime(1968, 9, 29), "rot");
      yield return new Person(16, "Schreiber", "Phillip", new DateTime(1989, 8, 17), "blau");
      yield return new Person(17, "Beike", "Jonas", new DateTime(1977, 11, 2), "blau");
      yield return new Person(18, "Keller", "Ralf", new DateTime(1966, 12, 2), "gelb");
      yield return new Person(19, "Wirth", "Christin", new DateTime(1973, 2, 27), "rot");
      yield return new Person(20, "Urner", "Angelika", new DateTime(1988, 7, 19), "blau");
      yield return new Person(21, "Pfaff", "Janina", new DateTime(1985, 6, 24), "blau");
      yield return new Person(22, "Zimmermann", "Torsten", new DateTime(1987, 5, 30), "grün");
      yield return new Person(23, "Schäfer", "Tom", new DateTime(1964, 8, 20), "gelb");
      yield return new Person(24, "Eberhardt", "Felix", new DateTime(1982, 7, 2), "orange");

    }
  }
}


