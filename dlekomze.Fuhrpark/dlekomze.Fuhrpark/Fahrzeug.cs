using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Fuhrpark
{
	public abstract class Fahrzeug
	{
		public string Hersteller { get; set; }
		public string Typ { get; set; }
		public int Listenpreis { get; set; }

		protected Fahrzeug(string hersteller, string typ, int listenpreis)
		{
			Hersteller = hersteller;
			Typ = typ;
			Listenpreis = listenpreis;
		}

		public abstract int BerechneWert(int jahr);
		public int BerechneWert()
		{
			return BerechneWert(DateTime.Today.Year);
		}
	}
}
