using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.ArbeitenMitInterfaces
{
    public interface IPersonenService
    {
        IEnumerable<Person> Laden();
    }
}
