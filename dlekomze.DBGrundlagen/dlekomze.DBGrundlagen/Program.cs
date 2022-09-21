namespace dlekomze.DBGrundlagen
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Datenbank db = new Datenbank(
					"10.0.104.73",
					"BFS2021fi_dlekomze",
					"dlekomze",
					"abc"
				);

			Console.WriteLine("Artikelid|Code   |Bezeichnung               |VK   |PreisErhoehtAm");
			Console.WriteLine("---------|-------|--------------------------|-----|--------------");

			foreach (var artikel in db.AlleArtikel())
			{
				Console.WriteLine(artikel);
			}

			db.AendernVerkaufspreis(8878331, 10.1M);
			Console.WriteLine(Environment.NewLine + Environment.NewLine);

			foreach (var artikel in db.ArtikelDerWarengruppe(7))
			{
				Console.WriteLine(artikel);
			}

			Console.ReadKey();
		}
	}
}