namespace Uebung.TankenApp.Entity
{
	public class Tankvorgang
	{
		public int Id { get; set; }
		public DateTimeOffset Datum { get; set; }
		public double Kilometerstand { get; set; }
		public double GefahreneKilometer { get; set; }
		public decimal Preis { get; set; }
		public double GetankteLiter { get; set; }

		public Tankvorgang()
		{
			Datum = DateTime.Now;
		}
	}
}