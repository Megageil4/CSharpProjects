using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.KfzSteuer.Model
{
    public class Motorrad : Fahrzeug
    {
        private const decimal _hubraumsatz = 1.84M;

        public Motorrad(string kennzeichen, DateTime erstzulassung, int hubraum, int leistung) : base(kennzeichen, erstzulassung, hubraum, leistung)
        {
        }

        public override decimal BerechneSteuer()
        {
            if (Leistung <= 11 && Hubraum <= 125)
            {
                return 0;
            }
            return Math.Ceiling(Hubraum / 25.0M) * _hubraumsatz;
        }
    }
}
