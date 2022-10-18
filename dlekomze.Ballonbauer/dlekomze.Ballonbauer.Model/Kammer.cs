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

		private double _volumen;
		public double Volumen
		{
			get { return _volumen; }
		}

		protected Kammer(Gas fuellGas = Gas.Luft, double volumen)
		{
			FuellGas = fuellGas;
			_volumen = volumen;
		}

		protected abstract double BerechneVolumen();
	}
}
