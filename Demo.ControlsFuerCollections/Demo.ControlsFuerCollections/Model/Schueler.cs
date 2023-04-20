namespace Demo.ControlsFuerCollections.Model;
#nullable enable
public class Schueler
{
	public int Id { get; set; }
	public string Nachname { get; set; }

	public string Vorname { get; set; }
	public string? Klasse { get; set; }

	public Schueler()
	{
		Nachname=string.Empty;
		Vorname=string.Empty;	
	}

}
