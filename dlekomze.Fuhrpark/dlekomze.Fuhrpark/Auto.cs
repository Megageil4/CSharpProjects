using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Fuhrpark
{
	public class Auto : Fahrzeug
	{
		#region Felder
		private int _geschwindigkeit;
		protected int _anfahrtsbeschleunigung;
		protected int _bremsbeschleunigung;
		#endregion
		
		#region Eigentschaften
		public int Zulassungsjahr { get; private set; }
		public int MaximalGeschwindigkeit { get; private set; }

		public int Reaktionsweg
		{
			get { return (int)(_geschwindigkeit / 10.0 * 3.0); }
		}

		public int Bremsweg
		{	
			get { return (int)Math.Pow((_geschwindigkeit / 10.0),2); }
		}

		public int Anhalteweg
		{
			get { return Reaktionsweg + Bremsweg; }
		}

		#endregion

		#region Konstruktoren
		public Auto(string hersteller, string typ, int zulassungsjahr, int listenpreis, int maximalGeschwindigkeit) : base(hersteller,typ,listenpreis)
		{
			Hersteller = hersteller;
			Typ = typ;
			Zulassungsjahr = zulassungsjahr;
			Listenpreis = listenpreis;
			MaximalGeschwindigkeit = maximalGeschwindigkeit;

			_geschwindigkeit = 0;
			_anfahrtsbeschleunigung = 6;
			_bremsbeschleunigung = 10;
		}
		#endregion

		#region Methoden
		public void Beschleunigen(int dauer)
		{
			_geschwindigkeit = Math.Clamp(_geschwindigkeit + _anfahrtsbeschleunigung * dauer,
										  0, MaximalGeschwindigkeit);
		}

		public void Bremsen(int dauer)
		{
			_geschwindigkeit = Math.Clamp(_geschwindigkeit - _bremsbeschleunigung * dauer,
										  0, MaximalGeschwindigkeit);
		}

		public override int BerechneWert(int jahr)
		{
			int preis = Listenpreis;
			int alter = jahr - Zulassungsjahr;

			for (int i = 0; i < alter; i++)
			{
				preis -= (int)Math.Ceiling(preis * 0.12M);
			}

			return preis;
		}
		#endregion
	}
}
