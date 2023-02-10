using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitenMitEFCore.Entity
{
	public class Vortrag
	{
		public int ID { get; set; }
		[StringLength(50)]
		public string Bezeichnung { get; set; }
		public List<Anmeldung> AnmeldungSet { get; set; }

		public Vortrag(int iD, string bezeichnung)
		{
			ID = iD;
			Bezeichnung = bezeichnung;
			AnmeldungSet = new();
		}

		public Vortrag() : this(default,string.Empty) {}
	}
}
