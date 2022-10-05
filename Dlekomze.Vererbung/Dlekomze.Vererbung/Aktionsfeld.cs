using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlekomze.Vererbung
{
	public class Aktionsfeld : Spielfeld
	{
		#region Eigentschaften
		public string Aktion { get; set; }
		#endregion

		#region Konstruktoren
		public Aktionsfeld(int nr, int posX, int posY, string aktion)
			: base(nr, posX, posY)
		{
			Aktion = aktion;
			feldFuerAbgelteiteteKlassen = "Ich bin ein Aktionsfeld";
		}
		public Aktionsfeld() : this(default,default,default,String.Empty) {}
		#endregion

		#region Methoden
		public override string AusgebenSvg()
		{
			return $"Aktionsfeld: {Aktion} ({base.ToString()})";
		}
		#endregion
	}
}
