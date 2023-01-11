using Devisenrechner.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Devisenrechner.DataAccess
{
	public class DevisenCsvRepository : IDevisenRepository
	{
		public event EventHandler? Einlesen;
		public event EventHandler<FehlerEventArgs>? Lesefehler;
		public event EventHandler<EingelesenEventArgs>? Eingelesen;
		private List<Waehrung>? waehrungen;

		public string Pfad { get; }

		public DevisenCsvRepository(string pfad)
		{
			Pfad = pfad;
		}

		public IEnumerable<Waehrung> GetAll()
		{
			if (waehrungen is null)
			{
				LoadFromCSV();
			}
		}

		public Waehrung? GetByKuerzel(string kuerzel)
		{
			if (waehrungen is null)
			{
				LoadFromCSV();
			}
		}

		private void LoadFromCSV()
		{
			waehrungen = new();
			foreach (var line in File.ReadAllLines(Pfad))
			{
				string[] fields = line.Split(",");
				waehrungen.Add(new Waehrung(
						fields[0],
						fields[1],
						fields[2],
						decimal.Parse(fields[3]),
						DateTime.Parse(fields[4])
					));
			}
		}
	}
}
