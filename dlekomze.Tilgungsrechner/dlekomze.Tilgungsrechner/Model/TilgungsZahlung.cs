using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Tilgungsrechner.Model
{
	public class TilgungsZahlung
	{
		public int Jahr { get; set; }
		public decimal AnfangsRestschulden { get; set; }
		public decimal Zinsen { get; set; }
		public decimal Tilgung { get; set; }
		public decimal Annuitaet { get; set; }
		public decimal Restschulden { get => AnfangsRestschulden - Tilgung; }

		public TilgungsZahlung(int jahr, decimal anfangsRestschulden, decimal zinsen, decimal tilgung, decimal annuitaet)
		{
			Jahr = jahr;
			AnfangsRestschulden = anfangsRestschulden;
			Zinsen = zinsen;
			Tilgung = tilgung;
			Annuitaet = annuitaet;
		}
	}
}
