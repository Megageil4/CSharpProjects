using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.DBGrundlagen
{
	public class Artikel
	{
		public int ArtikelId { get; set; }
		public string? Code { get; set; }
		public string? Bezeichnung { get; set; }
		public decimal Verkaufspreis { get; set; }
		public int Wgrid { get; set; }
		public DateTime ImAngebotSeit { get; set; }
		public DateTime? PreisErhoetAm { get; set; }
		public int Lagerbestand { get; set; }

		public Artikel(int artikelId, string? code, string? bezeichnung, decimal verkaufspreis, int wgrid, DateTime imAngebotSeit, DateTime? preisErhoetAm, int lagerbestand)
		{
			ArtikelId = artikelId;
			this.Code = code;
			Bezeichnung = bezeichnung;
			Verkaufspreis = verkaufspreis;
			this.Wgrid = wgrid;
			this.ImAngebotSeit = imAngebotSeit;
			this.PreisErhoetAm = preisErhoetAm;
			this.Lagerbestand = lagerbestand;
		}

		public Artikel() 
		: this(0,"0","A",0,0,DateTime.Now,DateTime.Now,0) { }
	
		public Artikel(int artikelId, string? code, string? bezeichnung, decimal verkaufspreis, DateTime imAngebotSeit)
		:this(artikelId, code, bezeichnung, verkaufspreis, 0, imAngebotSeit,null, 0) {}
	}
}
