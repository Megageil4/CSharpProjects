using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerwendenVonIComparer.Model;

namespace VerwendenVonIComparer.Comparer
{
	public class EinspieleregebnissComparer : IComparer<Film>
	{
		public bool Desc { get; set; }

		public EinspieleregebnissComparer(bool desc = false)
		{
			Desc = desc;
		}

		public int Compare(Film? x, Film? y)
		{
			int result = 0;
			if (x != null && y != null)
			{
				result = x.Einspielergebnis.CompareTo(y.Einspielergebnis);
			}
			else if (x == null && y != null)
			{
				result = -1;
			}
			else if (x != null && y == null)
			{
				result = 1;
			}
			return Desc ? result * -1 : result;
		}
	}
}
