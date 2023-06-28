using Demo.DependencyInjection.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Demo.DependencyInjection.Data;

public class CsvStadionReader : IStadionReader
{
	private string _dateiPfad;

	public CsvStadionReader()
	{
		_dateiPfad = Path.Combine(AppContext.BaseDirectory, @"Stadion.csv");
	}
	public List<string> ReadCSV()
	{
		List<string> lines = new();
		bool istErsteZeile = true;
		foreach (var zeile in File.ReadAllLines(_dateiPfad, Encoding.UTF8))
		{
			if (istErsteZeile)
			{
				istErsteZeile = false;
				continue; // Überschriften in der Datei ignorieren
			}
			if (IsValidLine(zeile))
			{
				lines.Add(zeile);
			}
		}
		return lines;
	}

	public List<Stadion> ParseCSV(IEnumerable<string> csvStrings)
	{
		var stadien = new List<Stadion>();
		foreach (string zeile in csvStrings)
		{
			var teile = zeile.Split(',');

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

	public IEnumerable<Stadion> FilterByLand(IEnumerable<Stadion> stadien, Func<Stadion,bool> isInFilter)
	{
		foreach (var stadion in stadien)
		{
			if (isInFilter(stadion))
			{
				yield return stadion;
			}
		}
	} 

	private bool IsValidLine(string line)
	{
		return !(string.IsNullOrEmpty(line)
			  || string.IsNullOrWhiteSpace(line)
			  || line.StartsWith("/"));
	}

	public List<Stadion> LadenStadien(string land)
	{
		List<string> lines = ReadCSV();
		List<Stadion> stadien = ParseCSV(lines);
		stadien = FilterByLand(stadien,land);
		return stadien;
	}
}
