using System.ComponentModel.DataAnnotations;

namespace ArbeitenMitEFCore.Entity
{
	public class Schueler
	{
		#region Properties
		public int ID { get; set; }

		[StringLength(25)]
		public string Nachname { get; set; }

		[StringLength(25)]
		public string Vorname { get; set; }

		public DateTime? Geburtsdatum { get; set; }

		[StringLength(8)]
		public string Kennung { get; set; }

		public List<Fehlzeit> FehlzeitSet { get; }
		#endregion

		#region Konstruktoren
		public Schueler(int id, string nachname, string vorname, DateTime? geburtsdatum, string kennung)
		{
			ID = id;
			Nachname = nachname;
			Vorname = vorname;
			Geburtsdatum = geburtsdatum;
			Kennung = kennung;
			FehlzeitSet = new();
		}

		public Schueler() : this(default, string.Empty, string.Empty, null, string.Empty) { } 
		#endregion
	}
}