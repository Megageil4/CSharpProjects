using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.AbstrakteKlassen
{
	public class Kreis : Form
	{
		public double Radius { get; set; }

		public Kreis(double posX, double posY, double radius) : base(posX, posY)
		{
			Radius = radius;
		}

		public override double BerechnenFlaeche()
		{
			return Radius * Radius * Math.PI;
		}

		public override double BerechnenUmfang()
		{
			return 2 * Radius * Math.PI;
		}
	}
}
