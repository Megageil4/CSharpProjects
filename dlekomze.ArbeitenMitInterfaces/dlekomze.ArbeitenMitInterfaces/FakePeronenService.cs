using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.ArbeitenMitInterfaces
{
    public class FakePeronenService : IPersonenService
    {
        public IEnumerable<Person> Laden()
        {
            yield return new Person("Franz", "Mueller");
            yield return new Person("", "");
        }
    }
}
