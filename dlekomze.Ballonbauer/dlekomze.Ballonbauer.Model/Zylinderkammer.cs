using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Ballonbauer.Model
{
	public class Zylinderkammer : Kammer
	{ 
		public double Radius { get; set; }
		public double Hoehe { get; set; }

		public Zylinderkammer(Gas fuellGas, double radius, double hohe)
			: base(fuellGas)
		{
			Radius = radius;
			Hoehe = hohe;
		}
		public Zylinderkammer(double radius, double hohe) 
			: this(Gas.Luft, radius, hohe) {}

		protected override double BerechneVolumen()
		{
			return Math.Pow(Radius,2) * Math.PI * Hoehe;
		}
	}
}
