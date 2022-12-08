using LinqUebung.Model;

namespace LinqUebung.DataAccess
{
	public class StadionService
	{
		public IEnumerable<Stadion> Laden()
		{
			yield return new Stadion(1, "Nationalstadion Peking", 91000, "Peking", "CHN", new DateTime(2008, 4, 18));
			yield return new Stadion(2, "Rose Bowl Stadium", 92542, "Pasadena", "USA", new DateTime(1923, 1, 1));
			yield return new Stadion(3, "Wembley-Stadion", 90000, "London", "GBR", null);
			yield return new Stadion(4, "FNB-Stadion", 94700, "Johannesburg", "ZAF", new DateTime(1989, 10, 7));
			yield return new Stadion(5, "Signal Iduna Park", 81359, "Dortmund", "DEU", new DateTime(1974, 4, 2));
			yield return new Stadion(6, "Red Bull Arena", 42959, "Leipzig", "DEU", new DateTime(2004, 11, 17));
			yield return new Stadion(7, "Azadi-Stadion", 95225, "Teheran", "IRN", new DateTime(1973, 10, 18));
			yield return new Stadion(8, "Camp Nou", 99354, "Barcelona", "ESP", new DateTime(1957, 9, 24));
			yield return new Stadion(9, "Allianz Arena", 75000, "München", "DEU", new DateTime(2005, 5, 30));
			yield return new Stadion(10, "Olympiastadion Berlin", 74649, "Berlin", "DEU", new DateTime(1936, 8, 1));
			yield return new Stadion(11, "ESPRIT arena", 54600, "Düsseldorf", "DEU", new DateTime(2005, 1, 18));
			yield return new Stadion(12, "Aztekenstadion", 105000, "Mexiko-Stadt", "MEX", null);
			yield return new Stadion(13, "Wildparkstadion", 29699, "Karlsruhe", "DEU", null);
			yield return new Stadion(14, "Stadion Erster Mai", 150000, "Pjöngjang", "PRK", new DateTime(1989, 5, 1));
			yield return new Stadion(15, "WWK Arena", 30660, "Augsburg", "DEU", new DateTime(2009, 7, 26));
			yield return new Stadion(16, "Continental Arena", 15224, "Regensburg", "DEU", new DateTime(2015, 7, 18));
			yield return new Stadion(17, "Städtisches Stadion an der Grünwalder Straße", 12500, "München", "DEU", new DateTime(1911, 5, 21));
			yield return new Stadion(18, "Olympiastadion München", 69250, "München", "DEU", new DateTime(1972, 5, 26));
			yield return new Stadion(19, "Veltins-Arena", 62271, "Gelsenkirchen", "DEU", new DateTime(2001, 8, 13));
			yield return new Stadion(20, "Atatürk-Olympiastadion", 83000, "Istanbul", "TUR", new DateTime(2002, 7, 31));
			yield return new Stadion(21, "Giuseppe-Meazza-Stadion", 80018, "Mailand", "ITA", new DateTime(1926, 9, 19));
			yield return new Stadion(22, "Stadio San Paolo", 60240, "Neapel", "ITA", new DateTime(1959, 12, 6));
			yield return new Stadion(23, "Old Trafford", 76312, "Manchester", "GBR", null);
			yield return new Stadion(24, "Olympiastadion Rom", 72698, "Rom", "ITA", null);
			yield return new Stadion(25, "Emirates Stadium", 60338, "London", "GBR", new DateTime(2006, 8, 19));
			yield return new Stadion(26, "Stadio San Nicola", 58248, "Bari", "ITA", null);
			yield return new Stadion(27, "Olympiastadion Barcelona", 55926, "Barcelona", "ESP", new DateTime(1929, 5, 20));
			yield return new Stadion(28, "Estadio Vicente Calderón", 55005, "Madrid", "ESP", new DateTime(1966, 10, 2));
			yield return new Stadion(29, "Hangzhou-Dragon-Stadion", 51139, "Hangzhou", "CHN", null);
			yield return new Stadion(30, "Estadio Mestalla", 52602, "Valencia", "ESP", new DateTime(1923, 5, 20));
		}
	}
}
