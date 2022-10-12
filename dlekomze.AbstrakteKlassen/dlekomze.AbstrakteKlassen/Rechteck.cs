using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.AbstrakteKlassen
{
	public class Rechteck : Form
	{
		public double Laenge { get; set; }
		public double Breite { get; set; }

		public Rechteck(double posX, double posY, double laenge, double breite) : base(posX, posY)
		{
			Laenge = laenge;
			Breite = breite;
		}

		public override double BerechnenFlaeche()
		{
			return Laenge * Breite;
		}

		public override double BerechnenUmfang()
		{
			return 2 * (Laenge + Breite);
		}
	}
}
