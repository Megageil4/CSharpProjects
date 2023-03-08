using System.ComponentModel.DataAnnotations;

namespace dlekomze.Zusatzstoffe.Enitity;

public class Verwendung
{
	public int ID { get; set; }
	[StringLength(50)]
	public string Bezeichnung { get; set; }
	[StringLength(600)]
	public string Beschreibung { get; set; }
	public List<Stoff> StoffSet { get; set; }

	public Verwendung(int iD, string bezeichnung, string beschreibung)
	{
		ID = iD;
		Bezeichnung = bezeichnung;
		Beschreibung = beschreibung;
		StoffSet = new List<Stoff>();
	}

	public Verwendung() : this(default, string.Empty, string.Empty) { }
}
