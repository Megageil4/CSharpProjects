using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.ArbeitenMitInterfaces
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        public override string ToString()
        {
            return $"{Vorname} {Nachname}";
        }
    }
}
