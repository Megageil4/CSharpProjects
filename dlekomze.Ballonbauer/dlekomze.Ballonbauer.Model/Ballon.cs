using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dvs.Utils;
using System.Collections.Generic;

namespace dlekomze.Ballonbauer.Model
{
	public class Ballon
	{
		private static Sequence _sequence;

		public int SerienNr{ get; private set; }

		public List<Kammer> Kammern { get; private set; }

		public double Volumen
		{
			get 
			{
				double volumen = 0;
				foreach (var kammer in Kammern)
				{
					volumen += kammer.Volumen;
				}
				return Math.Round(volumen,2, MidpointRounding.AwayFromZero);
			}
		}

		public double Masse
		{
			get
			{
				double masse = 0;
				foreach (var kammer in Kammern)
				{
					masse += kammer.Masse;
				}
				return Math.Round(masse,2, MidpointRounding.AwayFromZero);
			}
		}


		public Ballon()
		{
			SerienNr = _sequence.NextValue();
			Kammern = new();
		}

		static Ballon()
		{
			_sequence = new Sequence(111, 1);
		}

		public override string ToString()
		{
			return $"Ballon {SerienNr} ({Kammern.Count} Kammern | {Volumen} cbm | {Masse} kg)";
		}
	}
}
