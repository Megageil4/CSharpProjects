using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.Fuhrpark
{
	public class Cabrio : Auto
	{
		private override int _anfahrtsbeschleunigung;
		private override int _bremsbeschleunigung;
		public bool IstVerdeckOffen { get; private set; }

		public Cabrio(string hersteller, string typ, int zulassungsjahr, int listenpreis, int maximalGeschwindigkeit) 
			: base(hersteller, typ, zulassungsjahr, listenpreis, maximalGeschwindigkeit)
		{
			
		}
	}
}
