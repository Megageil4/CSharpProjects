using System.ComponentModel.DataAnnotations;

namespace ArbeitenMitEFCore.Entity
{
	public class Fehlzeit
	{
		public int Id { get; set; }
		public DateTime Von { get; set; }
		public DateTime? Bis { get; set; }
		[StringLength(50)]
		public string? Grund { get; set; }
		public Schueler? SchuelerNavigation { get; set; }
		public int SchuelerId { get; set; }
	}
}
