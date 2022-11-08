using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.ArbeitenMitInterfaces
{
	public class FlexiblerNotenGenerator : INotenGenerator
	{
		public int Untergrenze { get; set; }
		public int Obergrenze { get; set; }

		public FlexiblerNotenGenerator(int untergrenze, int obergrenze)
		{
			Untergrenze = untergrenze;
			Obergrenze = obergrenze;
		}

		public FlexiblerNotenGenerator() : this(1, 6) { }

		public IEnumerable<int> GenerierenNoten(int anzahl)
		{
			Random random = new(Environment.TickCount);
			for (int i = 0; i < anzahl; i++)
			{
				yield return random.Next(Untergrenze, Obergrenze + 1);
			}
		}
	}
}

