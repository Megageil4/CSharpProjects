using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Fuhrpark
{
	public class Fahrrad : Fahrzeug
	{
		public int Kaufjahr { get; private set; }
		public string Farbe { get; set; }
		private int _anzahlGaenge;

		public int AnzahlGaenge
		{
			get { return _anzahlGaenge; }
			set { _anzahlGaenge = Math.Clamp(value,1,30); }
		}

		private int _aktuellerGang;

		public int AktuellerGang
		{
			get { return _aktuellerGang; }
			set { _aktuellerGang = Math.Clamp(value,1,30); }
		}


		public Fahrrad(string hersteller, string typ, int listenpreis, int kaufjahr, string farbe, int anzahlGaenge) : base(hersteller, typ, listenpreis)
		{
			this.Kaufjahr = kaufjahr;
			this.Farbe = farbe;
			this.AnzahlGaenge = anzahlGaenge;
			AktuellerGang = 1;
		}

		public void Hochschalten()
		{
			AktuellerGang++;
		}

		public void Herrunterschalten()
		{
			AktuellerGang--;
		}

		public override int BerechneWert(int jahr)
		{
			int preis = Listenpreis;
			int alter = Kaufjahr - jahr;

			for (int i = 0; i < alter; i++)
			{
				if (preis - (preis * 0.05) < Listenpreis * 0.4)
				{
					break;
				}
				preis -= (int)(preis * 0.05);
			}

			return preis;
		}
	}
}
