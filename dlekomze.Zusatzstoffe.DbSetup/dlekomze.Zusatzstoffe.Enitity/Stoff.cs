using System.ComponentModel.DataAnnotations;

namespace dlekomze.Zusatzstoffe.Enitity;

public class Stoff
{
	public int ID { get; set; }
	[StringLength(50)]
	public string Bezeichnung { get; set; }
	public string Beschreibung { get; set; }
	public bool Genetechnik { get; set; }
	public bool Nanotechnik { get; set; }
	public List<Herkunft> HerkunftSet { get; set; }
	public List<Verwendung> VerwendungSet { get; set; }
	public int BewertungID { get; set; }
	public Bewertung? BewertungNavigation { get; set; }

	public Stoff(int iD, string bezeichnung, string beschreibung, bool genetechnik, bool nanotechnik, int bewertungID, Bewertung? bewertungNavigation)
	{
		ID = iD;
		Bezeichnung = bezeichnung;
		Beschreibung = beschreibung;
		Genetechnik = genetechnik;
		Nanotechnik = nanotechnik;
		BewertungID = bewertungID;
		BewertungNavigation = bewertungNavigation;
		HerkunftSet = new List<Herkunft>();
		VerwendungSet = new List<Verwendung>();
	}

	public Stoff() : this(default,string.Empty,string.Empty,default,default,default,default) { }
}
