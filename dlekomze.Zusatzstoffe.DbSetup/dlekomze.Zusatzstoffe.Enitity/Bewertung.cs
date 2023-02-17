using System.ComponentModel.DataAnnotations;

namespace dlekomze.Zusatzstoffe.Enitity;

public class Bewertung
{
	public int ID { get; set; }
	[StringLength(50)]
	public string Bezeichnung { get; set; }

	public Bewertung(int iD, string bezeichnung)
	{
		ID = iD;
		Bezeichnung = bezeichnung;
	}

	public Bewertung() : this(default,string.Empty) { }
}
