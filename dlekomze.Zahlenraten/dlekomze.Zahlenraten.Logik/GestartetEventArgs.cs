using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Zahlenraten.Logik
{
	public class GestartetEventArgs : EventArgs
	{
		public int Untergrenze { get; set; }
		public int Obergrenze { get; set; }
		public int MaxVersuche { get; set; }

		public GestartetEventArgs(int untergrenze, int obergrenze, int maxVersuche)
		{
			Untergrenze = untergrenze;
			Obergrenze = obergrenze;
			MaxVersuche = maxVersuche;
		}
	}
}
