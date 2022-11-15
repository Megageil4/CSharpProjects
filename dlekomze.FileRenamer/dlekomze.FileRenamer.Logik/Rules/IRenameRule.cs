using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.FileRenamer.Logik.Rules
{
	public interface IRenameRule
	{
		IEnumerable<string> Rename(IEnumerable<string> filenames);
	}
}
