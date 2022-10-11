using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Fuhrpark
{
	public class Cabrio : Auto
	{
		public bool IstVerdeckOffen { get; private set; }

		public Cabrio(string hersteller, string typ, int zulassungsjahr, int listenpreis, int maximalGeschwindigkeit) 
			: base(hersteller, typ, zulassungsjahr, listenpreis, maximalGeschwindigkeit)
		{
			_anfahrtsbeschleunigung = 4;
			_bremsbeschleunigung = 7;
			IstVerdeckOffen = false;
		}

		public void OeffnenVerdeck()
		{
			IstVerdeckOffen = true;
		}
		public void SchliessenVerdeck()
		{
			IstVerdeckOffen = false;
		}

		public override int BerechneWert(int alter)
		{
			int preis = Listenpreis;
			for (int i = 0; i < alter; i++)
			{
				int valueLoss = 0;
				if (alter <= 10)
				{
					valueLoss = 8;
				}
				else if (alter <= 20)
				{
					valueLoss = 6;
				}

				preis -= (int)Math.Ceiling(preis * (valueLoss / 100M));
			}
			return preis;
		}
	}
}
