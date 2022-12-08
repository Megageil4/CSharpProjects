namespace ArbeitenMitLinq.Model
{
	public class Person
	{
		#region Eigenschaften
		public int PersonID { get; set; }
		public string Nachname { get; set; }
		public string Vorname { get; set; }
		public DateTime Geburtsdatum { get; set; }
		public string Lieblingsfarbe { get; set; }
		#endregion

		#region Konstruktoren
		public Person(int personID, string nachname, string vorname, DateTime geburtsdatum, string lieblingsfarbe)
		{
			PersonID = personID;
			Nachname = nachname;
			Vorname = vorname;
			Geburtsdatum = geburtsdatum;
			Lieblingsfarbe = lieblingsfarbe;
		}

		public Person() : this(0, String.Empty, String.Empty, DateTime.Now, String.Empty) { }

		#endregion

		#region Methoden
		public override string ToString()
		{
			return $"{Nachname}, {Vorname} (PersonID {PersonID}, geb. am {Geburtsdatum:d})";
		}

		#endregion
	}
}
