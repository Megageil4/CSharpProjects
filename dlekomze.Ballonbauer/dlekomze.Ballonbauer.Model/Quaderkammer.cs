using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Ballonbauer.Model
{
	public class Quaderkammer : Kammer
	{
		public double Laenge { get; set; }
		public double Breite { get; set; }
		public double Hoehe { get; set; }

		public Quaderkammer(Gas fuellGas, double laenge, double breite, double hoehe) 
			: base(fuellGas)
		{
			Laenge = laenge;
			Breite = breite;
			Hoehe = hoehe;
		}
		public Quaderkammer(double laenge, double breite, double hoehe) : base()
		{
			Laenge = laenge;
			Breite = breite;
			Hoehe = hoehe;
		}

		protected override double BerechneVolumen()
		{
			return Laenge * Breite * Hoehe;
		}
	}
}
