using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlekomze.Vererbung
{
	public class Spielfeld
	{
		#region Eigenschaften
		public int Nr { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		#endregion

		#region Konstruktoren
		public Spielfeld()
		{

		}
		#endregion

		#region Methoden
		public string AusgebenSvg()
		{
			return "Spielfled";
		}
		#endregion
	}
}
