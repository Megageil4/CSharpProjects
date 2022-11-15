using Notenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenverwaltung.DataAccess
{
	public class FileZensurenRepository : IZensurenRepository
	{
		private List<Zensur> _zensuren;
		public string DataiPfad { get; }

		public FileZensurenRepository(string dataiPfad)
		{
			DataiPfad = dataiPfad;
			_zensuren = new();
			LoadZensuren();
		}

		public void Add(Zensur zensur)
		{
			_zensuren.Add(zensur);
		}

		public IEnumerable<Zensur> GetAll()
		{ 
			foreach (var zensur in _zensuren)
			{
				yield return zensur;
			}
		}

		private void LoadZensuren()
		{
			string lastSubj = "";
			foreach (var line in File.ReadAllLines(DataiPfad))
			{
				string[] fields = line.Split(":");
				if (fields[0] == "1" && fields[1] != lastSubj)
				{
					lastSubj = fields[1];
					continue;
				}
				DateTime date = DateTime.ParseExact(fields[1].Substring(0, 8), "ddmmyyyy", System.Globalization.CultureInfo.CurrentCulture);
				int note = int.Parse(fields[1].Substring(11));
				Leistungsart la = Enum.Parse<Leistungsart>(fields[1].Substring(8, 3));
				Add(new Zensur(lastSubj,date, note, la));
			}
		}

		public void SaveChanges()
		{
			_zensuren.Sort();
			string text = "";
			string lastSubj = "";
			foreach (var zensur in _zensuren)
			{
				if (zensur.Fach != lastSubj)
				{
					lastSubj = zensur.Fach;
					text += $"1:{lastSubj}{Environment.NewLine}";
				}
				text += $"2:{zensur.Datum.Day:D2}{zensur.Datum.Month:D2}{zensur.Datum.Year}{zensur.Art,-3}{zensur.Note}{Environment.NewLine}";
			}
			File.WriteAllText(DataiPfad,text);
		}
	}
}
