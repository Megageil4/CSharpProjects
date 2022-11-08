using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerwendenVonIComparer.Model;

namespace VerwendenVonIComparer.Comparer
{
	public class JahrTitelComparer : IComparer<Film>
	{
		public int Compare(Film? x, Film? y)
		{
			int result = 0;
			if (x != null && y != null)
			{
				result = x.Erscheinungsjahr.CompareTo(y.Erscheinungsjahr);
				if (result == 0)
				{
					result = x.Titel.CompareTo(y.Titel);
				}
			}
			else if (x == null && y != null)
			{
				result = - 1;
			}
			else if (x != null && y == null)
			{
				result = 1;
			}
			return result;
		}
	}
}
