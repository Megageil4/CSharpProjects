using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.TankenApp.Model
{
	public class Tankbeleg
	{
		public int TankbelegID { get; set; }
		public DateTime Datum { get; set; }
		public double Kilometerstand { get; set; }
		public double GefahreneKilometer { get; set; }
		public double Preis { get; set; }
		public double Liter { get; set; }
	}
}
