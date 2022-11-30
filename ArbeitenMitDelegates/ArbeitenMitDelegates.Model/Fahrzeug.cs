namespace ArbeitenMitDelegates.Model
{
	public class Fahrzeug
	{

		#region Properties
		public string Kennzeichen { get; set; }
		public DateTime Erstzulassung { get; set; }
		public int Kilometerstand { get; set; }
		public string Hersteller { get; set; }
		#endregion

		#region Konstruktoren
		public Fahrzeug(string kennzeichen, DateTime erstzulassung, int kilometerstand, string hersteller)
		{
			Kennzeichen = kennzeichen;
			Erstzulassung = erstzulassung;
			Kilometerstand = kilometerstand;
			Hersteller = hersteller;
		}

		public Fahrzeug() : this(String.Empty, new DateTime(), 0, String.Empty) { }
		#endregion

		#region Methoden
		public override string ToString()
		{
			return $"{Kennzeichen,-11} | {Hersteller,-8} | {Kilometerstand,-6} | {Erstzulassung:d}";
		} 
		#endregion
	}
}