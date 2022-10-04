using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace dlekomze.DBGrundlagen
{
	public class Datenbank
	{
		private string? _connectionString;
		public Datenbank(string servername, string datenbankname, string benutzername,
						 string passwort)
		{
			_connectionString = $"Data Source={servername};Initial Catalog={datenbankname};" +
								$"User ID={benutzername};Password={passwort};TrustServerCertificate=True";
		}

		public List<Artikel> AlleArtikel()
		{
			List<Artikel> artikel = new List<Artikel>();
			using (SqlConnection connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var cmd = connection.CreateCommand();
				cmd.CommandText = "SELECT artikelid,code,bezeichnung," +
								  "verkaufspreis,wgrid,imAngebotSeit," +
								  "preisErhoehtAm,lagerbestand FROM beispiele.artikel";
				var reader = cmd.ExecuteReader();
				ReadArtikel(artikel,reader);
				connection.Close();
			}
			return artikel;
		}

		public List<Artikel> ArtikelDerWarengruppe(int wgrid)
		{
			List<Artikel> artikel = new List<Artikel>();
			using (SqlConnection connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var cmd = connection.CreateCommand();
				cmd.CommandText = "SELECT artikelid,code,bezeichnung," +
								  "verkaufspreis,wgrid,imAngebotSeit," +
								  "preisErhoehtAm,lagerbestand FROM beispiele.artikel " +
								  "WHERE wgrid = @wgrid";
				cmd.Parameters.AddWithValue("wgrid", wgrid);
				var reader = cmd.ExecuteReader();
				ReadArtikel(artikel, reader);
				connection.Close();
			}
			return artikel;
		}

		private static void ReadArtikel(List<Artikel> artikel, SqlDataReader reader)
		{
			while (reader.Read())
			{
				Artikel art = new Artikel(
					reader.GetInt32(0),
					reader.GetString(1),
					reader.GetString(2),
					reader.GetDecimal(3),
					reader.IsDBNull(4) ? null : reader.GetInt32(4),
					reader.GetDateTime(5),
					reader.IsDBNull(6) ? null : reader.GetDateTime(6),
					reader.IsDBNull(7) ? null : reader.GetInt32(7)
					);
				artikel.Add(art);
			}
		}

		public void AendernVerkaufspreis(int artikelID, decimal neuerVerkaufspreis)
		{
			using (SqlConnection connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var cmd = connection.CreateCommand();
				cmd.CommandText = "UPDATE beispiele.artikel " +
								  "SET verkaufspreis = @vp, " +
								  "preisErhoehtAm = @pem " +
								  "WHERE artikelId = @aid";
				cmd.Parameters.AddWithValue("vp", neuerVerkaufspreis);
				cmd.Parameters.AddWithValue("pem", DateTime.Now);
				cmd.Parameters.AddWithValue("aid", artikelID);
				var reader = cmd.ExecuteNonQuery();
			}
		}

		//public void AddArtikel(Artikel artikel)
		//{
		//		
		//}
	}
}
