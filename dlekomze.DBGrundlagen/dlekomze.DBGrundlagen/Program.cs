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

			var alleArtikel = db.AlleArtikel();

			foreach (var artikel in alleArtikel)
			{
				Console.WriteLine(artikel);
			}

			db.AendernVerkaufspreis(8878331, 10.1M);
			Console.WriteLine(Environment.NewLine + Environment.NewLine);

			foreach (var artikel in db.ArtikelDerWarengruppe(7))
			{
				Console.WriteLine(artikel);
			}

			JsonExport.SpeichernArtikelliste(@"D:\Daten\dlekomze\git\csharp\uebungen.git\dlekomze.DBGrundlagen\dlekomze.DBGrundlagen\jsonArtikel", alleArtikel);

			bool ok = true;
			int wgrid = 0;

			do
			{
				Console.Write("wgrid: ");
				ok = int.TryParse(Console.ReadLine(), out wgrid);
			} while (!ok);

			Console.Write("Dateipfad: ");
			string? dateipfad = Console.ReadLine() ?? "";
			if (File.Exists(dateipfad))
			{
				Console.Write("Soll die Datei ersetzt werden? (y/n): ");
				if (Console.ReadLine() != "y")
				{
					return;
				}
			}

			try
			{
				JsonExport.SpeichernArtikelliste(dateipfad, db.ArtikelDerWarengruppe(wgrid));
			}
			catch (DirectoryNotFoundException)
			{
				Console.WriteLine("Dateipfad nicht vorhanden");
			}
			catch (Exception)
			{
				Console.WriteLine("Fehler beim erstellen der Json");
			}

			foreach (var artikel in JsonExport.ArtikelEinlesen(dateipfad))
			{
				Console.WriteLine(artikel);
			}

			Console.ReadKey();
		}
	}
}