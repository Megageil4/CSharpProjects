using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.KfzSteuer.Model
{
    public class PKW : Fahrzeug
    {
        public Schadstoffklasse Schadstoffklasse { get; set; }

		public int Emission { get; set; }

		public PKW(string kennzeichen, DateTime erstzulassung, int hubraum, int leistung, int emission,Schadstoffklasse schadstoffklasse) 
            : base(kennzeichen, erstzulassung, hubraum, leistung)
        {
            this.Schadstoffklasse = schadstoffklasse;
            Emission = emission;
        }

        public override decimal BerechneSteuer()
        {
            return Math.Ceiling(Hubraum / 100.0M) * this.Schadstoffklasse.Steuersatz;
        }
    }
}
