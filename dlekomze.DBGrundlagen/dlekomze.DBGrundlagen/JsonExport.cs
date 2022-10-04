using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace dlekomze.DBGrundlagen
{
	public class JsonExport
	{
		public static void SpeichernArtikelliste(string dateipfad, List<Artikel> artikelliste)
		{
			byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(artikelliste);
			File.WriteAllBytes(dateipfad, jsonUtf8Bytes);
		}

		public static List<Artikel> ArtikelEinlesen(string dateipfad)
		{
			return JsonSerializer.Deserialize<List<Artikel>>(File.ReadAllText(dateipfad)) ?? new List<Artikel>();
		}
	}
}
