using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitenMitEFCore.Entity
{
	public class Arbeitsgruppe
	{
		public int ID { get; set; }
		
		[StringLength(50)]
		public string Bezeichnung { get; set; }

		public List<Schueler> SchuelerSet { get; }

		public Arbeitsgruppe()
		{
			Bezeichnung = string.Empty;
			SchuelerSet = new();
		}
	}
}
