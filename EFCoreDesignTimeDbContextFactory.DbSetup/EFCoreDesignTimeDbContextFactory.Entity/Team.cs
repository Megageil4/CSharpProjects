using System.ComponentModel.DataAnnotations;

namespace EFCoreDesignTimeDbContextFactory.Entity;

public class Team
{

	public int Id { get; set; }
	[StringLength(50)]
	public string Bezeichnung { get; set; }

	#region Konstruktoren
	public Team(string bezeichnung)
	{
		Bezeichnung = bezeichnung;
	}
	public Team() : this(String.Empty) { }
	#endregion
}