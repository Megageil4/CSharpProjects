using Demo.DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Demo.DependencyInjection.Data;

public class CsvStadionReader : IStadionReader
{
	private string _dateiPfad;

	public CsvStadionReader()
	{
		_dateiPfad = Path.Combine(AppContext.BaseDirectory, @"Stadion.csv");
	}
	public List<Stadion> LadenStadien(string land)
	{
		var stadien = new List<Stadion>();
		bool istErsteZeile = true;
		foreach (var zeile in File.ReadAllLines(_dateiPfad, Encoding.UTF8))
		{
			if (istErsteZeile)
			{
				istErsteZeile = false;
				continue; // Überschriften in der Datei ignorieren
			}
			var teile = zeile.Split(',');
			if (!(teile[4].ToUpperInvariant() == land.ToUpperInvariant() || land == String.Empty))
			{
				continue;
			}

			Stadion stadion = new()
			{
				Id = int.Parse(teile[0]),
				Bezeichnung = teile[1],
				Kapazitaet = Convert.ToInt32(teile[2], CultureInfo.InvariantCulture),
				Stadt = teile[3],
				Land = teile[4],
				Eroeffnung = String.IsNullOrWhiteSpace(teile[5]) ? null : DateTime.ParseExact(teile[5], "yyyy-mm-dd", CultureInfo.InvariantCulture)
			};

			stadien.Add(stadion);
		}
		return stadien;
	}
}
