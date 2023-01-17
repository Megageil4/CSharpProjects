using Devisenrechner.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Devisenrechner.DataAccess
{
	public class DevisenCsvRepository : IDevisenRepository
	{
		public event EventHandler? Einlesen;
		public event EventHandler<FehlerEventArgs>? Lesefehler;
		public event EventHandler<EingelesenEventArgs>? Eingelesen;
		private List<Waehrung>? _waehrungen;

		public string Pfad { get; }

		public DevisenCsvRepository(string pfad)
		{
			Pfad = pfad;
		}

		public IEnumerable<Waehrung> GetAll()
		{
			if (_waehrungen == null)
			{
				_waehrungen = new();
				LoadFromCSV();
			}
			return _waehrungen;
		}

		public Waehrung? GetByKuerzel(string kuerzel)
		{
			return GetAll().Where(w => w.Kuerzel == kuerzel).First();
		}

		private void LoadFromCSV()
		{
			_waehrungen = new(); 
			string[] lines = File.ReadAllLines(Pfad);
			OnEinlesen();
			for (int i = 1; i < lines.Length; i++)
			{
				try
				{
					string[] fields = lines[i].Split(",");
					_waehrungen.Add(new Waehrung(
							fields[0],
							fields[1],
							fields[2],
							decimal.Parse(fields[3], new CultureInfo("en-GB")),
							fields[4] == "" ? null : DateTime.Parse(fields[4])
						));

				}
				catch (Exception)
				{
					OnLesefehler(lines[i]);
				}
			}
			OnEingelesen(_waehrungen.Count);
		}
		protected virtual void OnLesefehler(string zeile)
		{
			Lesefehler?.Invoke(this, new FehlerEventArgs(zeile));
		}


		protected virtual void OnEinlesen()
		{
			Einlesen?.Invoke(this, EventArgs.Empty);
		}


		protected virtual void OnEingelesen(int count)
		{
			Eingelesen?.Invoke(this, new EingelesenEventArgs(count));
		}

	}
}
