using System.ComponentModel.DataAnnotations;

namespace dlekomze.BergInfo.Entity
{
	public class Berg
	{
		#region Properties
		public int ID { get; set; }
		[StringLength(30)]
		public string Name { get; set; }
		[Range(0, 10000)]
		public int Hoehe { get; set; }
		public DateTime? Ersbesteigung { get; set; }
		#endregion

		#region Konstruktoren

		public Berg(int iD, string name, int hoehe, DateTime? erstbesteigung)
		{
			ID = iD;
			Name = name;
			Hoehe = hoehe;
			Ersbesteigung = erstbesteigung;
		}

		public Berg() : this(default, string.Empty, default, null) { } 
		#endregion
	}
}