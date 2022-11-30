namespace DelegateVerwendung.Model
{
	public class Person
	{

		#region Eigenschaften
		public string Nachname { get; set; }

		public string Vorname { get; set; }
		public DateTime Geburtsdatum { get; set; }
		#endregion

		#region Konstruktoren
		public Person(string nachname, string vorname, DateTime geburtsdatum)
		{
			Nachname = nachname;
			Vorname = vorname;
			Geburtsdatum = geburtsdatum;
		}

		public Person() : this(String.Empty, String.Empty, DateTime.Now) { }
		#endregion

		#region Methoden
		public override string ToString()
		{
			return String.Format("{0} {1} ({2})", Vorname, Nachname, Geburtsdatum);
		}

		#endregion
	}
}
