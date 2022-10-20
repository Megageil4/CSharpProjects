using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Ballonbauer.Model
{
	public abstract class Kammer
	{
		public Gas FuellGas { get; set; }

		public double Volumen
		{
			get { return BerechneVolumen(); }
		}

		public double Masse
		{
			get { return FuellGas.Dichte * Volumen; }
		}


		protected Kammer(Gas fuellGas)
		{
			FuellGas = fuellGas;
		}

		protected abstract double BerechneVolumen();
	}
}
