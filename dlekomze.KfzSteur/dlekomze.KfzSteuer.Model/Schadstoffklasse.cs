using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.KfzSteuer.Model
{
	public class Schadstoffklasse
	{
		public string Name { get; set; }
		public decimal Steuersatz { get; set; }

		public static Schadstoffklasse Euro1
		{
			get { return new Schadstoffklasse("Euro1",10.84M); }
		}

		public static Schadstoffklasse Euro2
		{
			get { return new Schadstoffklasse("Euro2", 7.36M); }
		}

		public static Schadstoffklasse Euro3
		{
			get { return new Schadstoffklasse("Euro3", 6.75M); }
		}

		public static Schadstoffklasse Euro4
		{
			get { return new Schadstoffklasse("Euro4", 6.75M); }
		}


		public Schadstoffklasse(string name, decimal steuersatz)
		{
			Name = name;
			Steuersatz = steuersatz;
		}
	}
}
