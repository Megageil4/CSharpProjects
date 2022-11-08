namespace dlekomze.ArbeitenMitInterfaces
{
	public class NotenGenerator : INotenGenerator
	{
		public IEnumerable<int> GenerierenNoten(int anzahl)
		{
			List<int> noten = new();
			Random random = new(Environment.TickCount);
			for (int i = 0; i < anzahl; i++)
			{
				noten.Add(random.Next(1, 7));
			}
			return noten;
		}
	}
}
