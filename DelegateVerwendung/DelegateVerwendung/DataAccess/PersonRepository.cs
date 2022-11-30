using DelegateVerwendung.Model;

namespace DelegateVerwendung.DataAccess
{
	public class PersonRepository
	{
		#region Attribute
		readonly List<Person> _personen;
		#endregion

		#region Konstrruktoren
		public PersonRepository()
		{
			_personen = new List<Person>();
			_personen.Add(new Person("König", "Diana", new DateTime(1989, 11, 20)));
			_personen.Add(new Person("Schulze", "Kevin", new DateTime(1977, 5, 31)));
			_personen.Add(new Person("Schäfer", "Verena", new DateTime(1953, 6, 10)));
			_personen.Add(new Person("Schultheiss", "Sabrina", new DateTime(1991, 7, 17)));
			_personen.Add(new Person("Herzog", "Sven", new DateTime(1944, 5, 31)));
			_personen.Add(new Person("Mayer", "Sebastian", new DateTime(1983, 1, 25)));
			_personen.Add(new Person("Trommler", "Angelika", new DateTime(1989, 7, 17)));
			_personen.Add(new Person("Hoffmann", "Sandra", new DateTime(1977, 4, 25)));
			_personen.Add(new Person("Frey", "Stephan", new DateTime(1959, 6, 12)));
			_personen.Add(new Person("Mayer", "Klaus", new DateTime(1984, 4, 27)));
			_personen.Add(new Person("Lang", "Sandro", new DateTime(1997, 10, 28)));
			_personen.Add(new Person("Wagner", "Ulrich", new DateTime(1993, 12, 10)));
			_personen.Add(new Person("Weber", "Karolin", new DateTime(1974, 11, 20)));
			_personen.Add(new Person("Kuhn", "Dagmar", new DateTime(1980, 3, 13)));
			_personen.Add(new Person("Herzog", "Janina", new DateTime(1968, 9, 29)));
			_personen.Add(new Person("Schreiber", "Phillip", new DateTime(1989, 8, 17)));
			_personen.Add(new Person("Beike", "Jonas", new DateTime(1977, 11, 2)));
			_personen.Add(new Person("Keller", "Ralf", new DateTime(1966, 12, 2)));
			_personen.Add(new Person("Wirth", "Christin", new DateTime(1973, 2, 27)));
			_personen.Add(new Person("Urner", "Angelika", new DateTime(1988, 7, 19)));
			_personen.Add(new Person("Pfaff", "Janina", new DateTime(1985, 6, 24)));
			_personen.Add(new Person("Zimmermann", "Torsten", new DateTime(1987, 5, 30)));
			_personen.Add(new Person("Schäfer", "Tom", new DateTime(1964, 8, 20)));
			_personen.Add(new Person("Eberhardt", "Felix", new DateTime(1982, 7, 2)));
		}
		#endregion

		#region Methoden
		public List<Person> Laden()
		{
			return _personen;
		}
		#endregion
	}
}
