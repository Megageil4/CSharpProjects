using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitenMitEreignissen
{
	public class Rechner
	{
		public event EventHandler? BerechnungGestarted;
		public event EventHandler? BerechnungBeendet;
		public long BerechnenSumme(int untergrenze, int obergrenze)
		{
			OnBerechnungGestarted();
			long summe = 0;
			for (int i = 0; untergrenze <= obergrenze; i++)
			{
				summe += i;
				Thread.Sleep(1000);
			}
			OnBerechnungBeendet();
			return summe;
		}

		protected virtual void OnBerechnungBeendet()
		{
			BerechnungBeendet?.Invoke(this, EventArgs.Empty);
		}

		protected virtual void OnBerechnungGestarted()
		{
			BerechnungGestarted?.Invoke(this, EventArgs.Empty);
		}
	}
}
