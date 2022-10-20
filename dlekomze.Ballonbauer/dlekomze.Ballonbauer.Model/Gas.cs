namespace dlekomze.Ballonbauer.Model
{
	public class Gas
	{
		public static Gas Luft
		{
			get { return new Gas("Luft", 1.293); }
		}

		public static Gas Helium
		{
			get { return new Gas("Helium", 0.1785); }
		}

		public string Name { get; set; }
		public double Dichte { get; set; }

		public Gas(string name, double dichte)
		{
			Name = name;
			Dichte = dichte;
		}
	}
}