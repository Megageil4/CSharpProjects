namespace dlekomze.Ballonbauer.Model
{
	public class Gas
	{
		public static readonly Gas Luft = new("Luft",1.293);
		public static readonly Gas Helium = new("Helium", 0.1785);

		public string Name { get; set; }
		public double Dichte { get; set; }

		public Gas(string name, double dichte)
		{
			Name = name;
			Dichte = dichte;
		}
	}
}