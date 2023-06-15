namespace dlekomze.UnitTesting.BL
{
	public class Produkt
	{
        public string Bezeichnung { get; set; }
        public decimal Verkaufspreis { get; set; }

		public Produkt()
		{
			Bezeichnung = string.Empty;
		}

		public decimal BerechneSteuer()
		{
			return Verkaufspreis / 119;
		}
	}
}