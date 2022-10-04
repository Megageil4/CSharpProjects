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
		public int PosX { get; set; }
		public int PosY { get; set; }
		#endregion

		#region Konstruktoren
		public Spielfeld()
		{

		}
		#endregion

		#region Methoden
		public virtual string AusgebenSvg()
		{
			return $"Spielfled {base.ToString()}";
		}
		#endregion
	}
}
