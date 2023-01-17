namespace CodeSnippetsErstellen;

public class Person
{
	public string Nachname { get; set; }

	private string _vorname;

	public string Vorname
	{
		get { return _vorname; }
		set { _vorname = value; }
	}

}
