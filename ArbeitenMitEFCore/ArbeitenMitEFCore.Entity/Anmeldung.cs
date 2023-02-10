using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitenMitEFCore.Entity
{
	public class Anmeldung
	{
		public int SchuelerId { get; set; }
		public int VortragId { get; set; }
		public Schueler? SchuelerNavigation { get; set; }
		public Vortrag? VortragNavigation { get; set; }
		public DateTime Anmeldezeitpunkt { get; set; }
	}
}
