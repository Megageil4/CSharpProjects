using Notenverwaltung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenverwaltung.Logik
{
	public interface IDurchschnittRechner
	{
		double BerechnenDurchschnitt(IEnumerable<Zensur> zensuren);
	}
}
