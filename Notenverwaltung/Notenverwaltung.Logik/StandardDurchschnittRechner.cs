using Notenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenverwaltung.Logik
{
	public class StandardDurchschnittRechner : IDurchschnittRechner
	{
		public double BerechnenDurchschnitt(IEnumerable<Zensur> zensuren)
		{
			double sum = 0;
			double count = 0;
			foreach (var note in zensuren)
			{
				int wertung = note.Art == Leistungsart.KA ? 2 : 1;
				count += wertung;
				sum += note.Note * wertung;
			}
			return Math.Round(sum / count,2, MidpointRounding.AwayFromZero);
		}
	}
}
