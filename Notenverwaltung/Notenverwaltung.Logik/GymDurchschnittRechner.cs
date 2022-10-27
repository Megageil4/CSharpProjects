using Notenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenverwaltung.Logik
{
	public class GymDurchschnittRechner : IDurchschnittRechner
	{
		public double BerechnenDurchschnitt(IEnumerable<Zensur> zensuren)
		{
			double[] sa = new double[2];
			double[] andere = new double[2];
			foreach (var note in zensuren)
			{
				if (note.Art == Leistungsart.SA)
				{
					sa[0] += note.Note;
					sa[1]++;
				}
				else
				{
					andere[0] += note.Note;
					andere[1]++;
				}
			}
			return Math.Round(sa[0] == 0 ?
					andere[0] / andere[1] :
					andere[0] == 0 ?
						sa[0] / sa[1] :
						(2 * (sa[0] / sa[1]) + andere[0] / andere[1]) / 3.0,2,MidpointRounding.AwayFromZero);
		}
	}
}
