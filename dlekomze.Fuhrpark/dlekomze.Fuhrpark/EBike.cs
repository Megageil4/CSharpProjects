using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Fuhrpark
{
	public class EBike : Fahrrad
	{
		public int MaximalDrehmoment { get; set; }
		public bool IstMotorAn { get; private set; }
		public EBike(string hersteller, string typ, int listenpreis, int kaufjahr, string farbe, int anzahlGaenge, int maximalDrehmoment) 
			: base(hersteller, typ, listenpreis, kaufjahr, farbe, anzahlGaenge)
		{
			MaximalDrehmoment = maximalDrehmoment;
			IstMotorAn = false;
		}

		public void Einschalten()
		{
			IstMotorAn = true;
		}
		public void Ausschalten()
		{
			IstMotorAn = false;
		}
	}
}
