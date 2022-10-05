using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Fuhrpark
{
	public class Auto
	{
		#region Felder
		private int _geschwindigkeit = 0;
		protected int _anfahrtsbeschleunigung = 6;
		protected int _bremsbeschleunigung = 10;
		#endregion
		
		#region Eigentschaften
		public string Hersteller { get; private set; }
		public string Typ { get; private set; }
		public int Zulassungsjahr { get; private set; }
		public int Listenpreis { get; private set; }
		public int MaximalGeschwindigkeit { get; private set; }

		public int Reaktionsweg
		{
			get { return 0; }
		}

		public int Bremsweg
		{	
			get { return 0; }
		}

		public int Anhalteweg
		{
			get { return 0; }
		}

		public Auto(string hersteller, string typ, int zulassungsjahr, int listenpreis, int maximalGeschwindigkeit)
		{
			Hersteller = hersteller;
			Typ = typ;
			Zulassungsjahr = zulassungsjahr;
			Listenpreis = listenpreis;
			MaximalGeschwindigkeit = maximalGeschwindigkeit;
		}
		#endregion

		#region Konstruktoren

		#endregion
	}
}
