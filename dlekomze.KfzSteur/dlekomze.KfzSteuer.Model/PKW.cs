using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.KfzSteuer.Model
{
    public class PKW : Fahrzeug
    {
        public static Dictionary<String, decimal> steuersatz;
        public string Schadstoffklasse { get; set; }

        public int Emission
        {
            get { return Leistung / Hubraum; }
        }

        public PKW(string kennzeichen, DateTime erstzulassung, int hubraum, int leistung, string schadstoffklasse) 
            : base(kennzeichen, erstzulassung, hubraum, leistung)
        {
            Schadstoffklasse = schadstoffklasse;
        }

        static PKW()
        {
            steuersatz = new();
            steuersatz.Add("Euro1", 10.84M);
            steuersatz.Add("Euro2", 7.36M);
            steuersatz.Add("Euro3", 6.75M);
            steuersatz.Add("Euro4", 6.75M);
        }

        public override decimal BerechneSteuer()
        {
            return Math.Ceiling(Hubraum / 100.0M) * steuersatz[Schadstoffklasse];
        }
    }
}
