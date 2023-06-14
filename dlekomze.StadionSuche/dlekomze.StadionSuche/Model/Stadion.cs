using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.StadionSuche.Model
{
	public class Stadion
	{
		public int Id { get; set; }
		public string Bezeichnung { get; set; }
		public int Kapazitaet { get; set; }
		public string Stadt { get; set; }
		public string Land { get; set; }
		public DateTime? Eroeffnung { get; set; }
	}
}
