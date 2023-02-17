using System.ComponentModel.DataAnnotations;

namespace dlekomze.Zusatzstoffe.Enitity;

public class Herkunft
{
	public int ID { get; set; }
	[StringLength(50)]
	public string Bezeichnung { get; set; }
	public List<Stoff> StoffSet { get; set; }

	public Herkunft(int iD, string bezeichnung)
	{
		ID = iD;
		Bezeichnung = bezeichnung;
		StoffSet = new List<Stoff>();
	}

	public Herkunft() : this(default, string.Empty) { }
}
