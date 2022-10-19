using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Ballonbauer.Model
{
	public class Kugelkammer : Kammer
	{
		public double Radius { get; set; }

		public Kugelkammer(Gas fuellGas, double radius) : base(fuellGas)
		{
			Radius = radius;
		}
		public Kugelkammer(double radius) : base()
		{
			Radius = radius;
		}

		protected override double BerechneVolumen()
		{
			return (4.0 / 3.0) * Math.Pow(Radius, 3) * Math.PI;
		}
	}
}
