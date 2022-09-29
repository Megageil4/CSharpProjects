using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlekomze.Vererbung
{
	public class Aktionsfeld : Spielfeld
	{
		public string Aktion { get; set; }

		public Aktionsfeld() : base()
		{
			Aktion = String.Empty;
		}
	}
}
